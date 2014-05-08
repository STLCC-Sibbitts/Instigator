using AudioSampler.Filters;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioSampler
{
   class Player
   {

      public string LogMessage { get; private set; }
      //use for mic recording
      //WaveIn micSourceStream = null;
      //DirectSoundOut micWavOut = null;
      //WaveFileWriter micWaveWriter = null;

      //use NAudio to read in wave files
      private WaveFileReader waveFile = null;
      //private WaveFileReader wave2 = null;

      //to be used to open samples
      //private OpenFileDialog multiSampleOpen = new OpenFileDialog();

      //use NAudio to play output sound
      private DirectSoundOut output = null;
      //private DirectSoundOut output2 = null;

      //DirectSoundOut and Stream objects for use when using filters
      private DirectSoundOut filterOutput = null;
      private BlockAlignReductionStream stream = null;

      //turn filter on and off
      public bool addFilter = false;  //this will end up in pad class

      public Player()
      {
         LogMessage = "";
      }

      /*
      */
      public void playSample(Pad pad)
      {
        
         if (pad.isLoaded)
         {
            waveFile = new WaveFileReader(pad.Dialog.FileName);
            LogMessage += "waveFile created" + waveFile.ToString()+"\n";
            if (waveFile != null)
            {
               output = new DirectSoundOut();
               output.Init(new WaveChannel32(waveFile));
              
               LogMessage += "Got past output creation\n";
               LogMessage = output.ToString()+"\n";
               //play sample without effects
               if (!addFilter)
               {
                  output.Play();
                  waveFile.CurrentTime = TimeSpan.Zero;
                  output.Play();
                  LogMessage += "No filter.\n";
               }


/*       /// //FOLLOWING ECHO METHODOLOGY MOVED TO SEPERATE PLAY FLOW (see below)

               //if echo button was pressed addFilter is true so we use FilterStream to add echo filter
               if (addFilter != false)
               {
                  // WaveCHannel32 guarenties 32bit floating point for filtering
                  WaveChannel32 wave3 = new WaveChannel32(new WaveFileReader(pad.SamplePath));

                  FilterStream delayedFilter = new FilterStream(wave3);
                  stream = new BlockAlignReductionStream(delayedFilter);

                  //apply a filter - make sure there is an effect assigned to each channel
                  for (int i = 0; i < waveFile.WaveFormat.Channels; i++)

                     //delayedFilter.filters.Add(new Echo(pad.padEchoDelay,pad.padEchoFactor));

                     filterOutput = new DirectSoundOut(200);
                  filterOutput.Init(stream);
                  filterOutput.Play();

               }
 */   
            
            }


            else
            {
               LogMessage += "The dialog was null...";
            }
           
             
             //probably don't want to continually dispose of the file for a sampler,
             //better to keep it in memory somehow

             //    You're right these were stopping the playing of the sound before it could play -- now it plays
             //    DisposeWave();
             //    DisposeWave();  //dispose of this if effect params change
         }
      }


       //
       // Different playSamp flow for each filter:
       //
       public void playSampEcho(Pad pad)
       {
         if (pad.isLoaded)
         {
            waveFile = new WaveFileReader(pad.Dialog.FileName);
            LogMessage += "waveFile created" + waveFile.ToString()+"\n";
            if (waveFile != null)
            {
               output = new DirectSoundOut();
               output.Init(new WaveChannel32(waveFile));
              
               LogMessage += "Got past output creation\n";
               LogMessage = output.ToString()+"\n";

                // WaveCHannel32 guarenties 32bit floating point for filtering
                WaveChannel32 wave3 = new WaveChannel32(new WaveFileReader(pad.SamplePath));

                //use filterstream to break stream apart
                FilterStream delayedFilter = new FilterStream(wave3);

                stream = new BlockAlignReductionStream(delayedFilter);

                  //apply a filter - make sure there is an effect assigned to each channel
                  for (int i = 0; i < waveFile.WaveFormat.Channels; i++)
                    delayedFilter.filters.Add(new Echo(pad.echoDelay,pad.echoFactor));

                     filterOutput = new DirectSoundOut(200);
                  filterOutput.Init(stream);
                  filterOutput.Play();

               }




            }
         }


      //public void stopRecording()
      //{

      //   if (micWavOut != null)
      //   {
      //      micWavOut.Stop();
      //      micWavOut.Dispose();
      //      micWavOut = null;
      //   }
      //   if (micSourceStream != null)
      //   {
      //      micSourceStream.StopRecording();
      //      micSourceStream.Dispose();
      //      micSourceStream = null;
      //   }
      //   //dispose for mic-record-to-wav
      //   if (micWaveWriter != null)
      //   {
      //      micWaveWriter.Dispose();
      //      micWaveWriter = null;
      //   }

      //}
      //public void micOn(int chosenInputNumber)
      //{


      //   micSourceStream = new WaveIn();
      //   micSourceStream.DeviceNumber = chosenInputNumber;
      //   micSourceStream.WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(chosenInputNumber).Channels);

      //   //use wavein to go between wave in and sound out
      //   WaveInProvider waveIn = new WaveInProvider(micSourceStream);

      //   micWavOut = new DirectSoundOut();
      //   micWavOut.Init(waveIn);

      //   //push recording into buffer
      //   micSourceStream.StartRecording();
      //   micWavOut.Play();



      //}


      //private void micSourceStream_DataAvailable(object sender, WaveInEventArgs e)
      //{
      //   if (micWaveWriter == null) return;
      //   micWaveWriter.WriteData(e.Buffer, 0, e.BytesRecorded);
      //   micWaveWriter.Flush();
      //}

      //public void recordWav(ListView listView1, SaveFileDialog micSaveWavDialog)
      //{
      //   int chosenInputNumber = listView1.SelectedItems[0].Index;


      //   micSourceStream = new WaveIn();
      //   micSourceStream.DeviceNumber = chosenInputNumber;

      //   //set up new waveformat using the chosen devices amount of channels
      //   micSourceStream.WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(chosenInputNumber).Channels);


      //   micSourceStream.DataAvailable += new EventHandler<WaveInEventArgs>(micSourceStream_DataAvailable);
      //   micWaveWriter = new WaveFileWriter(micSaveWavDialog.FileName, micSourceStream.WaveFormat);

      //   micSourceStream.StartRecording();
      //}

      //public void loadMicSources(ListView listView1)
      //{
      //   //create list of all our possible input options
      //   List<WaveInCapabilities> soundInputs = new List<WaveInCapabilities>(); 

      //   //populate list with available input options
      //   for (int i = 0; i < WaveIn.DeviceCount; i++)
      //   {
      //      soundInputs.Add(WaveIn.GetCapabilities(i));
      //   }
      //   //make sure the old input options are cleared out
      //   listView1.Clear();


      //   //populate input options with available from list
      //   foreach (var element in soundInputs)
      //   {
      //      //populate list referencing name
      //      ListViewItem soundInputView = new ListViewItem(element.ProductName);

      //      //attach the amount of channels to each name in list
      //      soundInputView.SubItems.Add(new ListViewItem.ListViewSubItem(soundInputView, element.Channels.ToString()));

      //      //toolsToolStripMenuItem.DropDownItems.Add(soundInputView);
      //      listView1.Items.Add(soundInputView);
      //   }
      //}

      //this needs cleaned up...
      public void DisposeWave()
      {
         if (output != null)
         {
            if (output.PlaybackState == PlaybackState.Playing)
               output.Stop();

            output.Dispose();
            output = null;
         }
         if (waveFile != null)
         {
            waveFile.Dispose();
            waveFile = null;
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
