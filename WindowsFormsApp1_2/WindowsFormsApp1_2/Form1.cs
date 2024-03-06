using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1_2
{
    public partial class Form1 : Form
    {
        private Chart chart;
        private TextBox[] pointTextBoxes;
        private TextBox[] pointMatrixTextBoxes;
        private TextBox[] lineTextBoxes;
        private TextBox[] lineMatrixTextBoxes;
        private TextBox[] triangle1TextBoxes;
        private TextBox[] triangle1MatrixTextBoxes;
        private TextBox[] triangle2TextBoxes;
        private TextBox[] triangle2MatrixTextBoxes;
        private TextBox[] translationTextBoxes;

        public Form1()
        {
            InitializeComponentForm();
            InitializeTextBoxes();
            InitializeChart();
        }

        private void InitializeComponentForm()
        {
            this.Text = "Лабораторна №1, Трачук Тетяна";
            this.Size = new Size(1200, 600);
        }

        private void InitializeChart()
        {
            chart = new Chart();
            chart.Parent = this;
            chart.Location = new System.Drawing.Point(0, 0);
            chart.Size = new Size(600, 600);
            chart.ChartAreas.Add(new ChartArea("MainArea"));

            chart.Series.Clear();

            Series pointSeries = new Series();
            pointSeries.ChartType = SeriesChartType.Point;
            pointSeries.Name = "Points";
            pointSeries.Color = Color.Red;

            pointSeries.Points.AddXY(0, 0);


            Series linesSeries = new Series
            {
                ChartType = SeriesChartType.Line,
                Name = "Lines",
                Color = Color.Green
            };


            Series transflinestSeries = new Series
            {
                ChartType = SeriesChartType.Line,
                Name = "TransfLine",
                Color = Color.DarkOliveGreen
            };

            Series triangleSeries = new Series
            {
                ChartType = SeriesChartType.Line,
                Name = "Triangles",
                Color = Color.Blue
            };

            Series triangle2Series = new Series
            {
                ChartType = SeriesChartType.Line,
                Name = "Triangles2",
                Color = Color.Black
            };

            Series transtriangleSeries = new Series
            {
                ChartType = SeriesChartType.Line,
                Name = "TransfTriangles",
                Color = Color.DeepPink
            };

            Series transf2triangleSeries = new Series
            {
                ChartType = SeriesChartType.Line,
                Name = "TransfTriangles2",
                Color = Color.Brown
            };


            chart.Series.Add(pointSeries);
            chart.Series.Add(linesSeries);
            chart.Series.Add(triangleSeries);
            chart.Series.Add(triangle2Series);
            chart.Series.Add(transflinestSeries);
            chart.Series.Add(transtriangleSeries);
            chart.Series.Add(transf2triangleSeries);

            Axis axisX = chart.ChartAreas["MainArea"].AxisX;
            Axis axisY = chart.ChartAreas["MainArea"].AxisY;

            axisX.MajorGrid.LineWidth = 1;
            axisX.MinorGrid.LineWidth = 1;
            axisX.Title = "X-axis";
            axisX.Minimum = -10;
            axisX.Maximum = 10;

            axisY.MajorGrid.LineWidth = 1;
            axisY.MinorGrid.LineWidth = 1;
            axisY.Title = "Y-axis";
            axisY.Minimum = -10;
            axisY.Maximum = 10;

            axisX.Enabled = AxisEnabled.True;
            axisY.Enabled = AxisEnabled.True;
        }


        private void InitializeTextBoxes()
        {
           
            pointTextBoxes = new TextBox[2];
            pointTextBoxes[0] = CreateTextBox(630, 70, 50, 25);
            pointTextBoxes[1] = CreateTextBox(700, 70, 50, 25);

            Label labelPointA = CreateLabel(760, 70, "Point A");

            foreach (TextBox textBox in pointTextBoxes)
            {
                textBox.TextChanged += TextBox_TextChanged;
            }

            pointMatrixTextBoxes = new TextBox[4];
            pointMatrixTextBoxes[0] = CreateTextBox(630, 110, 50, 25);
            pointMatrixTextBoxes[1] = CreateTextBox(700, 110, 50, 25);
            pointMatrixTextBoxes[2] = CreateTextBox(630, 150, 50, 25);
            pointMatrixTextBoxes[3] = CreateTextBox(700, 150, 50, 25);

            Label labelPointMatrix = CreateLabel(760, 110, "Point Matrix");

            foreach (TextBox textBox in pointMatrixTextBoxes)
            {
                textBox.TextChanged += TextBox_TextChanged;
            }

            triangle1TextBoxes = new TextBox[6];
            triangle1TextBoxes[0] = CreateTextBox(940, 70, 50, 25);
            triangle1TextBoxes[1] = CreateTextBox(1005, 70, 50, 25);
            triangle1TextBoxes[2] = CreateTextBox(940, 110, 50, 25);
            triangle1TextBoxes[3] = CreateTextBox(1005, 110, 50, 25);
            triangle1TextBoxes[4] = CreateTextBox(940, 150, 50, 25);
            triangle1TextBoxes[5] = CreateTextBox(1005, 150, 50, 25);

            Label labelTriangle1 = CreateLabel(1065, 70, "Triangle BCD");

            foreach (TextBox textBox in triangle1TextBoxes)
            {
                textBox.TextChanged += TextBox_TextChanged;
            }

            triangle1MatrixTextBoxes = new TextBox[4];
            triangle1MatrixTextBoxes[0] = CreateTextBox(940, 200, 50, 25);
            triangle1MatrixTextBoxes[1] = CreateTextBox(1005, 200, 50, 25);
            triangle1MatrixTextBoxes[2] = CreateTextBox(940, 240, 50, 25);
            triangle1MatrixTextBoxes[3] = CreateTextBox(1005, 240, 50, 25);

            Label labelTriangle1Matrix = CreateLabel(1065, 200, "Triangle Matrix");

            foreach (TextBox textBox in triangle1MatrixTextBoxes)
            {
                textBox.TextChanged += TextBox_TextChanged;
            }

            lineTextBoxes = new TextBox[4];
            lineTextBoxes[0] = CreateTextBox(630, 340, 50, 25);
            lineTextBoxes[1] = CreateTextBox(700, 340, 50, 25);
            lineTextBoxes[2] = CreateTextBox(630, 380, 50, 25);
            lineTextBoxes[3] = CreateTextBox(700, 380, 50, 25);

            Label labelLineBC = CreateLabel(760, 340, "Line EF");

            foreach (TextBox textBox in lineTextBoxes)
            {
                textBox.TextChanged += TextBox_TextChanged;
            }

            lineMatrixTextBoxes = new TextBox[4];
            lineMatrixTextBoxes[0] = CreateTextBox(630, 440, 50, 25);
            lineMatrixTextBoxes[1] = CreateTextBox(700, 440, 50, 25);
            lineMatrixTextBoxes[2] = CreateTextBox(630, 470, 50, 25);
            lineMatrixTextBoxes[3] = CreateTextBox(700, 470, 50, 25);

            Label labelLineMatrix = CreateLabel(760, 440, "Line Matrix");

            foreach (TextBox textBox in lineMatrixTextBoxes)
            {
                textBox.TextChanged += TextBox_TextChanged;
            }

            triangle2TextBoxes = new TextBox[6];
            triangle2TextBoxes[0] = CreateTextBox(940, 340, 50, 25);
            triangle2TextBoxes[1] = CreateTextBox(1005, 340, 50, 25);
            triangle2TextBoxes[2] = CreateTextBox(940, 380, 50, 25);
            triangle2TextBoxes[3] = CreateTextBox(1005, 380, 50, 25);
            triangle2TextBoxes[4] = CreateTextBox(940, 420, 50, 25);
            triangle2TextBoxes[5] = CreateTextBox(1005, 420, 50, 25);

            Label labelTriangle2 = CreateLabel(1065, 340, "Triangle KLM");

            foreach (TextBox textBox in triangle2TextBoxes)
            {
                textBox.TextChanged += TextBox_TextChanged;
            }

            translationTextBoxes = new TextBox[2];
            translationTextBoxes[0] = CreateTextBox(940, 470, 50, 25);
            translationTextBoxes[1] = CreateTextBox(1005, 470, 50, 25);

            Label labelTranslationVector = CreateLabel(1065, 480, "Translation Vector");

            foreach (TextBox textBox in translationTextBoxes)
            {
                textBox.TextChanged += TextBox_TextChanged;
            }
        }


        private Label CreateLabel(int x, int y, string text)
        {
            Label label = new Label();
            label.Location = new System.Drawing.Point(x, y);
            label.Text = text;
            this.Controls.Add(label);
            return label;
        }

        private TextBox CreateTextBox(int x, int y, int width, int height)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(x, y);
            textBox.Size = new Size(width, height);
            this.Controls.Add(textBox);
            return textBox;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }

        private void UpdateChart()
        {
            chart.Series["Points"].Points.Clear();
            chart.Series["Lines"].Points.Clear();
            chart.Series["Triangles"].Points.Clear();
            chart.Series["Triangles2"].Points.Clear();
            

            if (TryParsePoint(pointTextBoxes, out Point pointA))
            {
                DrawPoint(chart.Series["Points"], pointA, "A");
                if (PointMatrixIsValid(GetPointMatrix()))
                {
                    Point transformedPointA = TransformPoint(pointA, GetPointMatrix());
                    DrawPoint(chart.Series["Points"], transformedPointA, "A*");
                }
            }

            if (TryParseLine(lineTextBoxes, out Line lineBC))
            {
                DrawLine(chart.Series["Lines"], lineBC, new[] { "E", "F" });
                if (LineMatrixIsValid(GetLineMatrix()))
                {
                    chart.Series["TransfLine"].Points.Clear();
                    Line transformedLineBC = TransformLine(lineBC, GetLineMatrix());
                    DrawLine(chart.Series["TransfLine"], transformedLineBC, new[] { "E*", "F*" });
                }
            }

            if (TryParseTriangle(triangle1TextBoxes, out Triangle triangleDEF))
            {
                DrawTriangle(chart.Series["Triangles"], triangleDEF, new[] { "B", "C", "D" });
                if (Triangle1MatrixIsValid(GetTriangle1Matrix()))
                {
                    chart.Series["TransfTriangles"].Points.Clear();
                    Triangle transformedTriangleDEF = TransformTriangle(triangleDEF, GetTriangle1Matrix());
                    DrawTriangle(chart.Series["TransfTriangles"], transformedTriangleDEF, new[] { "B*", "C*", "D*" });
                }
            }

            if (TryParseTriangle(triangle2TextBoxes, out Triangle triangleGHI))
            {
                DrawTriangle(chart.Series["Triangles2"], triangleGHI, new[] { "K", "L", "M" });
                if (TryParseTranslationVector(translationTextBoxes, out double[] translationVector))
                {
                    chart.Series["TransfTriangles2"].Points.Clear();
                    Triangle transformedTriangleGHI = TranslateTriangle(triangleGHI, translationVector);
                    DrawTriangle(chart.Series["TransfTriangles2"], transformedTriangleGHI, new[] { "K*", "L*", "M*" });
                }
            }
            chart.ChartAreas["MainArea"].RecalculateAxesScale();
            //AdjustYAxisScale();
        }

        //private void AdjustYAxisScale()
        //{
        //    int blockSize = 100;

        //    // generates random data (i.e. 30 * blockSize random numbers)
        //    Random rand = new Random();
        //    var valuesArray = Enumerable.Range(0, blockSize * 30).Select(x => rand.Next(1, 10)).ToArray();

        //    var chartArea = chart.ChartAreas["MainArea"];
        //    chartArea.AxisX.Minimum = -100;
        //    chartArea.AxisX.Maximum = valuesArray.Length;

        //    // enable autoscroll
        //    chartArea.CursorX.AutoScroll = true;

        //    // let's zoom to [0,blockSize] (e.g. [0,100])
        //    chartArea.AxisX.ScaleView.Zoomable = true;
        //    chartArea.AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
        //    int position = 0;
        //    int size = blockSize;
        //    chartArea.AxisX.ScaleView.Zoom(position, size);

        //    // disable zoom-reset button (only scrollbar's arrows are available)
        //    chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;

        //    // set scrollbar small change to blockSize (e.g. 100)
        //    chartArea.AxisX.ScaleView.SmallScrollSize = blockSize;
        //}

        private bool TryParseTranslationVector(TextBox[] textBoxes, out double[] translationVector)
        {
            translationVector = new double[2];
            if (textBoxes.Length >= 2 &&
                double.TryParse(textBoxes[0].Text, out translationVector[0]) &&
                double.TryParse(textBoxes[1].Text, out translationVector[1]))
            {
                return true;
            }

            translationVector = null;
            return false;
        }

        private void DrawPoint(Series series, Point point, string label)
        {
            series.Points.AddXY(point.X, point.Y);
            series.Points[series.Points.Count - 1].Label = label;
            series.Points[series.Points.Count - 1].MarkerStyle = MarkerStyle.Circle;
            series.Points[series.Points.Count - 1].MarkerSize = 10;
        }

        private void DrawLine(Series series, Line line, string[] labels)
        {
            series.Points.AddXY(line.P1.X, line.P1.Y);
            series.Points.AddXY(line.P2.X, line.P2.Y);
            series.Points[series.Points.Count - 2].Label = labels[0];
            series.Points[series.Points.Count - 1].Label = labels[1];
           
        }

        private void DrawTriangle(Series series, Triangle triangle, string[] labels)
        {
            series.Points.AddXY(triangle.P1.X, triangle.P1.Y);
            series.Points.AddXY(triangle.P2.X, triangle.P2.Y);
            series.Points.AddXY(triangle.P3.X, triangle.P3.Y);
            series.Points.AddXY(triangle.P1.X, triangle.P1.Y);
            series.Points[series.Points.Count - 4].Label = labels[0];
            series.Points[series.Points.Count - 3].Label = labels[1];
            series.Points[series.Points.Count - 2].Label = labels[2];
        }

        private bool PointMatrixIsValid(double[] matrix)
        {
            double determinant = matrix[0] * matrix[3] - matrix[1] * matrix[2];
            return Math.Abs(determinant) > 1e-10; // Assuming a small value for floating-point error
        }

        private bool LineMatrixIsValid(double[] matrix)
        {
            double determinant = matrix[0] * matrix[3] - matrix[1] * matrix[2];
            return Math.Abs(determinant) > 1e-10; // Assuming a small value for floating-point error
        }

        private bool Triangle1MatrixIsValid(double[] matrix)
        {
            double determinant = matrix[0] * matrix[3] - matrix[1] * matrix[2];
            return Math.Abs(determinant) > 1e-10; // Assuming a small value for floating-point error
        }

        private bool Triangle2MatrixIsValid(double[] matrix)
        {
            double determinant = matrix[0] * matrix[3] - matrix[1] * matrix[2];
            return Math.Abs(determinant) > 1e-10; // Assuming a small value for floating-point error
        }

        private bool TryParsePoint(TextBox[] textBoxes, out Point point)
        {
            point = null;
            if (textBoxes.Length != 2 || !double.TryParse(textBoxes[0].Text, out double x) || !double.TryParse(textBoxes[1].Text, out double y))
            {
                return false;
            }

            point = new Point(x, y);
            return true;
        }

        private bool TryParseLine(TextBox[] textBoxes, out Line line)
        {
            line = null;
            if (textBoxes.Length != 4)
            {
                return false;
            }

            if (!TryParsePoint(textBoxes.Take(2).ToArray(), out Point p1) || !TryParsePoint(textBoxes.Skip(2).ToArray(), out Point p2))
            {
                return false;
            }

            line = new Line(p1, p2);
            return true;
        }

        private bool TryParseTriangle(TextBox[] textBoxes, out Triangle triangle)
        {
            triangle = null;
            if (textBoxes.Length != 6)
            {
                return false;
            }

            if (!TryParsePoint(textBoxes.Take(2).ToArray(), out Point p1) ||
                !TryParsePoint(textBoxes.Skip(2).Take(2).ToArray(), out Point p2) ||
                !TryParsePoint(textBoxes.Skip(4).ToArray(), out Point p3))
            {
                return false;
            }

            triangle = new Triangle(p1, p2, p3);
            return true;
        }

        private double[] GetPointMatrix()
        {
            double[] matrix = new double[4];
            if (!double.TryParse(pointMatrixTextBoxes[0].Text, out matrix[0]) ||
                !double.TryParse(pointMatrixTextBoxes[1].Text, out matrix[1]) ||
                !double.TryParse(pointMatrixTextBoxes[2].Text, out matrix[2]) ||
                !double.TryParse(pointMatrixTextBoxes[3].Text, out matrix[3]))
            {
                return new double[] { 1, 0, 0, 1 }; 
            }

            return matrix;
        }


        private double[] GetLineMatrix()
        {
            double[] matrix = new double[4];
            if (!double.TryParse(lineMatrixTextBoxes[0].Text, out matrix[0]) ||
                !double.TryParse(lineMatrixTextBoxes[1].Text, out matrix[1]) ||
                !double.TryParse(lineMatrixTextBoxes[2].Text, out matrix[2]) ||
                !double.TryParse(lineMatrixTextBoxes[3].Text, out matrix[3]))
            {
                return new double[] { 1, 0, 0, 1 }; 
            }

            return matrix;
        }

        private double[] GetTriangle1Matrix()
        {
            double[] matrix = new double[4];
            if (!double.TryParse(triangle1MatrixTextBoxes[0].Text, out matrix[0]) ||
                !double.TryParse(triangle1MatrixTextBoxes[1].Text, out matrix[1]) ||
                !double.TryParse(triangle1MatrixTextBoxes[2].Text, out matrix[2]) ||
                !double.TryParse(triangle1MatrixTextBoxes[3].Text, out matrix[3]))
            {
                return new double[] { 1, 0, 0, 1 }; 
            }

            return matrix;
        }

        private double[] GetTriangle2Matrix()
        {
            double[] matrix = new double[4];
            if (!double.TryParse(triangle2MatrixTextBoxes[0].Text, out matrix[0]) ||
                !double.TryParse(triangle2MatrixTextBoxes[1].Text, out matrix[1]) ||
                !double.TryParse(triangle2MatrixTextBoxes[2].Text, out matrix[2]) ||
                !double.TryParse(triangle2MatrixTextBoxes[3].Text, out matrix[3]))
            {
                return new double[] { 1, 0, 0, 1 }; 
            }

            return matrix;
        }

        private Point TransformPoint(Point point, double[] matrix)
        {
            double x = point.X * matrix[0] + point.Y * matrix[2];
            double y = point.X * matrix[1] + point.Y * matrix[3];
            return new Point(x, y);
        }

        private Line TransformLine(Line line, double[] matrix)
        {
            Point p1 = TransformPoint(line.P1, matrix);
            Point p2 = TransformPoint(line.P2, matrix);
            return new Line(p1, p2);
        }

        private Triangle TransformTriangle(Triangle triangle, double[] matrix)
        {
            Point p1 = TransformPoint(triangle.P1, matrix);
            Point p2 = TransformPoint(triangle.P2, matrix);
            Point p3 = TransformPoint(triangle.P3, matrix);
            return new Triangle(p1, p2, p3);
        }

        private Triangle TranslateTriangle(Triangle triangle, double[] vector)
        {
            Point p1 = new Point(triangle.P1.X + vector[0], triangle.P1.Y + vector[1]);
            Point p2 = new Point(triangle.P2.X + vector[0], triangle.P2.Y + vector[1]);
            Point p3 = new Point(triangle.P3.X + vector[0], triangle.P3.Y + vector[1]);
            return new Triangle(p1, p2, p3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
