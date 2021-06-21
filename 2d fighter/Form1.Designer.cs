
namespace _2d_fighter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.arrowmap = new System.Windows.Forms.Panel();
            this.movement = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // arrowmap
            // 
            this.arrowmap.BackgroundImage = global::_2d_fighter.Properties.Resources.arrow_map;
            this.arrowmap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arrowmap.Location = new System.Drawing.Point(12, 12);
            this.arrowmap.Name = "arrowmap";
            this.arrowmap.Size = new System.Drawing.Size(1284, 638);
            this.arrowmap.TabIndex = 1;
            this.arrowmap.Paint += new System.Windows.Forms.PaintEventHandler(this.arrowmap_Paint_1);
            // 
            // movement
            // 
            this.movement.Enabled = true;
            this.movement.Interval = 50;
            this.movement.Tick += new System.EventHandler(this.movement_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1453, 662);
            this.Controls.Add(this.arrowmap);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel arrowmap;
        private System.Windows.Forms.Timer movement;
    }
}

