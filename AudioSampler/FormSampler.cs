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
           //demonstration
           SetPictureBoxImage(padButton, imgPadYellow);
           int x;
            x = padButton.currentFilter;

            //switch to control which playing flow is used(different for filter/no filter
            switch (x)
            {
                case 0:
                    player.playSample(padButton);
                    break;
                case 1:  // pad.currentFilter = 1 for echo
                    player.playSampEcho(padButton);
                    break;
                default:
                    break;
            }





           
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



        private void DoPadInitialize()           //copied from designer real quick, 
        {                                        //extending PictureBox class got the design FUBAR,
            this.pad6 = new AudioSampler.Pad();//in the future this will use a foreach for less code.
            this.pad9 = new AudioSampler.Pad();
            this.pad2 = new AudioSampler.Pad();
            this.pad5 = new AudioSampler.Pad();
            this.pad8 = new AudioSampler.Pad();
            this.pad1 = new AudioSampler.Pad();
            this.pad4 = new AudioSampler.Pad();
            this.pad7 = new AudioSampler.Pad();
         
            // panelPads
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
         
            // pad3
            this.pad3.ContextMenuStrip = this.padContextMenuStrip;
            this.pad3.Location = new System.Drawing.Point(259, 256);
            this.pad3.Name = "pad3";
            this.pad3.Click += new System.EventHandler(this.pad_Activated);
         
              // pad6
            this.pad6.ContextMenuStrip = this.padContextMenuStrip;
            this.pad6.Location = new System.Drawing.Point(256, 131);
            this.pad6.Name = "pad6";
            this.pad6.Click += new System.EventHandler(this.pad_Activated);
         
            // pad9
            this.pad9.ContextMenuStrip = this.padContextMenuStrip;
            this.pad9.Location = new System.Drawing.Point(259, 6);
            this.pad9.Name = "pad9";
            this.pad9.Click += new System.EventHandler(this.pad_Activated);
         
            // pad2
            this.pad2.ContextMenuStrip = this.padContextMenuStrip;
            this.pad2.Location = new System.Drawing.Point(134, 256);
            this.pad2.Name = "pad2";
            this.pad2.Click += new System.EventHandler(this.pad_Activated);
          
            // pad5
            this.pad5.ContextMenuStrip = this.padContextMenuStrip;
            this.pad5.Location = new System.Drawing.Point(134, 131);
            this.pad5.Name = "pad5";
            this.pad5.Click += new System.EventHandler(this.pad_Activated);
          
            // pad8
            this.pad8.ContextMenuStrip = this.padContextMenuStrip;
            this.pad8.Location = new System.Drawing.Point(134, 6);
            this.pad8.Name = "pad8";
            this.pad8.Click += new System.EventHandler(this.pad_Activated);
 
            // pad1 
            this.pad1.ContextMenuStrip = this.padContextMenuStrip;
            this.pad1.Location = new System.Drawing.Point(9, 256);
            this.pad1.Name = "pad1";
            this.pad1.Click += new System.EventHandler(this.pad_Activated);
          
            // pad4
            this.pad4.ContextMenuStrip = this.padContextMenuStrip;
            this.pad4.Location = new System.Drawing.Point(9, 131);
            this.pad4.Name = "pad4";
            this.pad4.Click += new System.EventHandler(this.pad_Activated);
          
            // pad7
            this.pad7.ContextMenuStrip = this.padContextMenuStrip;
            this.pad7.Location = new System.Drawing.Point(9, 6);
            this.pad7.Name = "pad7";      
            this.pad7.Click += new System.EventHandler(this.pad_Activated);
         }

        private void fx2OnCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
