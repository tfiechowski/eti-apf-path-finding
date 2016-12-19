using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileRobotAPF {
    abstract class Source {
        protected int x, y;
        protected double charge;

        public Source(int x, int y, double charge) {
            this.x = x;
            this.y = y;
            this.charge = charge;
        }
    }
}
