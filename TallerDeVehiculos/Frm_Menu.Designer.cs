using CapaPresentacion.ComponentsUX;

namespace TallerDeVehiculos
{
    partial class Frm_Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            userInfo1 = new CapaPresentacion.ComponentsUI.UserInfo();
            Pn_Menu = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            alignedPanel4 = new AlignedPanel();
            IcBtn_Dashboard = new CapaPresentacion.ComponentsUI.IconsModernButtons();
            alignedPanel3 = new AlignedPanel();
            IcBtn_mechanic = new CapaPresentacion.ComponentsUI.IconsModernButtons();
            alignedPanel5 = new AlignedPanel();
            IcBtn_customer = new CapaPresentacion.ComponentsUI.IconsModernButtons();
            alignedPanel6 = new AlignedPanel();
            IcBtn_wrench = new CapaPresentacion.ComponentsUI.IconsModernButtons();
            alignedPanel2 = new AlignedPanel();
            pictureBox1 = new PictureBox();
            alignedPanel1 = new AlignedPanel();
            Pn_Content = new Panel();
            Pn_Body = new Panel();
            Apn_Title = new Panel();
            Pb_maximizar = new PictureBox();
            Pb_Restaurar = new PictureBox();
            Pb_Minimizar = new PictureBox();
            Pb_Close = new PictureBox();
            Pn_Menu.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            alignedPanel4.SuspendLayout();
            alignedPanel3.SuspendLayout();
            alignedPanel5.SuspendLayout();
            alignedPanel6.SuspendLayout();
            alignedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            alignedPanel1.SuspendLayout();
            Pn_Content.SuspendLayout();
            Apn_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pb_maximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Restaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Close).BeginInit();
            SuspendLayout();
            // 
            // userInfo1
            // 
            userInfo1.BackColor = Color.Transparent;
            userInfo1.BackgroundImage = CapaPresentacion.Properties.Resources.Rectangle_14;
            userInfo1.BackgroundImageLayout = ImageLayout.Stretch;
            userInfo1.BackgroundImagePanel = CapaPresentacion.Properties.Resources.Rectangle_14;
            userInfo1.Cursor = Cursors.Hand;
            userInfo1.Location = new Point(26, 0);
            userInfo1.Name = "userInfo1";
            userInfo1.Radius = 14;
            userInfo1.Size = new Size(184, 65);
            userInfo1.TabIndex = 0;
            userInfo1.UserNameFont = new Font("Roboto", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userInfo1.UserNameForeColor = Color.FromArgb(214, 251, 210);
            userInfo1.UserPerfil = CapaPresentacion.Properties.Resources.perfil;
            userInfo1.UserPerfilName = "Benito Camelo";
            userInfo1.UserPerfilRol = "Admin";
            userInfo1.UserRolFont = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userInfo1.UserRolForeColor = Color.FromArgb(141, 147, 151);
            // 
            // Pn_Menu
            // 
            Pn_Menu.BackColor = Color.FromArgb(10, 16, 21);
            Pn_Menu.Controls.Add(flowLayoutPanel1);
            Pn_Menu.Controls.Add(alignedPanel2);
            Pn_Menu.Controls.Add(alignedPanel1);
            Pn_Menu.Dock = DockStyle.Left;
            Pn_Menu.Location = new Point(0, 0);
            Pn_Menu.Name = "Pn_Menu";
            Pn_Menu.Size = new Size(237, 768);
            Pn_Menu.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(alignedPanel4);
            flowLayoutPanel1.Controls.Add(alignedPanel3);
            flowLayoutPanel1.Controls.Add(alignedPanel5);
            flowLayoutPanel1.Controls.Add(alignedPanel6);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 211);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(237, 451);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 24);
            panel1.TabIndex = 4;
            // 
            // alignedPanel4
            // 
            alignedPanel4.BackColor = Color.Transparent;
            alignedPanel4.BackgroundColor = Color.Transparent;
            alignedPanel4.ContentAlignment = ContentAlignment.MiddleCenter;
            alignedPanel4.Controls.Add(IcBtn_Dashboard);
            alignedPanel4.Location = new Point(3, 33);
            alignedPanel4.Name = "alignedPanel4";
            alignedPanel4.Radius = 1;
            alignedPanel4.Size = new Size(234, 77);
            alignedPanel4.TabIndex = 1;
            // 
            // IcBtn_Dashboard
            // 
            IcBtn_Dashboard.BackColor = Color.Transparent;
            IcBtn_Dashboard.BackgroundImageLayout = ImageLayout.Stretch;
            IcBtn_Dashboard.Cursor = Cursors.Hand;
            IcBtn_Dashboard.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IcBtn_Dashboard.ForeColor = Color.FromArgb(214, 251, 210);
            IcBtn_Dashboard.ImageIcon = (Image)resources.GetObject("IcBtn_Dashboard.ImageIcon");
            IcBtn_Dashboard.Location = new Point(18, 12);
            IcBtn_Dashboard.Name = "IcBtn_Dashboard";
            IcBtn_Dashboard.Size = new Size(198, 52);
            IcBtn_Dashboard.TabIndex = 0;
            IcBtn_Dashboard.TextoIngresado = "DashBoard";
            IcBtn_Dashboard.UseClicked += iconsModernButtons1_UseClicked;
            // 
            // alignedPanel3
            // 
            alignedPanel3.BackColor = Color.Transparent;
            alignedPanel3.BackgroundColor = Color.Transparent;
            alignedPanel3.ContentAlignment = ContentAlignment.MiddleCenter;
            alignedPanel3.Controls.Add(IcBtn_mechanic);
            alignedPanel3.Location = new Point(3, 116);
            alignedPanel3.Name = "alignedPanel3";
            alignedPanel3.Radius = 1;
            alignedPanel3.Size = new Size(234, 77);
            alignedPanel3.TabIndex = 0;
            // 
            // IcBtn_mechanic
            // 
            IcBtn_mechanic.BackColor = Color.Transparent;
            IcBtn_mechanic.BackgroundImageLayout = ImageLayout.Stretch;
            IcBtn_mechanic.Cursor = Cursors.Hand;
            IcBtn_mechanic.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IcBtn_mechanic.ForeColor = Color.FromArgb(214, 251, 210);
            IcBtn_mechanic.ImageIcon = (Image)resources.GetObject("IcBtn_mechanic.ImageIcon");
            IcBtn_mechanic.Location = new Point(18, 12);
            IcBtn_mechanic.Name = "IcBtn_mechanic";
            IcBtn_mechanic.Size = new Size(198, 52);
            IcBtn_mechanic.TabIndex = 1;
            IcBtn_mechanic.TextoIngresado = "Mechanic";
            IcBtn_mechanic.UseClicked += iconsModernButtons2_UseClicked;
            // 
            // alignedPanel5
            // 
            alignedPanel5.BackColor = Color.Transparent;
            alignedPanel5.BackgroundColor = Color.Transparent;
            alignedPanel5.ContentAlignment = ContentAlignment.MiddleCenter;
            alignedPanel5.Controls.Add(IcBtn_customer);
            alignedPanel5.Location = new Point(3, 199);
            alignedPanel5.Name = "alignedPanel5";
            alignedPanel5.Radius = 1;
            alignedPanel5.Size = new Size(234, 77);
            alignedPanel5.TabIndex = 2;
            // 
            // IcBtn_customer
            // 
            IcBtn_customer.BackColor = Color.Transparent;
            IcBtn_customer.BackgroundImageLayout = ImageLayout.Stretch;
            IcBtn_customer.Cursor = Cursors.Hand;
            IcBtn_customer.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IcBtn_customer.ForeColor = Color.FromArgb(214, 251, 210);
            IcBtn_customer.ImageIcon = (Image)resources.GetObject("IcBtn_customer.ImageIcon");
            IcBtn_customer.Location = new Point(18, 12);
            IcBtn_customer.Name = "IcBtn_customer";
            IcBtn_customer.Size = new Size(198, 52);
            IcBtn_customer.TabIndex = 1;
            IcBtn_customer.TextoIngresado = "Customer";
            IcBtn_customer.UseClicked += iconsModernButtons3_UseClicked;
            // 
            // alignedPanel6
            // 
            alignedPanel6.BackColor = Color.Transparent;
            alignedPanel6.BackgroundColor = Color.Transparent;
            alignedPanel6.ContentAlignment = ContentAlignment.MiddleCenter;
            alignedPanel6.Controls.Add(IcBtn_wrench);
            alignedPanel6.Location = new Point(3, 282);
            alignedPanel6.Name = "alignedPanel6";
            alignedPanel6.Radius = 1;
            alignedPanel6.Size = new Size(234, 77);
            alignedPanel6.TabIndex = 3;
            // 
            // IcBtn_wrench
            // 
            IcBtn_wrench.BackColor = Color.Transparent;
            IcBtn_wrench.BackgroundImageLayout = ImageLayout.Stretch;
            IcBtn_wrench.Cursor = Cursors.Hand;
            IcBtn_wrench.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IcBtn_wrench.ForeColor = Color.FromArgb(214, 251, 210);
            IcBtn_wrench.ImageIcon = (Image)resources.GetObject("IcBtn_wrench.ImageIcon");
            IcBtn_wrench.Location = new Point(18, 12);
            IcBtn_wrench.Name = "IcBtn_wrench";
            IcBtn_wrench.Size = new Size(198, 52);
            IcBtn_wrench.TabIndex = 1;
            IcBtn_wrench.TextoIngresado = "Service";
            IcBtn_wrench.UseClicked += iconsModernButtons4_UseClicked;
            // 
            // alignedPanel2
            // 
            alignedPanel2.BackColor = Color.Transparent;
            alignedPanel2.BackgroundColor = Color.Transparent;
            alignedPanel2.ContentAlignment = ContentAlignment.BottomCenter;
            alignedPanel2.Controls.Add(pictureBox1);
            alignedPanel2.Dock = DockStyle.Top;
            alignedPanel2.Location = new Point(0, 0);
            alignedPanel2.Name = "alignedPanel2";
            alignedPanel2.Radius = 1;
            alignedPanel2.Size = new Size(237, 211);
            alignedPanel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // alignedPanel1
            // 
            alignedPanel1.BackColor = Color.Transparent;
            alignedPanel1.BackgroundColor = Color.Transparent;
            alignedPanel1.ContentAlignment = ContentAlignment.TopCenter;
            alignedPanel1.Controls.Add(userInfo1);
            alignedPanel1.Dock = DockStyle.Bottom;
            alignedPanel1.Location = new Point(0, 662);
            alignedPanel1.Name = "alignedPanel1";
            alignedPanel1.Radius = 1;
            alignedPanel1.Size = new Size(237, 106);
            alignedPanel1.TabIndex = 0;
            // 
            // Pn_Content
            // 
            Pn_Content.BackgroundImage = CapaPresentacion.Properties.Resources.Fondo;
            Pn_Content.BackgroundImageLayout = ImageLayout.Stretch;
            Pn_Content.Controls.Add(Pn_Body);
            Pn_Content.Controls.Add(Apn_Title);
            Pn_Content.Dock = DockStyle.Fill;
            Pn_Content.Location = new Point(237, 0);
            Pn_Content.Name = "Pn_Content";
            Pn_Content.Size = new Size(843, 768);
            Pn_Content.TabIndex = 2;
            // 
            // Pn_Body
            // 
            Pn_Body.BackColor = Color.Transparent;
            Pn_Body.Dock = DockStyle.Fill;
            Pn_Body.Location = new Point(0, 25);
            Pn_Body.Name = "Pn_Body";
            Pn_Body.Size = new Size(843, 743);
            Pn_Body.TabIndex = 1;
            // 
            // Apn_Title
            // 
            Apn_Title.BackColor = Color.FromArgb(10, 16, 21);
            Apn_Title.Controls.Add(Pb_maximizar);
            Apn_Title.Controls.Add(Pb_Restaurar);
            Apn_Title.Controls.Add(Pb_Minimizar);
            Apn_Title.Controls.Add(Pb_Close);
            Apn_Title.Dock = DockStyle.Top;
            Apn_Title.Location = new Point(0, 0);
            Apn_Title.Name = "Apn_Title";
            Apn_Title.Size = new Size(843, 25);
            Apn_Title.TabIndex = 0;
            Apn_Title.MouseDown += Apn_Title_MouseDown;
            // 
            // Pb_maximizar
            // 
            Pb_maximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pb_maximizar.Image = (Image)resources.GetObject("Pb_maximizar.Image");
            Pb_maximizar.Location = new Point(789, 2);
            Pb_maximizar.Name = "Pb_maximizar";
            Pb_maximizar.Size = new Size(20, 20);
            Pb_maximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_maximizar.TabIndex = 3;
            Pb_maximizar.TabStop = false;
            Pb_maximizar.Click += Pb_maximizar_Click;
            // 
            // Pb_Restaurar
            // 
            Pb_Restaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pb_Restaurar.Image = (Image)resources.GetObject("Pb_Restaurar.Image");
            Pb_Restaurar.Location = new Point(789, 2);
            Pb_Restaurar.Name = "Pb_Restaurar";
            Pb_Restaurar.Size = new Size(20, 20);
            Pb_Restaurar.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_Restaurar.TabIndex = 4;
            Pb_Restaurar.TabStop = false;
            Pb_Restaurar.Click += Pb_Restaurar_Click;
            // 
            // Pb_Minimizar
            // 
            Pb_Minimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pb_Minimizar.Image = (Image)resources.GetObject("Pb_Minimizar.Image");
            Pb_Minimizar.Location = new Point(763, 2);
            Pb_Minimizar.Name = "Pb_Minimizar";
            Pb_Minimizar.Size = new Size(20, 20);
            Pb_Minimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_Minimizar.TabIndex = 2;
            Pb_Minimizar.TabStop = false;
            Pb_Minimizar.Click += pictureBox2_Click;
            // 
            // Pb_Close
            // 
            Pb_Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pb_Close.Image = (Image)resources.GetObject("Pb_Close.Image");
            Pb_Close.Location = new Point(815, 2);
            Pb_Close.Name = "Pb_Close";
            Pb_Close.Size = new Size(20, 20);
            Pb_Close.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_Close.TabIndex = 1;
            Pb_Close.TabStop = false;
            Pb_Close.Click += pictureBox1_Click;
            // 
            // Frm_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 768);
            Controls.Add(Pn_Content);
            Controls.Add(Pn_Menu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Pn_Menu.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            alignedPanel4.ResumeLayout(false);
            alignedPanel3.ResumeLayout(false);
            alignedPanel5.ResumeLayout(false);
            alignedPanel6.ResumeLayout(false);
            alignedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            alignedPanel1.ResumeLayout(false);
            Pn_Content.ResumeLayout(false);
            Apn_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pb_maximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Restaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Close).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CapaPresentacion.ComponentsUI.UserInfo userInfo1;
        private Panel Pn_Menu;
        private Panel Pn_Content;
        private AlignedPanel alignedPanel1;
        private PictureBox pictureBox1;
        private Panel Pn_Body;
        private AlignedPanel alignedPanel2;
        private CapaPresentacion.ComponentsUI.IconsModernButtons IcBtn_Dashboard;
        private FlowLayoutPanel flowLayoutPanel1;
        private AlignedPanel alignedPanel4;
        private AlignedPanel alignedPanel3;
        private CapaPresentacion.ComponentsUI.IconsModernButtons IcBtn_mechanic;
        private AlignedPanel alignedPanel5;
        private CapaPresentacion.ComponentsUI.IconsModernButtons IcBtn_customer;
        private AlignedPanel alignedPanel6;
        private CapaPresentacion.ComponentsUI.IconsModernButtons IcBtn_wrench;
        private Panel panel1;
        private Panel Apn_Title;
        private PictureBox Pb_maximizar;
        private PictureBox Pb_Restaurar;
        private PictureBox Pb_Minimizar;
        private PictureBox Pb_Close;
    }
}
