using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using Android.Content;
using System;

namespace IT123P_Intent_Activity
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btnActivityBermudez, btnActivityBorbe, btnActivityCaballero, btnActivityDano, btnActivityVillanueva;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            // Initialize layout resources
            btnActivityBermudez = FindViewById<Button>(Resource.Id.btnBermudez);
            btnActivityBorbe = FindViewById<Button>(Resource.Id.btnBorbe);
            btnActivityCaballero = FindViewById<Button>(Resource.Id.btnCaballero);
            btnActivityDano = FindViewById<Button>(Resource.Id.btnDano);
            btnActivityVillanueva = FindViewById<Button>(Resource.Id.btnVillanueva);

            // Set event handler
            btnActivityBermudez.Click += btnActivityBermudez_Click;
            btnActivityBorbe.Click += btnActivityBorbe_Click;
            btnActivityCaballero.Click += btnActivityCaballero_Click;
            btnActivityDano.Click += btnActivityDano_Click;
            btnActivityVillanueva.Click += btnActivityVillanueva_Click;
        }

        void btnActivityBermudez_Click (object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(Bermudez));
            StartActivity(i);
        }
        void btnActivityBorbe_Click(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(Borbe));
            StartActivity(i);
        }
        void btnActivityCaballero_Click(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(Caballero));
            StartActivity(i);
        }
        void btnActivityDano_Click(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(Dano));
            StartActivity(i);
        }
        void btnActivityVillanueva_Click(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(Villanueva));
            StartActivity(i);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}