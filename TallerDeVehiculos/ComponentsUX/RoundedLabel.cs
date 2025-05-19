using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CapaPresentacion.ComponentsUX
{
    public partial class RoundedLabel : UserControl
    {
        private Color _color = Color.White;
        private int _radius = 1;

        [Browsable(true)]
        public event EventHandler UseClicked;
        public event EventHandler MouseEntering;
        public event EventHandler MouseLeaving;
        public RoundedLabel()
        {

            InitializeComponent();
            this.DoubleBuffered = true;
            this.Click += Clicked;
            this.label1.Click += Clicked;
            this.MouseEnter += MouseEntered;
            this.label1.MouseEnter += MouseEntered;
            this.MouseLeave+= MouseLeft;
            this.label1.MouseLeave += MouseLeft;


        }

        private void MouseEntered(object? sender, EventArgs e)
        {
            MouseEntering?.Invoke(this, e);
        }private void MouseLeft(object? sender, EventArgs e)
        {
            MouseLeaving?.Invoke(this, e);
        }

        [Category("CustomLabel")]
        //[Localizable(true)]
        [DefaultValue(ContentAlignment.MiddleCenter)]
        public ContentAlignment Align
        {
            get
            { return label1.TextAlign; }
            set { label1.TextAlign = value; }
        }
        [Category("CustomLabel")]
        [DefaultValue(0)]
        public int Radius
        {
            get { return _radius; }
            set { _radius = value; Invalidate(); }


        }

        [Category("CustomLabel")]
        public string Texts
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }




        [Category("CustomLabel")]
        public Color StateColor
        {
            get { return _color; }
            set { _color = value; Invalidate(); }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle rect = this.ClientRectangle;
            rect.Inflate(-1, -1); // Ajuste para que no se corte

            using (GraphicsPath path = GetRoundedRectanglePath(rect, _radius))
            {
                using (SolidBrush brush = new SolidBrush(_color))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float r = radius;

            path.StartFigure();
            path.AddArc(rect.Left, rect.Top, r, r, 180, 90);
            path.AddLine(rect.Left + r, rect.Top, rect.Right - r, rect.Top);
            path.AddArc(rect.Right - r, rect.Top, r, r, 270, 90);
            path.AddLine(rect.Right, rect.Top + r, rect.Right, rect.Bottom - r);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddLine(rect.Right - r, rect.Bottom, rect.Left + r, rect.Bottom);
            path.AddArc(rect.Left, rect.Bottom - r, r, r, 90, 90);
            path.AddLine(rect.Left, rect.Bottom - r, rect.Left, rect.Top + r);
            path.CloseFigure();

            return path;
        }

        private void Clicked(object sender, EventArgs e)
        {
            UseClicked?.Invoke(this, e);
        }

    }
}
