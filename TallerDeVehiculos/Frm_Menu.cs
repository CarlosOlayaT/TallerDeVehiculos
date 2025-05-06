
using CapaPresentacion.ComponentsUI;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace TallerDeVehiculos
{
    public partial class Frm_Menu : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int vMsg, int wParam, int lParam);

        public Frm_Menu()
        {
            InitializeComponent();
            
            int w = (int)(Screen.PrimaryScreen.WorkingArea.Width * 0.56);
            int h = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.74);
            //Debug.WriteLine($"{w},{h}");
            this.Size = new Size(w, h);
            Pn_Menu.Size = new Size((int)(this.Size.Width * 0.22), this.Size.Height);
        }
        private void PanelDegradado_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = Pn_Content.ClientRectangle;
            float angle = 100f;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.Empty, // Ignorado cuando se usa ColorBlend
                Color.Empty,
                angle))
            {
                ColorBlend blend = new ColorBlend();

                // Define colores en la escala (3 puntos: inicio, 75%, fin)
                blend.Colors = new Color[]
                {
                Color.FromArgb(0, 9, 4  ),    // Color inicial
                Color.FromArgb(10, 16, 21),    // Color inicial
                Color.FromArgb(32, 192, 98),     // Color final
                };

                // Posiciones relativas (0.0 a 1.0)
                blend.Positions = new float[]
                {
                    0.0f,
                    0.80f,
                    1.0f
                };

                brush.InterpolationColors = blend;

                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private void Pn_SubContent_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
            Pn_SubContent.ClientRectangle,
            Color.FromArgb(13, 162, 174, 180),    // Color inicial
            Color.FromArgb(13, 70, 76, 78),     // Color final
            LinearGradientMode.Vertical)) // Dirección del degradado
            {
                e.Graphics.FillRectangle(brush, Pn_SubContent.ClientRectangle);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Pb_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Pb_maximizar.Visible = false;
            Pb_Restaurar.Visible = true;
            this.Refresh();
        }

        private void Pb_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Pb_maximizar.Visible = true;
            Pb_Restaurar.Visible = false;
            this.Refresh();

        }

        private void Apn_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void iconsModernButtons1_Click(object sender, EventArgs e)
        {
            //if (sender is IconsModernButtons)
            //{
            //    IconsModernButtons? icono = sender as IconsModernButtons;

            //    if (icono != null)
            //    {
            //        icono.BackgroundColor = Color.FromArgb(32, 192, 98);
            //        icono.ForeColor = Color.FromArgb(10, 16, 21);

            //    }

            //}
        }

        private void iconsModernButtons1_UseClicked(object sender, EventArgs e)
        {
            defaulticons();
            IcBtn_Dashboard.ImageIcon = CapaPresentacion.Properties.Resources.home;

            changeStyle(IcBtn_Dashboard);

        }


        private void iconsModernButtons2_UseClicked(object sender, EventArgs e)
        {
            defaulticons();
            IcBtn_mechanic.ImageIcon = CapaPresentacion.Properties.Resources.mechanic2;
            changeStyle(IcBtn_mechanic);
        }

        private void iconsModernButtons3_UseClicked(object sender, EventArgs e)
        {
            defaulticons();
            IcBtn_customer.ImageIcon = CapaPresentacion.Properties.Resources.Custome2;
            changeStyle(IcBtn_customer);
        }

        private void iconsModernButtons4_UseClicked(object sender, EventArgs e)
        {
            defaulticons();
            IcBtn_wrench.ImageIcon = CapaPresentacion.Properties.Resources.wrench2;
            changeStyle(IcBtn_wrench);
        }
        private void changeStyle(IconsModernButtons iconsModernButtons)
        {
            iconsModernButtons.ForeColor = Color.FromArgb(10, 16, 21);
            iconsModernButtons.BackgroundColor = Color.FromArgb(32, 192, 98);

        }
        private void defaulticons()
        {
            IconsModernButtons[] icons = { IcBtn_customer, IcBtn_Dashboard, IcBtn_mechanic, IcBtn_wrench };
            foreach (var icon in icons)
            {
                icon.BackgroundColor = Color.Transparent;
                icon.ForeColor = Color.FromArgb(214, 251, 210);
            }
            IcBtn_customer.ImageIcon = CapaPresentacion.Properties.Resources.customer;
            IcBtn_Dashboard.ImageIcon = CapaPresentacion.Properties.Resources.home2;
            IcBtn_mechanic.ImageIcon = CapaPresentacion.Properties.Resources.mechanic;
            IcBtn_wrench.ImageIcon = CapaPresentacion.Properties.Resources.wrench;
        }

    }
}
