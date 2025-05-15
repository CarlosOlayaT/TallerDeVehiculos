using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Table;

namespace CapaPresentacion
{
    public partial class UC_Mechanic : UserControl
    {
        public UC_Mechanic()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            List<Mecanico> Lista = CNMecanico.GetMecanicoList();
            lbl_mechanics.Text = $"All mechanic({Lista.Count})";
            LoadTable(Lista);

        }
        CNMecanico CNMecanico = new CNMecanico();
        private void LoadTable(List<Mecanico> Lista)
        {
            customdatagridview1.Rows.Clear();


            foreach (Mecanico mec in Lista)
            {

                customdatagridview1.Rows.Add(new object[] { false, mec.cedula, $"{mec.nombre} {mec.apellido}", mec.AniosExperiencia, mec.Especialidad, mec.telefono, mec.Estado ? "Disponible" : "No disponible" });

            }

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

            Panel y = (Panel)sender;

            using (Pen pen = new Pen(Color.FromArgb(141, 147, 151), 2))
            {
                e.Graphics.DrawLine(pen, 0, y.Height - 1, y.Width, y.Height - 1);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Point panelScreenPos = this.PointToScreen(Point.Empty);

            Frm_NewMechanic frm_NewMechanic = new Frm_NewMechanic();

            int centerX = panelScreenPos.X + (this.Width - frm_NewMechanic.Width) / 2;
            int centerY = panelScreenPos.Y + (this.Height - frm_NewMechanic.Height) / 2;

            frm_NewMechanic.StartPosition = FormStartPosition.Manual;
            frm_NewMechanic.Location = new Point(centerX, centerY);


            if (frm_NewMechanic.ShowDialog() == DialogResult.Cancel)
            {
                List<Mecanico> Lista = CNMecanico.GetMecanicoList();
                lbl_mechanics.Text = $"All mechanic({Lista.Count})";
                LoadTable(Lista);
            }
        }

        private void customdatagridview1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var cell = customdatagridview1.Rows[e.RowIndex].Cells[e.ColumnIndex] as AlignedPanelCell;
            if (cell != null)
            {
                if (e.ColumnIndex == 6 && e.CellStyle != null)
                {
                    string caso = e.Value?.ToString() ?? string.Empty;


                    switch (caso)
                    {
                        case "Disponible":
                            e.CellStyle.ForeColor = Color.FromArgb(32, 192, 98);
                            cell.PanelColor = Color.FromArgb(4, 53, 25);
                            break;
                        case "No disponible":
                            e.CellStyle.ForeColor = Color.FromArgb(216, 64, 64);
                            cell.PanelColor = Color.FromArgb(89, 4, 4);
                            break;
                        default:
                            e.CellStyle.ForeColor = Color.Gray;
                            cell.PanelColor = Color.DarkGray;
                            break;
                    }
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            List<Mecanico> lista = CNMecanico.GetMecanicoList();
            if (Regex.IsMatch(txt_search.Text, @"[\d+]"))
            {
                List<Mecanico> resultado = lista.Where(m => m.cedula.ToString().Contains(txt_search.Text)).ToList();
                LoadTable(resultado);
            }
            else
            {
                List<Mecanico> resultado = lista.Where(m => $"{m.nombre} {m.apellido}".ToString().Contains(txt_search.Text)).ToList();
                LoadTable(resultado);
            }
        }
    }
}
