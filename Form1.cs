using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileRobotAPF {
    public partial class Form1 : Form {
        private System.Drawing.Graphics graphics;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Black, 2F);

        private Robot robot;
        private Pendulum pendulum;
        private List<Source> sources;

        public Form1() {
            InitializeComponent();

            sources = new List<Source>();
            sources.Add(new RobotDestination(400, 400));

            pendulum = new Pendulum(200, 200, -5, 15, 200, 10, 50);
            sources.Add(pendulum);

            robot = new Robot(10,10, 5, sources);
        }

        private void Form1_Load( object sender, EventArgs e ) {
            timerProgramLoop.Start();
        }

        private void buttonStart_Click( object sender, EventArgs e ) {
        }

        private void timerProgramLoop_Tick( object sender, EventArgs e ) {
            graphics = movementFieldBox.CreateGraphics();
            graphics.Clear(Color.White);

            pendulum.Move();

            sources.ForEach(delegate (Source source) {
                graphics.FillEllipse(Brushes.Black, new Rectangle((int)source.x, (int)source.y, 20, 20));
            });

            Rectangle robotRectangle = new Rectangle(robot.x, robot.y, 20, 20);
            graphics.FillEllipse(Brushes.Tomato, robotRectangle);

            robot.Move();
            // System.Console.Out.WriteLine("Robot moving, engine working...");
        }
    }
}
