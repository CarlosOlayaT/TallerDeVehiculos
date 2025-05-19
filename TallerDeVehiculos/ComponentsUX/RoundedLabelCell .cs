using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.ComponentsUX
{
    public class RoundedLabelCell : DataGridViewTextBoxCell
    {
        public int Radius { get; set; } = 10;
        public Color FillColor { get; set; } = Color.LightBlue;
        public ContentAlignment Align { get; set; } = ContentAlignment.MiddleCenter;

        protected override void Paint(Graphics graphics,
                                      Rectangle clipBounds,
                                      Rectangle cellBounds,
                                      int rowIndex,
                                      DataGridViewElementStates cellState,
                                      object value,
                                      object formattedValue,
                                      string errorText,
                                      DataGridViewCellStyle cellStyle,
                                      DataGridViewAdvancedBorderStyle advancedBorderStyle,
                                      DataGridViewPaintParts paintParts)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = cellBounds;
            rect.Inflate(-1, -1);

            using (GraphicsPath path = GetRoundedRectanglePath(rect, Radius))
            using (SolidBrush brush = new SolidBrush(FillColor))
            {
                graphics.FillPath(brush, path);
            }

            // Dibujar el texto
            TextRenderer.DrawText(graphics,
                                  formattedValue?.ToString() ?? "",
                                  cellStyle.Font,
                                  rect,
                                  cellStyle.ForeColor,
                                  GetTextFormatFlags(Align));
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float r = radius;

            path.StartFigure();
            path.AddArc(rect.Left, rect.Top, r, r, 180, 90);
            path.AddLine(rect.Left + r, rect.Top, rect.Right - r, rect.Top);
            path.AddArc(rect.Right - r, rect.Top, r, r, 270, 90);
            path.AddLine(rect.Right, rect.Top + r, rect.Right, rect.Bottom - r);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddLine(rect.Right - r, rect.Bottom, rect.Left + r, rect.Bottom);
            path.AddArc(rect.Left, rect.Bottom - r, r, r, 90, 90);
            path.AddLine(rect.Left, rect.Bottom - r, rect.Left, rect.Top + r);
            path.CloseFigure();

            return path;
        }

        private TextFormatFlags GetTextFormatFlags(ContentAlignment alignment)
        {
            TextFormatFlags flags = TextFormatFlags.WordBreak;

            switch (alignment)
            {
                case ContentAlignment.TopLeft: flags |= TextFormatFlags.Top | TextFormatFlags.Left; break;
                case ContentAlignment.TopCenter: flags |= TextFormatFlags.Top | TextFormatFlags.HorizontalCenter; break;
                case ContentAlignment.TopRight: flags |= TextFormatFlags.Top | TextFormatFlags.Right; break;
                case ContentAlignment.MiddleLeft: flags |= TextFormatFlags.VerticalCenter | TextFormatFlags.Left; break;
                case ContentAlignment.MiddleCenter: flags |= TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter; break;
                case ContentAlignment.MiddleRight: flags |= TextFormatFlags.VerticalCenter | TextFormatFlags.Right; break;
                case ContentAlignment.BottomLeft: flags |= TextFormatFlags.Bottom | TextFormatFlags.Left; break;
                case ContentAlignment.BottomCenter: flags |= TextFormatFlags.Bottom | TextFormatFlags.HorizontalCenter; break;
                case ContentAlignment.BottomRight: flags |= TextFormatFlags.Bottom | TextFormatFlags.Right; break;
            }

            return flags;
        }
    }
}
