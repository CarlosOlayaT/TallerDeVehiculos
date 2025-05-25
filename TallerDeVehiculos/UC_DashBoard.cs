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
            customdatagridview1.AutoGenerateColumns = false;
            metodoPrueba();
        }

        private void metodoPrueba()
        {
            CNServicio cNServicio = new CNServicio();

            List<Servicio> lista = cNServicio.GetListTable();
            customdatagridview1.DataSource = lista;
            CNCliente cNCliente = new CNCliente();
            lbl_vehic.Text = cNCliente.GetAll().Count.ToString();
            CNMecanico cNMecanico = new CNMecanico();
            lbl_revisados.Text = cNMecanico.GetAlls().Count.ToString();
            lbl_pend.Text = lista.Count.ToString();

            Dictionary<string, int> conteo = lista.GroupBy(l => l.estado).ToDictionary(g =>g.Key, g => g.Count());



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
            var labels = estado.Zip(estadonum, (lblEstado, lblNum) => (lblEstado, lblNum)).ToArray();
            int total = conteo.Values.Sum();
            int index = 0;

            foreach (var (key, value) in conteo)
            {
                int porc = (int)Math.Round((double)value / total * 100);

                labels[index].lblEstado.Text = $"{key} ({porc}%)";
                labels[index].lblNum.Text = value.ToString();

                series.Points.Add(new DataPoint
                {
                    AxisLabel = "",
                    YValues = new double[] { value },
                    Color = paleta[index]
                });

                index++;
            }

            chart1.Series.Add(series);
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
                    Debug.WriteLine(caso);

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
