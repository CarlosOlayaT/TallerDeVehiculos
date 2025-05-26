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
    public partial class UC_Service : UserControl
    {
        public UC_Service()
        {
            InitializeComponent();

            this.DoubleBuffered = true;






            List<Servicio> Lista = CNServicio.GetListTable();
            customdatagridview1.AutoGenerateColumns = false;
            customdatagridview1.DataSource = Lista;
            //prueba();
        }

        private void prueba()
        {
            CNServicio.AgregarServicio(new Servicio
            {
                tipo = "preventivo",
                cliente = new Cliente
                {
                    apellido = "Pérez",
                    cedula = "0912345678",
                    direccion = "Av. 9 de Octubre y Boyacá",
                    email = "perez.juan@example.com",
                    nombre = "Juan",
                    telefono = "0991234567"
                },
                codigo = "M001",
                diagnostico = "Cambio de aceite y revisión general.",
                estado = "Completado",
                mecanico = new Mecanico
                {
                    apellido = "Ramírez",
                    cedula = "0923456789",
                    nombre = "Carlos",
                    telefono = "0987654321",
                    AniosExperiencia = 5,
                    Especialidad = "Mecánica general",
                    Estado = true
                },
                repuestos = new List<Repuesto>()
    {
        new Repuesto { _Cantidad = 1, _Nombre = "Aceite 10W40", _precio = 25.5f }
    },
                total = 45.5f,
                vehiculo = new Vehiculo
                {
                    anio = 2018,
                    marca = "Toyota",
                    modelo = "Corolla",
                    placa = "ABC-1234"
                }
            });

            CNServicio.AgregarServicio(new Servicio
            {
                tipo = "correctivo",
                cliente = new Cliente
                {
                    apellido = "García",
                    cedula = "0922223333",
                    direccion = "Cdla. Kennedy Norte, Guayaquil",
                    email = "garcia.maria@example.com",
                    nombre = "María",
                    telefono = "0983344556"
                },
                codigo = "M002",
                diagnostico = "Reparación del sistema de frenos.",
                estado = "Esperando",
                mecanico = new Mecanico
                {
                    apellido = "Mendoza",
                    cedula = "0933445566",
                    nombre = "Luis",
                    telefono = "0976543210",
                    AniosExperiencia = 8,
                    Especialidad = "Frenos y suspensión",
                    Estado = true
                },
                repuestos = new List<Repuesto>()
    {
        new Repuesto { _Cantidad = 4, _Nombre = "Pastillas de freno", _precio = 15 },
        new Repuesto { _Cantidad = 1, _Nombre = "Líquido de frenos", _precio = 8 }
    },
                total = 83,
                vehiculo = new Vehiculo
                {
                    anio = 2015,
                    marca = "Chevrolet",
                    modelo = "Aveo",
                    placa = "XYZ-5678"
                }
            });

            CNServicio.AgregarServicio(new Servicio
            {
                tipo = "correctivo",
                cliente = new Cliente
                {
                    apellido = "Suárez",
                    cedula = "0945678912",
                    direccion = "Calle Los Almendros, Manta",
                    email = "suarez.ricardo@example.com",
                    nombre = "Ricardo",
                    telefono = "0965432187"
                },
                codigo = "M003",
                diagnostico = "Reemplazo de batería y revisión eléctrica.",
                estado = "Cancelado",
                mecanico = new Mecanico
                {
                    apellido = "Torres",
                    cedula = "0911223344",
                    nombre = "Elena",
                    telefono = "0956781234",
                    AniosExperiencia = 3,
                    Especialidad = "Electricidad automotriz",
                    Estado = true
                },
                repuestos = new List<Repuesto>(),
                total = 95,
                vehiculo = new Vehiculo
                {
                    anio = 2020,
                    marca = "Hyundai",
                    modelo = "Tucson",
                    placa = "DEF-3456"
                }
            });
            CNServicio.AgregarServicio(new Servicio
            {
                tipo = "correctivo",
                cliente = new Cliente
                {
                    apellido = "Suárez",
                    cedula = "0945678912",
                    direccion = "Calle Los Almendros, Manta",
                    email = "suarez.ricardo@example.com",
                    nombre = "Ricardo",
                    telefono = "0965432187"
                },
                codigo = "M003",
                diagnostico = "Reemplazo de batería y revisión eléctrica.",
                estado = "Cancelado",
                mecanico = new Mecanico
                {
                    apellido = "Torres",
                    cedula = "0911223344",
                    nombre = "Elena",
                    telefono = "0956781234",
                    AniosExperiencia = 3,
                    Especialidad = "Electricidad automotriz",
                    Estado = true
                },
                repuestos = new List<Repuesto>(),
                total = 95,
                vehiculo = new Vehiculo
                {
                    anio = 2020,
                    marca = "Hyundai",
                    modelo = "Tucson",
                    placa = "DEF-3456"
                }
            });
            CNServicio.AgregarServicio(new Servicio
            {
                tipo = "correctivo",
                cliente = new Cliente
                {
                    apellido = "Suárez",
                    cedula = "0945678912",
                    direccion = "Calle Los Almendros, Manta",
                    email = "suarez.ricardo@example.com",
                    nombre = "Ricardo",
                    telefono = "0965432187"
                },
                codigo = "M003",
                diagnostico = "Reemplazo de batería y revisión eléctrica.",
                estado = "Cancelado",
                mecanico = new Mecanico
                {
                    apellido = "Torres",
                    cedula = "0911223344",
                    nombre = "Elena",
                    telefono = "0956781234",
                    AniosExperiencia = 3,
                    Especialidad = "Electricidad automotriz",
                    Estado = true
                },
                repuestos = new List<Repuesto>(),
                total = 95,
                vehiculo = new Vehiculo
                {
                    anio = 2020,
                    marca = "Hyundai",
                    modelo = "Tucson",
                    placa = "DEF-3456"
                }
            });

            CNServicio.AgregarServicio(new Servicio
            {
                tipo = "correctivo",
                cliente = new Cliente
                {
                    apellido = "Navarrete",
                    cedula = "0967891234",
                    direccion = "Cdla. Miraflores, Loja",
                    email = "navarrete.luisa@example.com",
                    nombre = "Luisa",
                    telefono = "0912345678"
                },
                codigo = "M005",
                diagnostico = "Cambio de correa de distribución.",
                estado = "Completado",
                Fecha = new DateTime(2023, 1, 1),
                mecanico = new Mecanico
                {
                    apellido = "Vega",
                    cedula = "0954321897",
                    nombre = "Diego",
                    telefono = "0909876543",
                    AniosExperiencia = 10,
                    Especialidad = "Motor",
                    Estado = true
                },
                repuestos = new List<Repuesto>
    {
        new Repuesto { _Cantidad = 1, _Nombre = "Correa distribución", _precio = 60 }
    },
                total = 90,
                vehiculo = new Vehiculo
                {
                    anio = 2012,
                    marca = "Kia",
                    modelo = "Sportage",
                    placa = "JKL-1122"
                }
            });
        }
        CNServicio CNServicio = new CNServicio();

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

            Frm_NewService frm_NewService = new Frm_NewService();

            int centerX = panelScreenPos.X + (this.Width - frm_NewService.Width) / 2;
            int centerY = panelScreenPos.Y + (this.Height - frm_NewService.Height) / 2;

            frm_NewService.StartPosition = FormStartPosition.Manual;
            frm_NewService.Location = new Point(centerX, centerY);

            if (frm_NewService.ShowDialog() == DialogResult.Cancel)
            {
                List<Servicio> Lista = CNServicio.GetListTable();
                customdatagridview1.DataSource = Lista;
            }
        }






        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value.Date;
            List<Servicio> list = CNServicio.GetListTable(fecha.ToString());
            customdatagridview1.DataSource = list;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txt_cliente.Text))
            {
                List<Servicio> list = CNServicio.GetListTable(txt_cliente.Text.Trim());
                customdatagridview1.DataSource = list;
            }
            else
            {
                customdatagridview1.DataSource = CNServicio.GetListTable();
            }
        }

        private void txt_cod_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_cod.Text))
            {
                List<Servicio> list = CNServicio.GetListTableCod(txt_cod.Text.Trim());
                customdatagridview1.DataSource = list;
            }
            else
            {
                customdatagridview1.DataSource = CNServicio.GetListTable();
            }
        }

        private void customdatagridview1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                int w = (int)(Properties.Resources.btn_edit.Width * 0.90f);
                var h = (int)(Properties.Resources.btn_edit.Height * 0.90f);
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.btn_edit, new System.Drawing.Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void customdatagridview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                if (customdatagridview1.Columns[e.ColumnIndex].Name == "Cl_Edit")
                {
                    string codigo = customdatagridview1.Rows[index].Cells["Cl_codigo"].Value.ToString();

                    Servicio servicio = CNServicio.GetServicioByCode(codigo);



                    if (servicio != null)
                    {
                        Frm_Editar frm_Editar = new Frm_Editar(servicio);

                        Point panelScreenPos = this.PointToScreen(Point.Empty);

                        int centerX = panelScreenPos.X + (this.Width - frm_Editar.Width) / 2;
                        int centerY = panelScreenPos.Y + (this.Height - frm_Editar.Height) / 2;

                        frm_Editar.StartPosition = FormStartPosition.Manual;
                        frm_Editar.Location = new Point(centerX, centerY);
                        frm_Editar.ShowDialog();
                    }

                }

            }
        }
    }
}
