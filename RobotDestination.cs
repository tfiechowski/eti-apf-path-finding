using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileRobotAPF {
    class RobotDestination : Source {

        public RobotDestination(int x, int y) : base(x, y, 10.0) {
            
        }

        public override void Draw(Graphics graphics) {
            graphics.FillEllipse(Brushes.LawnGreen, new RectangleF((float)this.x, (float)this.y, 10, 10));
        }
    }
}
