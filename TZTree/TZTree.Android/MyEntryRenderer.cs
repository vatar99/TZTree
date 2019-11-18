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
using TZTree;
using TZTree.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

#pragma warning disable CS0612 // Тип или член устарел
[assembly:ExportRenderer(typeof(MeEntry), typeof(MyEntryRenderer))]
#pragma warning restore CS0612 // Тип или член устарел

namespace TZTree.Droid
{
    [Obsolete] //устаревшая
    public class MyEntryRenderer:EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if(Control !=null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.White);
                Control.SetTextColor(global::Android.Graphics.Color.Black);
                Control.SetText("Для android", TextView.BufferType.Normal);
            }
        }
    }
}