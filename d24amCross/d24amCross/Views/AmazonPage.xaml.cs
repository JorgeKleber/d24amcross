using d24amCross.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace d24amCross.Views
{
    public partial class AmazonPage : ContentPage
    {
        public AmazonPage()
        {
            InitializeComponent();

            if ( Device.OS == TargetPlatform.Windows )
            {
                var refresh = new ToolbarItem()
                {
                    Icon = "ic_refresh.png",
                    Name = "Atualizar"
                };

                refresh.SetBinding( ToolbarItem.CommandProperty, new Binding( "ReloadCommand" ) );

                ToolbarItems.Add( refresh );

            }

            BindingContext = new AmazoniaViewModel();
        }
    }

}
