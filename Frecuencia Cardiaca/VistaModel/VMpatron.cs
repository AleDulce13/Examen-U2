using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Frecuencia_Cardiaca.VistaModel
{
    public class VMpatron : BaseViewModel
    {
        #region VARIABLES
        private int _latidos;
        private int _frecuencia;
        private string _estado;
        #endregion

        #region CONSTRUCTOR
        public VMpatron(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region PROPIEDADES
        public int Latidos
        {
            get { return _latidos; }
            set { SetValue(ref _latidos, value); }
        }

        public int Frecuencia
        {
            get { return _frecuencia; }
            set { SetValue(ref _frecuencia, value); }
        }

        public string Estado
        {
            get { return _estado; }
            set { SetValue(ref _estado, value); }
        }
        #endregion

        #region MÉTODOS
        public void Calcular()
        {
            Frecuencia = Latidos * 4;

            if (Frecuencia < 60)
                Estado = "Frecuencia cardiaca baja";
            else if (Frecuencia > 100)
                Estado = "Frecuencia cardiaca alta";
            else
                Estado = "Frecuencia cardiaca normal";
        }
        #endregion

        #region COMANDOS
        public ICommand CalcularCommand => new Command(Calcular);
        #endregion

    }
}
