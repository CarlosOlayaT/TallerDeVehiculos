using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class UC_Mechanic : UserControl
    {
        public UC_Mechanic()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

            Panel y =(Panel)sender ;

            using (Pen pen = new Pen(Color.FromArgb(141, 147, 151), 2)) 
            {
                e.Graphics.DrawLine(pen, 0, y.Height - 1, y.Width, y.Height - 1);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Point panelScreenPos = this.PointToScreen(Point.Empty);

            Frm_NewMechanic frm_NewMechanic = new Frm_NewMechanic();

            int centerX = panelScreenPos.X + (this.Width - frm_NewMechanic.Width) / 2;
            int centerY = panelScreenPos.Y + (this.Height - frm_NewMechanic.Height) / 2;

            frm_NewMechanic.StartPosition = FormStartPosition.Manual;
            frm_NewMechanic.Location = new Point(centerX, centerY);


            frm_NewMechanic.ShowDialog();
        }
    }
}
