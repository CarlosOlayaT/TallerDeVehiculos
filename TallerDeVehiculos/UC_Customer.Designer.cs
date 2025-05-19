namespace CapaPresentacion
{
    partial class UC_Customer
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            roundedPanel1 = new CapaPresentacion.ComponentsUX.RoundedPanel();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            lbl_customers = new Label();
            roundedPanel3 = new CapaPresentacion.ComponentsUX.RoundedPanel();
            pictureBox1 = new PictureBox();
            txt_search = new TextBox();
            panel6 = new Panel();
            customdatagridview1 = new CapaPresentacion.ComponentsUX.Customdatagridview();
            Check = new DataGridViewCheckBoxColumn();
            Cl_Cedula = new DataGridViewTextBoxColumn();
            Cl_Names = new DataGridViewTextBoxColumn();
            Cl_Email = new DataGridViewTextBoxColumn();
            Cl_Telf = new DataGridViewTextBoxColumn();
            panel7 = new Panel();
            panel8 = new Panel();
            roundedPanel2 = new CapaPresentacion.ComponentsUX.RoundedPanel();
            roundedLabel1 = new CapaPresentacion.ComponentsUX.RoundedLabel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel4.SuspendLayout();
            roundedPanel1.SuspendLayout();
            panel5.SuspendLayout();
            roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            roundedPanel1.Location = new Point(592, 9);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Radius.All = 1;
            roundedPanel1.Radius.BottomLeft = 1;
            roundedPanel1.Radius.BottomRight = 1;
            roundedPanel1.Radius.TopLeft = 1;
            roundedPanel1.Radius.TopRight = 1;
            roundedPanel1.Size = new Size(175, 49);
            roundedPanel1.StateColor = Color.Transparent;
            roundedPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Roboto", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(10, 16, 21);
            label2.Location = new Point(31, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 49);
            label2.TabIndex = 0;
            label2.Text = "New Customer";
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
            label3.Size = new Size(31, 49);
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
            label1.Text = "Customers";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.Controls.Add(lbl_customers);
            panel5.Controls.Add(roundedPanel3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(35, 86);
            panel5.Name = "panel5";
            panel5.Size = new Size(773, 59);
            panel5.TabIndex = 4;
            panel5.Paint += panel5_Paint;
            // 
            // lbl_customers
            // 
            lbl_customers.Dock = DockStyle.Left;
            lbl_customers.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_customers.ForeColor = Color.White;
            lbl_customers.Location = new Point(0, 0);
            lbl_customers.Name = "lbl_customers";
            lbl_customers.Size = new Size(286, 59);
            lbl_customers.TabIndex = 1;
            lbl_customers.Text = "All Customer(10)";
            lbl_customers.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roundedPanel3
            // 
            roundedPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.Controls.Add(pictureBox1);
            roundedPanel3.Controls.Add(txt_search);
            roundedPanel3.Location = new Point(485, 9);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Radius.All = 20;
            roundedPanel3.Radius.BottomLeft = 20;
            roundedPanel3.Radius.BottomRight = 20;
            roundedPanel3.Radius.TopLeft = 20;
            roundedPanel3.Radius.TopRight = 20;
            roundedPanel3.Size = new Size(282, 38);
            roundedPanel3.StateColor = Color.FromArgb(30, 39, 43);
            roundedPanel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(15, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txt_search
            // 
            txt_search.BackColor = Color.FromArgb(30, 39, 43);
            txt_search.BorderStyle = BorderStyle.None;
            txt_search.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_search.ForeColor = Color.White;
            txt_search.Location = new Point(43, 9);
            txt_search.MaximumSize = new Size(217, 25);
            txt_search.MinimumSize = new Size(217, 25);
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "Search...";
            txt_search.Size = new Size(217, 25);
            txt_search.TabIndex = 0;
            txt_search.TextChanged += textBox1_TextChanged;
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(30, 39, 43);
            dataGridViewCellStyle5.Font = new Font("Roboto", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            customdatagridview1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            customdatagridview1.ColumnHeadersHeight = 40;
            customdatagridview1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            customdatagridview1.Columns.AddRange(new DataGridViewColumn[] { Check, Cl_Cedula, Cl_Names, Cl_Email, Cl_Telf });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(10, 16, 21);
            dataGridViewCellStyle6.Font = new Font("Roboto", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(10, 16, 21);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            customdatagridview1.DefaultCellStyle = dataGridViewCellStyle6;
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
            // 
            // Check
            // 
            Check.FillWeight = 15F;
            Check.HeaderText = "";
            Check.Name = "Check";
            // 
            // Cl_Cedula
            // 
            Cl_Cedula.HeaderText = "Cedula";
            Cl_Cedula.Name = "Cl_Cedula";
            Cl_Cedula.ReadOnly = true;
            // 
            // Cl_Names
            // 
            Cl_Names.HeaderText = "Nombres y Apellidos";
            Cl_Names.Name = "Cl_Names";
            Cl_Names.ReadOnly = true;
            // 
            // Cl_Email
            // 
            Cl_Email.HeaderText = "Email";
            Cl_Email.Name = "Cl_Email";
            Cl_Email.ReadOnly = true;
            // 
            // Cl_Telf
            // 
            Cl_Telf.HeaderText = "Telefono";
            Cl_Telf.Name = "Cl_Telf";
            Cl_Telf.ReadOnly = true;
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
            // UC_Customer
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
            Name = "UC_Customer";
            Size = new Size(843, 743);
            panel4.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private CapaPresentacion.ComponentsUX.RoundedPanel roundedPanel3;
        private PictureBox pictureBox1;
        private TextBox txt_search;
        private Label lbl_customers;
        private DataGridViewCheckBoxColumn Check;
        private DataGridViewTextBoxColumn Cl_Cedula;
        private DataGridViewTextBoxColumn Cl_Names;
        private DataGridViewTextBoxColumn Cl_Email;
        private DataGridViewTextBoxColumn Cl_Telf;
    }
}