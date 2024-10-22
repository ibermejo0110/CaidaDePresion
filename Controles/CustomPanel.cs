using System.Drawing.Drawing2D;

namespace Controles
{
    public class CustomPanel:Panel
    {
        //fields
        private int borderRadius = 30;
        private float gradientAngle = 90F;
        private  Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.CadetBlue;
        
        //Constructor
        public CustomPanel()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(350, 200);
        }

        //Properties 
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }
        }
        public float GradientAngle 
        {
            get => gradientAngle; 
            set { gradientAngle = value; this.Invalidate(); }
        }
        public Color GradientTopColor
        {
            get => gradientTopColor;
            set { gradientTopColor = value; this.Invalidate(); }
        }
        public Color GradientBottomColor 
        { 
            get => gradientBottomColor;
            set { gradientBottomColor = value; this.Invalidate(); }
        }

        //methods
        private GraphicsPath GetArtanPath(RectangleF rectangle,float radius)
        {
            GraphicsPath graphicsPath = new();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rectangle.Width -radius,rectangle.Height-radius,radius,radius,0,90);
            graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            graphicsPath.CloseFigure();
            return graphicsPath;
        }
        // override methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brushArtan = new (ClientRectangle, this.GradientTopColor,
                this.gradientBottomColor, this.gradientAngle);
            Graphics graphicsArtan=e.Graphics;
            graphicsArtan.FillRectangle(brushArtan, ClientRectangle);

            //borderRadius
            RectangleF rectanglef = new(0,0,this.Width,this.Height);
            if (borderRadius > 2)
            {
                using (GraphicsPath graphicsPath = GetArtanPath(rectanglef, borderRadius)) {
                    using (Pen pen = new(this.Parent.BackColor, 2))
                    {
                        this.Region = new Region(graphicsPath);
                        e.Graphics.DrawPath(pen, graphicsPath);
                    } 
                }
            }
            else this.Region=new Region(rectanglef);
        }


    }
}
