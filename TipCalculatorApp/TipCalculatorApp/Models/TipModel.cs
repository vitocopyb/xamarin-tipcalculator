using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace TipCalculatorApp.Models
{
    public class TipModel : INotifyPropertyChanged
    {
        private decimal totalPorPersona;
        private decimal propinaPorPersona;
        private decimal totalConPropina;
        private decimal totalPropina;
        private int propina;

        public Command OperationsCommand { get; set; }
        public decimal Total { get; set; }
        public int Propina
        {
            get => propina;
            set
            {
                propina = value;
                OnPropertyChanged();
            }
        }
        public int NoPersonas { get; set; }
        public decimal TotalPropina
        {
            get => totalPropina;
            set
            {
                totalPropina = value;
                OnPropertyChanged();
            }
        }
        public decimal TotalConPropina
        {
            get => totalConPropina;
            set
            {
                totalConPropina = value;
                OnPropertyChanged();
            }
        }
        public decimal PropinaPorPersona
        {
            get => propinaPorPersona;
            set
            {
                propinaPorPersona = value;
                OnPropertyChanged();
            }
        }
        public decimal TotalPorPersona
        {
            get => totalPorPersona;
            set
            {
                totalPorPersona = value;
                OnPropertyChanged();
            }
        }

        public TipModel()
        {
            OperationsCommand = new Command(DoOperations);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected virtual void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void DoOperations()
        {
            TotalPropina = Total * Propina / 100;
            TotalConPropina = TotalPropina + Total;
            PropinaPorPersona = TotalPropina / NoPersonas;
            TotalPorPersona = (Total + TotalPropina) / NoPersonas;
        }

    }
}
