
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace CapaPresentacion.ComponentsUX
{

    public class AlignedPanel : Panel
    {
        private ContentAlignment _contentAlignment = ContentAlignment.TopLeft;
        private int _radius = 1;
        private Color _color = Color.White;

        public AlignedPanel()
        {
            this.DoubleBuffered = true;
            this.BackColor = Color.Transparent;
        }

        [Category("Layout")]
        [Description("Alinea los controles dentro del panel.")]
        [DefaultValue(typeof(ContentAlignment), "TopLeft")]
        public ContentAlignment ContentAlignment
        {
            get => _contentAlignment;
            set
            {
                _contentAlignment = value;
                PerformLayout();
            }
        }
        [Category("Layout")]
        public Color BackgroundColor
        {
            get { return _color; }
            set { _color = value; PerformLayout(); }
        }
        [Category("Layout")]
        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);

            if (this.Controls.Count == 0) return;

            Rectangle totalBounds = GetTotalBounds();

            int offsetX = 0;
            int offsetY = 0;

            switch (_contentAlignment)
            {
                case ContentAlignment.TopLeft:
                    offsetX = 0;
                    offsetY = 0;
                    break;
                case ContentAlignment.TopCenter:
                    offsetX = (this.Width - totalBounds.Width) / 2;
                    offsetY = 0;
                    break;
                case ContentAlignment.TopRight:
                    offsetX = this.Width - totalBounds.Width;
                    offsetY = 0;
                    break;
                case ContentAlignment.MiddleLeft:
                    offsetX = 0;
                    offsetY = (this.Height - totalBounds.Height) / 2;
                    break;
                case ContentAlignment.MiddleCenter:
                    offsetX = (this.Width - totalBounds.Width) / 2;
                    offsetY = (this.Height - totalBounds.Height) / 2;
                    break;
                case ContentAlignment.MiddleRight:
                    offsetX = this.Width - totalBounds.Width;
                    offsetY = (this.Height - totalBounds.Height) / 2;
                    break;
                case ContentAlignment.BottomLeft:
                    offsetX = 0;
                    offsetY = this.Height - totalBounds.Height;
                    break;
                case ContentAlignment.BottomCenter:
                    offsetX = (this.Width - totalBounds.Width) / 2;
                    offsetY = this.Height - totalBounds.Height;
                    break;
                case ContentAlignment.BottomRight:
                    offsetX = this.Width - totalBounds.Width;
                    offsetY = this.Height - totalBounds.Height;
                    break;
            }

            foreach (Control ctrl in this.Controls)
            {
                ctrl.Location = new Point(
                    ctrl.Location.X - totalBounds.X + offsetX,
                    ctrl.Location.Y - totalBounds.Y + offsetY
                );
            }
        }

        private Rectangle GetTotalBounds()
        {
            if (this.Controls.Count == 0) return Rectangle.Empty;

            Rectangle bounds = this.Controls[0].Bounds;

            foreach (Control ctrl in this.Controls)
            {
                bounds = Rectangle.Union(bounds, ctrl.Bounds);
            }

            return bounds;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle rect = this.ClientRectangle;
            rect.Inflate(-1, -1); // Ajuste para que no se corte

            using (GraphicsPath path = GetRoundedTopCornersPath(rect, _radius))
            {
                using (SolidBrush brush = new SolidBrush(_color))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }


        private GraphicsPath GetRoundedTopCornersPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float r = radius;

            path.StartFigure();
            path.AddArc(rect.Left, rect.Top, r, r, 180, 90); // Esquina superior izquierda
            path.AddLine(rect.Left + r, rect.Top, rect.Right - r, rect.Top); // Línea superior entre esquinas
            path.AddArc(rect.Right - r, rect.Top, r, r, 270, 90); // Esquina superior derecha
            path.AddLine(rect.Right, rect.Top + r, rect.Right, rect.Bottom); // Lado derecho recto
            path.AddLine(rect.Right, rect.Bottom, rect.Left, rect.Bottom); // Línea inferior recta
            path.AddLine(rect.Left, rect.Bottom, rect.Left, rect.Top + r); // Lado izquierdo recto
            path.CloseFigure();

            return path;
        }
    }
}
