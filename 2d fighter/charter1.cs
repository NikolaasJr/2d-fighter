using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace _2d_fighter
{



    class charter1
    {
        public int x, y, width, height;//variables for the rectangle
        public Image charter;//variable for the planet's image

        public Rectangle spaceRec;//variable for a rectangle to place our image in
        public charter1()
        {
            x = 10;
            y = 360;
            width = 40;
            height = 40;
            charter = Image.FromFile("bob.png");
            spaceRec = new Rectangle(x, y, width, height);

        }
        public void Drawcharter(Graphics g)
        {

            g.DrawImage(charter, spaceRec);
        }

        public void Movecharter(string move)
        {
            spaceRec.Location = new Point(x, y);

            if (move == "right")
            {

                x += 10;
                spaceRec.Location = new Point(x, y);
            }

            if (move == "left")
            {

                x -= 10;
                spaceRec.Location = new Point(x, y);
            }

            if (move == "up")
            {

                y -= 10;
                spaceRec.Location = new Point(x, y);
            }
        }

    }
}
