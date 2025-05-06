namespace CapaPresentacion.ComponentsUI
{
    partial class UserInfo
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfo));
            roundedPanel1 = new Table.RoundedPanel();
            lbl_UserRol = new Label();
            lbl_UserName = new Label();
            pictureBox1 = new PictureBox();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(lbl_UserRol);
            roundedPanel1.Controls.Add(lbl_UserName);
            roundedPanel1.Controls.Add(pictureBox1);
            roundedPanel1.Dock = DockStyle.Fill;
            roundedPanel1.Location = new Point(0, 0);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Radius.All = 15;
            roundedPanel1.Radius.BottomLeft = 15;
            roundedPanel1.Radius.BottomRight = 15;
            roundedPanel1.Radius.TopLeft = 15;
            roundedPanel1.Radius.TopRight = 15;
            roundedPanel1.Size = new Size(195, 65);
            roundedPanel1.StateColor = Color.White;
            roundedPanel1.TabIndex = 0;
            // 
            // lbl_UserRol
            // 
            lbl_UserRol.AutoSize = true;
            lbl_UserRol.Location = new Point(61, 38);
            lbl_UserRol.Name = "lbl_UserRol";
            lbl_UserRol.Size = new Size(38, 15);
            lbl_UserRol.TabIndex = 1;
            lbl_UserRol.Text = "label2";
            // 
            // lbl_UserName
            // 
            lbl_UserName.AutoSize = true;
            lbl_UserName.Font = new Font("Segoe UI", 10F);
            lbl_UserName.Location = new Point(61, 12);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(45, 19);
            lbl_UserName.TabIndex = 0;
            lbl_UserName.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // UserInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(roundedPanel1);
            Name = "UserInfo";
            Size = new Size(195, 65);
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Table.RoundedPanel roundedPanel1;
        private PictureBox pictureBox1;
        private Label lbl_UserRol;
        private Label lbl_UserName;
    }
}
