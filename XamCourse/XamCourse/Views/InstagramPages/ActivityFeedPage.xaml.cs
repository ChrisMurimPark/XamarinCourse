using System;
using System.Collections.Generic;

using Xamarin.Forms;

using XamCourse.Models;
using XamCourse.Services;

namespace XamCourse.Views.InstagramPages
{
    public partial class ActivityFeedPage : ContentPage
    {
        public ActivityFeedPage()
        {
            InitializeComponent();
            list_view.ItemsSource = ActivityService.GetActivities();
        }

        async void HandleActivitySelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var activity = e.SelectedItem as Activity;
            await Navigation.PushAsync(new UserPage(activity.m_user_id));
            list_view.SelectedItem = null;
        }
    }
}
