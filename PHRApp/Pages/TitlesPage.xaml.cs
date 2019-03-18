using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PHRApp.Pages
{
   
    public sealed partial class TitlesPage : Page
    {
        Classes.Title title;

        public TitlesPage()
        {
            this.InitializeComponent();
            title = new Classes.Title();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ShowTitles();
        }

        private void BtnAddTitle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnReload_Click(object sender, RoutedEventArgs e)
        {
            ShowTitles();
        }

        private void ShowTitles()
        {
            ListViewTitles.Items.Clear();

            var titles = title.GetTitles();

            foreach (var title in titles)
            {
                UserControls.TitlesUserControl tuc = new UserControls.TitlesUserControl();
                tuc.Title = title;
                ListViewTitles.Items.Add(title);
            }
        }

    }
}
