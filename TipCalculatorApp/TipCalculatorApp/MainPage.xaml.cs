using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TipCalculatorApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            decimal total = decimal.Parse(txtTotal.Text);
            int propina = int.Parse(txtPropina.Text);
            int noPersonas = int.Parse(txtNoPersonas.Text);

            decimal totalPropina = total * propina / 100;

            // asigna valores con formato de moneda
            lblPropina.Detail = totalPropina.ToString("C");
            lblTotal.Detail = (totalPropina + total).ToString("C");
            lblPropinaPorPersona.Detail = (totalPropina / noPersonas).ToString("C");
            lblTotalPorPersona.Detail = ((total + totalPropina) / noPersonas).ToString("C");
        }
    }
}
