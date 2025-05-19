using CapaPresentacion.ComponentsUX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion
{
    public partial class UC_DashBoard : UserControl
    {
        public UC_DashBoard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            metodoPrueba();
        }

        private void metodoPrueba()
        {
            customdatagridview1.Rows.Add(new object[] { null, 547536, "Carlos Olaya", DateTime.Now, "preventivo", 432, "Completado" });
            customdatagridview1.Rows.Add(new object[] { null, 547536, "Carlos Olaya", DateTime.Now, "preventivo", 432, "Esperando" });
            customdatagridview1.Rows.Add(new object[] { null, 547536, "Carlos Olaya", DateTime.Now, "preventivo", 432, "Cancelado" });
            //customdatagridview1.Rows.Add(new object[] { null, 547536, "Carlos Olaya", DateTime.Now, "preventivo", 432, "Cancelado" });

            Dictionary<string, int> Datos = new Dictionary<string, int>()
            {
                { "Aceptados",6 },
                { "Devueltos",2 },
                { "Pendientes",2 }

            };

            int suma = Datos.Values.Sum();
            List<Color> paleta = new List<Color>()
            {
                Color.FromArgb(214, 251, 210),
                Color.FromArgb(217, 119, 6),
                Color.FromArgb(216, 64, 64)
            };
            
            Series series = new Series()
            {
                ChartType = SeriesChartType.Doughnut,


            };
            int i = 0;
            Label[] estado = new Label[] { lbl_aceptados, lbl_devueltos, lbl_pendientes };
            Label[] estadonum = new Label[] { lbl_acept_num, lbl_devu_num, lbl_pend_num };
            foreach (var key in Datos)
            {
                int porc = (int)Math.Round((double)key.Value / suma * 100);
                estado[i].Text = $"{key.Key}({porc})%";
                estadonum[i].Text = key.Value.ToString();
                DataPoint punto = new DataPoint();
                punto.AxisLabel = "";
                punto.YValues = new double[] { key.Value };
                punto.Color = paleta[i];
                series.Points.Add(punto);
                i++;
            }

            chart1.Series.Add(series);
        }

        private void customdatagridview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                        case "Completado":
                            e.CellStyle.ForeColor = Color.FromArgb(32, 192, 98);
                            cell.PanelColor = Color.FromArgb(4, 53, 25);
                            break;
                        case "Esperando":
                            e.CellStyle.ForeColor = Color.FromArgb(217, 119, 6);
                            cell.PanelColor = Color.FromArgb(60, 23, 0);
                            break;
                        case "Cancelado":
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
        private void Pn_aceptados_Paint(object sender, PaintEventArgs e)
        {
            int y = lbl_pendientes.Height - 1; // Parte baja del panel
            using (Pen pen = new Pen(Color.FromArgb(214, 251, 210), 2)) // Cambia el color y grosor según desees
            {
                e.Graphics.DrawLine(pen, 0, y, lbl_pendientes.Width, y);
            }
        }

        private void Pn_devueltos_Paint(object sender, PaintEventArgs e)
        {
            int y = lbl_pendientes.Height - 1; // Parte baja del panel
            using (Pen pen = new Pen(Color.FromArgb(217, 119, 6), 2)) // Cambia el color y grosor según desees
            {
                e.Graphics.DrawLine(pen, 0, y, lbl_pendientes.Width, y);
            }
        }
        private void Pn_pendientes_Paint(object sender, PaintEventArgs e)
        {
            int y = lbl_pendientes.Height - 1; // Parte baja del panel
            using (Pen pen = new Pen(Color.FromArgb(216, 64, 64), 2)) // Cambia el color y grosor según desees
            {
                e.Graphics.DrawLine(pen, 0, y, lbl_pendientes.Width, y);
            }
        }
    }
}
