﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinLayout
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new XamarinLayout.MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
