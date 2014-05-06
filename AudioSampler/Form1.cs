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
        //private const int SPLITTER_DISTANCE_COLLAPSED = 460;    //
        //private const int SPLITTER_DISTANCE_EXPANDED = 430;     //   ^ same
        //private readonly Point TOGGLE_LOCATION_UP = new Point(0,430);
        //private readonly Point TOGGLE_LOCATION_DOWN = new Point(0,460);
        //private const int SPLIT_PANEL_HEIGHT_COLLAPSED = 721;   //
        //private const int SPLIT_PANEL_HEIGHT_EXPANDED = 690;    //
        
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
           // pictureBoxExpand.Location = TOGGLE_LOCATION_UP;
            splitContainer1.Panel2Collapsed = true;
            //splitContainer1.SplitterDistance = SPLITTER_DISTANCE_COLLAPSED;
            //splitContainer1.Height = SPLIT_PANEL_HEIGHT_COLLAPSED;
            isPanelExpanded = false;
        }
        private void ExpandPanel()
        {
            this.Height = EXPANDED_HEIGHT;
            splitContainer1.Panel2Collapsed = false;
            //splitContainer1.SplitterDistance = SPLITTER_DISTANCE_EXPANDED;
            //splitContainer1.Height = SPLIT_PANEL_HEIGHT_EXPANDED;
            pictureBoxExpand.Image = imgUpArrow;
            //pictureBoxExpand.Location = TOGGLE_LOCATION_DOWN;
            isPanelExpanded = true;
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
            //Thread padThread = new Thread(() => PlayPad(activatedPad));
            //padThread.Start();
            PlayPad(activatedPad);
            
        }

        private void PlayPad(PictureBox padButton)
        {
            padButton.Image = imgPadYellow;
            padButton.Refresh();
            //sound output etc goes here
            Thread.Sleep(500);
            padButton.Image = imgPadBlack;
            padButton.Refresh();
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
            txtBoxDebug.AppendText(LocalizeText(newText));
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
