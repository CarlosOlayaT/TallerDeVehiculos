using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.ComponentsUX
{
    public class Customdatagridview : DataGridView
    {
        public Customdatagridview()

        {

            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();

            Visible = true;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BorderStyle = BorderStyle.None;
            CellBorderStyle = DataGridViewCellBorderStyle.None;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ColumnHeadersHeight = 40;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Dock = DockStyle.Fill;
            EnableHeadersVisualStyles = false;
            Location = new Point(0, 0);
            MultiSelect = false;
            Name = "dataGridView1";
            RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            RowHeadersVisible = false;
            Size = new Size(777, 448);
            TabIndex = 0;
            DoubleBuffered = true;

        }
        [Category("CustomColumns")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new DataGridViewColumnCollection Columns
        {
            get { return base.Columns; }
        }
        protected override void OnColumnAdded(DataGridViewColumnEventArgs e)
        {
            base.OnColumnAdded(e);


            // Asegura que la columna tenga un CellTemplate válido
            if (e.Column.CellTemplate == null)
            {
                e.Column.CellTemplate = new DataGridViewTextBoxCell(); // Plantilla predeterminada
            }

        }



    }
}
