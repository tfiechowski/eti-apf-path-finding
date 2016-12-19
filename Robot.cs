using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileRobotAPF {
    class Robot {
        public int x, y;
        public int velocity;
        public List<Source> obstacles;
        private double dt;

        public Robot() {
            x = 10;
            y = 10;

            dt = 0.1;

            obstacles = new List<Source>();
        }

        public Robot(int x, int y, int velocity, List<Source> obstacles) {
            this.x = x;
            this.y = y;
            this.velocity = velocity;
            this.obstacles = obstacles;

            this.dt = 0.1;
        }

        public void Move() {
            double dx = 0.0;
            double dy = 0.0;

            obstacles.ForEach(delegate ( Source obstacle ) {
                ForceVector forceVector = new ForceVector(obstacle.x, x, obstacle.y, y);

                dx += (forceVector.dx * obstacle.charge) / (forceVector.width * forceVector.width);
                dy += (forceVector.dy * obstacle.charge) / (forceVector.width * forceVector.width);
            });

            if(Double.IsNaN(dx)) {
                bool __marker1 = true;
            }

            double norm = Math.Sqrt(dx * dx + dy + dy);
            dx /= norm;
            dy /= norm;

            // dx *= this.velocity;
            // dy *= this.velocity;

            if(dx < 1) {
                dx = 1;
            }

            if(dy < 1) {
                dy = 1;
            }

            this.x += (int)dx;
            this.y += (int)dy;

            bool __marker = true;
        }
    }
}
