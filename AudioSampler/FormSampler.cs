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
        private Pad pad1;
        private Pad pad2;
        private Pad pad3;
        private Pad pad4;
        private Pad pad5;
        private Pad pad6;
        private Pad pad7;
        private Pad pad8;
        private Pad pad9;
        private Player player1;
        private Player player2;
        private Player player3;
        private Player player4;
        private Player player5;
        private Player player6;
        private Player player7;
        private Player player8;
        private Player player9;

        private List<Player> playerList; //we'll need a player for each pad
        private List<Pad> padList;  //some functions will be easier with a foreach of all the pads
        
        private bool isDebugging = true;  //setting to true displays the debug textbox

        //////////////////////////////////////////////////////////////////
        //  Constructor
        // 
        // Draws form, initializes values
        //////////////////////////////////////////////////////////////////
        public FormSampler()
        {
           InitializeComponent();
           if (isDebugging)
           {
              txtBoxDebug.Visible = true;
              lblDebug.Visible = true;
           }

           InitializePads();
           InitializePlayers();
           CollapsePanel();
        }

        //////////////////////////////////////////////////////////////////
        //  Form interaction methods
        // 
        // mouse events, etc
        //////////////////////////////////////////////////////////////////
        private void pictureBox1_Click(object sender, EventArgs e)
        { 
           if (isPanelExpanded)
              CollapsePanel();
           else
              ExpandPanel();
        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //to be implemented later:
            //load "kit" file
            //includes samples, effects settings for all pads
        }
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //to be implemented later:
            //save "kit" file
            //includes samples, effects settings for all pads
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //to be implemented later:
            //prompt to save changes
            //stop playback, dispose of players and associated objects
            //dispose of form
        }

        //////////////////////////////////////////////////////////////////
        //  Visual methods
        // 
        // toggle fx panel, light up pads
        //////////////////////////////////////////////////////////////////

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

        //////////////////////////////////////////////////////////////////
        //  Pad methods
        // 
        // file loading, click, keypress, etc.
        //////////////////////////////////////////////////////////////////
        
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

        // Selects a file to be opened, saves that value to the pad
        private void GetSampleFromDialog(Pad pad)
        {
           try
           {
              OpenFileDialog fileDialog = new OpenFileDialog();

              fileDialog.Filter = "Wave File (*.wav|*.wav;"; //update later with MP3 support
              fileDialog.Title = "Select Sample for Pad #" +pad.Name.Substring(2,1);

              DialogResult dr = fileDialog.ShowDialog();
              if (dr != DialogResult.OK)
              {
                 OutputTextLine("DialogResult did not equal OK");
                 return;
              }
              pad.SamplePath = fileDialog.FileName;

              pad.Dialog = fileDialog;
              pad.parametersChanged = true;
              OutputTextLine("Sample loaded " + pad.SamplePath);
           }
           catch (Exception ex)
           {
              OutputTextLine("Error: " + ex.Message);
              OutputTextLine("Probably couldn't cast to Pad");
           }
        }

        //this method is called any time the pad is triggered
        private void pad_Activated(object sender, EventArgs e)
        {
            //might want a try catch on this cast...
            Pad activatedPad = (Pad)sender;
            OutputTextLine(activatedPad.Name+" activated");

            //make a new thread for the playback
            Thread padThread = new Thread(() => PlayPad(ref activatedPad));
            padThread.Start();            
        }

        private void PlayPad(ref Pad padButton)   //ISSUE: After loading a sample for the first time,
        {
           int escapeCounter = 0;
           SetPictureBoxImage(padButton, imgPadYellow);
           //using seperate players for each button, we need to fetch the right player
           GetPlayer(padButton).playSample(ref padButton);

           /*  Moved filter playback logic to player class
            //switch to control which playing flow is used(different for filter/no filter
            switch (padButton.currentFilter)
            {
                case 0:
                    player.playSample(padButton);
                    break;
                case 1:  // pad.currentFilter = 1 for echo
                    player.playSampEcho(padButton);
                    break;
                default:
                    break;
            }*/

           if (!GetPlayer(padButton).LogMessage.Equals(""))
           {
               OutputTextLine(GetPlayer(padButton).LogMessage);
           }
            //wait until the player is done before changing color back
           do 
           {
              Thread.Sleep(20);
           } while (GetPlayer(padButton).IsPlaying && ++escapeCounter < 1000);
           OutputTextLine("IsPlaying = "+GetPlayer(padButton).IsPlaying.ToString());
           OutputTextLine("Escape counter value: "+escapeCounter);
            SetPictureBoxImage(padButton, imgPadBlack);
            OutputTextLine("Done playing " + padButton.Name);
            //the player built the proper waveforms and outputs, so this can be reset
            padButton.parametersChanged = false;
        }

        //////////////////////////////////////////////////////////////////
        // Returns the player that correspondings to the pad sent as a parameter
        // Needs a try catch in implementation for unhandled conversion exception
        //////////////////////////////////////////////////////////////////
        private Player GetPlayer(Pad pad)
        {
            string name = pad.Name;
            //returns the last character within the name string (ex. pad1 = 1)
            string numString = name.Substring(name.Length - 1, 1);
            //convert the number to a string
            int numInt = Convert.ToInt32(numString);
            //then use the number to reference index of the playerList
            return playerList[numInt - 1];
        }

        //////////////////////////////////////////////////////////////////
        //  Text output methods
        // (currently used for txtBoxDebug output)
        // 
        //////////////////////////////////////////////////////////////////

        //Translates the newline char for use in textboxes
        private string LocalizeText(string text)
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

        /// <summary>
        /// Initializes and draws the pads on the form
        /// 
        /// in the future this will use a foreach for less code.
        /// but it works for now
       /// </summary>
        private void InitializePads()           
        {                                        
            this.pad1 = new AudioSampler.Pad();
            this.pad2 = new AudioSampler.Pad();
            this.pad3 = new AudioSampler.Pad();
            this.pad4 = new AudioSampler.Pad();
            this.pad5 = new AudioSampler.Pad();
            this.pad6 = new AudioSampler.Pad();
            this.pad7 = new AudioSampler.Pad();
            this.pad8 = new AudioSampler.Pad();
            this.pad9 = new AudioSampler.Pad();

            //load the padList
            padList = new List<Pad>()
            {
               this.pad1,
               this.pad2,
               this.pad3,
               this.pad4,
               this.pad5,
               this.pad6,
               this.pad7,
               this.pad8,
               this.pad9
            };
         
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

        private void InitializePlayers()
        {
            this.player1 = new AudioSampler.Player();
            this.player2 = new AudioSampler.Player();
            this.player3 = new AudioSampler.Player();
            this.player4 = new AudioSampler.Player();
            this.player5 = new AudioSampler.Player();
            this.player6 = new AudioSampler.Player();
            this.player7 = new AudioSampler.Player();
            this.player8 = new AudioSampler.Player();
            this.player9 = new AudioSampler.Player();

            //load the playerList
            playerList = new List<Player>()
            {
            this.player1,
            this.player2,
            this.player3,
            this.player4,
            this.player5,
            this.player6,
            this.player7,
            this.player8,
            this.player9
            };
        }

    }
}
