using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioSampler
{
   class Pad : PictureBox //we can have it inherit the picturebox class
   {
      //general properties
	   private string pathToSample = "";
      private OpenFileDialog dialogOfSample = new OpenFileDialog();
	  
      public string SamplePath
      {
         get
         {
            return this.pathToSample;
         }
         set
         {
            //validate data here
			   pathToSample = value;
            isLoaded = true;
         }
      }
      public OpenFileDialog Dialog 
      {
         get
         {
            return dialogOfSample;
         }
         set
         {
            dialogOfSample = value;
         }
      }


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
         this.chorusDelay = 0D;
         this.chorusDepth = 0D;
         this.chorusLevel = 0D;
         this.driveSetting = 0D;
         this.echoCount = 0;
         this.echoDelay = 0;
         this.echoFactor = 0F;
         this.frequency = 0D;
         this.Image = global::AudioSampler.Properties.Resources.Black_Pad;
         this.InitialImage = null;
         this.isChorusing = false;
         this.isEchoing = false;
         this.isLoaded = false;
         this.isLowPass = false;
         this.isOverdriving = false;
         this.isPassing = false;
         this.keyShortCut = '\0';
         //this.Location = new System.Drawing.Point(9, 6);
         this.MaximumSize = new System.Drawing.Size(114, 114);
         this.MinimumSize = new System.Drawing.Size(114, 114);
         //this.Name = "pad7";
         this.SamplePath = null;
         this.Size = new System.Drawing.Size(114, 114);
         this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.TabIndex = 0;
         this.TabStop = false;
         //this.pad7.Click += new System.EventHandler(this.pad_Activated);
         //this.ContextMenuStrip = this.padContextMenuStrip;
      }
   }
}
