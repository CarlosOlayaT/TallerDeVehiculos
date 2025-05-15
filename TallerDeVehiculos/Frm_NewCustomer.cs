using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Frm_NewCustomer : Form
    {

        public Frm_NewCustomer()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel y = sender as Panel;

            using (Pen pen = new Pen(Color.FromArgb(141, 147, 151), 2)) // Cambia el color y grosor según desees
            {
                e.Graphics.DrawLine(pen, 0, y.Height - 1, y.Width, y.Height - 1);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            int radio = 42; // Radio del borde redondeado
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90); // esquina superior izquierda
            path.AddArc(new Rectangle(this.Width - radio, 0, radio, radio), 270, 90); // superior derecha
            path.AddArc(new Rectangle(this.Width - radio, this.Height - radio, radio, radio), 0, 90); // inferior derecha
            path.AddArc(new Rectangle(0, this.Height - radio, radio, radio), 90, 90); // inferior izquierda
            path.CloseFigure();

            this.Region = new Region(path);
            base.OnPaint(e);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void roundedLabel1_Load(object sender, EventArgs e)
        {

        }

        private void roundedLabel1_Click(object sender, EventArgs e)
        {

        }

        private void roundedLabel1_UseClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundedLabel1_MouseEnter(object sender, EventArgs e)
        {
            btn_cancel.ForeColor = Color.FromArgb(255, 59, 59);
            btn_cancel.StateColor = Color.FromArgb(146, 10, 10);
        }

        private void btn_cancel_MouseEntering(object sender, EventArgs e)
        {
            btn_cancel.ForeColor = Color.FromArgb(255, 59, 59);
            btn_cancel.StateColor = Color.FromArgb(146, 10, 10);
        }

        private void btn_cancel_MouseLeaving(object sender, EventArgs e)
        {
            btn_cancel.ForeColor = Color.FromArgb(216, 64, 64);
            btn_cancel.StateColor = Color.FromArgb(89, 4, 4);
        }

        private void btn_create_MouseEntering(object sender, EventArgs e)
        {
            btn_create.ForeColor = Color.FromArgb(36, 240, 120);
            btn_create.StateColor = Color.FromArgb(3, 87, 39);
        }

        private void btn_create_MouseLeaving(object sender, EventArgs e)
        {
            btn_create.ForeColor = Color.FromArgb(32, 192, 98);
            btn_create.StateColor = Color.FromArgb(4, 53, 25);
        }
    }
}
