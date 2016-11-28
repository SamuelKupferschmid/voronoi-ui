using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoronoiUI
{
    public partial class Main : Form
    {
        private List<Point> _points = new List<Point>();
        private Bitmap _image;
        private Voronoi _voronoi;

        public Main()
        {
            InitializeComponent();
            _voronoi = new Voronoi(Distance.Euclidean);
        }

        protected override void OnLoad(EventArgs e)
        {
            _image = new Bitmap(canvas.Width,canvas.Height);
            canvas.Image = _image;
        }

        private void canvas_Click(object sender, EventArgs e)
        {
            var ev = e as MouseEventArgs;
            _points.Add(new Point(ev.X,ev.Y));
            DrawCanvas();

        }

        private void DrawCanvas()
        {
            var edges = _voronoi.CalcEdges(_points);
            using (var g = Graphics.FromImage(_image))
            {
                g.Clear(BackColor);
                foreach (var p in _points)
                {
                    g.FillEllipse(Brushes.CornflowerBlue,(float)p.X,(float)p.Y, 5, 5);
                }

                foreach (var e in edges)
                {
                    g.DrawLine(Pens.Blue, (float)e.Start.X,(float)e.Start.Y,(float)e.End.X,(float)e.End.Y);
                }
            }
            canvas.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _points.Clear();
            DrawCanvas();
        }
    }
}
