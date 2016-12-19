using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileRobotAPF {
    class Pendulum : Source {
        protected int z;
        protected double angle;
        protected double range;
        protected double radius;
        private double tick = 0.00;
        private int x0, y0;

        public Pendulum(int x, int y, double charge, double radius, int z, double angle, double range) 
                : base(x, y, charge) {
            this.z = z;
            this.radius = radius;
            this.angle = angle;
            this.range = range;
            this.x0 = x;
            this.y0 = y;
        }

        public new ForceVector calculateForceVector( Robot robot ) {
            ForceVector forceVector = new ForceVector(this.x, robot.x, this.y, robot.y);

            forceVector.width -= this.radius;

            if(forceVector.width < 0) {
                forceVector.width = 0;
            }

            forceVector.dx *= this.charge;
            forceVector.dy *= this.charge;

            double vectorWidthSquare = forceVector.width * forceVector.width;

            forceVector.dx /= vectorWidthSquare;
            forceVector.dy /= vectorWidthSquare;

            return forceVector;
        }

        public void Move() {
            this.x = this.x0 + this.range * Math.Sin(this.angle + this.tick);
            this.y = this.y0;

            //double x1 = this.range;
            //double y1 = 0;

            //double x2 = x1 * Math.Cos(tick) - y1 * Math.Sin(tick);
            //double y2 = x1 * Math.Sin(tick) + y1 * Math.Cos(tick);

            //this.x = (int)((this.x0 + x2) * Math.Sin(tick));
            //this.y = (int)((this.y0 + y2) * Math.Sin(tick));

            tick += Math.PI / 10;
        }
    }
}
