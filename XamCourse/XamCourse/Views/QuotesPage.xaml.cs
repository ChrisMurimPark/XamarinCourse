using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace XamCourse.Views
{
    public partial class QuotesPage : ContentPage
    {
        string[] m_quotes = {
                "All for one, and one for all.",
                "Never give up.",
                "Do it to it."
            };
        long m_curr_quote_index = 0;

        public QuotesPage()
        {
            InitializeComponent();
            quote_label.Text = m_quotes[m_curr_quote_index];
            slider.Value = 16;
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
                    this.Padding = safe_insets;
                    break;
            }
        }

        void Handle_Next_Clicked(object sender, System.EventArgs e)
        {
            m_curr_quote_index = (m_curr_quote_index + 1) % m_quotes.Length;
            quote_label.Text = m_quotes[m_curr_quote_index];
        }
    }
}
