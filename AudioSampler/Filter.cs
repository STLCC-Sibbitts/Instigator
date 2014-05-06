using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioSampler
{
   public interface Filter
   {
      float addFilter(float sample);  
   }
}
