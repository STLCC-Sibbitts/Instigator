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
    public partial class formSampler : Form
    {
        //constants
        private const int COLLAPSED_HEIGHT = 510;               //required to shift expand/collapse bar
        private const int EXPANDED_HEIGHT = 784;                //

        delegate void SetPictureBoxImageCallBack(PictureBox pBox, Image img); //need these for multithreading
        delegate void OutputTextCallBack(string text);
        
        private bool isPanelExpanded;
        private Image imgPadBlack = AudioSampler.Properties.Resources.Black_Pad;
        private Image imgPadYellow = AudioSampler.Properties.Resources.Yellow_Pad;
        private Image imgUpArrow = AudioSampler.Properties.Resources.TogglePanelButtonUp;
        private Image imgDownArrow = AudioSampler.Properties.Resources.TogglePanelButtonDown;

        public formSampler()
        {
            InitializeComponent();
            CollapsePanel();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isPanelExpanded)
            {
                CollapsePanel();
            }
            else
            {
                ExpandPanel();
            }
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
         * Pad activation methods
         * 
         * click, keypress, etc.
         * ******************************************/

        private void pad_Activated(object sender, EventArgs e)
        {
            //might want a try catch on this cast...
            PictureBox activatedPad = (PictureBox)sender;
            OutputTextLine(activatedPad.Name+" activated");

            //make a new thread for the playback, ...complicated stuff
            Thread padThread = new Thread(() => PlayPad(activatedPad));
            padThread.Start();            
        }

        private void PlayPad(PictureBox padButton)
        {
           SetPictureBoxImage(padButton, imgPadYellow);
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

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
