using System.Drawing.Drawing2D;

namespace ToolTipForDrawingObjectsExample
{
    public class Node
    {
        int NodeWidth = 16;
        Color NodeColor = Color.Blue;
        Color HotColor = Color.Red;
        public string Name { get; set; }
        public Point Location { get; set; }
        private GraphicsPath GetShape()
        {
            GraphicsPath shape = new GraphicsPath();
            shape.AddEllipse(Location.X - NodeWidth / 2, Location.Y - NodeWidth / 2,
                NodeWidth, NodeWidth);
            return shape;
        }
        public void Draw(Graphics g, bool isHot = false)
        {
            using (var brush = new SolidBrush(isHot ? HotColor : NodeColor))
            using (var shape = GetShape())
            {
                g.FillPath(brush, shape);
            }
        }
        public bool HitTest(Point p)
        {
            using (var shape = GetShape())
                return shape.IsVisible(p);
        }
    }
}
