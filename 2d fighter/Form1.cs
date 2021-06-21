using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace _2d_fighter
{
    public partial class Form1 : Form
    {
        Graphics g; //declare a graphics object called g
        bool left, right;
        string move;

        charter1 charter = new charter1();
        public Form1()
        {
            InitializeComponent();
            // arrowmap.Invalidate();//makes the paint event fire to redraw the panel
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, arrowmap, new object[] { true });
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void arrowmap_Paint_1(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            charter.Drawcharter(g);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void movement_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                charter.Movecharter(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                charter.Movecharter(move);
            }
            arrowmap.Invalidate();
        }



    }
}
