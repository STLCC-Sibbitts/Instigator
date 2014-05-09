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

      //use NAudio to read in wave files
      private WaveFileReader waveFile = null;

      //use NAudio to play output sound
      private DirectSoundOut output = null;

      //DirectSoundOut and Stream objects for use when using filters
      //private DirectSoundOut filterOutput = null;  //looking at the code, I don't think you need two outputs
      private BlockAlignReductionStream stream = null;
      private WaveChannel32 waveChannel = null;
      public bool IsPlaying
      {
         get
         {
            if (output != null)
            {
               if (output.PlaybackState == PlaybackState.Playing)
                  return true;
               else
                  return false;
            }
            else
               return false;            
         }
      }
      private bool isOutputBuilt;

      public Player()
      {
         LogMessage = "";
         isOutputBuilt = false;
      }

      public void playSample(ref Pad pad)
      {

          LogMessage = "";
          if (pad.parametersChanged || !isOutputBuilt)//if settings have changed, rebuild output
          {
              if (pad.isLoaded)
              {
                  this.waveFile = new WaveFileReader(pad.Dialog.FileName);
                  LogMessage += "waveFile created" + waveFile.ToString() + "\n";

                  if (this.waveFile != null)
                  {
                      output = new DirectSoundOut(50);  //latency of 50ms
                      waveChannel = new WaveChannel32(waveFile);
                      waveChannel.PadWithZeroes = false;  //this fixed the issue where the stop event was never called!
                      output.Init(waveChannel);

                      LogMessage += "Got past output creation\n";
                      LogMessage += output.ToString() + "\n";

                      switch (pad.currentFilter)
                      {
                          case 0:
                              //play sample without effects
                              waveFile.CurrentTime = TimeSpan.Zero;
                              //output.Play();
                              LogMessage += "No filter.\n";
                              break;
                          case 1:  // pad.currentFilter = 1 for echo
                              playSampEcho(pad);
                              break;
                          default:
                              break;
                      }
                      isOutputBuilt = true;
                      pad.parametersChanged = false;
                      output.Play();
                  }
                  else
                  {
                      LogMessage += "The dialog was null...";
                  }
                  //probably don't want to continually dispose of the file for a sampler,
                  //better to keep it in memory somehow
                  //    DisposeWave();  //dispose of this if effect params change
              }
          }
          else
          {
              LogMessage += "Output already built\n";
              waveFile.CurrentTime = TimeSpan.Zero;
              output.Play();
          }
      }


       //
       // Different playSamp flow for each filter:
       //
       private void playSampEcho(Pad pad)
       {
            //use filterstream to break stream apart
            FilterStream delayedFilter = new FilterStream(waveChannel);

            stream = new BlockAlignReductionStream(delayedFilter);

            //apply a filter - make sure there is an effect assigned to each channel
            for (int i = 0; i < waveFile.WaveFormat.Channels; i++)
               delayedFilter.filters.Add(new Echo(pad.echoDelay,pad.echoFactor));

            //output = new DirectSoundOut(200);  //latency of 200ms?  Yikes.
            output.Init(stream);               //NAudio documentation is lacking
         } //end playSampEcho

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
      } //end pause method

   }
}
