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
        private List<Event> _points = new List<Event>();
        private Bitmap _image;
        private Voronoi _voronoi;

        public Main()
        {
            InitializeComponent();
            _voronoi = new Voronoi(Geometry.Euclidean);
        }

        protected override void OnLoad(EventArgs e)
        {
            _image = new Bitmap(canvas.Width,canvas.Height);
            canvas.Image = _image;
        }

        private void canvas_Click(object sender, EventArgs e)
        {
            var ev = e as MouseEventArgs;
            _points.Add(new Event(ev.X,ev.Y, EventType.Site));
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
                    g.DrawLine(Pens.Blue, (float)e.X1,(float)e.Y1,(float)e.X2,(float)e.Y2);
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
