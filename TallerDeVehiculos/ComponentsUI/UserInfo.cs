using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.ComponentsUI
{
    public partial class UserInfo : UserControl
    {
        private int _radius = 14;

        [Category("UserData")]
        public Image BackgroundImagePanel
        {
            get { return this.BackgroundImage; }
            set { this.BackgroundImage = value; }
        }


        [Category("UserData")]
        public int Radius
        {
            get { return _radius; }
            set
            {
                _radius = value;
                RedondearEsquinas(pictureBox1, _radius); // <-- Se actualiza cada vez que cambie
                pictureBox1.Invalidate();
            }
        }
        public UserInfo()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            RedondearEsquinas(pictureBox1, _radius);
        }

        public void RedondearEsquinas(PictureBox pictureBox, int radio)
        {
            Rectangle bounds = pictureBox.ClientRectangle;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, radio, radio, 180, 90); // esquina superior izquierda
            path.AddArc(bounds.Right - radio, bounds.Y, radio, radio, 270, 90); // esquina superior derecha
            path.AddArc(bounds.Right - radio, bounds.Bottom - radio, radio, radio, 0, 90); // inferior derecha
            path.AddArc(bounds.X, bounds.Bottom - radio, radio, radio, 90, 90); // inferior izquierda
            path.CloseAllFigures();

            pictureBox.Region = new Region(path);
        }

        [Category("UserData")]
        public Image UserPerfil
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }
        [Category("UserData")]
        public string UserPerfilName
        {
            get { return lbl_UserName.Text; }
            set
            {
                lbl_UserName.Text = value;
            }
        }
        [Category("UserData")]
        public string UserPerfilRol
        {
            get { return lbl_UserRol.Text; }
            set { lbl_UserRol.Text = value; }
        }
        [Category("UserData")]


        public Font UserNameFont
        {
            get { return lbl_UserName.Font; }
            set { lbl_UserName.Font = value; }
        }

        [Category("UserData")]
        public Font UserRolFont
        {
            get { return lbl_UserRol.Font; }
            set { lbl_UserRol.Font = value; }
        }


        [Category("UserData")]
        public Color UserNameForeColor
        {
            get { return lbl_UserName.ForeColor; }
            set { lbl_UserName.ForeColor = value; }
        }

        [Category("UserData")]
        public Color UserRolForeColor
        {
            get { return lbl_UserRol.ForeColor; }
            set { lbl_UserRol.ForeColor = value; }
        }

    }
}
