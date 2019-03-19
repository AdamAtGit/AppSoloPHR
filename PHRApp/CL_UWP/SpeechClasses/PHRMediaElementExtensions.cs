using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace CL_UWP.SpeechClasses
{
   
    public static class PHRMediaElementExtensions
    {
        public static object MediaElement { get; internal set; }
        public static async Task PrompterPlayStreamAsync(
          //? this MediaElement mediaElement,
          this MediaElement mediaElement,
          IRandomAccessStream stream,
          bool disposeStream = true)
        {
            // bool is irrelevant here, just using this to flag task completion.
            TaskCompletionSource<bool> taskCompleted = new TaskCompletionSource<bool>();

            // Note that the MediaElement needs to be in the UI tree for events
            // like MediaEnded to fire.
            RoutedEventHandler endOfPlayHandler = (s, e) =>
            {
                if (disposeStream)
                {
                    stream.Dispose();
                }
                taskCompleted.SetResult(true);
            };
            mediaElement.MediaEnded += endOfPlayHandler;

            mediaElement.SetSource(stream, string.Empty);
            mediaElement.Play();
            #region TODO: Maybe Get sender/caller
            //RepeaterUserControl repeaterUC = new RepeaterUserControl();
            //RepeaterUserControl2 repeaterUC2 = new RepeaterUserControl2();
            ////QnAPage qnAPage = new QnAPage();
            //if (repeaterUC2.MySender == "BtnRepeatMediaOutAsync2")
            //{
            //    Debug.WriteLine("Sender is RepeaterUserControl: " + repeaterUC2.MySender.ToString());
            //}
            //else if(repeaterUC2.MySender == "BtnRepeatMediaOutAsync2")
            //{
            //    Debug.WriteLine("Sender is RepeaterUserControl2: " + repeaterUC2.MySender.ToString());
            //}
            //else
            //{
            //    Debug.WriteLine("Sender undetermined");
            //}
            #endregion
            //Code-Set Get Amount of time takes for Async Task - await takes
            Int32 secs = 0;
            Int32 secs2 = 0;
            TimeSpan tsCombinedSecs = new TimeSpan(0, 0, secs);
            var sw = new Stopwatch();
            sw.Start();
            try
            {
                bool IsValid = await taskCompleted.Task;
                //Debug.WriteLine("\nbool IsValid : " + IsValid.ToString());
            }
            catch (Exception) { }

            try
            {
                sw.Stop();
                TimeSpan tsElapsedSecs = sw.Elapsed;
                Debug.WriteLine("Elapsed Secs: " + tsElapsedSecs.Seconds.ToString());
                Debug.WriteLine("Elapsed Secs: " + tsElapsedSecs.TotalSeconds.ToString());
                double secsElapsed = sw.Elapsed.TotalSeconds;
               // Debug.WriteLine("\ndouble secsElapsed = sw.Elapsed.TotalSeconds; : " + secsElapsed.ToString());
            }
            catch (Exception) { }

            try
            {
                //Do not think this is doing anything, as secs2 is no value,
                Interlocked.Add(ref secs, secs2);
                //Debug.WriteLine("\nsecs : " + secs.ToString());
            }
            catch (Exception){}
            
            mediaElement.MediaEnded -= endOfPlayHandler;
        }
    }
}