using OxyPlot;
using OxyPlot.Series;
using System.Collections.Generic;

namespace GraficasOxyplot.ViewModels
{
    public class AreasViewModel
    {
        public PlotModel Modelo { get; set; }

        public AreasViewModel()
        {
            AreaSeries serie1 = new AreaSeries();
            AreaSeries serie2 = new AreaSeries();

            List<DataPoint> puntos1 = new List<DataPoint>
            {
                new DataPoint(-4, 0),
                new DataPoint(-3, 2.64),
                new DataPoint(-2, 3.46),
                new DataPoint(-1, 3.87),
                new DataPoint(0, 4),
                new DataPoint(1, 3.87),
                new DataPoint(2, 3.46),
                new DataPoint(3, 2.64),
                new DataPoint(4, 0)
            };

            List<DataPoint> puntos2 = new List<DataPoint>
            {
                new DataPoint(0, -3),
                new DataPoint(1.491, -2),
                new DataPoint(1.886, -1),
                new DataPoint(2, 0),
                new DataPoint(1.886, 1),
                new DataPoint(1.491, 2),
                new DataPoint(0, 3),
            };

            serie1.ItemsSource = puntos1;
            serie2.ItemsSource = puntos2;

            serie1.Color = OxyColors.GreenYellow;
            serie2.Color = OxyColors.Navy;

            Modelo = new PlotModel() { PlotMargins = new OxyThickness(50) };
            Modelo.Series.Add(serie1);
            Modelo.Series.Add(serie2);
        }
    }
}
