using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace d24amCross.Controller
{
    public class ControlNavigationApp : NavigationPage
    {
        string color;

        public ControlNavigationApp( Page root, string color ) : base( root )
        {
            this.color = color;

            Init();
        }

        public ControlNavigationApp()
        {
            Init();
        }

        void Init()
        {
            BarBackgroundColor = Color.FromHex( this.color );
            BarTextColor = Color.White;
        }
    }
}
