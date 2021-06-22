using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace _2d_fighter
{
    class floor
    {
        public int x, y, width, height;//variables for the rectangle
        public Rectangle floorRec;
        public Image floor3;//variable for the planet's image
        

        public floor()
        {
            x = 0;
            y = 600;
            width = 1700;
            height = 38;
            floor3 = Image.FromFile("Platform.png");
            floorRec = new Rectangle(x, y, width, height);
        }
        public void Drawfloor(Graphics g)
        {

            g.DrawImage(floor3, floorRec);

        }

        
    }
}
