using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioSampler
{
   class Pad : PictureBox //we can have it inherit the picturebox class
      //I've modified the Form1.designer.cs so that these will be created in lieu of regular pictureboxes
      //as such, it gives a nasty warning going into design view, but should function perfectly.
   {
      //general properties
      public OpenFileDialog sampleLoadFileDialog { get; set; }
      public string sampleFilePath { get; set; }
      public char keyShortCut { get; set; }
      public bool isLoaded { get; set; }

      //properties for echo filter
      public bool isEchoing { get; set; }
      public int echoDelay { get; set; }
      public float echoFactor { get; set; }
      public int echoCount { get; set; }

      //properties for overdrive
      public bool isOverdriving { get; set; }
      public double driveSetting { get; set; }

      //properties for chorus
      public bool isChorusing { get; set; }
      public double chorusLevel { get; set; }
      public double chorusDepth { get; set; }
      public double chorusDelay { get; set; }

      //properities for low/high pass
      public bool isPassing { get; set; }
      public double frequency { get; set; }
      public bool isLowPass { get; set; } //if not then it is high pass

      //constructor for pad 
      public Pad(Keys key)
      {
         this.keyShortCut = Convert.ToChar(key);

         //start with filters off:
      }

      public Pad()  //empty constructor, we'll set keyShortCut later
      {
         this.isLoaded = false;
         this.isEchoing = false;
         this.isOverdriving = false;
         this.isChorusing = false;
         this.isPassing = false;
      }
   }
}
