﻿using Maui.TikTok.Pages;

namespace Maui.TikTok
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HomePage();
        }
    }
}
