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
            //customdatagridview1.Rows.Add(new object[] { null, 547536, "Carlos Olaya", "preventivo", 432, });
            //customdatagridview1.Rows.Add(new object[] { null, 547536, "Carlos Olaya", "preventivo", 432, });
            //customdatagridview1.Rows.Add(new object[] { null, 547536, "Carlos Olaya", "preventivo", 432, });
            List<Cliente> lista = CNCliente.GetClientes();
            lbl_customers.Text = $"All Customer({lista.Count})";
            LoadTable(lista);
        }

        private void LoadTable(List<Cliente> lista)
        {
            customdatagridview1.Rows.Clear();
           

            foreach (Cliente cliente in lista)
            {
                customdatagridview1.Rows.Add(new object[] { false, cliente.cedula, $"{cliente.nombre} {cliente.apellido}", cliente.email, cliente.telefono });
            }
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
                List<Cliente> lista = CNCliente.GetClientes();
                lbl_customers.Text = $"All Customer({lista.Count})";
                LoadTable(lista);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Cliente> lista = CNCliente.GetClientes();
            if (Regex.IsMatch(txt_search.Text, @"[\d+]"))
            {
                List<Cliente> resultado = lista.Where(c => c.cedula.ToString().Contains(txt_search.Text)).ToList();
                LoadTable(resultado);
            }
            else
            {
                List<Cliente> resultado = lista.Where(c => $"{c.nombre} {c.apellido}".ToString().Contains(txt_search.Text)).ToList();
                LoadTable(resultado);
            }
        }
    }
}
