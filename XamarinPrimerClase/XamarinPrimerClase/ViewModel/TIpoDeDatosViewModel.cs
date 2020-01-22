using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinPrimerClase.Model;

namespace XamarinPrimerClase.ViewModel
{
   public class TIpoDeDatosViewModel
    {
        public TipoDeDatosModel MisDatos { get; set; }
        public Command HazClickCommand { get; set; }
        public Command haz { get; set; }
        public TIpoDeDatosViewModel()
        {
            MisDatos = new TipoDeDatosModel();
            HazClickCommand = new Command(MostrarInformacion);
            haz = new Command(mostrar);
            
        }


        private async void mostrar()
        {
            await App.Current.MainPage.DisplayAlert("TITULO", MisDatos.Nombre.ToUpper(), "OK");
            await App.Current.MainPage.DisplayAlert("TITULO", MisDatos.PeliculaFavorita.ToUpper(), "OK");
            await App.Current.MainPage.DisplayAlert("TITULO", MisDatos.AnnioNacimiento.ToString(), "OK");

            await App.Current.MainPage.DisplayAlert("TITULO", "MI NOMBRE ES:" + MisDatos.Nombre.ToUpper() + "\n" +
                                                    "MI pelicula es:" + MisDatos.PeliculaFavorita.ToUpper() + "\n" +
                                                    "MI año es:" + MisDatos.AnnioNacimiento.ToString(), "OK");
        }

        private async void MostrarInformacion()
        {
            await App.Current.MainPage.DisplayAlert("TITULO",MisDatos.Nombre,"OK");
            await App.Current.MainPage.DisplayAlert("TITULO", MisDatos.PeliculaFavorita, "OK");
            await App.Current.MainPage.DisplayAlert("TITULO", MisDatos.AnnioNacimiento.ToString(), "OK");

            await App.Current.MainPage.DisplayAlert("TITULO", "MI NOMBRE ES:"+ MisDatos.Nombre + "\n"+
                                                    "MI pelicula es:" + MisDatos.PeliculaFavorita + "\n"+
                                                    "MI año es:" + MisDatos.AnnioNacimiento.ToString(), "OK");

        }
    }
}
