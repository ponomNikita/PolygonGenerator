using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PolygonGenerator
{
    public partial class Main : Form
    {
        private PictureBox _canvas;
        private const int CANVAS_SIZE = 10000;
        
        private readonly List<Point> _points = new List<Point>();
        private List<Polygon> _polygons = new List<Polygon>();
        private string _fileName;

        public Main()
        {
            InitializeComponent();
        }
        private void Initialize()
        {
            WindowState = FormWindowState.Maximized;

            Container.AutoScroll = true;

            _canvas = new PictureBox();
            _canvas.Width = CANVAS_SIZE;
            _canvas.Height = CANVAS_SIZE;
            _canvas.MouseClick += OnCanvasMouseClick;
            _canvas.Paint += OnCanvasPaint;

            Container.Controls.Add(_canvas);
        }

        private void OnCanvasPaint(object sender, PaintEventArgs e)
        {
            var pen = new Pen(Color.AliceBlue);
            for (var i = 0; i < CANVAS_SIZE; i += 15)
            {
                e.Graphics.DrawLine(pen, new Point(0, i), new Point(CANVAS_SIZE, i));
                e.Graphics.DrawLine(pen, new Point(i, 0), new Point(i, CANVAS_SIZE));
            }

            pen.Color = Color.Black;

            if (_points.Count > 1)
            {
                e.Graphics.DrawLines(pen, _points.ToArray());
            }

            foreach (var polygon in _polygons)
            {
                pen.Width = 3;
                e.Graphics.DrawPolygon(pen, polygon.Points.ToArray());
            }

            pen.Color = Color.Red;
            _points.ForEach(p => e.Graphics.FillEllipse(pen.Brush, p.X, p.Y, 3, 3));
        }

        private void OnCanvasMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                OnRightMouseClick(sender, e);
                return;
            }

            var location = e.Location;
            Coords.Text = $"X:{location.X} Y:{location.Y}";
            
            _points.Add(location);

            if (_points.Count > 1)
            {
                if (DistanceSqr(location, _points.First()) < 36)
                {
                    _points.Remove(location);

                    _polygons.Add(new Polygon(_points.ToArray()));

                    PolygonsCount.Text = $"Polygons: {_polygons.Count}";
                    
                    _points.Clear();

                    _canvas.Invalidate();
                }
            }

            _canvas.Invalidate();
        }

        private void OnRightMouseClick(object sender, MouseEventArgs e)
        {
            Undo();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private int DistanceSqr(Point a, Point b)
        {
            return (a.X - b.X)*(a.X - b.X) + (a.Y - b.Y)*(a.Y - b.Y);
        }

        private void SavePolygons(string fileName)
        {
            if (!string.IsNullOrWhiteSpace(_fileName))
            {
                var json = JsonConvert.SerializeObject(_polygons, Formatting.Indented);

                File.WriteAllText(fileName, json);

                var bitmap = new Bitmap(CANVAS_SIZE, CANVAS_SIZE);
                _canvas.DrawToBitmap(bitmap, new Rectangle(0, 0, CANVAS_SIZE, CANVAS_SIZE));

                bitmap.Save($"{_fileName}_image.png", ImageFormat.Png);
            }
            else
            {
                SavePolygonsAs();
            }
        }

        private void SavePolygonsAs()
        {
            var dialog = new SaveFileDialog();
            dialog.CheckPathExists = false;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _fileName = dialog.FileName;
                SavePolygons(_fileName);
            }
        }

        private void Undo()
        {
            if (_points.Count > 0)
            {
                _points.RemoveAt(_points.Count - 1);
            }
            else if (_polygons.Count > 0)
            {
                _polygons.RemoveAt(_polygons.Count - 1);
            }

            PolygonsCount.Text = $"Polygons: {_polygons.Count}";

            _canvas.Invalidate();
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SavePolygonsAs();
        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            SavePolygons(_fileName);
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _fileName = dialog.FileName;
                var json = File.ReadAllText(_fileName);
                _polygons = JsonConvert.DeserializeObject<List<Polygon>>(json);
                
                _canvas.Invalidate();
            }
        }
    }
}
