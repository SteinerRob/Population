using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace Population
{
    public class DrawingManager
    {

        public static void DrawGraph(Chart chart1, FilterDocument document, int gender)
        {
            var chart = chart1.ChartAreas[0];

            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = document.FilteredList.Count;
            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = MaxY(document.FilteredList);
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 50;
            if (chart1.Series == null)
            {
                chart1.Series.Add("Population");
                chart1.Series["Population"].ChartType = SeriesChartType.Line;
                if (gender == 0)
                {
                    chart1.Series["Population"].Color = Color.Blue;
                }
                else
                    chart1.Series["Population"].Color = Color.Red;
                chart1.Series[0].IsVisibleInLegend = false;

                foreach (var day in document.FilteredList)
                {
                    chart1.Series["Population"].Points.AddY(day.Value);
                }
            }
            else
            {
                chart1.Series.Clear();
                chart1.Series.Add("Population");
                chart1.Series["Population"].ChartType = SeriesChartType.Line;
                if (gender == 0)

                    chart1.Series["Population"].Color = Color.Blue;
                else
                    chart1.Series["Population"].Color = Color.Red;
                chart1.Series[0].IsVisibleInLegend = false;

                foreach (var day in document.FilteredList)
                {
                    chart1.Series["Population"].Points.AddY(day.Value);
                }
            }


        }
        
        private static int MaxY(List<Day> days)
        {
            int maxY = 0;

            foreach (var day in days)
            {
                if (maxY < day.Value)
                    maxY = day.Value;
            }
            return maxY;
        }
    }
}
