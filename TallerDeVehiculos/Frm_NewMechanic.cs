using CapaEntidad;
using CapaNegocio;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class Frm_NewMechanic : Form
    {

        public Frm_NewMechanic()
        {
            InitializeComponent();

        }
        private CNMecanico CNMecanico = new CNMecanico();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel y = (Panel)sender;

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

        private void btn_create_UseClicked(object sender, EventArgs e)
        {
            try
            {
                Mecanico mecanico = new Mecanico()
                {
                    nombre = txt_name.Text,
                    apellido = txt_lastname.Text,
                    cedula = txt_dni.Text,
                    Especialidad = txt_espec.Text,
                    telefono = txt_phone.Text,
                    AniosExperiencia = Convert.ToInt32(nud_yearsxp.Value)
                };


                CNMecanico.AgregarMecanico(mecanico);


                MessageBox.Show("Registro del mecanico exitoso!.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //1. forma
            //mecanico.nombre= txt_name.Text;
            //mecanico.apellido =txt_lastname.Text;
            //2. forma


        }
        private void Clean()
        {
            txt_name.Text = string.Empty;
            txt_lastname.Text = string.Empty;
            txt_dni.Text = string.Empty;
            txt_espec.Text = string.Empty;
            txt_phone.Text = string.Empty;
            nud_yearsxp.Value = 0;

        }

    }
}
