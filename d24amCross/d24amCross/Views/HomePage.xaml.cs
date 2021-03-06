﻿using d24amCross.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace d24amCross.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            if ( Device.OS == TargetPlatform.Windows )
            {
                var refresh = new ToolbarItem()
                {
                    Icon = "ic_refresh.png",
                    Name = "Atualizar"
                };

                refresh.SetBinding(ToolbarItem.CommandProperty, new Binding( "ReloadCommand" ) );

                ToolbarItems.Add(refresh);
                
            }

            BindingContext = new HomeViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}
