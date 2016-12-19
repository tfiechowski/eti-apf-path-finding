using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileRobotAPF {
    abstract class Source {
        public double x, y;
        public double charge;

        public Source(int x, int y, double charge) {
            this.x = x;
            this.y = y;
            this.charge = charge;
        }

        public ForceVector calculateForceVector( Robot robot ) {
            return new ForceVector(this.x, robot.x, this.y, robot.y);
        }
    }
}
