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
        private string icon1;
        private string icon2;

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

        public string Icon1
        {
            get
            {
                return icon1;
            }

            set
            {
                icon1 = value;
                Notify( "Icon1" );
            }
        }

        public string Icon2
        {
            get
            {
                return icon2;
            }

            set
            {
                icon2 = value;
                Notify( "Icon2" );
            }
        }

        public DetailViewModel(ItemRss feedData)
        {
            //if ( Device.OS == TargetPlatform.Android )
            //{
            //    Icon1 = "ic_share_white_24dp.png";
            //    Icon2 = "ic_open_in_browser_white_24dp.png";
            //}
            //else
            //{
            //    Icon1 = "Send";
            //    Icon2 = "Globe";
            //}

            SharedCommad = new Command(SharedLink_Clicked);
            OpenBrowserCommand = new Command(OpenBrowser_Clicked);

            this.ImageSource = feedData.Imagem;
            Title = feedData.Titulo;
            Descricao = "<html>" + "<body style=\"text-align: justify;\">" + feedData.Descricao + "</body>" + "</html>";
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
