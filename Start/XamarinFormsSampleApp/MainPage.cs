using Xamarin.Forms;

namespace XamarinFormsSampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void NavigateToSecondPage(object sender, System.EventArgs e) 
        {
            Application.Current.MainPage = new SecondPage();
        }

        void NavigateToNativePage(object sender, System.EventArgs e)
        {
        }
    }
}
