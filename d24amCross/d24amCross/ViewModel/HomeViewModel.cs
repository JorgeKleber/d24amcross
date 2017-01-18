using Acr.UserDialogs;
using d24amCross.Controller;
using d24amCross.Model;
using Plugin.Connectivity;
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
    public class HomeViewModel : ViewModelBase
    {
        private ObservableCollection<ItemRss> lista;

        private Controle controle;

        public ObservableCollection<ItemRss> Lista
        {
            get
            {
                return lista;
            }
            set
            {
                lista = value;
                Notify( "Lista" );
            }
        }

        public ICommand ReloadCommand { get; set; }

        public HomeViewModel()
        {
            controle = new Controle();

            Feed();
        }

        private void Refresh_Clicked( object obj )
        {
            Feed();
        }

        public async void Feed()
        {
            var check = CrossConnectivity.Current.IsConnected;

            if ( check )
            {
                try
                {
                    var item = await controle.BaixarFeed( "http://new.d24am.com/rss" );

                    Lista = item;
                }
                catch ( Exception )
                {
                    controle.MensagemInfo("Problemas com a conexão");
                }

            }
            else
            {
                controle.MensagemInfo("Seu dispositivo não está conectado à internet :(");
            }
        }
    }
}
