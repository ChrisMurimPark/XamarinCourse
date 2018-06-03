using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamCourse.Views
{
    public partial class ImagesPage : ContentPage
    {
        string[] image_uris = new string[]
        {
            "https://goo.gl/CuYUGN",
            "https://goo.gl/1wHqz9",
            "https://goo.gl/QoxtNy",
            "https://goo.gl/Yt6cdF"
        };
        uint image_index = 0;

        public ImagesPage()
        {
            InitializeComponent();
            SetImage();
        }

        void HandlePrevClicked(object sender, System.EventArgs e)
        {
            if (image_index == 0)
                image_index = (uint)image_uris.Length - 1;
            else
                image_index--;
            SetImage();
        }

        void HandleNextClicked(object sender, System.EventArgs e)
        {
            image_index = (image_index + 1) % (uint) image_uris.Length;
            SetImage();
        }

        void SetImage()
        {
            image.Source = new UriImageSource
            {
                Uri = new Uri(image_uris[image_index]),
                CachingEnabled = false
            };
        }
    }
}