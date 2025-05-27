namespace CapaPresentacion
{
    partial class UC_Service
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Service));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            roundedPanel1 = new ComponentsUX.RoundedPanel();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            roundedPanel5 = new ComponentsUX.RoundedPanel();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            roundedPanel4 = new ComponentsUX.RoundedPanel();
            txt_cliente = new TextBox();
            label5 = new Label();
            roundedPanel3 = new ComponentsUX.RoundedPanel();
            txt_cod = new TextBox();
            label4 = new Label();
            panel6 = new Panel();
            customdatagridview1 = new ComponentsUX.Customdatagridview();
            Cl_Codigo = new DataGridViewTextBoxColumn();
            Cl_cliente = new DataGridViewTextBoxColumn();
            Cl_mech = new DataGridViewTextBoxColumn();
            Cl_date = new DataGridViewTextBoxColumn();
            Cl_placa = new DataGridViewTextBoxColumn();
            Cl_total = new DataGridViewTextBoxColumn();
            Cl_Edit = new DataGridViewImageColumn();
            panel7 = new Panel();
            panel8 = new Panel();
            roundedPanel2 = new ComponentsUX.RoundedPanel();
            roundedLabel1 = new ComponentsUX.RoundedLabel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel4.SuspendLayout();
            roundedPanel1.SuspendLayout();
            panel5.SuspendLayout();
            roundedPanel5.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customdatagridview1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(35, 743);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(808, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(35, 743);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(35, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(773, 18);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(roundedPanel1);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(35, 18);
            panel4.Name = "panel4";
            panel4.Size = new Size(773, 68);
            panel4.TabIndex = 3;
            panel4.Paint += panel5_Paint;
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.BackgroundImage = Properties.Resources.Rectangle_3;
            roundedPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Location = new Point(527, 9);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Radius.All = 1;
            roundedPanel1.Radius.BottomLeft = 1;
            roundedPanel1.Radius.BottomRight = 1;
            roundedPanel1.Radius.TopLeft = 1;
            roundedPanel1.Radius.TopRight = 1;
            roundedPanel1.Size = new Size(243, 49);
            roundedPanel1.StateColor = Color.Transparent;
            roundedPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Roboto", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(10, 16, 21);
            label2.Location = new Point(35, 0);
            label2.Name = "label2";
            label2.Size = new Size(208, 49);
            label2.TabIndex = 0;
            label2.Text = "New Mantenimiento";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Cursor = Cursors.Hand;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Roboto", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(10, 16, 21);
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(35, 49);
            label3.TabIndex = 1;
            label3.Text = "+";
            label3.TextAlign = ContentAlignment.MiddleRight;
            label3.Click += label2_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Roboto", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(286, 68);
            label1.TabIndex = 0;
            label1.Text = "Services";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.Controls.Add(roundedPanel5);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(roundedPanel4);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(roundedPanel3);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(35, 86);
            panel5.Name = "panel5";
            panel5.Size = new Size(773, 59);
            panel5.TabIndex = 4;
            panel5.Paint += panel5_Paint;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.Transparent;
            roundedPanel5.Controls.Add(dateTimePicker1);
            roundedPanel5.Location = new Point(524, 17);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Radius.All = 5;
            roundedPanel5.Radius.BottomLeft = 5;
            roundedPanel5.Radius.BottomRight = 5;
            roundedPanel5.Radius.TopLeft = 5;
            roundedPanel5.Radius.TopRight = 5;
            roundedPanel5.Size = new Size(157, 23);
            roundedPanel5.StateColor = Color.FromArgb(30, 39, 43);
            roundedPanel5.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.Transparent;
            dateTimePicker1.Cursor = Cursors.Hand;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(3, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Roboto", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(478, 0);
            label6.Name = "label6";
            label6.Size = new Size(135, 59);
            label6.TabIndex = 6;
            label6.Text = "Fecha";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.Transparent;
            roundedPanel4.Controls.Add(txt_cliente);
            roundedPanel4.Location = new Point(324, 17);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Radius.All = 5;
            roundedPanel4.Radius.BottomLeft = 5;
            roundedPanel4.Radius.BottomRight = 5;
            roundedPanel4.Radius.TopLeft = 5;
            roundedPanel4.Radius.TopRight = 5;
            roundedPanel4.Size = new Size(141, 23);
            roundedPanel4.StateColor = Color.FromArgb(30, 39, 43);
            roundedPanel4.TabIndex = 5;
            // 
            // txt_cliente
            // 
            txt_cliente.BackColor = Color.FromArgb(30, 39, 43);
            txt_cliente.BorderStyle = BorderStyle.None;
            txt_cliente.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_cliente.ForeColor = Color.White;
            txt_cliente.Location = new Point(0, 5);
            txt_cliente.MaximumSize = new Size(217, 25);
            txt_cliente.Name = "txt_cliente";
            txt_cliente.Size = new Size(138, 15);
            txt_cliente.TabIndex = 2;
            txt_cliente.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Roboto", 10F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(270, 0);
            label5.Name = "label5";
            label5.Size = new Size(135, 59);
            label5.TabIndex = 4;
            label5.Text = "Cliente";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.Controls.Add(txt_cod);
            roundedPanel3.Location = new Point(121, 17);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Radius.All = 5;
            roundedPanel3.Radius.BottomLeft = 5;
            roundedPanel3.Radius.BottomRight = 5;
            roundedPanel3.Radius.TopLeft = 5;
            roundedPanel3.Radius.TopRight = 5;
            roundedPanel3.Size = new Size(141, 23);
            roundedPanel3.StateColor = Color.FromArgb(30, 39, 43);
            roundedPanel3.TabIndex = 3;
            // 
            // txt_cod
            // 
            txt_cod.BackColor = Color.FromArgb(30, 39, 43);
            txt_cod.BorderStyle = BorderStyle.None;
            txt_cod.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_cod.ForeColor = Color.White;
            txt_cod.Location = new Point(0, 5);
            txt_cod.MaximumSize = new Size(217, 25);
            txt_cod.Name = "txt_cod";
            txt_cod.Size = new Size(138, 15);
            txt_cod.TabIndex = 2;
            txt_cod.TextChanged += txt_cod_TextChanged;
            // 
            // label4
            // 
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Roboto", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(135, 59);
            label4.TabIndex = 1;
            label4.Text = "Buscar por Codigo";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel6.BackColor = Color.Transparent;
            panel6.BackgroundImage = Properties.Resources.Rectangle_12;
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Controls.Add(customdatagridview1);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(roundedPanel2);
            panel6.Controls.Add(roundedLabel1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(35, 166);
            panel6.Name = "panel6";
            panel6.Size = new Size(773, 547);
            panel6.TabIndex = 5;
            // 
            // customdatagridview1
            // 
            customdatagridview1.AllowUserToAddRows = false;
            customdatagridview1.AllowUserToDeleteRows = false;
            customdatagridview1.AllowUserToResizeColumns = false;
            customdatagridview1.AllowUserToResizeRows = false;
            customdatagridview1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customdatagridview1.BackgroundColor = Color.FromArgb(10, 16, 21);
            customdatagridview1.BorderStyle = BorderStyle.None;
            customdatagridview1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            customdatagridview1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 39, 43);
            dataGridViewCellStyle1.Font = new Font("Roboto", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            customdatagridview1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            customdatagridview1.ColumnHeadersHeight = 40;
            customdatagridview1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            customdatagridview1.Columns.AddRange(new DataGridViewColumn[] { Cl_Codigo, Cl_cliente, Cl_mech, Cl_date, Cl_placa, Cl_total, Cl_Edit });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(10, 16, 21);
            dataGridViewCellStyle3.Font = new Font("Roboto", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(10, 16, 21);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            customdatagridview1.DefaultCellStyle = dataGridViewCellStyle3;
            customdatagridview1.Dock = DockStyle.Fill;
            customdatagridview1.EnableHeadersVisualStyles = false;
            customdatagridview1.Location = new Point(1, 30);
            customdatagridview1.MultiSelect = false;
            customdatagridview1.Name = "customdatagridview1";
            customdatagridview1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            customdatagridview1.RowHeadersVisible = false;
            customdatagridview1.RowHeadersWidth = 45;
            customdatagridview1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            customdatagridview1.RowTemplate.Height = 38;
            customdatagridview1.RowTemplate.Resizable = DataGridViewTriState.False;
            customdatagridview1.Size = new Size(771, 484);
            customdatagridview1.TabIndex = 0;
            customdatagridview1.CellContentClick += customdatagridview1_CellContentClick;
            customdatagridview1.CellPainting += customdatagridview1_CellPainting;
            // 
            // Cl_Codigo
            // 
            Cl_Codigo.DataPropertyName = "codigo";
            Cl_Codigo.HeaderText = "Codigo";
            Cl_Codigo.Name = "Cl_Codigo";
            // 
            // Cl_cliente
            // 
            Cl_cliente.DataPropertyName = "cliente";
            Cl_cliente.HeaderText = "Cliente";
            Cl_cliente.Name = "Cl_cliente";
            Cl_cliente.ReadOnly = true;
            // 
            // Cl_mech
            // 
            Cl_mech.DataPropertyName = "mecanico";
            Cl_mech.HeaderText = "Mecanico";
            Cl_mech.Name = "Cl_mech";
            Cl_mech.ReadOnly = true;
            // 
            // Cl_date
            // 
            Cl_date.DataPropertyName = "Fecha";
            Cl_date.HeaderText = "Fecha";
            Cl_date.Name = "Cl_date";
            Cl_date.ReadOnly = true;
            // 
            // Cl_placa
            // 
            Cl_placa.DataPropertyName = "vehiculo";
            Cl_placa.HeaderText = "Placa";
            Cl_placa.Name = "Cl_placa";
            Cl_placa.ReadOnly = true;
            Cl_placa.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Cl_total
            // 
            Cl_total.DataPropertyName = "total";
            Cl_total.HeaderText = "Total";
            Cl_total.Name = "Cl_total";
            Cl_total.ReadOnly = true;
            // 
            // Cl_Edit
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(10, 16, 21);
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            Cl_Edit.DefaultCellStyle = dataGridViewCellStyle2;
            Cl_Edit.FillWeight = 25F;
            Cl_Edit.HeaderText = "";
            Cl_Edit.Image = Properties.Resources.Rectangle_5;
            Cl_Edit.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Cl_Edit.Name = "Cl_Edit";
            Cl_Edit.Resizable = DataGridViewTriState.False;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(772, 30);
            panel7.Name = "panel7";
            panel7.Size = new Size(1, 484);
            panel7.TabIndex = 4;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 30);
            panel8.Name = "panel8";
            panel8.Size = new Size(1, 484);
            panel8.TabIndex = 3;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Dock = DockStyle.Bottom;
            roundedPanel2.Location = new Point(0, 514);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Radius.All = 1;
            roundedPanel2.Radius.BottomLeft = 1;
            roundedPanel2.Radius.BottomRight = 1;
            roundedPanel2.Radius.TopLeft = 1;
            roundedPanel2.Radius.TopRight = 1;
            roundedPanel2.Size = new Size(773, 33);
            roundedPanel2.StateColor = Color.Transparent;
            roundedPanel2.TabIndex = 2;
            // 
            // roundedLabel1
            // 
            roundedLabel1.Align = ContentAlignment.MiddleLeft;
            roundedLabel1.BackColor = Color.Transparent;
            roundedLabel1.Dock = DockStyle.Top;
            roundedLabel1.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedLabel1.ForeColor = Color.White;
            roundedLabel1.Location = new Point(0, 0);
            roundedLabel1.Margin = new Padding(5);
            roundedLabel1.Name = "roundedLabel1";
            roundedLabel1.Radius = 1;
            roundedLabel1.Size = new Size(773, 30);
            roundedLabel1.StateColor = Color.Transparent;
            roundedLabel1.TabIndex = 1;
            roundedLabel1.Texts = "";
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(35, 713);
            panel9.Name = "panel9";
            panel9.Size = new Size(773, 30);
            panel9.TabIndex = 6;
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(35, 145);
            panel10.Name = "panel10";
            panel10.Size = new Size(773, 21);
            panel10.TabIndex = 7;
            // 
            // UC_Service
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel6);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_Service";
            Size = new Size(843, 743);
            panel4.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            roundedPanel5.ResumeLayout(false);
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customdatagridview1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private CapaPresentacion.ComponentsUX.RoundedPanel roundedPanel1;
        private Label label2;
        private Label label3;
        private Panel panel6;
        private CapaPresentacion.ComponentsUX.Customdatagridview customdatagridview1;
        private Panel panel7;
        private Panel panel8;
        private CapaPresentacion.ComponentsUX.RoundedPanel roundedPanel2;
        private CapaPresentacion.ComponentsUX.RoundedLabel roundedLabel1;
        private Panel panel9;
        private Panel panel10;
        private Label label4;
        private ComponentsUX.RoundedPanel roundedPanel3;
        private TextBox txt_cod;
        private ComponentsUX.RoundedPanel roundedPanel5;
        private Label label6;
        private ComponentsUX.RoundedPanel roundedPanel4;
        private TextBox txt_cliente;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn Cl_Codigo;
        private DataGridViewTextBoxColumn Cl_cliente;
        private DataGridViewTextBoxColumn Cl_mech;
        private DataGridViewTextBoxColumn Cl_date;
        private DataGridViewTextBoxColumn Cl_placa;
        private DataGridViewTextBoxColumn Cl_total;
        private DataGridViewImageColumn Cl_Edit;
    }
}