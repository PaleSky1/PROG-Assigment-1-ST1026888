using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace prjSaneleAppWPF
{
    public partial class PieChartWindow : Window
    {
        public PieChartWindow(Dictionary<string, double> foodGroupPercentages)
        {
            InitializeComponent();
            DrawPieChart(foodGroupPercentages);
        }

        private void DrawPieChart(Dictionary<string, double> foodGroupPercentages)
        {
            double total = foodGroupPercentages.Values.Sum();

            double angle = 0;
            Random rand = new Random();
            foreach (var kvp in foodGroupPercentages)
            {
                double sliceAngle = kvp.Value / total * 360;
                Brush sliceBrush = new SolidColorBrush(Color.FromRgb((byte)rand.Next(256), (byte)rand.Next(256), (byte)rand.Next(256)));

                DrawPieSlice(PieChartCanvas, 200, 200, 100, angle, angle + sliceAngle, sliceBrush);
                AddLegendItem(kvp.Key, sliceBrush);

                angle += sliceAngle;
            }
        }

        private void DrawPieSlice(Canvas canvas, double centerX, double centerY, double radius, double startAngle, double endAngle, Brush fillBrush)
        {
            double startRadians = startAngle * (Math.PI / 180);
            double endRadians = endAngle * (Math.PI / 180);

            Point startPoint = new Point(
                centerX + radius * Math.Cos(startRadians),
                centerY + radius * Math.Sin(startRadians));

            Point endPoint = new Point(
                centerX + radius * Math.Cos(endRadians),
                centerY + radius * Math.Sin(endRadians));

            PathFigure pathFigure = new PathFigure();
            pathFigure.StartPoint = new Point(centerX, centerY);
            pathFigure.Segments.Add(new LineSegment(startPoint, true));
            pathFigure.Segments.Add(new ArcSegment(endPoint, new Size(radius, radius), 0, endAngle - startAngle > 180, SweepDirection.Clockwise, true));
            pathFigure.Segments.Add(new LineSegment(new Point(centerX, centerY), true));

            PathGeometry pathGeometry = new PathGeometry();
            pathGeometry.Figures.Add(pathFigure);

            Path path = new Path();
            path.Fill = fillBrush;
            path.Data = pathGeometry;

            canvas.Children.Add(path);
        }

        private void AddLegendItem(string foodGroup, Brush brush)
        {
            StackPanel legendItem = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(5) };

            Rectangle colorBox = new Rectangle
            {
                Width = 16,
                Height = 16,
                Fill = brush,
                Margin = new Thickness(0, 0, 5, 0)
            };

            TextBlock text = new TextBlock
            {
                Text = foodGroup,
                VerticalAlignment = VerticalAlignment.Center
            };

            legendItem.Children.Add(colorBox);
            legendItem.Children.Add(text);

            LegendPanel.Children.Add(legendItem);
        }
    }
}

