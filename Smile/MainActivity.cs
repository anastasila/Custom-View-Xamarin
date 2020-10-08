﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Views;

namespace Smile
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private EmotionalFaceView emotionalFaceView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);           

            View HappyButton = FindViewById(Resource.Id.happyButton);
            HappyButton.Click += delegate
            {
                             
                FindViewById<EmotionalFaceView>(Resource.Id.emotionalFaceView).HappinessState = StateButton.Happy;                
               
            };

            View SadButton = FindViewById(Resource.Id.sadButton);
            SadButton.Click += delegate
            {
                FindViewById<EmotionalFaceView>(Resource.Id.emotionalFaceView).HappinessState = StateButton.Sad;
            };

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}