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
            lbl_UserRol = new Label();
            lbl_UserName = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_UserRol
            // 
            lbl_UserRol.AutoSize = true;
            lbl_UserRol.Location = new Point(61, 37);
            lbl_UserRol.Name = "lbl_UserRol";
            lbl_UserRol.Size = new Size(38, 15);
            lbl_UserRol.TabIndex = 4;
            lbl_UserRol.Text = "label2";
            // 
            // lbl_UserName
            // 
            lbl_UserName.AutoSize = true;
            lbl_UserName.Font = new Font("Segoe UI", 10F);
            lbl_UserName.Location = new Point(61, 11);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(45, 19);
            lbl_UserName.TabIndex = 2;
            lbl_UserName.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(13, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // UserInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lbl_UserRol);
            Controls.Add(lbl_UserName);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "UserInfo";
            Size = new Size(195, 65);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_UserRol;
        private Label lbl_UserName;
        private PictureBox pictureBox1;
    }
}
