using OxyPlot;
using OxyPlot.Series;

namespace GraficasOxyplot.ViewModels
{
    public class PastelViewModel
    {
        public PlotModel Modelo { get; set; }

        public PastelViewModel()
        {
            PieSeries serie = new PieSeries();
            serie.Slices.Add(new PieSlice("Hielo", 40) { IsExploded = true, Fill = OxyColors.SkyBlue });
            serie.Slices.Add(new PieSlice("Fuego", 67) { IsExploded = false, Fill = OxyColors.Red });
            serie.Slices.Add(new PieSlice("Normal", 109) { IsExploded = false, Fill = OxyColors.LightGray });
            serie.Slices.Add(new PieSlice("Dragón", 48) { IsExploded = true, Fill = OxyColors.Orange });
            serie.Slices.Add(new PieSlice("Agua", 133) { IsExploded = true, Fill = OxyColors.Blue });
            serie.Slices.Add(new PieSlice("Eléctrico", 51) { IsExploded = false, Fill = OxyColors.Yellow });

            Modelo = new PlotModel() { PlotMargins = new OxyThickness(50) };
            Modelo.Series.Add(serie);
        }
    }
}
