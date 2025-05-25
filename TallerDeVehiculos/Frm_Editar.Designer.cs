namespace CapaPresentacion
{
    partial class Frm_Editar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            btn_cancel = new ComponentsUX.RoundedLabel();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(30, 39, 43);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Completado", "Esperando", "Cancelado" });
            comboBox1.Location = new Point(192, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 23);
            comboBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Roboto", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 67);
            label2.Name = "label2";
            label2.Size = new Size(176, 17);
            label2.TabIndex = 10;
            label2.Text = "Estado del mantenimiento";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Roboto", 15F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 20);
            label1.Name = "label1";
            label1.Size = new Size(323, 24);
            label1.TabIndex = 11;
            label1.Text = "Cambiar estado del mantenimiento";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Transparent;
            btn_cancel.Cursor = Cursors.Hand;
            btn_cancel.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancel.ForeColor = Color.FromArgb(32, 192, 98);
            btn_cancel.Location = new Point(154, 100);
            btn_cancel.Margin = new Padding(4);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Radius = 15;
            btn_cancel.Size = new Size(135, 28);
            btn_cancel.StateColor = Color.FromArgb(4, 53, 25);
            btn_cancel.TabIndex = 20;
            btn_cancel.Texts = "Listo";
            btn_cancel.UseClicked += roundedLabel1_UseClicked;
            btn_cancel.MouseEntering += btn_create_MouseEntering;
            btn_cancel.MouseLeaving += btn_create_MouseLeaving;
            // 
            // Frm_Editar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 39, 43);
            ClientSize = new Size(471, 141);
            Controls.Add(btn_cancel);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Editar";
            Text = "Frm_Editar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private ComponentsUX.RoundedLabel btn_cancel;
    }
}