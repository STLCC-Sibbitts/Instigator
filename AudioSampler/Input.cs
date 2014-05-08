using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioSampler
{
   class Input  //moved unused microphone methods from player class to new class
   {
      //use for mic recording
      //WaveIn micSourceStream = null;
      //DirectSoundOut micWavOut = null;
      //WaveFileWriter micWaveWriter = null;
      
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
   }
}
