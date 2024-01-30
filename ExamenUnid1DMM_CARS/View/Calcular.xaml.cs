using ExamenUnid1DMM_CARS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenUnid1DMM_CARS.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calcular : ContentPage
    {
        public Calcular()
        {
            InitializeComponent();
            BindingContext = new VMcalcular(Navigation);
        }
    }
}