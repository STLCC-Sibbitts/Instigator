using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WavPlayer.Filters;

namespace AudioSampler
{
   class Player
   {







      //use for mic recording
      WaveIn micSourceStream = null;
      DirectSoundOut micWavOut = null;
      WaveFileWriter micWaveWriter = null;

      //use NAudio to read in wave files
      private WaveFileReader wave = null;
      private WaveFileReader wave2 = null;



      //to be used to open samples
      private OpenFileDialog multiSampleOpen = new OpenFileDialog();

      //use NAudio to play output sound
      private DirectSoundOut output = null;
      private DirectSoundOut output2 = null;

      //array to keep the filenames of selected samples
      public string[] openFileObjects = new string[8];
      public bool[] loadedSamps = new bool[8];

      //DirectSoundOut and Stream objects for use when using filters
      private DirectSoundOut filterOutput = null;
      private BlockAlignReductionStream stream = null;

      //turn filter on and off
      public bool addFilter = false;



      public void loadSamp(Pad pad)
      {

         //set filter for wave files
         this.multiSampleOpen.Filter = "Wave File (*.wav|*.wav;";
         this.multiSampleOpen.Title = "Choose Sample:";


         DialogResult dr = this.multiSampleOpen.ShowDialog();
         if (dr != System.Windows.Forms.DialogResult.OK) return;

         pad.isLoaded = true;
         pad.sample = multiSampleOpen;

      }



      /*
      */
      public void playSample(Pad pad)
      {

         wave2 = new WaveFileReader(pad.sample.FileName);
         output2 = new DirectSoundOut();
         output2.Init(new WaveChannel32(wave2));


         if (wave2 != null)
         {
            //play sample without effects
            if (addFilter == false)
            {
               output2.Play();
               wave2.CurrentTime = TimeSpan.Zero;
               output2.Play();
            }
            //if echo button was pressed addFilter is true so we use FilterStream to add echo filter
            if (addFilter != false)
            {
               // WaveCHannel32 guarenties 32bit floating point for filtering
               WaveChannel32 wave3 = new WaveChannel32(new WaveFileReader(pad.sample.FileName));

               FilterStream delayedFilter = new FilterStream(wave3);
               stream = new BlockAlignReductionStream(delayedFilter);

               //apply a filter - make sure there is an effect assigned to each channel
               for (int i = 0; i < wave2.WaveFormat.Channels; i++)


                  //delayedFilter.filters.Add(new Echo(pad.padEchoDelay,pad.padEchoFactor));


                  filterOutput = new DirectSoundOut(200);




               filterOutput.Init(stream);

               filterOutput.Play();

            }
         }
         DisposeWave(output2, wave2);
         DisposeWave(filterOutput, wave2);
      }


      public void stopRecording()
      {

         if (micWavOut != null)
         {
            micWavOut.Stop();
            micWavOut.Dispose();
            micWavOut = null;
         }
         if (micSourceStream != null)
         {
            micSourceStream.StopRecording();
            micSourceStream.Dispose();
            micSourceStream = null;
         }
         //dispose for mic-record-to-wav
         if (micWaveWriter != null)
         {
            micWaveWriter.Dispose();
            micWaveWriter = null;
         }

      }
      public void micOn(int chosenInputNumber)
      {


         micSourceStream = new WaveIn();
         micSourceStream.DeviceNumber = chosenInputNumber;
         micSourceStream.WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(chosenInputNumber).Channels);

         //use wavein to go between wave in and sound out
         WaveInProvider waveIn = new WaveInProvider(micSourceStream);

         micWavOut = new DirectSoundOut();
         micWavOut.Init(waveIn);

         //push recording into buffer
         micSourceStream.StartRecording();
         micWavOut.Play();



      }


      private void micSourceStream_DataAvailable(object sender, WaveInEventArgs e)
      {
         if (micWaveWriter == null) return;
         micWaveWriter.WriteData(e.Buffer, 0, e.BytesRecorded);
         micWaveWriter.Flush();
      }

      public void recordWav(ListView listView1, SaveFileDialog micSaveWavDialog)
      {
         int chosenInputNumber = listView1.SelectedItems[0].Index;


         micSourceStream = new WaveIn();
         micSourceStream.DeviceNumber = chosenInputNumber;

         //set up new waveformat using the chosen devices amount of channels
         micSourceStream.WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(chosenInputNumber).Channels);


         micSourceStream.DataAvailable += new EventHandler<WaveInEventArgs>(micSourceStream_DataAvailable);
         micWaveWriter = new WaveFileWriter(micSaveWavDialog.FileName, micSourceStream.WaveFormat);

         micSourceStream.StartRecording();
      }

      public void loadMicSources(ListView listView1)
      {
         //create list of all our possible input options
         List<WaveInCapabilities> soundInputs = new List<WaveInCapabilities>();

         //populate list with available input options
         for (int i = 0; i < WaveIn.DeviceCount; i++)
         {
            soundInputs.Add(WaveIn.GetCapabilities(i));
         }
         //make sure the old input options are cleared out
         listView1.Clear();


         //populate input options with available from list
         foreach (var element in soundInputs)
         {
            //populate list referencing name
            ListViewItem soundInputView = new ListViewItem(element.ProductName);

            //attach the amount of channels to each name in list
            soundInputView.SubItems.Add(new ListViewItem.ListViewSubItem(soundInputView, element.Channels.ToString()));

            //toolsToolStripMenuItem.DropDownItems.Add(soundInputView);
            listView1.Items.Add(soundInputView);
         }
      }

      public void DisposeWave(DirectSoundOut outputx, WaveFileReader wavex)
      {

         if (output != null)
         {
            if (output.PlaybackState == PlaybackState.Playing)
               output.Stop();

            output.Dispose();
            output = null;
         }
         if (wave != null)
         {
            wave.Dispose();
            wave = null;
         }

      }



      public void pause()
      {

         if (output != null)
         {
            if (output.PlaybackState == PlaybackState.Playing)
               output.Pause();
            else if (output.PlaybackState == PlaybackState.Paused)
               output.Play();

         }
      }
   }
}
