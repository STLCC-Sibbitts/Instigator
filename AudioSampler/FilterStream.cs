using System;
using System.Collections.Generic;
using NAudio.Wave;

namespace AudioSampler
{
   public class FilterStream : WaveStream
   {
      //store the list of filters to be used
      public List<Filter> filters { get; private set; }

      public WaveStream Source { get; set; }

      public FilterStream(WaveStream stream)
      {
         this.Source = stream;
         this.filters = new List<Filter>();
      }

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

            //do something to sample:
            //sample = sample * .5f; lower sound

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

