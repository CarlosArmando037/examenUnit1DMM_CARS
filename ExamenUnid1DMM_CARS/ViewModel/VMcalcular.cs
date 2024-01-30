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
        string _peso;
        string _altura;
        string _resultado;
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
        public string Peso
        {
            get { return _peso; }
            set { SetValue(ref _peso, value); }
        }
        public string Altura
        {
            get { return _altura; }
            set { SetValue(ref _altura, value); }
        }
        public string Resultado
        {
            get { return _resultado; }
            set { SetValue(ref _resultado, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void procesoSimple()
        {
            int altura1 = int.Parse(Altura);
            int peso1 = int.Parse(Peso);
            int respuesta = int.Parse(Resultado);
            respuesta = peso1 /(altura1 * altura1);
            Resultado = Convert.ToString(respuesta);
        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcomand => new Command(procesoSimple);
        #endregion
    }
}
