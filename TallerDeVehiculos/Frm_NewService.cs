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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Frm_NewService : Form
    {
        public Frm_NewService()
        {
            InitializeComponent();
            CNServicio cNServicio = new CNServicio();
            int codigo = cNServicio.GetAll().Count + 1;
            lbl_codigo.Text = $"M{codigo.ToString("D3")}";
            flowLayoutPanel1.VerticalScroll.Visible = true;
            flowLayoutPanel1.HorizontalScroll.Visible = false;
            CNCliente cNCliente = new CNCliente();
            CNMecanico cNMecanico = new CNMecanico();
            cmb_clientes.DataSource = cNCliente.GetClientList();
            cmb_mecanicos.DataSource = cNMecanico.GetMecanicoList();

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

        private void btn_addRep_MouseEntering(object sender, EventArgs e)
        {
            btn_addRep.ForeColor = Color.FromArgb(32, 192, 98);
            btn_addRep.StateColor = Color.FromArgb(4, 53, 25);

        }

        private void btn_addRep_MouseLeaving(object sender, EventArgs e)
        {
            btn_addRep.ForeColor = Color.FromArgb(4, 53, 25);
            btn_addRep.StateColor = Color.FromArgb(32, 192, 98);

        }

        float total = 0;
        float totalAdd = 0;
        List<Repuesto> repuestos = new List<Repuesto>();
        List<string> serAdicional = new List<string>();
        private void roundedLabel1_UseClicked_1(object sender, EventArgs e)
        {
            float subt = int.Parse(this.txt_cant_rep.Text) * float.Parse(this.txt_valor_rep.Text);

            Repuesto repuesto = new Repuesto()
            {
                _Nombre = txt_name_rep.Text,
                _Cantidad = int.Parse(txt_cant_rep.Text),
                _precio = float.Parse(txt_valor_rep.Text),
                subtotal = subt,

            };
            repuestos.Add(repuesto);
            ComponentRepuesto componentRepuesto = new ComponentRepuesto(repuesto);

            componentRepuesto.ClickDeleted += ComponentRepuesto_ClickDeleted;
            flowLayoutPanel1.Controls.Add(componentRepuesto);

            total += repuesto.subtotal;
            lbl_total.Text = $"${total.ToString()}";

        }

        private void ComponentRepuesto_ClickDeleted(object? sender, EventArgs e)
        {

            ComponentRepuesto componentRepuesto = (ComponentRepuesto)sender;
            repuestos.Remove(componentRepuesto.repuesto);
            flowLayoutPanel1.Controls.Remove(componentRepuesto);
            total -= componentRepuesto.repuesto.subtotal;
            lbl_total.Text = $"${total.ToString()}";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                totalAdd += float.Parse(checkBox.Tag.ToString());
                serAdicional.Add(checkBox.Text);
            }
            else
            {
                totalAdd -= float.Parse(checkBox.Tag.ToString());
                serAdicional.Remove(checkBox.Text);
            }

            lbl_total_add.Text = $"${totalAdd.ToString()}";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Panel_repuestos.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Panel_repuestos.Visible = false;

        }
        private string tipo()
        {
            if (rdb_preven.Checked)
            {
                return rdb_preven.Text;
            }
            else if (rdb_correct.Checked)
            {
                return rdb_correct.Text;
            }
            else
            {
                return null;
            }
        }
        private void btn_create_UseClicked(object sender, EventArgs e)
        {
            try
            {
                Vehiculo vehiculo = new Vehiculo()
                {
                    placa = txt_placa.Text.Trim(),
                    modelo = txt_modelo.Text.Trim(),
                    anio = int.Parse(txt_anio.Text.Trim()),
                    marca = txt_marca.Text.Trim(),
                };
                Cliente cliente = (Cliente)cmb_clientes.SelectedItem as Cliente;
                Mecanico mecanico = cmb_mecanicos.SelectedItem as Mecanico;

                Servicio servicio = new Servicio()
                {



                    cliente = cliente,
                    mecanico = mecanico,
                    vehiculo = vehiculo,
                    repuestos = this.repuestos,
                    codigo = lbl_codigo.Text,
                    estado = "Esperando",
                    tipo = tipo(),
                    diagnostico = rchtxt_diagnostico.Text,
                    trabajosRealizados = rchtxt_trab_realiz.Text,
                    Fecha = dtp_fecha.Value.Date,
                    ServAdicionales = this.serAdicional,
                    SubtAdd = float.Parse(lbl_total_add.Text.Substring(1)),
                    subtrep = float.Parse(lbl_total.Text.Substring(1)),
                    subtbase = tipo() == "Preventivo" ? 30 : 60,

                };
                float subtotal = servicio.subtbase + servicio.subtrep + servicio.SubtAdd;
                servicio.total = subtotal + (subtotal * 0.15f);
                CNServicio cNServicio = new CNServicio();
                CNMecanico cNMecanico = new CNMecanico();
                cNMecanico.ChangeState(mecanico, false);
                cNServicio.AgregarServicio(servicio);
                Frm_Comprobante frm_Comprobante = new Frm_Comprobante(servicio);
                Point panelScreenPos = this.PointToScreen(Point.Empty);


                int centerX = panelScreenPos.X + (this.Width - frm_Comprobante.Width) / 2;
                int centerY = panelScreenPos.Y + (this.Height - frm_Comprobante.Height) / 2;

                frm_Comprobante.StartPosition = FormStartPosition.Manual;
                frm_Comprobante.Location = new Point(centerX, centerY);

                MessageBox.Show("Registro del mantenimiento exitoso!.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clean();
                this.Close();
                frm_Comprobante.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void clean()
        {
            txt_anio.Text = string.Empty;
            txt_marca.Text = string.Empty;
            txt_modelo.Text = string.Empty;
            txt_placa.Text = string.Empty;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            rdb_correct.Checked = false;
            rdb_preven.Checked = true;
        }

        private void txt_cant_rep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;

            if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains("."))
                return;

            if (e.KeyChar == (char)Keys.Back)
                return;

            e.Handled = true;
        }

        private void txt_anio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;

            if (e.KeyChar == (char)Keys.Back)
                return;

            e.Handled = true;
        }



        private void txt_placa_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            int length = txt_placa.Text.Length;

            if (char.IsControl(e.KeyChar))
                return;

            if (length < 3)
            {
                if (!char.IsLetter(e.KeyChar))
                    e.Handled = true;
                else
                    e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else if (length >= 3 && length < 7)
            {
                if (!char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
