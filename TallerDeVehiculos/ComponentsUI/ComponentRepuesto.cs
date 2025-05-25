using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.ComponentsUI
{
    public partial class ComponentRepuesto : UserControl
    {

        //public float subtotal;
        [Browsable(true)]
        public event EventHandler ClickDeleted;
        public ComponentRepuesto()
        {
            InitializeComponent();
            this.lbl_delete.Click += Clicked;

        }
        public Repuesto repuesto = null;
        public ComponentRepuesto(Repuesto repuesto)
        {
            InitializeComponent();
            Nombre = repuesto._Nombre;
            Cantidad = $"Cant: {repuesto._Cantidad}";
            Valor = $"Valor Unit: ${repuesto._precio}";
            Subtotal = $"Subtotal: ${repuesto.subtotal}";
            this.repuesto = repuesto;
            this.lbl_delete.Click += Clicked;

        }

        [Category("Repuesto")]
        public string Nombre
        {
            get { return lbl_name.Text; }
            set { lbl_name.Text = value; }
        }




        [Category("Repuesto")]
        public string Cantidad
        {
            get { return lbl_cant.Text; }
            set { lbl_cant.Text = value; }
        }

        [Category("Repuesto")]
        public string Valor
        {
            get { return lbl_valor.Text; }
            set { lbl_valor.Text = value; }
        }

        [Category("Repuesto")]
        public string Subtotal
        {
            get { return lbl_subt.Text; }
            set { lbl_subt.Text = value; }
        }


        private void Clicked(object sender, EventArgs e)
        {
            ClickDeleted?.Invoke(this, e);
        }

        private void lbl_delete_MouseEnter(object sender, EventArgs e)
        {
            lbl_delete.ForeColor = Color.Blue;
        }

        private void lbl_delete_MouseLeave(object sender, EventArgs e)
        {
            lbl_delete.ForeColor = Color.Black;
        }
    }
}
