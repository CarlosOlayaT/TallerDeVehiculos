namespace CapaPresentacion.ComponentsUI
{
    partial class IconsModernButtons
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
            roundedPanel1 = new Table.RoundedPanel();
            alignedPanel1 = new Table.AlignedPanel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            roundedPanel1.SuspendLayout();
            alignedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(alignedPanel1);
            roundedPanel1.Dock = DockStyle.Fill;
            roundedPanel1.Location = new Point(0, 0);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Radius.All = 15;
            roundedPanel1.Radius.BottomLeft = 15;
            roundedPanel1.Radius.BottomRight = 15;
            roundedPanel1.Radius.TopLeft = 15;
            roundedPanel1.Radius.TopRight = 15;
            roundedPanel1.Size = new Size(240, 65);
            roundedPanel1.StateColor = Color.White;
            roundedPanel1.TabIndex = 0;
            // 
            // alignedPanel1
            // 
            alignedPanel1.BackColor = Color.Transparent;
            alignedPanel1.BackgroundColor = Color.Transparent;
            alignedPanel1.ContentAlignment = ContentAlignment.MiddleLeft;
            alignedPanel1.Controls.Add(label1);
            alignedPanel1.Controls.Add(pictureBox1);
            alignedPanel1.Controls.Add(panel1);
            alignedPanel1.Dock = DockStyle.Fill;
            alignedPanel1.Location = new Point(0, 0);
            alignedPanel1.Name = "alignedPanel1";
            alignedPanel1.Radius = 1;
            alignedPanel1.Size = new Size(240, 65);
            alignedPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 23);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(21, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(20, 38);
            panel1.TabIndex = 2;
            // 
            // IconsModernButtons
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(roundedPanel1);
            Name = "IconsModernButtons";
            Size = new Size(240, 65);
            roundedPanel1.ResumeLayout(false);
            alignedPanel1.ResumeLayout(false);
            alignedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Table.RoundedPanel roundedPanel1;
        private Table.AlignedPanel alignedPanel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
