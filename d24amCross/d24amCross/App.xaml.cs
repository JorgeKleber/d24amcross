using d24amCross.Views;
using Xamarin.Forms;

namespace d24amCross
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if ( Device.OS == TargetPlatform.Android )
            {
                MainPage = new RootPage();
            }
            else if ( Device.OS == TargetPlatform.Windows)
            {
                MainPage = new HomeTabbedPage() { Title = "D24am - Feed de notícias" };
            }
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
