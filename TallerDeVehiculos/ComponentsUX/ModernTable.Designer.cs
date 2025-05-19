
using CapaPresentacion.ComponentsUX;

namespace CapaPresentacion.ComponentsUX
{
    partial class ModernTable
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            alignedPanel1 = new AlignedPanel();
            label1 = new Label();
            panel7 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            customdatagridview1 = new Customdatagridview();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            roundedPanel1 = new RoundedPanel();
            alignedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customdatagridview1).BeginInit();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // alignedPanel1
            // 
            alignedPanel1.BackColor = Color.Transparent;
            alignedPanel1.BackgroundColor = Color.Transparent;
            alignedPanel1.Controls.Add(label1);
            alignedPanel1.Dock = DockStyle.Fill;
            alignedPanel1.Location = new Point(0, 0);
            alignedPanel1.Name = "alignedPanel1";
            alignedPanel1.Radius = 1;
            alignedPanel1.Size = new Size(777, 62);
            alignedPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 62);
            panel7.Name = "panel7";
            panel7.Size = new Size(2, 440);
            panel7.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(775, 62);
            panel5.Name = "panel5";
            panel5.Size = new Size(2, 440);
            panel5.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 502);
            panel6.Name = "panel6";
            panel6.Size = new Size(777, 32);
            panel6.TabIndex = 6;
            // 
            // customdatagridview1
            // 
            customdatagridview1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customdatagridview1.BorderStyle = BorderStyle.None;
            customdatagridview1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            customdatagridview1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            customdatagridview1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            customdatagridview1.ColumnHeadersHeight = 35;
            customdatagridview1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            customdatagridview1.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5, Column6 });
            customdatagridview1.Dock = DockStyle.Fill;
            customdatagridview1.EnableHeadersVisualStyles = false;
            customdatagridview1.Location = new Point(0, 62);
            customdatagridview1.MultiSelect = false;
            customdatagridview1.Name = "customdatagridview1";
            customdatagridview1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            customdatagridview1.RowHeadersVisible = false;
            customdatagridview1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            customdatagridview1.Size = new Size(777, 472);
            customdatagridview1.TabIndex = 4;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Column6";
            Column6.Name = "Column6";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(alignedPanel1);
            roundedPanel1.Dock = DockStyle.Top;
            roundedPanel1.Location = new Point(0, 0);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Radius.All = 1;
            roundedPanel1.Radius.BottomLeft = 1;
            roundedPanel1.Radius.BottomRight = 1;
            roundedPanel1.Radius.TopLeft = 1;
            roundedPanel1.Radius.TopRight = 1;
            roundedPanel1.Size = new Size(777, 62);
            roundedPanel1.StateColor = SystemColors.WindowFrame;
            roundedPanel1.TabIndex = 0;
            // 
            // ModernTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(customdatagridview1);
            Controls.Add(roundedPanel1);
            Name = "ModernTable";
            Size = new Size(777, 534);
            alignedPanel1.ResumeLayout(false);
            alignedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customdatagridview1).EndInit();
            roundedPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AlignedPanel alignedPanel1;
        private Panel panel7;
        private Panel panel5;
        private Panel panel6;
        private Customdatagridview customdatagridview1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private RoundedPanel roundedPanel1;
        private Label label1;
    }
}
