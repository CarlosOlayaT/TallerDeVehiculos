

namespace CapaPresentacion
{
    partial class Frm_NewMechanic
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            panel3 = new Panel();
            btn_create = new Table.RoundedLabel();
            btn_cancel = new Table.RoundedLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 73);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Font = new Font("Roboto", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 20);
            label1.Name = "label1";
            label1.Size = new Size(455, 48);
            label1.TabIndex = 1;
            label1.Text = "Create new mechanic (profile)";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(640, 315);
            panel2.TabIndex = 6;
            panel2.Paint += panel1_Paint;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(30, 39, 43);
            numericUpDown1.BorderStyle = BorderStyle.None;
            numericUpDown1.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown1.ForeColor = Color.White;
            numericUpDown1.Location = new Point(46, 207);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(58, 22);
            numericUpDown1.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(337, 72);
            label6.Name = "label6";
            label6.Size = new Size(123, 18);
            label6.TabIndex = 12;
            label6.Text = "Number of phone";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(30, 39, 43);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.CharacterCasing = CharacterCasing.Lower;
            textBox5.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(337, 96);
            textBox5.Margin = new Padding(10);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "   Insert number phone";
            textBox5.Size = new Size(252, 23);
            textBox5.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(337, 15);
            label7.Name = "label7";
            label7.Size = new Size(78, 18);
            label7.TabIndex = 10;
            label7.Text = "Last name";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(30, 39, 43);
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.CharacterCasing = CharacterCasing.Lower;
            textBox6.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.ForeColor = Color.White;
            textBox6.Location = new Point(337, 39);
            textBox6.Margin = new Padding(10);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "   Insert last name";
            textBox6.Size = new Size(252, 23);
            textBox6.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(46, 186);
            label4.Name = "label4";
            label4.Size = new Size(142, 18);
            label4.TabIndex = 8;
            label4.Text = "Years of experience";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(46, 129);
            label5.Name = "label5";
            label5.Size = new Size(81, 18);
            label5.TabIndex = 6;
            label5.Text = "Especiality";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(30, 39, 43);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.CharacterCasing = CharacterCasing.Lower;
            textBox4.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(46, 153);
            textBox4.Margin = new Padding(10);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "   Insert especiality";
            textBox4.Size = new Size(252, 23);
            textBox4.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(46, 72);
            label3.Name = "label3";
            label3.Size = new Size(33, 18);
            label3.TabIndex = 4;
            label3.Text = "DNI";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(30, 39, 43);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.CharacterCasing = CharacterCasing.Lower;
            textBox2.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(46, 96);
            textBox2.Margin = new Padding(10);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "   Insert DNI";
            textBox2.Size = new Size(252, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(46, 15);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 2;
            label2.Text = "Name";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 39, 43);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.CharacterCasing = CharacterCasing.Lower;
            textBox1.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(46, 39);
            textBox1.Margin = new Padding(10);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "   Insert name";
            textBox1.Size = new Size(252, 23);
            textBox1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(btn_create);
            panel3.Controls.Add(btn_cancel);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 388);
            panel3.Name = "panel3";
            panel3.Size = new Size(640, 58);
            panel3.TabIndex = 7;
            // 
            // btn_create
            // 
            btn_create.Cursor = Cursors.Hand;
            btn_create.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_create.ForeColor = Color.FromArgb(32, 192, 98);
            btn_create.Location = new Point(536, 15);
            btn_create.Margin = new Padding(4);
            btn_create.Name = "btn_create";
            btn_create.Radius = 20;
            btn_create.Size = new Size(91, 28);
            btn_create.StateColor = Color.FromArgb(4, 53, 25);
            btn_create.TabIndex = 1;
            btn_create.Texts = "Crear";
            btn_create.MouseEntering += btn_create_MouseEntering;
            btn_create.MouseLeaving += btn_create_MouseLeaving;
            // 
            // btn_cancel
            // 
            btn_cancel.Cursor = Cursors.Hand;
            btn_cancel.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancel.ForeColor = Color.FromArgb(216, 64, 64);
            btn_cancel.Location = new Point(411, 15);
            btn_cancel.Margin = new Padding(4);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Radius = 20;
            btn_cancel.Size = new Size(91, 28);
            btn_cancel.StateColor = Color.FromArgb(89, 4, 4);
            btn_cancel.TabIndex = 0;
            btn_cancel.Texts = "Cancelar";
            btn_cancel.UseClicked += roundedLabel1_UseClicked;
            btn_cancel.MouseEntering += btn_cancel_MouseEntering;
            btn_cancel.MouseLeaving += btn_cancel_MouseLeaving;
            // 
            // Frm_NewMechanic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Rectangle_26;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(640, 446);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_NewMechanic";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Frm_NewMechanica";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Table.RoundedLabel btn_create;
        private Table.RoundedLabel btn_cancel;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private NumericUpDown numericUpDown1;
    }
}