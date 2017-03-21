using d24amCross.Controller;
using d24amCross.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace d24amCross.Views
{
    public class RootPage : MasterDetailPage
    {
        Dictionary<MenuIndex, NavigationPage> Views { get; set; }

        public RootPage()
        {
            Title = "Tutor Inteligente";
            BackgroundColor = Color.Green;

            Views = new Dictionary<MenuIndex, NavigationPage>();

            Master = new MenuPage( this )
            {
                Title = "Menu Page"
            };

            Detail = new NavigationPage( new HomePage()
            {
                Title = "Home Page"
            });

            NavigateAsync( MenuIndex.Home );
        }

        public void NavigateAsync( MenuIndex id )
        {
            Page newPage;

            if ( !Views.ContainsKey( id ) )
            {
                switch ( id )
                {
                    case MenuIndex.Home:

                        Views.Add( id, new ControlNavigationApp( new HomePage() ) );

                        break;
                    case MenuIndex.Eportes:

                        Views.Add( id, new ControlNavigationApp( new EsporteTabPage() ) );

                        break;
                    case MenuIndex.Plus:

                        Views.Add( id, new ControlNavigationApp( new PlusTabPage() ) );

                        break;
                    case MenuIndex.Amazonia:

                        Views.Add( id, new ControlNavigationApp( new HomePage() ) );

                        break;
                    case MenuIndex.Sobre:
                        Views.Add( id, new ControlNavigationApp( new HomePage() ) );
                        break;
                    default:
                        break;
                }
            }

            newPage = Views[id];

            if ( newPage == null )
                return;

            ////pop to root for Windows Phone
            //if ( Detail != null && Device.OS == TargetPlatform.WinPhone )
            //{
            //    await Detail.Navigation.PopToRootAsync();
            //}

            Detail = newPage;

            if ( Device.Idiom != TargetIdiom.Tablet )
                IsPresented = false;
        }
    }
}
