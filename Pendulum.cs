using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileRobotAPF {
    class Pendulum : Source, IForceField {
        protected int z;
        protected double angle;
        protected double range;
        protected double radius;

        public Pendulum(int x, int y, double charge, double radius, int z, double angle, double range) 
                : base(x, y, charge) {
            this.z = z;
            this.radius = radius;
            this.angle = angle;
            this.range = range;
        }

        public ForceVector calculateForceVector( Robot robot ) {
            ForceVector forceVector = new ForceVector(this.x, robot.x, this.y, robot.y);

            forceVector.width -= this.radius;

            if(forceVector.width < 0) {
                forceVector.width = 0;
            }

            forceVector.width *= this.charge;

            return forceVector;
        }
    }
}
