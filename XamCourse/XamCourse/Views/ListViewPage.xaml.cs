using XamCourse.Services;
using XamCourse.Models;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using System.Collections.Generic;

namespace XamCourse.Views
{
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            UpdateSearches();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    var safe_insets = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
                    Padding = safe_insets;
                    break;
            }
        }

        void UpdateSearches(string filter = null)
        {
            var search_group = new SearchGroup(SearchService.GetSearches(filter));
            list_view.ItemsSource = new List<SearchGroup> { search_group };
        }

        void HandleSearchTextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            UpdateSearches(e.NewTextValue);
        }

        void HandleDeleteClicked(object sender, System.EventArgs e)
        {
            var id = (int)(sender as MenuItem).CommandParameter;
            SearchService.DeleteSearch(id);
            UpdateSearches(search_bar.Text);
        }

        void HandleRefreshing(object sender, System.EventArgs e)
        {
            UpdateSearches(search_bar.Text);
            list_view.EndRefresh();
        }

        void HandleItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            list_view.SelectedItem = null;
        }
    }
}
