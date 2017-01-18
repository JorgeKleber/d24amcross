using d24amCross.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace d24amCross.ViewModel
{
    public class HomeTabbedViewModel : ViewModelBase
    {
        private string title;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
                Notify( "Title" );
            }
        }

        public HomeTabbedViewModel( HomeTabbedPage page )
        {
            Title = "D24am Feed";

            ( App.Current.MainPage as TabbedPage ).Children.Add( new HomePage() { Title = "D24am Feed" });
            ( App.Current.MainPage as TabbedPage ).Children.Add( new EsporteTabPage() { Title = "D24am Feed" } );
            ( App.Current.MainPage as TabbedPage ).Children.Add( new PlusTabPage() { Title = "D24am Feed" } );

            //page.Children.Add( new NavigationPage( new HomePage() { Title = "D24am Feed" } ) { Title = "Page1"} );
            //page.Children.Add( new NavigationPage( new EsporteTabPage() { Title = "D24am Feed" } ) { Title = "Page2" } );
            //page.Children.Add( new NavigationPage( new PlusTabPage() { Title = "D24am Feed" } ) { Title = "Page3" } );
        }


    }
}
