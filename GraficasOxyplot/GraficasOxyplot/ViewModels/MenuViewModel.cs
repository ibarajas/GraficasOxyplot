using System.Windows.Input;
using Xamarin.Forms;
using GraficasOxyplot.Views;

namespace GraficasOxyplot.ViewModels
{
    public class MenuViewModel
    {
        public ICommand PastelCommand { protected set; get; }
        public ICommand BarrasCommand { protected set; get; }
        public ICommand XYCommand { protected set; get; }
        public ICommand AreasCommand { protected set; get; }
        private INavigation _navigation;

        public MenuViewModel(INavigation navigation)
        {
            _navigation = navigation;

            PastelCommand = new Command(async() => {
                await _navigation.PushAsync(new PastelView());
            });

            BarrasCommand = new Command(async() => {
                await _navigation.PushAsync(new BarrasView());
            });

            XYCommand = new Command(async() => {
                await _navigation.PushAsync(new XYView());
            });

            AreasCommand = new Command(async() => {
                await _navigation.PushAsync(new AreasView());
            });
        }
    }
}
