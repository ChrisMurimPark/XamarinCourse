using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamCourse.Views
{
    public partial class GridPage : ContentPage
    {
        const int MAX_DIGITS = 10;

        public GridPage()
        {
            InitializeComponent();
        }

        void Handle_1_Clicked(object sender, System.EventArgs e)
        {
            if (phone_number_label.Text.Length < MAX_DIGITS)
                phone_number_label.Text += '1';
        }
        void Handle_2_Clicked(object sender, System.EventArgs e)
        {
            if (phone_number_label.Text.Length < MAX_DIGITS)
                phone_number_label.Text += '2';
        }
        void Handle_3_Clicked(object sender, System.EventArgs e)
        {
            if (phone_number_label.Text.Length < MAX_DIGITS)
                phone_number_label.Text += '3';
        }
        void Handle_4_Clicked(object sender, System.EventArgs e)
        {
            if (phone_number_label.Text.Length < MAX_DIGITS)
                phone_number_label.Text += '4';
        }
        void Handle_5_Clicked(object sender, System.EventArgs e)
        {
            if (phone_number_label.Text.Length < MAX_DIGITS)
                phone_number_label.Text += '5';
        }
        void Handle_6_Clicked(object sender, System.EventArgs e)
        {
            if (phone_number_label.Text.Length < MAX_DIGITS)
                phone_number_label.Text += '6';
        }
        void Handle_7_Clicked(object sender, System.EventArgs e)
        {
            if (phone_number_label.Text.Length < MAX_DIGITS)
                phone_number_label.Text += '7';
        }
        void Handle_8_Clicked(object sender, System.EventArgs e)
        {
            if (phone_number_label.Text.Length < MAX_DIGITS)
                phone_number_label.Text += '8';
        }
        void Handle_9_Clicked(object sender, System.EventArgs e)
        {
            if (phone_number_label.Text.Length < MAX_DIGITS)
                phone_number_label.Text += '9';
        }
        void Handle_0_Clicked(object sender, System.EventArgs e)
        {
            if (phone_number_label.Text.Length < MAX_DIGITS)
                phone_number_label.Text += '0';
        }

        void Handle_Delete_Clicked(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(phone_number_label.Text))
                return;
            phone_number_label.Text = 
                phone_number_label.Text.Substring(0, phone_number_label.Text.Length - 1);
        }
    }
}
