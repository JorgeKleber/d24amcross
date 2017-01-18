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
        public ControlNavigationApp( Page root ) : base( root )
        {
            Init();
        }

        public ControlNavigationApp()
        {
            Init();
        }

        void Init()
        {
            BarBackgroundColor = Color.FromHex( "#0d0d0d" );
            //BarTextColor = Color.White;
        }
    }
}
