

namespace CapaPresentacion
{
    partial class Frm_NewCustomer
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
            label4 = new Label();
            txt_location = new TextBox();
            label6 = new Label();
            txt_phone = new TextBox();
            label7 = new Label();
            txt_lastname = new TextBox();
            label5 = new Label();
            txt_email = new TextBox();
            label3 = new Label();
            txt_dni = new TextBox();
            label2 = new Label();
            txt_name = new TextBox();
            panel3 = new Panel();
            btn_create = new ComponentsUX.RoundedLabel();
            btn_cancel = new ComponentsUX.RoundedLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            label1.Text = "Create new customer (profile)";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txt_location);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txt_phone);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txt_lastname);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txt_email);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_dni);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_name);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(640, 251);
            panel2.TabIndex = 6;
            panel2.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(337, 129);
            label4.Name = "label4";
            label4.Size = new Size(65, 18);
            label4.TabIndex = 14;
            label4.Text = "Location";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_location
            // 
            txt_location.BackColor = Color.FromArgb(30, 39, 43);
            txt_location.BorderStyle = BorderStyle.None;
            txt_location.CharacterCasing = CharacterCasing.Lower;
            txt_location.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_location.ForeColor = Color.White;
            txt_location.Location = new Point(337, 153);
            txt_location.Margin = new Padding(10);
            txt_location.MaximumSize = new Size(252, 25);
            txt_location.MinimumSize = new Size(252, 25);
            txt_location.Name = "txt_location";
            txt_location.PlaceholderText = "   Insert location";
            txt_location.Size = new Size(252, 25);
            txt_location.TabIndex = 13;
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
            // txt_phone
            // 
            txt_phone.BackColor = Color.FromArgb(30, 39, 43);
            txt_phone.BorderStyle = BorderStyle.None;
            txt_phone.CharacterCasing = CharacterCasing.Lower;
            txt_phone.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_phone.ForeColor = Color.White;
            txt_phone.Location = new Point(337, 96);
            txt_phone.Margin = new Padding(10);
            txt_phone.MaximumSize = new Size(252, 25);
            txt_phone.MinimumSize = new Size(252, 25);
            txt_phone.Name = "txt_phone";
            txt_phone.PlaceholderText = "   Insert number phone";
            txt_phone.Size = new Size(252, 25);
            txt_phone.TabIndex = 11;
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
            // txt_lastname
            // 
            txt_lastname.BackColor = Color.FromArgb(30, 39, 43);
            txt_lastname.BorderStyle = BorderStyle.None;
            txt_lastname.CharacterCasing = CharacterCasing.Lower;
            txt_lastname.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_lastname.ForeColor = Color.White;
            txt_lastname.Location = new Point(337, 39);
            txt_lastname.Margin = new Padding(10);
            txt_lastname.MaximumSize = new Size(252, 25);
            txt_lastname.MinimumSize = new Size(252, 25);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.PlaceholderText = "   Insert last name";
            txt_lastname.Size = new Size(252, 25);
            txt_lastname.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(46, 129);
            label5.Name = "label5";
            label5.Size = new Size(45, 18);
            label5.TabIndex = 6;
            label5.Text = "Email";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.FromArgb(30, 39, 43);
            txt_email.BorderStyle = BorderStyle.None;
            txt_email.CharacterCasing = CharacterCasing.Lower;
            txt_email.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_email.ForeColor = Color.White;
            txt_email.Location = new Point(46, 153);
            txt_email.Margin = new Padding(10);
            txt_email.MaximumSize = new Size(252, 25);
            txt_email.MinimumSize = new Size(252, 25);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "   Insert especiality";
            txt_email.Size = new Size(252, 25);
            txt_email.TabIndex = 5;
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
            // txt_dni
            // 
            txt_dni.BackColor = Color.FromArgb(30, 39, 43);
            txt_dni.BorderStyle = BorderStyle.None;
            txt_dni.CharacterCasing = CharacterCasing.Lower;
            txt_dni.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_dni.ForeColor = Color.White;
            txt_dni.Location = new Point(46, 96);
            txt_dni.Margin = new Padding(10);
            txt_dni.MaximumSize = new Size(252, 25);
            txt_dni.MinimumSize = new Size(252, 25);
            txt_dni.Name = "txt_dni";
            txt_dni.PlaceholderText = "   Insert DNI";
            txt_dni.Size = new Size(252, 25);
            txt_dni.TabIndex = 3;
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
            // txt_name
            // 
            txt_name.BackColor = Color.FromArgb(30, 39, 43);
            txt_name.BorderStyle = BorderStyle.None;
            txt_name.CharacterCasing = CharacterCasing.Lower;
            txt_name.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_name.ForeColor = Color.White;
            txt_name.Location = new Point(46, 39);
            txt_name.Margin = new Padding(10);
            txt_name.MaximumSize = new Size(252, 25);
            txt_name.MinimumSize = new Size(252, 25);
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "   Insert name";
            txt_name.Size = new Size(252, 25);
            txt_name.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(btn_create);
            panel3.Controls.Add(btn_cancel);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 324);
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
            btn_create.UseClicked += btn_create_UseClicked;
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
            // Frm_NewCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 16, 21);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(640, 382);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_NewCustomer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Frm_NewMechanica";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private CapaPresentacion.ComponentsUX.RoundedLabel btn_create;
        private CapaPresentacion.ComponentsUX.RoundedLabel btn_cancel;
        private TextBox txt_name;
        private Label label6;
        private TextBox txt_phone;
        private Label label7;
        private TextBox txt_lastname;
        private Label label5;
        private TextBox txt_email;
        private Label label3;
        private TextBox txt_dni;
        private Label label2;
        private Label label4;
        private TextBox txt_location;
    }
}