using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.ComponentsUX;
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
            customdatagridview1.AutoGenerateColumns = false;

            customdatagridview1.DataSource = Lista;

        }
        CNMecanico CNMecanico = new CNMecanico();

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
                customdatagridview1.DataSource = Lista;
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
                if (e.ColumnIndex == 5 && e.CellStyle != null)
                {
                    bool caso = Boolean.Parse(e.Value.ToString());

                    //Debug.WriteLine(caso);

                    switch (caso)
                    {
                        case true:
                            e.CellStyle.ForeColor = Color.FromArgb(32, 192, 98);
                            cell.PanelColor = Color.FromArgb(4, 53, 25);
                            break;
                        case false:
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
            if (!string.IsNullOrWhiteSpace(txt_search.Text))
            {
                List<Mecanico> list = CNMecanico.GetListTable(txt_search.Text.Trim());
                customdatagridview1.DataSource = list;
            }
            else
            {
                customdatagridview1.DataSource = CNMecanico.GetMecanicoList();
            }
        }

        private void customdatagridview1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (customdatagridview1.Columns[e.ColumnIndex].Name == "Cl_Status")
            {
                if (e.Value is bool estado)
                {
                    e.Value = estado ? "Disponible" : "No disponible";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
