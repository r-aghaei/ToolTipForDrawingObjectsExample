using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace ToolTipForDrawingObjectsExample
{
    public class DrawingSurface : Control
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public List<Node> Nodes { get; }
        public DrawingSurface()
        {
            Nodes = new List<Node>();
            ResizeRedraw = true;
            DoubleBuffered = true;
            toolTip = new ToolTip();
            mouseHoverTimer = new System.Windows.Forms.Timer();
            mouseHoverTimer.Enabled = false;
            mouseHoverTimer.Interval = SystemInformation.MouseHoverTime;
            mouseHoverTimer.Tick += mouseHoverTimer_Tick;
        }
        private void mouseHoverTimer_Tick(object sender, EventArgs e)
        {
            mouseHoverTimer.Enabled = false;
            if (hotNode != null)
            {
                var p = hotNode.Location;
                p.Offset(16, 16);
                toolTip.Show(hotNode.Name, this, p, 2000);
            }
        }

        private System.Windows.Forms.Timer mouseHoverTimer;
        private ToolTip toolTip;
        Node hotNode;
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            var node = Nodes.Where(x => x.HitTest(e.Location)).FirstOrDefault();
            if (node != hotNode)
            {
                mouseHoverTimer.Enabled = false;
                toolTip.Hide(this);
            }
            hotNode = node;
            if (node != null)
                mouseHoverTimer.Enabled = true;
            Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            hotNode = null;
            mouseHoverTimer.Enabled = false;
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (Nodes.Count >= 2)
                e.Graphics.DrawLines(Pens.Black,
                Nodes.Select(x => x.Location).ToArray());
            foreach (var node in Nodes)
                node.Draw(e.Graphics, node == hotNode);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (mouseHoverTimer != null)
                {
                    mouseHoverTimer.Enabled = false;
                    mouseHoverTimer.Dispose();
                }
                if (toolTip != null)
                {
                    toolTip.Dispose();
                }
            }
            base.Dispose(disposing);
        }
    }
}
