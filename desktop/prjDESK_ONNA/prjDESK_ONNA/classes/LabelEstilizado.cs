﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace prjDESK_ONNA.classes
{
    public class LabelEstilizado : Label
    {
        private int tamanhoBorda = 0;
        private int curvaturaBorda = 40;
        private Color corBorda = Color.PaleVioletRed;
        [Category("Estilo Avançado")]
        public int TamanhoBorda
        {
            get
            {
                return tamanhoBorda;
            }
            set
            {
                tamanhoBorda = value;
                this.Invalidate();
            }
        }
        [Category("Estilo Avançado")]
        public int CurvaturaBorda
        {
            get
            {
                return curvaturaBorda;
            }
            set
            {
                if (value <= this.Height)
                    curvaturaBorda = value;
                else curvaturaBorda = this.Height;
                this.Invalidate();
            }
        }
        [Category("Estilo Avançado")]
        public Color CorBorda
        {
            get
            {
                return corBorda;
            }
            set
            {
                corBorda = value;
                this.Invalidate();
            }
        }
        [Category("Estilo Avançado")]
        public Color BackgroudColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        [Category("Estilo Avançado")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }


        public LabelEstilizado()
        {
            this.FlatStyle = FlatStyle.Flat;
            
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);

        }



        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);
            if (curvaturaBorda > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, curvaturaBorda))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, curvaturaBorda - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(corBorda, tamanhoBorda))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    if (tamanhoBorda >= 1)

                        pevent.Graphics.DrawPath(penBorder, pathBorder);


                }


            }
            else
            {
                this.Region = new Region(rectSurface);
                if (tamanhoBorda >= 1)
                {
                    using (Pen penBorder = new Pen(corBorda, tamanhoBorda))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);

        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
        private void Button_Resize(object sender, EventArgs e)
        {
            if (curvaturaBorda > this.Height)
                CurvaturaBorda = this.Height;
        }
    }
}
