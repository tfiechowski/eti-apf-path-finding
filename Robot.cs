using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileRobotAPF {
    class Robot {
        public int x, y;
        public int velocity;
        public List<Source> obstacles;

        public Robot() {
            x = 10;
            y = 10;

            obstacles = new List<Source>();
        }

        public Robot(int x, int y, int velocity, List<Source> obstacles) {
            this.x = x;
            this.y = y;
            this.velocity = velocity;
            this.obstacles = obstacles;
        }

        public void Move() {
            double dx = 0.0;
            double dy = 0.0;

            obstacles.ForEach(delegate ( Source obstacle ) {
                ForceVector forceVector = new ForceVector(obstacle.x, x, obstacle.y, y);

                double squaredLength = forceVector.width * forceVector.width;

                dx += ((obstacle.x - x) * obstacle.charge) / squaredLength;
                dy += ((obstacle.y - y) * obstacle.charge) / squaredLength;
            });


            double dLength = Math.Sqrt(dx * dx + dy * dy);

            dx /= dLength;
            dy /= dLength;

            dx *= this.velocity;
            dy *= this.velocity;

            if (dx < 1 && dx >= -1) {
                dx = Math.Sign(dx);
            }

            if (dy < 1 && dy >= -1) {
                dy = Math.Sign(dy);
            }

            this.x += (int)dx;
            this.y += (int)dy;
        }

        public void Draw(Graphics graphics) {
            Rectangle robotRectangle = new Rectangle(this.x - 10, this.y - 10, 20, 20);
            graphics.FillEllipse(Brushes.Tomato, robotRectangle);
        }
    }
}
