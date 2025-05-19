using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.ComponentsUX
{
    public class AlignedPanelCell : DataGridViewTextBoxCell
    {
        public ContentAlignment ContentAlignment { get; set; } = ContentAlignment.MiddleCenter;
        [Category("ModernDesign")]
        public int Radius { get; set; } = 1;
        private Color color;
        public Color PanelColor
        {
            get { return color; }
            set { color = value; }
        }
        public override object Clone()
        {
            var clone = (AlignedPanelCell)base.Clone();
            clone.Radius = Radius;
            clone.PanelColor = PanelColor;
            return clone;
        }
        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex,
                              DataGridViewElementStates cellState, object value, object formattedValue,
                              string errorText, DataGridViewCellStyle cellStyle,
                              DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            // Fondo de la celda
            using (SolidBrush backBrush = new SolidBrush(cellStyle.BackColor))
            {
                graphics.FillRectangle(backBrush, cellBounds);
            }

            // Datos del texto
            string text = formattedValue?.ToString() ?? "";
            Font font = cellStyle.Font;
            SizeF textSize = graphics.MeasureString(text, font);

            // Tamaño del rounded label
            int paddingX = 12;
            int paddingY = 6;

            SizeF roundedLabelSize = new SizeF(textSize.Width + paddingX * 2, textSize.Height + paddingY);

            // Centrado en la celda
            float labelX = cellBounds.X + (cellBounds.Width - roundedLabelSize.Width) / 2;
            float labelY = cellBounds.Y + (cellBounds.Height - roundedLabelSize.Height) / 2;
            RectangleF labelRect = new RectangleF(labelX, labelY, roundedLabelSize.Width, roundedLabelSize.Height);

            // Dibujar fondo redondeado del label
            using (GraphicsPath path = RoundedRect(labelRect))
            using (SolidBrush labelBrush = new SolidBrush(color)) // Cambia color si quieres
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.FillPath(labelBrush, path);
            }

            // Dibujar el texto centrado
            using (SolidBrush textBrush = new SolidBrush(cellStyle.ForeColor))
            using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                graphics.DrawString(text, font, textBrush, labelRect, sf);
            }
        }
        private GraphicsPath RoundedRect(RectangleF bounds)
        {
            float diameter = Radius * 2;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

    }
}
