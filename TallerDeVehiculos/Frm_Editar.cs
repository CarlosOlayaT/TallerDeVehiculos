using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Frm_Editar : Form
    {
        public Frm_Editar()
        {
            InitializeComponent();
        }
        Servicio servicio = null;
        public Frm_Editar(Servicio serv)
        {
            InitializeComponent();
            comboBox1.SelectedItem = serv.estado;
            servicio = serv;

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            int radio = 65;
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
            path.AddArc(new Rectangle(this.Width - radio, 0, radio, radio), 270, 90);
            path.AddArc(new Rectangle(this.Width - radio, this.Height - radio, radio, radio), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - radio, radio, radio), 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
            base.OnPaint(e);
        }
        private void roundedLabel1_UseClicked(object sender, EventArgs e)
        {
            servicio.estado = comboBox1.SelectedItem.ToString();
            CNServicio cNServicio = new CNServicio();
            cNServicio.ChangeState(servicio);
            this.Close();
        }


        private void btn_create_MouseEntering(object sender, EventArgs e)
        {

            btn_cancel.ForeColor = Color.FromArgb(36, 240, 120);
            btn_cancel.StateColor = Color.FromArgb(3, 87, 39);
        }

        private void btn_create_MouseLeaving(object sender, EventArgs e)
        {
            btn_cancel.ForeColor = Color.FromArgb(32, 192, 98);
            btn_cancel.StateColor = Color.FromArgb(4, 53, 25);
        }

    }
}
