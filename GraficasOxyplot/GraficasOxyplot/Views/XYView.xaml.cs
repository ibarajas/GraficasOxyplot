using Xamarin.Forms;
using GraficasOxyplot.ViewModels;

namespace GraficasOxyplot.Views
{
    public partial class XYView : ContentPage
    {
        public XYViewModel vm { get; set; }

        public XYView()
        {
            InitializeComponent();

            vm = new XYViewModel();
            BindingContext = vm;
        }
    }
}
