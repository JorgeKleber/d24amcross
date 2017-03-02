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
                var tabPage = new TabbedPage();

                tabPage.Title = "App do Kleber";

                tabPage.Children.Add( new NavigationPage( new HomePage() ) { Title = "News" } );
                tabPage.Children.Add( new NavigationPage( new EsporteTabPage() ) { Title = "Esporte" } );
                tabPage.Children.Add( new NavigationPage( new PlusTabPage() ) { Title = "Plus" } );

                MainPage = tabPage;
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
