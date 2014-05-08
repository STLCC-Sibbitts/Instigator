using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AudioSampler.Filters

{
   class Echo:Filter
   {
      public int EchoDelay { get; private set; }

        public float EchoFactor { get; private set; }

        private Queue<float> samples;

        public Echo(int length = 20000, float factor = 0.5f)
        {
            this.EchoDelay = length;
            this.EchoFactor = factor;
            this.samples = new Queue<float>();

            for (int i=0; i<length; i++)
            {
                samples.Enqueue(0f);
            }
        }

        public float addFilter(float sample)
        {
           //push current sample into queue
            samples.Enqueue(sample);
            //return sample + delay
            
            return Math.Min(1,Math.Max(-1, sample + EchoFactor * samples.Dequeue())); //return number has to be between -1 and 1 as NAudio uses normalized floating points

        }
    }
}
