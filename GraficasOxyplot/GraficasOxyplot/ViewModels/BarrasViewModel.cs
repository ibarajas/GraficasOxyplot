using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace GraficasOxyplot.ViewModels
{
    public class BarrasViewModel
    {
        public PlotModel Modelo { get; set; }

        public BarrasViewModel()
        {
            BarSeries serie1 = new BarSeries() { Title = "Articuno", FillColor = OxyColors.LightBlue, StrokeThickness = 1 };
            BarSeries serie2 = new BarSeries() { Title = "Blastoise", FillColor = OxyColors.Navy, StrokeThickness = 1 };

            serie1.Items.Add(new BarItem { Value = 384 });
            serie1.Items.Add(new BarItem { Value = 295 });
            serie1.Items.Add(new BarItem { Value = 328 });
            serie1.Items.Add(new BarItem { Value = 317 });
            serie1.Items.Add(new BarItem { Value = 383 });
            serie1.Items.Add(new BarItem { Value = 295 });

            serie2.Items.Add(new BarItem { Value = 362 });
            serie2.Items.Add(new BarItem { Value = 291 });
            serie2.Items.Add(new BarItem { Value = 328 });
            serie2.Items.Add(new BarItem { Value = 295 });
            serie2.Items.Add(new BarItem { Value = 339 });
            serie2.Items.Add(new BarItem { Value = 280 });

            var ejeCategorias = new CategoryAxis { Position = CategoryAxisPosition() };
            ejeCategorias.Labels.Add("HP");
            ejeCategorias.Labels.Add("Attack");
            ejeCategorias.Labels.Add("Defense");
            ejeCategorias.Labels.Add("Sp. Atk");
            ejeCategorias.Labels.Add("Sp. Def");
            ejeCategorias.Labels.Add("Speed");

            Modelo = new PlotModel() {
                PlotMargins = new OxyThickness(50),
                LegendPlacement = LegendPlacement.Outside,
                LegendPosition = LegendPosition.BottomCenter,
                LegendOrientation = LegendOrientation.Horizontal
            };

            var ejeValores = new LinearAxis { Position = ValueAxisPosition() };
            Modelo.Axes.Add(ejeCategorias);
            Modelo.Axes.Add(ejeValores);

            Modelo.Series.Add(serie1);
            Modelo.Series.Add(serie2);
        }

        private AxisPosition CategoryAxisPosition()
        {
            if (typeof(BarSeries) == typeof(ColumnSeries))
            {
                return AxisPosition.Bottom;
            }

            return AxisPosition.Left;
        }

        private AxisPosition ValueAxisPosition()
        {
            if (typeof(BarSeries) == typeof(ColumnSeries))
            {
                return AxisPosition.Left;
            }

            return AxisPosition.Bottom;
        }
    }
}