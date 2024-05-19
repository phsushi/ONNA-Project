using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace prjDESK_ONNA
{
    public class ModeracaoBtn : Button
    {
        private int tamanhoBorda = 0;
        private int curvaturaBorda = 0;
        private Color corBorda = Color.PaleVioletRed;


        public ModeracaoBtn()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;

        }
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width-radius,rect.Height-radius,radius,radius,0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1,1,this.Width-0.8F,this.Height-1);
            if (curvaturaBorda > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, curvaturaBorda))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, curvaturaBorda-1F))

            }
            else
            {

            }
        }
    }
}
