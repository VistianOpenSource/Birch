using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CodedUIExperiment.Services;
using CodedUIExperiment.Views;
using Xamarin.Forms.Internals;

namespace CodedUIExperiment
{
    [Preserve(AllMembers = true)]
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
