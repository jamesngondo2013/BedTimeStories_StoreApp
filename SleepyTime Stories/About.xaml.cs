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

namespace SleepyTime_Stories
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class About : Page
    {
        public About()
        {
            this.InitializeComponent();
            aboutTheGame.Text = " BedTime Stories" + "\n" +
                                "An easy-to-use full of exciting bed time stories for kids." + "\n" +
                                "This app is self-contained and does not require an internet connection. It is an excellent app" + "\n" +
                                "for kids. " + "\n" +

                                "James Ngondo - Copyright 2015" + "\n" +
                                "jamesngondo2013@outlook.com" + "\n" +
                                "Facebook: Jay Ngondo";
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
