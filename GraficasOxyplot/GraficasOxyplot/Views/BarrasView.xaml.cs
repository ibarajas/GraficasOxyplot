using Xamarin.Forms;
using GraficasOxyplot.ViewModels;

namespace GraficasOxyplot.Views
{
    public partial class BarrasView : ContentPage
    {
        public BarrasViewModel vm { get; set; }

        public BarrasView()
        {
            InitializeComponent();

            vm = new BarrasViewModel();
            BindingContext = vm;
        }
    }
}
