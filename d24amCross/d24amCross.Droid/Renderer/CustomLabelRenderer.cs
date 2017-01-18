using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Text;
using d24amCross.Customs;
using d24amCross.Droid.Renderer;

[assembly: ExportRenderer( typeof( CustomLabel ), typeof( CustomLabelRenderer ) )]

namespace d24amCross.Droid.Renderer
{
    public class CustomLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged( ElementChangedEventArgs<Label> e )
        {
            base.OnElementChanged( e );

            if ( Control != null )
            {
                Control.TextFormatted = Html.FromHtml( Control.Text );
            }
        }
    }
}