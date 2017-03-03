using d24amCross.Customs;
using d24amCross.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer( typeof( CustomLabel ), typeof( CustomLabelRenderer ) )]

namespace d24amCross.UWP
{
    public class CustomLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged( ElementChangedEventArgs<Label> e )
        {
            base.OnElementChanged( e );

            if ( Control != null )
            {
                Control.Text = RemoveHtmlTags(Control.Text);
            }

        }

        public string RemoveHtmlTags( string html )
        {
            return Regex.Replace( html, "<.+?>", string.Empty );

            //return Regex.Replace(html, "<[^>]+>", string.Empty);
        }
    }
}
