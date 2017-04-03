using d24amCross.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace d24amCross
{
    public partial class AmazoniaPage : ContentPage
    {
        public AmazoniaPage()
        {
            InitializeComponent();

            this.BindingContext = new AmazoniaViewModel();
        }
    }
}
