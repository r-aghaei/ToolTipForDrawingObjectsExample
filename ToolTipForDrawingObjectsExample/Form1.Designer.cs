namespace ToolTipForDrawingObjectsExample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawingSurface1 = new ToolTipForDrawingObjectsExample.DrawingSurface();
            this.SuspendLayout();
            // 
            // drawingSurface1
            // 
            this.drawingSurface1.BackColor = System.Drawing.Color.White;
            this.drawingSurface1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingSurface1.Location = new System.Drawing.Point(0, 0);
            this.drawingSurface1.Name = "drawingSurface1";
            this.drawingSurface1.Size = new System.Drawing.Size(800, 450);
            this.drawingSurface1.TabIndex = 0;
            this.drawingSurface1.Text = "drawingSurface1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawingSurface1);
            this.Name = "Form1";
            this.Text = "ToolTipExampleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private DrawingSurface drawingSurface1;
    }
}