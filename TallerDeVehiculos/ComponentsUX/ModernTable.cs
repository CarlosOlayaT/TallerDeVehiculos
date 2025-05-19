using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.ComponentsUX
{
    public partial class ModernTable : UserControl
    {
        public ModernTable()
        {
            InitializeComponent();
            customdatagridview1.AllowUserToAddRows = false;

        }
        [Category("ModernTable")]
        public CornerRadius Radius
        {
            get { return roundedPanel1.Radius; }
            set
            {
                roundedPanel1.Radius = value;
            }
        }
        [Category("ModernTable")]
        public Color backgroundColor
        {
            get { return roundedPanel1.StateColor; }
            set
            {
                roundedPanel1.StateColor = value;
                customdatagridview1.BackgroundColor = value;
            }
        }
        [Category("ModernTable")]
        public string Texts
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        [Category("ModernTable")]
        [DefaultValue(ContentAlignment.TopLeft)]
        public ContentAlignment TextAlign
        {
            get { return alignedPanel1.ContentAlignment; }
            set
            {
                alignedPanel1.ContentAlignment = value; PerformLayout();
            }
        }
        [Category("ModernTable")]
        public Font TitleFont
        {
            get { return label1.Font; }
            set { label1.Font = value; }
        }
        [Category("ModernTable")]
        public Color TitleBackColor
        {
            get { return alignedPanel1.BackgroundColor; }
            set { alignedPanel1.BackgroundColor = value; }
        }
        [Category("ModernTableGrid")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataGridViewColumnCollection Columns
        {
            get { return customdatagridview1.Columns; }
        }



        [Category("ModernTableGrid")]
        public DataGridViewCellStyle HeaderAlignment
        {
            get { return customdatagridview1.ColumnHeadersDefaultCellStyle; }
            set { customdatagridview1.ColumnHeadersDefaultCellStyle = value; }
        }
    }
}
