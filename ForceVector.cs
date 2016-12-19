using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileRobotAPF {
    class ForceVector {
        public double dx, dy;
        public double width;

        public ForceVector() {
            dx = 0;
            dy = 0;
            width = 0.0;
        }

        public ForceVector(double x0, double x1, double y0, double y1) {
            dx = x1 - x0;
            dy = y1 - y0;

            width = Math.Sqrt(dx * dx + dy * dy);
        }
        
    }
}
