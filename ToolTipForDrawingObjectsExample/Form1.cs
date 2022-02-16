namespace ToolTipForDrawingObjectsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            drawingSurface1.Nodes.Add(new Node()
            {
                Name = "Node1",
                Location = new Point(100, 100)
            });
            drawingSurface1.Nodes.Add(new Node()
            {
                Name = "Node2",
                Location = new Point(150, 70)
            });
            drawingSurface1.Nodes.Add(new Node()
            {
                Name = "Node3",
                Location = new Point(170, 140)
            });
            drawingSurface1.Nodes.Add(new Node()
            {
                Name = "Node4",
                Location = new Point(200, 50)
            });
            drawingSurface1.Nodes.Add(new Node()
            {
                Name = "Node5",
                Location = new Point(90, 160)
            });
            drawingSurface1.Invalidate();
        }
    }
}