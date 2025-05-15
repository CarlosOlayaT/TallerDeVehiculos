
using CapaPresentacion;
using CapaPresentacion.ComponentsUI;
using System;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            int w = (int)(Screen.FromControl(this).WorkingArea.Width * 0.56);
            int h = (int)(Screen.FromControl(this).WorkingArea.Height * 0.74);
            //Debug.WriteLine($"{w},{h}");
            this.Size = new Size(w, h);
            //Pn_Menu.Size = new Size((int)(this.Size.Width * 0.22), this.Size.Height);
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
            Rectangle workingArea = Screen.FromControl(this).WorkingArea;
            this.Location = workingArea.Location;
            this.Size = workingArea.Size;

            Pb_maximizar.Visible = false;
            Pb_Restaurar.Visible = true;
        }

        private void Pb_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            int w = (int)(Screen.FromControl(this).WorkingArea.Width * 0.56);
            int h = (int)(Screen.FromControl(this).WorkingArea.Height * 0.74);
            this.Size = new Size(w, h); // o el tamaño que tenías antes
            this.CenterToScreen(); // opcional, para centrarlo

            Pb_maximizar.Visible = true;
            Pb_Restaurar.Visible = false;

        }

        private void Apn_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private async void iconsModernButtons1_UseClicked(object sender, EventArgs e)
        {
            defaulticons();
            IcBtn_Dashboard.ImageIcon = CapaPresentacion.Properties.Resources.home2;

            changeStyle(IcBtn_Dashboard, new UC_DashBoard());

        }


        private void iconsModernButtons2_UseClicked(object sender, EventArgs e)
        {
            defaulticons();
            IcBtn_mechanic.ImageIcon = CapaPresentacion.Properties.Resources.mechanic2;
            changeStyle(IcBtn_mechanic, new UC_Mechanic());
        }

        private void iconsModernButtons3_UseClicked(object sender, EventArgs e)
        {
            defaulticons();
            IcBtn_customer.ImageIcon = CapaPresentacion.Properties.Resources.Custome2;
            changeStyle(IcBtn_customer, new UC_Customer());
        }

        private void iconsModernButtons4_UseClicked(object sender, EventArgs e)
        {
            defaulticons();
            IcBtn_wrench.ImageIcon = CapaPresentacion.Properties.Resources.wrench2;
            changeStyle(IcBtn_wrench, new UC_Service());
        }
        private void changeStyle(IconsModernButtons iconsModernButtons, UserControl control)
        {
            iconsModernButtons.ForeColor = Color.FromArgb(10, 16, 21);
            iconsModernButtons.BackgroundImage = CapaPresentacion.Properties.Resources.Rectangle_3;
            Pn_Body.SuspendLayout(); // Detener diseño temporalmente
            Pn_Body.Controls.Clear();

            control.Dock = DockStyle.Fill;
            Pn_Body.Controls.Add(control);
            Pn_Body.ResumeLayout();

        }
        private void defaulticons()
        {
            IconsModernButtons[] icons = { IcBtn_customer, IcBtn_Dashboard, IcBtn_mechanic, IcBtn_wrench };
            foreach (var icon in icons)
            {
                icon.BackgroundImage = null;
                icon.ForeColor = Color.FromArgb(214, 251, 210);
            }
            IcBtn_customer.ImageIcon = CapaPresentacion.Properties.Resources.customer;
            IcBtn_Dashboard.ImageIcon = CapaPresentacion.Properties.Resources.home;
            IcBtn_mechanic.ImageIcon = CapaPresentacion.Properties.Resources.mechanic;
            IcBtn_wrench.ImageIcon = CapaPresentacion.Properties.Resources.wrench;
        }

    }
}
