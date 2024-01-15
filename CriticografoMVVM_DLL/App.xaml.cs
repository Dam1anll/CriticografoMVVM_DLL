using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CriticografoMVVM_DLL.Views;

namespace CriticografoMVVM_DLL
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
