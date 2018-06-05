using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamCourse.Services;
using XamCourse.Models;

namespace XamCourse.Views.InstagramPages
{
    public partial class UserPage : ContentPage
    {
        public UserPage(int user_id)
        {
            InitializeComponent();
            User user = UserService.GetUser(user_id);
            Title = user.m_name;
            label.Text = user.m_status;
        }
    }
}
