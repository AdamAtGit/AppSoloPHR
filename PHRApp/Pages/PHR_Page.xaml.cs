﻿using CL_UWP.SpeechClasses;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Windows.Media.SpeechRecognition;
using Windows.Media.SpeechSynthesis;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;



namespace PHRApp.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PHR_Page : Page
    {
        #region Class member declarations
        //below line for app settings
        ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

        // For App Life Cycle and Db
        public string CurrentUserName { get; set; }
        public int CurrentUserId { get; set; }
        public int SelectedTitleId { get; set; }
        public int EditTitleId { get; set; }
        public int DeleteTitleId { get; set; }
        //public List<Title> TitleListIds { get; set; }

        // Get Senders and Callers
        public string MyParent;
        public string MyChild;
        public string MySender;

        public event RoutedEventHandler BtnRepeatMediaOutAsyncClick
        {
            add { BtnRepeatMediaOutAsync.Click += value; }
            remove { BtnRepeatMediaOutAsync.Click -= value; }
        }

        private void UserControl_GotFocus(object sender, RoutedEventArgs e)
        {
            this.stpPlayControls.Background = new SolidColorBrush(Windows.UI.Colors.Orange);
        }
        private void UserControl_LostFocus(object sender, RoutedEventArgs e)
        {
            this.stpPlayControls.Background = new SolidColorBrush(Windows.UI.Colors.Ivory);
        }

        // Repeater Dispatcher Timer
        DispatcherTimer repeatDispTimer = new DispatcherTimer();
        Int32 LeadTime, LagTime;
        static int SetCounter;
        TimeSpan TsInterval;
        static TimeSpan TsElapsed;
        static TimeSpan TsTotalTime;//hh, mm, ss
       
        int timesToTick;
        int i = 0;
        int Repetitions;

        // Media Output Async 
        string ttsRaw = string.Empty;

        //Speech Synth and Recogn
        public string SpeechInputResult { get; set; }

        //Speech User Settings
        public string VoiceGender = "female";
        #endregion

        public PHR_Page()
        {
            this.InitializeComponent();

            //TODO: ARS-Get user's Name for Interactive.
            CurrentUserName = "Adam";

            // Wire up Start Recognizing Routed Event Handlers
            btnRecognitionTtsRawBigAsync.Click += new RoutedEventHandler(StartRecognizing_Click);

            // Wire up Synthesis Test Plays Routed Event Handlers
            //btnTestPlayBig.Click += new RoutedEventHandler(TestPlayBigAsync_Click);

            // Wire up Add Title Save Changes Async to ORMs
            //btnAddTitleBigAsync.Click += new RoutedEventHandler(AddTitleBigAsync_Click);

            //Initialize values- LeadTime before first PHRSet, LagTime for between Sets
            LeadTime = 3;
            SetCounter = 0;
            LagTime = 5;
            TsElapsed = new TimeSpan(0,0, LeadTime);
            TsTotalTime = new TimeSpan(0, 0, 0);
           
            TimerSetUp();
            CboVoiceGender.SelectedIndex = CboVoiceGender.Items.Count - 1;
        }

        public void TimerSetUp()
        {
            repeatDispTimer.Tick += RepeatDispTimer_Tick;
        }

        #region Progress Slider 
        //async Task<int> StopTestAsync(int _reps)
        //{
        //    int reps = _reps + 1;
        //    int totalTime = 0;
        //    double ticksPlusIntervalSecs = 0;
        //    double intervals;

        //    DispatcherTimer dt = new DispatcherTimer();
        //    dt.Interval = new TimeSpan(0, 0, Convert.ToInt16(boxInterval.Text));
        //    intervals = Convert.ToInt16(boxInterval.Text);
        //    dt.Start();
        //    dt.Tick += Dt_Tick;
        //    for (int ticks = 0; ticks < reps; ticks++)
        //    {
        //        ticksPlusIntervalSecs = ticksPlusIntervalSecs + (ticks + intervals);
        //        Debug.WriteLine("dt.interval: " + dt.Interval.ToString());
        //        Debug.WriteLine("ticks: " + ticks.ToString());
        //        Debug.WriteLine("ticksPlusIntervalSecs accruing: "
        //                                        + ticksPlusIntervalSecs.ToString());
        //    }   
        //    //if (reps > Convert.ToInt16(boxRepetitions.Text))
        //    //{
        //    //    dt.Stop();
        //    //}
        //    Debug.WriteLine("\ndt.IsEnabled: " + dt.IsEnabled.ToString());

        //    totalTime = Convert.ToInt16(ticksPlusIntervalSecs);
        //    return (totalTime);
        //}

        //private void Dt_Tick(object sender, object e)
        //{
        //    SdrSpeakAsyncProgress.Value = SdrSpeakAsyncProgress.Value + 10;
        //    Debug.WriteLine("\n\nSdrSpeakAsyncProgress.Value = + 1: "
        //                                    + SdrSpeakAsyncProgress.Value.ToString());
        //}

        //private async void TgbCommandModeOn_Click(object sender, RoutedEventArgs e)
        //{          
        //    TgbCommandModeOn.Foreground = new SolidColorBrush(Colors.DodgerBlue);
        //    int reps;
        //    reps = Convert.ToInt16(boxRepetitions.Text);         
        //    await StopTestAsync(reps);
        //    TgbCommandModeOn.Foreground = new SolidColorBrush(Colors.DarkOrange);
        //}
        #endregion
        #region Todo CancelAllAsync
        //stop async method from https://stackoverflow.com/questions/15614991/simply-stop-an-async-method
        ////bool playing;
        //bool keepdoing = true;
        //int count = 10;
        //string text;
        //private async void  TgbCommandModeOff_Click(object sender, RoutedEventArgs e)
        //{
        //    if (cts == null)
        //    {
        //        cts = new CancellationTokenSource();
        //        try
        //        {
        //            await DoSomethingAsync("my text", cts.Token);
        //        }
        //        catch (OperationCanceledException)
        //        {
        //        }
        //        finally
        //        {
        //            cts = null;
        //        }
        //    }
        //    else
        //    {
        //        cts.Cancel();
        //        cts = null;
        //    }
        //}

        //private async void DoSomethingAsync()
        //{
        //    playing = true;
        //    for (int i = 0; keepdoing; count++)
        //    {
        //        await DoSomethingAsync(text, token);
        //    }
        //    playing = false;
        //}

        //private async Task DoSomethingAsync(string text, CancellationToken token)
        //{
        //    TgbCommandModeOff.IsChecked = true;
        //    for (int i = 0; ; i++)
        //    {
        //        token.ThrowIfCancellationRequested();
        //        await DoSomethingAsync(text, token);
        //    }
        //    TgbCommandModeOff.IsChecked = false;
        //}
        #endregion

        private void RepeatDispTimer_Tick(object sender, object e)
        {        
            BtnRepeatMediaOutAsync_Click(sender, new RoutedEventArgs());
        }

        #region Change content based on status
        public string SRep_Status, SInterval_Status;
        public int IRep_Status, IInterval_Status;

        private void ChangeContent()
        {

        }
        #endregion

        //Code Set - Interactive
        //Instantiate class outside of method.
        Interactive interactive = new Interactive();
        InteractivePhRSets PhrSets = new InteractivePhRSets();

        public static TimeSpan AdjustForTaskRunTime(TimeSpan tsInterval, TimeSpan tsElapsed, int reps, out TimeSpan tsTotalTime)
        {
           
            TimeSpan tsAdjustedInterval = new TimeSpan(0, 0, 0);
            TsElapsed = tsElapsed;
            Debug.WriteLine("TsElapsed: " + TsElapsed.ToString());
            tsAdjustedInterval = tsInterval.Add(TsElapsed);
           
            Debug.WriteLine("______ Set " + SetCounter + " ________");
            Debug.WriteLine("tsInterval: " + tsInterval.TotalSeconds.ToString());
            Debug.WriteLine("TsElapsed: " + TsElapsed.TotalSeconds.ToString());
            Debug.WriteLine("tsAdjustedInterval: " + tsAdjustedInterval.TotalSeconds.ToString());
           
            tsTotalTime = TsTotalTime.Add(tsAdjustedInterval);
            Debug.WriteLine("______ PlayList TotalTime: " +  tsTotalTime.ToString() + " ________\n");

            SetCounter++;

            return tsAdjustedInterval;            
        }

        public async void BtnRepeatMediaOutAsync_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TgsRepeats.IsOn)
                {       
                    #region Visible, Drawing, Rotating
                    BtnRepeatMediaOutAsync.Visibility = Visibility.Collapsed;
                    BtnStopPauseRepeatMediaOutAsync.Visibility = Visibility.Visible;
                    stpStatus.Visibility = Visibility.Visible;
                    #endregion
                    #region Status
                    tbStatus.Text = (i + 1).ToString();
                    SRep_Status = (i + 1).ToString();
                    IRep_Status = Convert.ToInt16((i + 1).ToString());
                    #endregion
                    #region Code Set - Interactive                 
                    interactive.PlName = boxTtsRawBig.Text.Trim();
                    //Debug.WriteLine("interactive.PlName = boxTtsRawBig.Text.Trim(); \n" + interactive.PlName);                   
                    // interactive.ChangeTitle(IRep_Status, plName: interactive.PlName);
                    interactive.ChangeTitle(IRep_Status);
                    if (IRep_Status > 0)
                    {
                        boxTtsRawBig.Text = interactive.TitleName.Trim();
                       
                        TsInterval = AdjustForTaskRunTime(TsInterval, PhRTiming.TsElapsed, Repetitions, out TsTotalTime);
                    }
                    #endregion
                    Repetitions = Convert.ToInt32(boxRepetitions.Text.Trim());
                    if (i == 0)
                    {
                        int intervalInSecs = Convert.ToInt32(boxInterval.Text.Trim());
                        TsInterval = new TimeSpan(0, 0, intervalInSecs);
                        TsInterval = AdjustForTaskRunTime(TsInterval, PhRTiming.TsElapsed, Repetitions, out TsTotalTime);
                        repeatDispTimer.Interval = TsInterval;
                        timesToTick = (Repetitions - 1);
                    }
                    //Increment Status
                    ////tbElapsed.Text = PhRTiming.TsElapsed.Seconds.ToString();
                    ////tbTotalTime.Text = TsTotalTime.Seconds.ToString();
                    if (i > 0 && i <= IRep_Status)
                    {
                        Debug.WriteLine("Hit if(i > 0 && i <= IRep_Status)");
                        Debug.Write(i.ToString() + " > 0 && " + i.ToString() + " <= " + IRep_Status.ToString() + "\n\n");
                    }

                    // Debug.WriteLine("\nAfter the if(1 == 0)...timesToTick = (repetitions - 1);\n" +
                    // timesToTick.ToString());
                    //BtnRepeatMediaOutAsync.Foreground = new SolidColorBrush(Windows.UI.Colors.Orange);
                    ttsRaw = boxTtsRawBig.Text.Trim();
                    try
                    {
                        await SpeakTextAsync(ttsRaw, MediaElementPrompter);
                    }
                    catch (Exception) { }
                    
                    // Start Repeater Timer
                    repeatDispTimer.Start();

                    // Stop timer when reps are complete
                    i++;
                    if (i > timesToTick)
                    {
                        tbStatus.Text = "0";
                        repeatDispTimer.Stop();
                        BtnStopPauseRepeatMediaOutAsync.Visibility = Visibility.Collapsed;
                        BtnRepeatMediaOutAsync.Visibility = Visibility.Visible;
                        BtnRepeatMediaOutAsync.Foreground = new SolidColorBrush(Windows.UI.Colors.Orange);
                        stpStatus.Visibility = Visibility.Collapsed;
                        i = 0;
                    }
                }
                else
                {    //This condition is if TsReats.IsOn = false              
                    BtnRepeatMediaOutAsync.Foreground = new SolidColorBrush(Windows.UI.Colors.Orange);
                    ttsRaw = boxTtsRawBig.Text.Trim();
                    try
                    {
                        await SpeakTextAsync(ttsRaw, MediaElementPrompter);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        #region Speech Recognition
        private async void StartRecognizing_Click(object sender, RoutedEventArgs e)
        {
            //test change for commi
            // Create an instance of SpeechRecognizer.
            var speechRecognizer = new SpeechRecognizer();

            // Set timeout settings.
            speechRecognizer.Timeouts.InitialSilenceTimeout = TimeSpan.FromSeconds(8.0);
            speechRecognizer.Timeouts.BabbleTimeout = TimeSpan.FromSeconds(6.0);
            speechRecognizer.Timeouts.EndSilenceTimeout = TimeSpan.FromSeconds(3.2);

            // Compile the dictation grammar by default.
            await speechRecognizer.CompileConstraintsAsync();

            //Inform user it's now listening
            tbRecogStatus.Foreground = new SolidColorBrush(Colors.DarkOrange);
            tbRecogStatus.Text = "...listening";
            SolidColorBrush darkGray = new SolidColorBrush(Colors.DarkGray);
            btnRecognitionTtsRawBigAsync.BorderBrush = new SolidColorBrush(Colors.DarkOrange);
            // Start recognition.
            SpeechRecognitionResult speechRecognitionResult =
                        await speechRecognizer.RecognizeAsync();
            //await speechRecognizer.RecognizeWithUIAsync();



            // Do something with the recognition result.
            SpeechInputResult = speechRecognitionResult.Text;
            boxTtsRawBig.Text += SpeechInputResult;

            //Inform user it has finished listening and to click the Mic to continue
            tbRecogStatus.Foreground = new SolidColorBrush(Colors.Ivory);
            tbRecogStatus.Text = "listening stopped. Tap the Mic to continue";
            btnRecognitionTtsRawBigAsync.BorderBrush = darkGray;

            //var messageDialog = new Windows.UI.Popups.MessageDialog(speechRecognitionResult.Text, "Text spoken");
            //await messageDialog.ShowAsync();
        }
        #endregion

        private void BtnStopPauseRepeatMediaOutAsync_Click(object sender, RoutedEventArgs e)
        {
            i = 0;
            tbStatus.Text = "0";
            repeatDispTimer.Stop();
            Debug.WriteLine("tnStopPauseRepeatMediaOutAsync_Click: "
                + repeatDispTimer.IsEnabled.ToString());
            //repeatDispTimer.Tick -= RepeatDispTimer_Tick;
            Debug.WriteLine("\ntnStopPauseRepeatMediaOutAsync_Click\n after -=  : "
                + repeatDispTimer.IsEnabled.ToString());
            if (TgsRepeats.IsOn)
            {
                BtnRepeatMediaOutAsync.Visibility = Visibility.Visible;
                BtnStopPauseRepeatMediaOutAsync.Visibility = Visibility.Collapsed;
                stpStatus.Visibility = Visibility.Collapsed;
            }
            BtnRepeatMediaOutAsync.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
        }

        #region Speech
        async Task<IRandomAccessStream> SynthesizeTextToSpeechAsync(string text)
        {
            // Windows.Storage.Streams.IRandomAccessStream
            IRandomAccessStream stream = null;

            // Windows.Media.SpeechSynthesis.SpeechSynthesizer
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {
                #region TODO: speech user settings
                //// Select the US English voice.
                //if (VoiceGender == "female")
                //{
                //   // synthesizer.Voice.Gender.voi = Windows.Media.SpeechSynthesis.VoiceGender.Female;
                //    synthesizer.Options.AudioVolume = 100;
                //}

                //Volume Setting
                //synthesizer.Options.AudioVolume = +100;
                #endregion
                stream = await synthesizer.SynthesizeTextToStreamAsync(text);
            }
            return (stream);
        }

        async Task SpeakTextAsync(string text, MediaElement mediaElement)
        {
            //TODO: ARS use link below to stop async tasks
            //https://stackoverflow.com/questions/15614991/simply-stop-an-async-method
            IRandomAccessStream stream = await SynthesizeTextToSpeechAsync(text);
            //here try stoping timer
            repeatDispTimer.Stop();
            await mediaElement.PrompterPlayStreamAsync(stream, true);
            repeatDispTimer.Start();
        }
        #endregion
        #region User Speech Gender Settings
        private void CboVoiceGender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            VoiceGender = CboVoiceGender.SelectedValue.ToString();
        }
        #endregion       
    }
}
