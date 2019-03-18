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


namespace PHRApp.UserControls
{
    public sealed partial class TitlesUserControl : UserControl
    {
        private Classes.Title title;
        public Classes.Title Title
        {
            get { return title; }
            set
            {
                title = value;
                TbTitleName.Text = title.TitleName;
                TbCategory.Text = title.Category;
                TbTtsRaw.Text = title.TtsRaw;
                TbUses.Text = title.Uses;
                TbFileUri.Text = title.FileUri;
            }
        }

        public TitlesUserControl()
        {
            this.InitializeComponent();
        }
    }
}
