using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.ComponentsUX
{
    public class AlignedPanelColumn : DataGridViewColumn
    {
        public int Radius
        {
            get => ((AlignedPanelCell)CellTemplate).Radius;
            set
            {
                ((AlignedPanelCell)CellTemplate).Radius = value;
            }
        }
        public Color LabelColor
        {
            get => ((AlignedPanelCell)CellTemplate).PanelColor;
            set
            {
                ((AlignedPanelCell)CellTemplate).PanelColor = value;
            }
        }

        public AlignedPanelColumn()
        {
            CellTemplate = new AlignedPanelCell();
        }

        public override object Clone()
        {
            AlignedPanelColumn col = (AlignedPanelColumn)base.Clone();
            col.Radius = Radius;
            col.LabelColor = LabelColor;
            return col;
        }
    }
}
