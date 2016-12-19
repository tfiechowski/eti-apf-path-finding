using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileRobotAPF {
    class RobotDestination : Source, IForceField {

        public RobotDestination(int x, int y) : base(x, y, 10.0) {
            
        }

        ForceVector IForceField.calculateForceVector( Robot robot ) {
            ForceVector forceVector = new ForceVector(this.x, robot.x, this.y, robot.y);

            // This value is 'global', so width is set to fixed value.
            // TODO: Adjust this value
            forceVector.width = 1;

            return forceVector;
        }
    }
}
