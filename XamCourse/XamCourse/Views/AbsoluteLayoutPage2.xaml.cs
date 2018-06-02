using System;
using System.Collections.Generic;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

using Xamarin.Forms;

namespace XamCourse.Views
{
    public partial class AbsoluteLayoutPage2 : ContentPage
    {
        public AbsoluteLayoutPage2()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    var safe_insets = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
                    safe_insets.Left = 20;
                    safe_insets.Right = 20;
                    safe_insets.Top += 20;
                    relax_label.Margin = safe_insets;
                    break;
            }
        }

    }
}
