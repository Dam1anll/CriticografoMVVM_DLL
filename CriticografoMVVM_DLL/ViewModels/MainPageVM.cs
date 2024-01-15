using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;
using CriticografoMVVM_DLL.ViewModels;
using System.Threading.Tasks;
using CriticografoMVVM_DLL.Views;
using System.Collections;
using System.Linq;

namespace CriticografoMVVM_DLL.ViewModels
{
    public class MainPageVM : BaseViewModel
    {
        #region VARIABLES
        private string _nombre;
        private bool _hombre;
        private bool _alto;
        private bool _listo;
        private bool _raro;
        private bool _feo;
        private bool _extravagante;
        private bool _grande;
        private string _datos;
        #endregion
        #region CONTRUCTOR
        public MainPageVM(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string Nombre 
        {
            get { return _nombre; }
            set { SetValue(ref _nombre, value);}
        }
        public bool Hombre
        {
            get { return _hombre; }
            set { SetValue(ref _hombre, value); }
        }
        public bool Alto 
        {
            get { return _alto;}
            set { SetValue(ref _alto, value);}
        }
        public bool Listo
        {
            get { return _listo; }
            set { SetValue(ref _listo, value); }
        }
        public bool Raro
        {
            get { return _raro; }
            set { SetValue(ref _raro, value); }
        }
        public bool Feo
        {
            get { return _feo; }
            set { SetValue(ref _feo, value); }
        }
        public bool Extravagante
        {
            get { return _extravagante; }
            set { SetValue(ref _extravagante, value); }
        }
        public bool Grande
        {
            get { return _grande; }
            set { SetValue(ref _grande, value); }
        }
        public string Datos
        {
            get { return _datos; }
            set { SetValue(ref _datos, value); }
        }
        #endregion
        #region PROCESOS
        public async Task Criticar() 
        {
            string nombre = Nombre;
            string alto = null;
            string listo = null;
            string raro = null;
            string feo = null;
            string extravagante = null;
            string grande = null;

            if (Alto)
                alto = Hombre ? "Alto" : "Alta";

            if (Listo)
                listo = Hombre ? "Listo" : "Lista";

            if (Raro)
                raro = Hombre ? "Raro" : "Rara";

            if (Feo)
                feo = Hombre ? "Feo" : "Fea";

            if (Extravagante)
                extravagante = Hombre ? "Extravagante" : "Extravagante";

            if (Grande)
                grande = Hombre ? "Grande" : "Grande";

            List<string> adjetivos = new List<string>
            {
                alto,
                listo,
                raro,
                feo,
                extravagante,
                grande
            }.Where(adj => adj != null).ToList();

            string datasos = $"{nombre} es: ";

            int adjetivosCant = adjetivos.Count;

            for (int x = 0; x < adjetivosCant; x++)
            {
                datasos += adjetivos[x];

                if (x < adjetivosCant - 2)
                {
                    datasos += ", ";
                }
                else if (x == adjetivosCant - 2)
                {
                    datasos += " y ";
                }
            }

            Datos = datasos;
            //await Application.Current.MainPage.DisplayAlert($"Datos de {nombre}", datasos, "OK");
        }
        #endregion
        #region COMANDOS
        public ICommand CriticarCommand => new Command(async () => await Criticar());
        #endregion
    }
}
