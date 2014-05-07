using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioSampler
{
    public partial class FormSampler : Form
    {
        //constants
        private const int COLLAPSED_HEIGHT = 510;     //required to shift expand/collapse bar
        private const int EXPANDED_HEIGHT = 784;      //

        delegate void SetPictureBoxImageCallBack(PictureBox pBox, Image img); //need these for multithreading
        delegate void OutputTextCallBack(string text);
        
        private bool isPanelExpanded;
        private Image imgPadBlack = AudioSampler.Properties.Resources.Black_Pad;
        private Image imgPadYellow = AudioSampler.Properties.Resources.Yellow_Pad;
        private Image imgUpArrow = AudioSampler.Properties.Resources.TogglePanelButtonUp;
        private Image imgDownArrow = AudioSampler.Properties.Resources.TogglePanelButtonDown;

        Player player;
        
       private List<Pad> PadList = new List<Pad>();  //some functions might be easier with a foreach of all the pads

       //constructor
        public FormSampler()
        {
            InitializeComponent();
            DoPadInitialize();
            CollapsePanel();
            player = new Player();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { 
           if (isPanelExpanded)
              CollapsePanel();
           else
              ExpandPanel();
        }
        /*********************************************
         * Visual methods
         * 
         * -toggle fx panel, light up pads
         * ******************************************/

        private void CollapsePanel()
        {
            this.Height = COLLAPSED_HEIGHT;
            pictureBoxExpand.Image = imgDownArrow;
            splitContainer1.Panel2Collapsed = true;
            isPanelExpanded = false;
        }
       
       private void ExpandPanel()
        {
            this.Height = EXPANDED_HEIGHT;
            splitContainer1.Panel2Collapsed = false;
            pictureBoxExpand.Image = imgUpArrow;
            isPanelExpanded = true;
        }

        private void SetPictureBoxImage(PictureBox pBox, Image img)
        {
           // InvokeRequired required compares the thread ID of
           // the calling thread to the thread ID of the 
           // creating thread.  If these threads are different, 
           // it returns true
           if (pBox.InvokeRequired)
           {  
              //basically, if the PictureBox (pBox) that is trying to be altered 
              //was created in a different thread than the one calling this method,
              //we make a clone of this method...  (using the previously declared delegate object)
              SetPictureBoxImageCallBack d = new SetPictureBoxImageCallBack(SetPictureBoxImage);
              //and have the original thread call our cloned method so it can execute safely
              this.Invoke(d, new object[] { pBox, img });
           }
           else
           {
              pBox.Image = img;
           }
        }


        /*********************************************
         * Pad methods
         * 
         * file loading, click, keypress, etc.
         * ******************************************/
        
        private void loadSampleToolStripMenuItem_Click(object sender, EventArgs e)  //ONLY TO BE CALLED BY CLICKING ON A PAD
        {   //Because we're using the same context menu for all pads,                 //To load sample other ways, use GetSampleFromDialog method
           //we'll have to figure out the object that was clicked on
           
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
               // Retrieve the ContextMenuStrip that owns this ToolStripItem
               ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
               if (owner != null)
               {
                  // Get the control that is displaying this context menu
                  Control sourceControl = owner.SourceControl;
                  Pad pad = (Pad)sourceControl;
                  GetSampleFromDialog(pad);
               }
            }
        }

        private void GetSampleFromDialog(Pad pad)
        {
           try
           {
              OpenFileDialog fileDialog = new OpenFileDialog();

              fileDialog.Filter = "Wave File (*.wav|*.wav;"; //update with MP3 support
              fileDialog.Title = "Select Sample for Pad #" +pad.Name.Substring(2,1);

              DialogResult dr = fileDialog.ShowDialog();
              if (dr != DialogResult.OK)
              {
                 OutputTextLine("DialogResult did not equal OK");
                 return;
              }
              pad.SamplePath = fileDialog.FileName;

              pad.Dialog = fileDialog;
              OutputTextLine("Sample loaded " + pad.SamplePath);
           }
           catch (Exception ex)
           {
              OutputTextLine("Error: " + ex.Message);
              OutputTextLine("Probably couldn't cast to Pad");
           }
        }

        private void pad_Activated(object sender, EventArgs e)
        {
            //might want a try catch on this cast...
            Pad activatedPad = (Pad)sender;
            OutputTextLine(activatedPad.Name+" activated");

            //make a new thread for the playback, ...complicated stuff
            Thread padThread = new Thread(() => PlayPad(activatedPad));
            padThread.Start();            
        }

        private void PlayPad(Pad padButton)
        {
           SetPictureBoxImage(padButton, imgPadYellow);
           //player.playSample(padButton);
           if (!player.LogMessage.Equals(""))
           {
              OutputTextLine(player.LogMessage);
           }
            Thread.Sleep(500); //sleep for testing purposes ONLY
            SetPictureBoxImage(padButton, imgPadBlack);
            OutputTextLine("Done playing " + padButton.Name);
        }

        /*********************************************
         * Text output methods
         * 
         * 
         * ******************************************/
        private string LocalizeText(string text)  //new line char doesn't work in textbox
        {
            text = text.Replace("\n", Environment.NewLine);
            return text;
        }
        private void OutputText(string newText)
        {
           if (this.txtBoxDebug.InvokeRequired)
           {
              OutputTextCallBack ot = new OutputTextCallBack(OutputText);
              this.Invoke(ot, new object[] { newText });
           }
           else
           {
              txtBoxDebug.AppendText(LocalizeText(newText));
           }
        }
        private void OutputTextLine(string newLine)
        {
            OutputText(newLine + Environment.NewLine);
        }
        private void ClearOutputText()
        {
            txtBoxDebug.Clear();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //not yet implemented
        }



        private void DoPadInitialize()
        {
         this.pad6 = new AudioSampler.Pad();
         this.pad9 = new AudioSampler.Pad();
         this.pad2 = new AudioSampler.Pad();
         this.pad5 = new AudioSampler.Pad();
         this.pad8 = new AudioSampler.Pad();
         this.pad1 = new AudioSampler.Pad();
         this.pad4 = new AudioSampler.Pad();
         this.pad7 = new AudioSampler.Pad();
         // 
         // panelPads
         // 
         this.panelPads.BackColor = System.Drawing.SystemColors.InactiveCaption;
         this.panelPads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panelPads.Controls.Add(this.pad3);
         this.panelPads.Controls.Add(this.pad6);
         this.panelPads.Controls.Add(this.pad9);
         this.panelPads.Controls.Add(this.pad2);
         this.panelPads.Controls.Add(this.pad5);
         this.panelPads.Controls.Add(this.pad8);
         this.panelPads.Controls.Add(this.pad1);
         this.panelPads.Controls.Add(this.pad4);
         this.panelPads.Controls.Add(this.pad7);
         // 
         // pad3
         // 
         this.pad3.chorusDelay = 0D;
         this.pad3.chorusDepth = 0D;
         this.pad3.chorusLevel = 0D;
         this.pad3.ContextMenuStrip = this.padContextMenuStrip;
         this.pad3.driveSetting = 0D;
         this.pad3.echoCount = 0;
         this.pad3.echoDelay = 0;
         this.pad3.echoFactor = 0F;
         this.pad3.frequency = 0D;
         this.pad3.Image = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad3.InitialImage = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad3.isChorusing = false;
         this.pad3.isEchoing = false;
         this.pad3.isLoaded = false;
         this.pad3.isLowPass = false;
         this.pad3.isOverdriving = false;
         this.pad3.isPassing = false;
         this.pad3.keyShortCut = '\0';
         this.pad3.Location = new System.Drawing.Point(259, 256);
         this.pad3.MaximumSize = new System.Drawing.Size(114, 114);
         this.pad3.MinimumSize = new System.Drawing.Size(114, 114);
         this.pad3.Name = "pad3";
         this.pad3.SamplePath = null;
         this.pad3.Size = new System.Drawing.Size(114, 114);
         this.pad3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pad3.TabIndex = 0;
         this.pad3.TabStop = false;
         this.pad3.Click += new System.EventHandler(this.pad_Activated);
         // 
         // pad6
         // 
         this.pad6.chorusDelay = 0D;
         this.pad6.chorusDepth = 0D;
         this.pad6.chorusLevel = 0D;
         this.pad6.ContextMenuStrip = this.padContextMenuStrip;
         this.pad6.driveSetting = 0D;
         this.pad6.echoCount = 0;
         this.pad6.echoDelay = 0;
         this.pad6.echoFactor = 0F;
         this.pad6.frequency = 0D;
         this.pad6.Image = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad6.InitialImage = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad6.isChorusing = false;
         this.pad6.isEchoing = false;
         this.pad6.isLoaded = false;
         this.pad6.isLowPass = false;
         this.pad6.isOverdriving = false;
         this.pad6.isPassing = false;
         this.pad6.keyShortCut = '\0';
         this.pad6.Location = new System.Drawing.Point(256, 131);
         this.pad6.MaximumSize = new System.Drawing.Size(114, 114);
         this.pad6.MinimumSize = new System.Drawing.Size(114, 114);
         this.pad6.Name = "pad6";
         this.pad6.SamplePath = null;
         this.pad6.Size = new System.Drawing.Size(114, 114);
         this.pad6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pad6.TabIndex = 0;
         this.pad6.TabStop = false;
         this.pad6.Click += new System.EventHandler(this.pad_Activated);
         // 
         // pad9
         // 
         this.pad9.chorusDelay = 0D;
         this.pad9.chorusDepth = 0D;
         this.pad9.chorusLevel = 0D;
         this.pad9.ContextMenuStrip = this.padContextMenuStrip;
         this.pad9.driveSetting = 0D;
         this.pad9.echoCount = 0;
         this.pad9.echoDelay = 0;
         this.pad9.echoFactor = 0F;
         this.pad9.frequency = 0D;
         this.pad9.Image = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad9.InitialImage = null;
         this.pad9.isChorusing = false;
         this.pad9.isEchoing = false;
         this.pad9.isLoaded = false;
         this.pad9.isLowPass = false;
         this.pad9.isOverdriving = false;
         this.pad9.isPassing = false;
         this.pad9.keyShortCut = '\0';
         this.pad9.Location = new System.Drawing.Point(259, 6);
         this.pad9.MaximumSize = new System.Drawing.Size(114, 114);
         this.pad9.MinimumSize = new System.Drawing.Size(114, 114);
         this.pad9.Name = "pad9";
         this.pad9.SamplePath = null;
         this.pad9.Size = new System.Drawing.Size(114, 114);
         this.pad9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pad9.TabIndex = 0;
         this.pad9.TabStop = false;
         this.pad9.Click += new System.EventHandler(this.pad_Activated);
         // 
         // pad2
         // 
         this.pad2.chorusDelay = 0D;
         this.pad2.chorusDepth = 0D;
         this.pad2.chorusLevel = 0D;
         this.pad2.ContextMenuStrip = this.padContextMenuStrip;
         this.pad2.driveSetting = 0D;
         this.pad2.echoCount = 0;
         this.pad2.echoDelay = 0;
         this.pad2.echoFactor = 0F;
         this.pad2.frequency = 0D;
         this.pad2.Image = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad2.InitialImage = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad2.isChorusing = false;
         this.pad2.isEchoing = false;
         this.pad2.isLoaded = false;
         this.pad2.isLowPass = false;
         this.pad2.isOverdriving = false;
         this.pad2.isPassing = false;
         this.pad2.keyShortCut = '\0';
         this.pad2.Location = new System.Drawing.Point(134, 256);
         this.pad2.MaximumSize = new System.Drawing.Size(114, 114);
         this.pad2.MinimumSize = new System.Drawing.Size(114, 114);
         this.pad2.Name = "pad2";
         this.pad2.SamplePath = null;
         this.pad2.Size = new System.Drawing.Size(114, 114);
         this.pad2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pad2.TabIndex = 0;
         this.pad2.TabStop = false;
         this.pad2.Click += new System.EventHandler(this.pad_Activated);
         // 
         // pad5
         // 
         this.pad5.chorusDelay = 0D;
         this.pad5.chorusDepth = 0D;
         this.pad5.chorusLevel = 0D;
         this.pad5.ContextMenuStrip = this.padContextMenuStrip;
         this.pad5.driveSetting = 0D;
         this.pad5.echoCount = 0;
         this.pad5.echoDelay = 0;
         this.pad5.echoFactor = 0F;
         this.pad5.frequency = 0D;
         this.pad5.Image = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad5.InitialImage = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad5.isChorusing = false;
         this.pad5.isEchoing = false;
         this.pad5.isLoaded = false;
         this.pad5.isLowPass = false;
         this.pad5.isOverdriving = false;
         this.pad5.isPassing = false;
         this.pad5.keyShortCut = '\0';
         this.pad5.Location = new System.Drawing.Point(134, 131);
         this.pad5.MaximumSize = new System.Drawing.Size(114, 114);
         this.pad5.MinimumSize = new System.Drawing.Size(114, 114);
         this.pad5.Name = "pad5";
         this.pad5.SamplePath = null;
         this.pad5.Size = new System.Drawing.Size(114, 114);
         this.pad5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pad5.TabIndex = 0;
         this.pad5.TabStop = false;
         this.pad5.Click += new System.EventHandler(this.pad_Activated);
         // 
         // pad8
         // 
         this.pad8.chorusDelay = 0D;
         this.pad8.chorusDepth = 0D;
         this.pad8.chorusLevel = 0D;
         this.pad8.ContextMenuStrip = this.padContextMenuStrip;
         this.pad8.driveSetting = 0D;
         this.pad8.echoCount = 0;
         this.pad8.echoDelay = 0;
         this.pad8.echoFactor = 0F;
         this.pad8.frequency = 0D;
         this.pad8.Image = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad8.InitialImage = null;
         this.pad8.isChorusing = false;
         this.pad8.isEchoing = false;
         this.pad8.isLoaded = false;
         this.pad8.isLowPass = false;
         this.pad8.isOverdriving = false;
         this.pad8.isPassing = false;
         this.pad8.keyShortCut = '\0';
         this.pad8.Location = new System.Drawing.Point(134, 6);
         this.pad8.MaximumSize = new System.Drawing.Size(114, 114);
         this.pad8.MinimumSize = new System.Drawing.Size(114, 114);
         this.pad8.Name = "pad8";
         this.pad8.SamplePath = null;
         this.pad8.Size = new System.Drawing.Size(114, 114);
         this.pad8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pad8.TabIndex = 0;
         this.pad8.TabStop = false;
         this.pad8.Click += new System.EventHandler(this.pad_Activated);
         // 
         // pad1
         // 
         this.pad1.chorusDelay = 0D;
         this.pad1.chorusDepth = 0D;
         this.pad1.chorusLevel = 0D;
         this.pad1.ContextMenuStrip = this.padContextMenuStrip;
         this.pad1.driveSetting = 0D;
         this.pad1.echoCount = 0;
         this.pad1.echoDelay = 0;
         this.pad1.echoFactor = 0F;
         this.pad1.frequency = 0D;
         this.pad1.Image = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad1.InitialImage = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad1.isChorusing = false;
         this.pad1.isEchoing = false;
         this.pad1.isLoaded = false;
         this.pad1.isLowPass = false;
         this.pad1.isOverdriving = false;
         this.pad1.isPassing = false;
         this.pad1.keyShortCut = '\0';
         this.pad1.Location = new System.Drawing.Point(9, 256);
         this.pad1.MaximumSize = new System.Drawing.Size(114, 114);
         this.pad1.MinimumSize = new System.Drawing.Size(114, 114);
         this.pad1.Name = "pad1";
         this.pad1.SamplePath = null;
         this.pad1.Size = new System.Drawing.Size(114, 114);
         this.pad1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pad1.TabIndex = 0;
         this.pad1.TabStop = false;
         this.pad1.Click += new System.EventHandler(this.pad_Activated);
         // 
         // pad4
         // 
         this.pad4.chorusDelay = 0D;
         this.pad4.chorusDepth = 0D;
         this.pad4.chorusLevel = 0D;
         this.pad4.ContextMenuStrip = this.padContextMenuStrip;
         this.pad4.driveSetting = 0D;
         this.pad4.echoCount = 0;
         this.pad4.echoDelay = 0;
         this.pad4.echoFactor = 0F;
         this.pad4.frequency = 0D;
         this.pad4.Image = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad4.InitialImage = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad4.isChorusing = false;
         this.pad4.isEchoing = false;
         this.pad4.isLoaded = false;
         this.pad4.isLowPass = false;
         this.pad4.isOverdriving = false;
         this.pad4.isPassing = false;
         this.pad4.keyShortCut = '\0';
         this.pad4.Location = new System.Drawing.Point(9, 131);
         this.pad4.MaximumSize = new System.Drawing.Size(114, 114);
         this.pad4.MinimumSize = new System.Drawing.Size(114, 114);
         this.pad4.Name = "pad4";
         this.pad4.SamplePath = null;
         this.pad4.Size = new System.Drawing.Size(114, 114);
         this.pad4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pad4.TabIndex = 0;
         this.pad4.TabStop = false;
         this.pad4.Click += new System.EventHandler(this.pad_Activated);
         // 
         // pad7
         // 
         this.pad7.chorusDelay = 0D;
         this.pad7.chorusDepth = 0D;
         this.pad7.chorusLevel = 0D;
         this.pad7.ContextMenuStrip = this.padContextMenuStrip;
         this.pad7.driveSetting = 0D;
         this.pad7.echoCount = 0;
         this.pad7.echoDelay = 0;
         this.pad7.echoFactor = 0F;
         this.pad7.frequency = 0D;
         this.pad7.Image = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad7.InitialImage = null;
         this.pad7.isChorusing = false;
         this.pad7.isEchoing = false;
         this.pad7.isLoaded = false;
         this.pad7.isLowPass = false;
         this.pad7.isOverdriving = false;
         this.pad7.isPassing = false;
         this.pad7.keyShortCut = '\0';
         this.pad7.Location = new System.Drawing.Point(9, 6);
         this.pad7.MaximumSize = new System.Drawing.Size(114, 114);
         this.pad7.MinimumSize = new System.Drawing.Size(114, 114);
         this.pad7.Name = "pad7";
         this.pad7.SamplePath = null;
         this.pad7.Size = new System.Drawing.Size(114, 114);
         this.pad7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pad7.TabIndex = 0;
         this.pad7.TabStop = false;
         this.pad7.Click += new System.EventHandler(this.pad_Activated);

         ((System.ComponentModel.ISupportInitialize)(this.pad6)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pad9)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pad2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pad5)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pad8)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pad1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pad4)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pad7)).EndInit();


        }

        private void fx2OnCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
