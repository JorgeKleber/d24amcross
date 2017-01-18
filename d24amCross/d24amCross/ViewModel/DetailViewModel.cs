using d24amCross.Controller;
using d24amCross.Model;
using Plugin.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace d24amCross.ViewModel
{
    public class DetailViewModel : ViewModelBase
    {
        private string descricao;
        private string title;
        private string imageSource;
        private string link;

        public ICommand SharedCommad { get; set; }
        public ICommand OpenBrowserCommand { get; set; }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;

                Notify( "Descricao" );
            }
        }

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

        public string ImageSource
        {
            get
            {
                return imageSource;
            }

            set
            {
                imageSource = value;
                Notify( "ImageSource" );
            }
        }

        public DetailViewModel(ItemRss feedData)
        {
            SharedCommad = new Command(SharedLink_Clicked);
            OpenBrowserCommand = new Command(OpenBrowser_Clicked);

            this.ImageSource = feedData.Imagem;
            Title = feedData.Titulo;
            Descricao = feedData.Descricao;
            link = feedData.Link;
        }

        private void OpenBrowser_Clicked( object obj )
        {
            CrossShare.Current.OpenBrowser(link);
        }

        private void SharedLink_Clicked( object obj )
        {
            CrossShare.Current.ShareLink( link, "Teste", Title );
        }
    }
}
