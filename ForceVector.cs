using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileRobotAPF {
    class ForceVector {
        public int dx, dy;
        public double width;

        public ForceVector() {
            dx = 0;
            dy = 0;
            width = 0.0;
        }

        public ForceVector(int x0, int x1, int y0, int y1) {
            dx = x1 - x0;
            dy = y1 - y0;

            width = Math.Sqrt(dx ^ 2 + dy ^ 2);
        }
        
    }
}
