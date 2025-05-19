using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.ComponentsUX
{
    public class RoundedLabelColumn : DataGridViewColumn
    {
        public int Radius { get; set; } = 5;
        public Color FillColor { get; set; } = Color.LightGray;
        public ContentAlignment Align { get; set; } = ContentAlignment.MiddleCenter;

        public RoundedLabelColumn()
        {
            CellTemplate = new RoundedLabelCell();
        }

        public override object Clone()
        {
            var clone = (RoundedLabelColumn)base.Clone();
            clone.Radius = Radius;
            clone.FillColor = FillColor;
            clone.Align = Align;
            return clone;
        }
    }
}
