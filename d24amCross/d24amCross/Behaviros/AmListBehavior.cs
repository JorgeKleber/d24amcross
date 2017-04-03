using d24amCross.Controller;
using d24amCross.Model;
using d24amCross.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace d24amCross.Behaviros
{
    public class AmListBehavior : Behavior<ListView>
    {
        ListView Lista;
        protected override void OnAttachedTo( ListView bindable )
        {
            base.OnAttachedTo( bindable );
            Lista = bindable;
            Lista.ItemTapped += Bindable_ItemTapped;
            Lista.Refreshing += Bindable_Refreshing;
        }

        private async void Bindable_Refreshing( object sender, EventArgs e )
        {
            Lista.IsRefreshing = true;

            Controle controle = new Controle();

            var item = await controle.BaixarFeed( "http://new.d24am.com/rss?section=6" );

            Lista.ItemsSource = item;

            Lista.IsRefreshing = false;
        }

        private async void Bindable_ItemTapped( object sender, ItemTappedEventArgs e )
        {
            var item = e.Item as ItemRss;

            await ( App.Current.MainPage as MasterDetailPage ).Detail.Navigation.PushAsync( new DetailPage( item ), true );

        }

        protected override void OnDetachingFrom( ListView bindable )
        {
            base.OnDetachingFrom( bindable );
        }
    }
}
