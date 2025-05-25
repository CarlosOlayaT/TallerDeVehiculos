using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.ComponentsUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Frm_Comprobante : Form
    {
        public Frm_Comprobante()
        {
            InitializeComponent();

        }
        public Frm_Comprobante(Servicio servicio)
        {
            InitializeComponent();
            cargar(servicio);

        }

        private void cargar(Servicio servicio)
        {
            lbl_cedula.Text = servicio.cliente.cedula;
            lbl_codigo.Text = servicio.codigo;
            lbl_diagnostico.Text = servicio.diagnostico;
            lbl_fecha.Text = servicio.Fecha.ToShortDateString();
            lbl_iva.Text = $"${(servicio.subtbase + servicio.subtrep + servicio.SubtAdd) * 0.15f}";
            lbl_mecanico.Text= servicio.mecanico.nombre;
            lbl_nombre.Text = servicio.cliente.nombre;
            lbl_placa.Text = servicio.vehiculo.placa;
            lbl_subt.Text = $"${(servicio.subtbase + servicio.subtrep + servicio.SubtAdd)}";
            lbl_subtadd.Text = $"${servicio.SubtAdd.ToString("F2")}";
            lbl_subtbase.Text = $"${servicio.subtbase.ToString("F2")}";
            lbl_subtrep.Text = $"${servicio.subtrep.ToString("F2")}";
            lbl_telefono.Text = servicio.cliente.telefono;
            lbl_tipo.Text = servicio.tipo;
            lbl_total.Text = $"${servicio.total.ToString("F2")}";
            lbl_trabajos.Text = servicio.trabajosRealizados;
            lbl_vehiculo.Text = servicio.vehiculo.modelo;


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


        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Panel y = sender as Panel;

            using (Pen pen = new Pen(Color.FromArgb(141, 147, 151), 2)) // Cambia el color y grosor según desees
            {
                e.Graphics.DrawLine(pen, 0, y.Height - 1, y.Width, y.Height - 1);
            }
        }

        private void roundedLabel1_UseClicked(object sender, EventArgs e)
        {
            this.Close();
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


        

    }
}
