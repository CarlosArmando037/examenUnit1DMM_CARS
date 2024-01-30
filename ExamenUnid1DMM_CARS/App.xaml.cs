using ExamenUnid1DMM_CARS.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenUnid1DMM_CARS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Calcular();
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
