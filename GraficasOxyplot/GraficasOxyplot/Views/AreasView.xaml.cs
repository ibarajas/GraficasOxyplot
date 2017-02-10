using Xamarin.Forms;
using GraficasOxyplot.ViewModels;

namespace GraficasOxyplot.Views
{
    public partial class AreasView : ContentPage
    {
        public AreasViewModel vm { get; set; }

        public AreasView()
        {
            InitializeComponent();

            vm = new AreasViewModel();
            BindingContext = vm;
        }
    }
}
