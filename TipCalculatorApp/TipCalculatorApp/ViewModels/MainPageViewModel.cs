using System;
using System.Collections.Generic;
using System.Text;
using TipCalculatorApp.Models;
using Xamarin.Forms;

namespace TipCalculatorApp.ViewModels
{
    public class MainPageViewModel
    {
        public TipModel TipModel { get; set; }
        public Command OperationsCommand { get; set; }

        public MainPageViewModel()
        {
            OperationsCommand = new Command(DoOperations);
            TipModel = new TipModel
            {
                Propina = 5,
                NoPersonas = 2
            };
        }

        private void DoOperations()
        {
            TipModel.TotalPropina = TipModel.Total * TipModel.Propina / 100;
            TipModel.TotalConPropina = TipModel.TotalPropina + TipModel.Total;
            TipModel.PropinaPorPersona = TipModel.TotalPropina / TipModel.NoPersonas;
            TipModel.TotalPorPersona = (TipModel.Total + TipModel.TotalPropina) / TipModel.NoPersonas;
        }
    }
}
