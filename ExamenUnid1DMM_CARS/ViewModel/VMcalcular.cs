using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ExamenUnid1DMM_CARS.ViewModel
{
    public class VMcalcular : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        double _peso;
        double _altura;
        int _resultadoFCN;
        double _resultadoIMC;

        bool _IMC = false;
        bool _FCN = false;
        int _cardio;
        #endregion
        #region CONSTRUCTOR
        public VMcalcular(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        public bool FCN
        {
            get { return _FCN; }
            set { SetValue(ref _FCN, value); }
        }
        public bool IMC
        {
            get { return _IMC; }
            set { SetValue(ref _IMC, value); }
        }
        public double Peso
        {
            get { return _peso; }
            set { SetValue(ref _peso, value); }
        }
        public double Altura
        {
            get { return _altura; }
            set { SetValue(ref _altura, value); }
        }
        public int ResultadoFCN
        {
            get { return _resultadoFCN; }
            set { SetValue(ref _resultadoFCN, value); }
        }
        public double ResultadoIMC
        {
            get { return _resultadoIMC; }
            set { SetValue(ref _resultadoIMC, value); }
        }
        public int Cardio
        {
            get { return _cardio; }
            set { SetValue(ref _cardio, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void procesoIMC()
        {
            double altura1 = Altura;
            double peso1 = Peso;
            ResultadoIMC = peso1 / (altura1 * altura1);

        }
        public void procesoFCN()
        {
            int cardio = Cardio;
            ResultadoFCN = cardio*4;

        }

        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoIMCSimpcomand => new Command(procesoIMC);
        public ICommand ProcesoFCNSimpcomand => new Command(procesoFCN);


        #endregion
    }
}
