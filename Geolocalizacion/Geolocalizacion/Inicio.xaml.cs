using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Geolocator;
using Xamarin.Forms;

namespace Geolocalizacion
{
    public partial class Inicio : ContentPage
    {

        public Inicio()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var loc = CrossGeolocator.Current; //referencia actual del geolocalizador para la plataforma
            var pos = await loc.GetPositionAsync(10000);
            if (pos == null)
            {
                await DisplayAlert("Error", "No recibo la posicion", "ok");
                return;
            }


            TxtLat.Text = pos.Latitude.ToString();
            TxtLon.Text = pos.Longitude.ToString();
        }
    }
}
