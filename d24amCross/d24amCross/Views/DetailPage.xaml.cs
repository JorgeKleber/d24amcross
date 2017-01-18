using d24amCross.Model;
using d24amCross.ViewModel;
using Plugin.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace d24amCross.Views
{
    public partial class DetailPage : ContentPage
    {
        ItemRss item;

        public DetailPage(ItemRss item)
        {
            InitializeComponent();

            this.item = item;

            BindingContext = new DetailViewModel(item);

        }

    }
}
