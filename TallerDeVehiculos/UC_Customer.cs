using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class UC_Customer : UserControl
    {
        CNCliente CNCliente = new CNCliente();
        public UC_Customer()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            customdatagridview1.AutoGenerateColumns = false;
            List<Cliente> lista = CNCliente.GetClientList();
            lbl_customers.Text = $"All Customer({lista.Count})";
            customdatagridview1.DataSource = lista;
        }


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

            Panel y = (Panel)sender;

            using (Pen pen = new Pen(Color.FromArgb(141, 147, 151), 2)) // Cambia el color y grosor según desees
            {
                e.Graphics.DrawLine(pen, 0, y.Height - 1, y.Width, y.Height - 1);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Point panelScreenPos = this.PointToScreen(Point.Empty);

            Frm_NewCustomer frm_NewCustomer = new Frm_NewCustomer();

            int centerX = panelScreenPos.X + (this.Width - frm_NewCustomer.Width) / 2;
            int centerY = panelScreenPos.Y + (this.Height - frm_NewCustomer.Height) / 2;

            frm_NewCustomer.StartPosition = FormStartPosition.Manual;
            frm_NewCustomer.Location = new Point(centerX, centerY);


            if (frm_NewCustomer.ShowDialog() == DialogResult.Cancel)
            {
                List<Cliente> lista = CNCliente.GetClientList();
                lbl_customers.Text = $"All Customer({lista.Count})";
                customdatagridview1.DataSource = lista;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txt_search.Text.Trim()))
            {
               List<Cliente> list = CNCliente.GetFilterListTable(txt_search.Text.Trim());
               customdatagridview1.DataSource= list;
            }
            else
            {
                List<Cliente> clientes = CNCliente.GetClientList();
                customdatagridview1.DataSource = clientes;
            }

        }
    }
}
