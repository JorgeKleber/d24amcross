using d24amCross.Controller;
using d24amCross.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public EsporteViewModel()
        {
            TitlePage = "D24am Feed";
            Feed();
        }

        private async void Feed()
        {
            controle = new Controle();

            RssList = await controle.BaixarFeed( "http://new.d24am.com/rss?section=3" );
        }
    }
}
