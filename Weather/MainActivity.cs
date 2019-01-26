using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Weather.Core.Service;
using System;

namespace Weather
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button button;
        Button button2;
        TextView textView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

          

            button = FindViewById<Button>(Resource.Id.button1);
            button2 = FindViewById<Button>(Resource.Id.button2);

            textView = FindViewById<TextView>(Resource.Id.textView1);

            button.Click += GetWeather;

            button2.Click += GetForcastWeather;
        }

        private void GetForcastWeather(object sender, EventArgs e)
        {
            WeatherService weatherService = new WeatherService();
            var data = weatherService.GetForcasttWeather("");
            string s = "";
        }

        private void GetWeather(object sender, EventArgs e)
        {
            WeatherService weatherService = new WeatherService();
            var data = weatherService.GetCurrentWeather("");
            string s = "";
        }
    }
}