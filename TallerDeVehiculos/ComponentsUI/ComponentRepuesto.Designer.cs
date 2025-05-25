namespace CapaPresentacion.ComponentsUI
{
    partial class ComponentRepuesto
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
            lbl_name = new Label();
            lbl_cant = new Label();
            lbl_valor = new Label();
            lbl_subt = new Label();
            lbl_delete = new Label();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name.Location = new Point(-2, 4);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(39, 14);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "label1";
            // 
            // lbl_cant
            // 
            lbl_cant.AutoSize = true;
            lbl_cant.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cant.Location = new Point(94, 4);
            lbl_cant.Name = "lbl_cant";
            lbl_cant.Size = new Size(39, 14);
            lbl_cant.TabIndex = 1;
            lbl_cant.Text = "label2";
            // 
            // lbl_valor
            // 
            lbl_valor.AutoSize = true;
            lbl_valor.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_valor.Location = new Point(170, 4);
            lbl_valor.Name = "lbl_valor";
            lbl_valor.Size = new Size(39, 14);
            lbl_valor.TabIndex = 2;
            lbl_valor.Text = "label3";
            // 
            // lbl_subt
            // 
            lbl_subt.AutoSize = true;
            lbl_subt.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_subt.Location = new Point(258, 4);
            lbl_subt.Name = "lbl_subt";
            lbl_subt.Size = new Size(39, 14);
            lbl_subt.TabIndex = 3;
            lbl_subt.Text = "label4";
            // 
            // lbl_delete
            // 
            lbl_delete.AutoSize = true;
            lbl_delete.Cursor = Cursors.Hand;
            lbl_delete.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_delete.Location = new Point(351, 4);
            lbl_delete.Name = "lbl_delete";
            lbl_delete.Size = new Size(50, 14);
            lbl_delete.TabIndex = 4;
            lbl_delete.Text = "Eliminar";
            lbl_delete.MouseEnter += lbl_delete_MouseEnter;
            lbl_delete.MouseLeave += lbl_delete_MouseLeave;
            // 
            // ComponentRepuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(lbl_delete);
            Controls.Add(lbl_subt);
            Controls.Add(lbl_valor);
            Controls.Add(lbl_cant);
            Controls.Add(lbl_name);
            Name = "ComponentRepuesto";
            Size = new Size(399, 22);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private Label lbl_cant;
        private Label lbl_valor;
        private Label lbl_subt;
        private Label lbl_delete;
    }
}
