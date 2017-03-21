using d24amCross.Controller;
using d24amCross.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace d24amCross.ViewModel
{
    public class EsporteViewModel : ViewModelBase
    {
        public Controle controle;

        private string titlePage;

        private ObservableCollection<ItemRss> rssList;

        public ObservableCollection<ItemRss> RssList
        {
            get
            {
                return rssList;
            }

            set
            {
                rssList = value;
                Notify( "RssList" );
            }
        }

        public string TitlePage
        {
            get
            {
                return titlePage;
            }

            set
            {
                titlePage = value;
                Notify( "TitlePage" );
            }
        }

        public ICommand ReloadCommand { get; set; }

        public bool Visibility
        {
            get
            {
                return visibility;
            }

            set
            {
                visibility = value;
                Notify("Visibility");
            }
        }

        private bool visibility;

        public EsporteViewModel()
        {
            this.Visibility = true;

            TitlePage = "D24am Feed";

            ReloadCommand = new Command( Refresh_Command );

            Feed();
        }

        private void Refresh_Command( object obj )
        {
            Feed();
        }

        private async void Feed()
        {
            controle = new Controle();

            this.Visibility = true;

            RssList = await controle.BaixarFeed( "http://new.d24am.com/rss?section=3" );

            this.Visibility = false;

        }
    }
}
