using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileRobotAPF {
    class Pendulum : Source {
        protected double angle;
        protected double range;
        protected double radius;
        protected double lineAngle;
        private double tick = 0.00;
        private int x0, y0;

        public Pendulum(int x, int y, double charge, double radius, double angle, double range, double lineAngle)
                : base(x, y, charge) {
            this.radius = radius;
            this.angle = angle;
            this.range = range;
            this.lineAngle = lineAngle;
            this.x0 = x;
            this.y0 = y;

            this.x = this.x0 + this.range * Math.Sin(this.angle + this.tick);
            this.y = this.y0;
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

            double x0 = this.range * Math.Sin(this.angle + this.tick);
            double y0 = 0;

            double x1 = x0 * Math.Cos(lineAngle) - y0 * Math.Sin(lineAngle);
            double y1 = x0 * Math.Sin(lineAngle) + y0 * Math.Cos(lineAngle);

            this.x = this.x0 + x1;
            this.y = this.y0 + y1;

            tick += Math.PI / 25;
        }

        public override void Draw( Graphics graphics ) {

            float _x = (float)(this.x - this.radius / 2);
            float _y = (float)(this.y - this.radius / 2);

            graphics.FillEllipse(Brushes.SteelBlue, new RectangleF(_x, _y, (float)this.radius, (float)this.radius));
        }
    }
}
