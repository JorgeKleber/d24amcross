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
    public partial class MenuPage : ContentPage
    {
        RootPage main;

        private Controle controle;

        public MenuPage( RootPage main )
        {
            InitializeComponent();

            controle = new Controle();

            this.main = main;

            List<MenuModel> menuItems = new List<MenuModel>
                {
                    new MenuModel { Opcao = "Notícias",   IndexItem = MenuIndex.Home,       IconeSrc = "ic_home.png",    },
                    new MenuModel { Opcao = "Esportes",   IndexItem = MenuIndex.Apoio,      IconeSrc = "ic_consulta.png",},
                    new MenuModel { Opcao = "Plus",       IndexItem = MenuIndex.Desempenho, IconeSrc = "ic_combos.png",  },
                    new MenuModel { Opcao = "Amazônia",   IndexItem = MenuIndex.Simulado,   IconeSrc = "ic_list.png",    },
                    new MenuModel { Opcao = "Sobre",      IndexItem = MenuIndex.Sobre,      IconeSrc = "ic_info.png",    },
                };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.ItemSelected += ListViewMenu_ItemSelected;
        }

        private void ListViewMenu_ItemSelected( object sender, SelectedItemChangedEventArgs e )
        {
            MenuModel item = ( sender as ListView ).SelectedItem as MenuModel;

            this.main.NavigateAsync( item.IndexItem );
        }
    }
}
