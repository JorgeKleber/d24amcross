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

            Detail = new HomePage()
            {
                Title = "Tutor Inteligente"
            };

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
                    case MenuIndex.Apoio:

                        Views.Add( id, new ControlNavigationApp( new HomePage() ) );

                        break;
                    case MenuIndex.Desempenho:

                        Views.Add( id, new ControlNavigationApp( new HomePage() ) );

                        break;
                    case MenuIndex.Simulado:

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
