using ForeignExchange.Models;
using ForeignExchange.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ForeignExchange.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Props
        string message;
        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }

        DialogService dialogService;

        decimal pesos;
        public decimal Pesos
        {
            get { return pesos; }
            set { SetProperty(ref pesos, value); }
        }

        public ObservableCollection<ForeignExchangeModel> Items { get; set; }
        
        decimal pounds;
        public decimal Pounds
        {
            get { return pounds; }
            set { SetProperty(ref pounds, value); }
        }

        decimal dollars;
        public decimal Dollars
        {
            get { return dollars; }
            set { SetProperty(ref dollars, value); }
        }

        decimal euros;
        public decimal Euros
        {
            get { return euros; }
            set { SetProperty(ref euros, value); }
        }
        #endregion

        #region Commands
        public ICommand ConvertCommand { get; private set; }
        #endregion

        public MainViewModel()
        {
            Message = "Welcome to Xamarin.Forms!";
            dialogService = new DialogService();
            ConvertCommand = new Command(async () => await ConvertMoney());
        }

        #region Methods
        private async Task ConvertMoney()
        {
            if (Pesos <= 0)
            {
                await dialogService.ShowMessage("Error", "Debe ingresar un valor en pesos mayor a cero (0)");
                return;
            }

            

            Dollars = XeConvertApi.Convert("COP", "USD", Pesos);
            Pounds = XeConvertApi.Convert("COP", "GBP", Pesos);
            Euros = XeConvertApi.Convert("COP", "EUR", Pesos);
        }
        #endregion
    }
}
