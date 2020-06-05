using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Counter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CounterPage();
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
