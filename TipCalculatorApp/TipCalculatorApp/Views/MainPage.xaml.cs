using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipCalculatorApp.Models;
using TipCalculatorApp.ViewModels;
using Xamarin.Forms;

namespace TipCalculatorApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            //decimal total = decimal.Parse(txtTotal.Text);
            //int propina = int.Parse(txtPropina.Text);
            //int noPersonas = int.Parse(txtNoPersonas.Text);
            //decimal totalPropina = total * propina / 100;

            //// asigna valores con formato de moneda
            //lblPropina.Detail = totalPropina.ToString("C");
            //tipModel.TotalPropina = tipModel.Total * tipModel.Propina / 100;

            ////lblTotal.Detail = (totalPropina + total).ToString("C");
            //tipModel.TotalConPropina = tipModel.TotalPropina + tipModel.Total;

            ////lblPropinaPorPersona.Detail = (totalPropina / noPersonas).ToString("C");
            //tipModel.PropinaPorPersona = tipModel.TotalPropina / tipModel.NoPersonas;

            ////lblTotalPorPersona.Detail = ((total + totalPropina) / noPersonas).ToString("C");
            //tipModel.TotalPorPersona = (tipModel.Total + tipModel.TotalPropina) / tipModel.NoPersonas;
        }
    }
}
