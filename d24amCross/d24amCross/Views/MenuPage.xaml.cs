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

        public MenuPage(RootPage main)
        {
            InitializeComponent();

            controle = new Controle();

            this.main = main;

            List<MenuModel> menuItems;

            menuItems = new List<MenuModel>
                {
                    new MenuModel { Opcao = "Notícias",   IndexItem = MenuIndex.Home,     IconeSrc = "noticia.png", Background = "#c90019" },
                    new MenuModel { Opcao = "Esportes",   IndexItem = MenuIndex.Eportes,  IconeSrc = "sports.png",  Background = "#239bd2" },
                    new MenuModel { Opcao = "Plus",       IndexItem = MenuIndex.Plus,     IconeSrc = "plus.png",    Background = "#e2007a" },
                    new MenuModel { Opcao = "Amazônia",   IndexItem = MenuIndex.Amazonia, IconeSrc = "folha.png",   Background = "#99cc33" },
                    //new MenuModel { Opcao = "Sobre",      IndexItem = MenuIndex.Sobre,    IconeSrc = "sobre.png",   Background = "#3333ff" },
                };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.ItemSelected += ListViewMenu_ItemSelected;
        }

        private void ListViewMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MenuModel item = (sender as ListView).SelectedItem as MenuModel;

            this.main.NavigateAsync(item.IndexItem);

            this.BackgroundColor = Color.FromHex(item.Background); ;
        }
    }
}
