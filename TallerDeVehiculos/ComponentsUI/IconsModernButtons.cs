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

    public partial class IconsModernButtons : UserControl
    {
        [Browsable(true)]
        public event EventHandler UseClicked;
        public IconsModernButtons()
        {
            InitializeComponent();
            this.Click += Clicked;
            this.pictureBox1.Click += Clicked;
            this.label1.Click += Clicked;
            this.alignedPanel1.Click += Clicked;
            this.panel1.Click += Clicked;
            this.DoubleBuffered =true;
        }



        [Category("Botones Modernos")]
        public Image ImageIcon
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }

        }

        [Category("Botones Modernos")]
        public string TextoIngresado
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        [Category("Botones Modernos")]
        public Color BackgroundColor
        {
            get { return roundedPanel1.StateColor; }
            set { roundedPanel1.StateColor = value; }

        }
        private void Clicked(object sender, EventArgs e)
        {
            UseClicked?.Invoke(this, e);
        }

    }
}
