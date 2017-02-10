using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.Collections.Generic;

namespace GraficasOxyplot.ViewModels
{
    public class XYViewModel
    {
        public PlotModel Modelo { get; set; }

        public XYViewModel()
        {
            LineSeries serie = new LineSeries();

            List<DataPoint> puntos = new List<DataPoint>
            {
                new DataPoint(1, 6),
                new DataPoint(2, 10),
                new DataPoint(3, 14),
                new DataPoint(4, 17),
                new DataPoint(5, 21),
                new DataPoint(6, 25),
                new DataPoint(7, 26),
                new DataPoint(8, 26),
                new DataPoint(9, 26),
                new DataPoint(10, 25),
                new DataPoint(11, 24),
                new DataPoint(12, 23),
                new DataPoint(13, 22),
                new DataPoint(14, 21)
            };

            serie.ItemsSource = puntos;

            Modelo = new PlotModel() { PlotMargins = new OxyThickness(50) };
            Modelo.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Title = "Día" });
            Modelo.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Title = "Usuarios (millones)" });
            Modelo.PlotType = PlotType.XY;
            Modelo.Series.Add(serie);
        }
    }
}
