﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Denna.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UnitTests : Page
    {
        public UnitTests()
        {
            this.InitializeComponent();
        }
        private async void SwipeListItem_RightFirstClicked(object sender, RoutedEventArgs e)
        {
            await new MessageDialog("Fist Clicked").ShowAsync();
        }

        private async void SwipeListItem_RightSecondClicked(object sender, RoutedEventArgs e)
        {
            await new MessageDialog("Second Clicked").ShowAsync();
        }

        private async void SwipeListItem_RightThirdClicked(object sender, RoutedEventArgs e)
        {
            await new MessageDialog("Third Clicked").ShowAsync();
        }
    }
}
