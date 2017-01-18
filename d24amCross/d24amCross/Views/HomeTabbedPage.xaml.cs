using d24amCross.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace d24amCross.Views
{
    public partial class HomeTabbedPage : TabbedPage
    {
        public HomeTabbedPage()
        {
            InitializeComponent();
            //BindingContext = new HomeTabbedViewModel(this);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //if ( BindingContext == null )
            //{
            //    BindingContext = new HomeTabbedViewModel( this ); 
            //}
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}
