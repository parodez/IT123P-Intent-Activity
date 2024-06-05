using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IT123P_Intent_Activity
{
    [Activity (Label = "Bermudez")]
    public class Bermudez:Activity 
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Set view from appropriate layout resource
            SetContentView(Resource.Layout.activityBermudez);
        }
    }
}