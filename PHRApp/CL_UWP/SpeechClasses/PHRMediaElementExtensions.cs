using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace CL_UWP.SpeechClasses
{
    public static class PHRMediaElementExtensions
    {
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

            await taskCompleted.Task;

            mediaElement.MediaEnded -= endOfPlayHandler;
        }
    }
}