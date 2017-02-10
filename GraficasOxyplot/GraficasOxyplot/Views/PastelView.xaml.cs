using Xamarin.Forms;
using GraficasOxyplot.ViewModels;

namespace GraficasOxyplot.Views
{
    public partial class PastelView : ContentPage
    {
        public PastelViewModel vm { get; set; }

        public PastelView()
        {
            InitializeComponent();

            vm = new PastelViewModel();
            BindingContext = vm;
        }
    }
}
