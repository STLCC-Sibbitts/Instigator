using System;
using System.Collections.Generic;
using NAudio.Wave;
//using System.Numerics;

namespace AudioSampler
{
    public class PassFilterStream : WaveStream
    {
        // Gain in dB
        public float gain { get; set; }
        // Center Frequency (always less than samplerate/2)
        public float centerFreq { get; set; }
        // Bandwidth in octaves
        public float bandwidth { get; set; }
        public float sampleRate { get; set; }

        private float x1 { get; set; }
        private float x2 { get; set; }
        private float y1 { get; set; }
        private float y2 { get; set; }

        //store the list of filters to be used
        public List<Filter> filters { get; private set; }

        public WaveStream Source { get; set; }

        public PassFilterStream(WaveStream stream, Pad pad)
        {

            this.Source = stream;
            this.filters = new List<Filter>();

            //Need these four properties in the pad class:
            this.bandwidth = 43;//pad.passBandwith;
            this.sampleRate = 44100;// pad.sampleRate;
            this.gain = 80;// pad.passGain;
            this.centerFreq = 240;//pad.passCenterFreq;
        }

        public float EchoFactor { get; set; }

        //call abstract methods of parent
        public override long Length
        {
            get { return Source.Length; }
        }


        public override long Position
        {
            get
            {
                return Source.Position;
            }
            set
            {
                Source.Position = value;
            }
        }

        public override WaveFormat WaveFormat
        {
            get { return Source.WaveFormat; }
        }

        private int channel = 0;


        public override int Read(byte[] buffer, int offset, int count)
        {
            //read stream
            int read = Source.Read(buffer, offset, count);
            //go through each sample - convert to floating - filter - convert back to bytearray
            for (int i = 0; i < read / 4; i++) //read/4 is teh number of samples being read
            {
                float sample = BitConverter.ToSingle(buffer, i * 4);

                //
                //  The following is deriven from Robert Bristow Johnson's Audio Cookbook
                //  TODO:  THis is only the 'recipe' for Peaking EQ ... simple change of b0,b1,b2,a0,a1,a2 can be used to make 
                //          other filters ie high pass low pass etc.
                float A = (float)System.Math.Pow(10, gain / 40);
                float w0 = Convert.ToSingle(2 * (Math.PI * centerFreq / sampleRate));

                float c = (float)Math.Cos(w0);
                float s = (float)Math.Sin(w0);
                float alpha = Convert.ToSingle(s * Math.Sinh(Math.Log(2) / 2 * bandwidth * w0 / s));
                //filter coefficients
                float b0 = 1 + alpha * A;
                float b1 = -2 * c;
                float b2 = 1 - alpha * A;
                float a0 = 1 + alpha / A;
                float a1 = -2 * c;
                float a2 = 1 - alpha / A;
                //normalize 
                b0 /= a0;
                b1 /= a0;
                b2 /= a0;
                a1 /= a0;
                a2 /= a0;

                float y = b0 * sample + b1 * x1 + b2 * x2 - a1 * y1 - a2 * y2;

                this.x2 = x1;
                this.x1 = sample;
                this.y2 = y1;
                this.y1 = y;


                sample = y;

                //////////////////////////////////////
                if (filters.Count == WaveFormat.Channels)
                {
                    sample = filters[channel].addFilter(sample);
                    channel = ((channel + 1) % WaveFormat.Channels);
                }
                byte[] bytes = BitConverter.GetBytes(sample);

                ///write new bytes directly ot buffer
                buffer[i * 4] = bytes[0];
                buffer[i * 4 + 1] = bytes[1];
                buffer[i * 4 + 2] = bytes[2];
                buffer[i * 4 + 3] = bytes[3];

            }
            return read;
        }
    }
}
