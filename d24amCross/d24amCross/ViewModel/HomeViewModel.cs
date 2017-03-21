﻿using Acr.UserDialogs;
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

        private bool visibility;

        private Controle controle;

        private bool status;

        private string titlePage;

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

        public bool Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
                Notify( "Status" );
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
                Notify( "Visibility" );
            }
        }

        public HomeViewModel()
        {
            TitlePage = "D24am Feed";

            this.Visibility = true;

            controle = new Controle();

            Feed();

            ReloadCommand = new Command( Refresh_Clicked );
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
                    this.Visibility = true;

                    var item = await controle.BaixarFeed( "http://new.d24am.com/rss" );

                    Lista = item;

                    this.Visibility = false;

                }
                catch ( Exception )
                {
                    controle.MensagemInfo( "Problemas com a conexão" );
                }

            }
            else
            {
                controle.MensagemInfo( "Seu dispositivo não está conectado à internet :(" );
            }
        }
    }
}
