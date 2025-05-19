using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace CapaPresentacion.ComponentsUX
{
    public class RoundedPanel : Panel
    {

        private Color _color = Color.White;
        private CornerRadius cornerRadius = new CornerRadius();



        public RoundedPanel()
        {
            DoubleBuffered = true;
            BackColor = Color.Transparent;
            DoubleBuffered = true;
        }
        [Category("CustomPanel")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public CornerRadius Radius
        {
            get => cornerRadius;
            set
            {
                if (cornerRadius != null)
                    cornerRadius.PropertyChanged -= CornerRadius_PropertyChanged;

                cornerRadius = value;

                if (cornerRadius != null)
                    cornerRadius.PropertyChanged += CornerRadius_PropertyChanged;

                Invalidate(); // Redibuja el panel
            }
        }

        private void CornerRadius_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Invalidate(); // Redibuja al cambiar cualquier propiedad del radius
        }

        [Category("CustomPanel")]
        public Color StateColor
        {
            get { return _color; }
            set { _color = value; Invalidate(); }
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = ClientRectangle;
            rect.Inflate(-1, -1); // Ajuste para que no se corte

            using (GraphicsPath path = GetRoundedRectanglePath(rect, cornerRadius))
            {
                using (SolidBrush brush = new SolidBrush(_color))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, CornerRadius radius)
        {
            GraphicsPath path = new GraphicsPath();

            int tl = radius.TopLeft;
            int tr = radius.TopRight;
            int br = radius.BottomRight;
            int bl = radius.BottomLeft;

            path.StartFigure();
            path.AddArc(rect.Left, rect.Top, tl * 2, tl * 2, 180, 90);
            path.AddLine(rect.Left + tl, rect.Top, rect.Right - tr, rect.Top);
            path.AddArc(rect.Right - tr * 2, rect.Top, tr * 2, tr * 2, 270, 90);
            path.AddLine(rect.Right, rect.Top + tr, rect.Right, rect.Bottom - br);
            path.AddArc(rect.Right - br * 2, rect.Bottom - br * 2, br * 2, br * 2, 0, 90);
            path.AddLine(rect.Right - br, rect.Bottom, rect.Left + bl, rect.Bottom);
            path.AddArc(rect.Left, rect.Bottom - bl * 2, bl * 2, bl * 2, 90, 90);
            path.AddLine(rect.Left, rect.Bottom - bl, rect.Left, rect.Top + tl);
            path.CloseFigure();

            return path;
        }
    }
}
