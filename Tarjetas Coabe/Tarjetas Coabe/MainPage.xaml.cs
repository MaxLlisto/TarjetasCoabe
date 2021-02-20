using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using ZXing;

namespace Tarjetas_Coabe
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            miEAN.IsVisible = false;
            lblCodigo.IsVisible = false;
        }

        private void BtnGenerar_Clicked(object sender, EventArgs e)
        {
            string _Codigo = "9724304068665";
            miEAN.BarcodeValue = _Codigo;
            lblCodigo.Text = _Codigo;
            miEAN.IsVisible = true;
            lblCodigo.IsVisible = true;
        }
    }
}
