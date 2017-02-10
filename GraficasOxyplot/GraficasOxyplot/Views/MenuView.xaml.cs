using Xamarin.Forms;
using GraficasOxyplot.ViewModels;

namespace GraficasOxyplot.Views
{
    public partial class MenuView : ContentPage
    {
        public MenuViewModel vm { get; set; }

        public MenuView()
        {
            InitializeComponent();
            
            vm = new MenuViewModel(this.Navigation);
            BindingContext = vm;
        }
    }
}
