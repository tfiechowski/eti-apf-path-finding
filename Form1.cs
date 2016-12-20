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
    public partial class ArtificialPotentialFieldPathFinding : Form {
        private System.Drawing.Graphics graphics;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Black, 2F);

        private int pendulumsAmount = 2;

        private Bitmap bitmap = new Bitmap(20, 20);

        private Robot robot;
        private Pendulum pendulum;
        private List<Source> sources;
        private RobotDestination destination;

        public ArtificialPotentialFieldPathFinding() {
            InitializeComponent();
            timerProgramLoop.Stop();
            generateRandomStartState();
            updateBitmap();
        }

        private void updateBitmap() {
            bitmap = new Bitmap(this.Width, this.Height);
            graphics = Graphics.FromImage(bitmap);
        }

        private void Form1_Load( object sender, EventArgs e ) {
            timerProgramLoop.Stop();
        }

        private void buttonStart_Click( object sender, EventArgs e ) {
            timerProgramLoop.Stop();

            updatePendulumsAmount();

            generateRandomStartState();
            timerProgramLoop.Start();
        }

        private void updatePendulumsAmount() {
            int newAmount = 0;
            try {
                newAmount = Convert.ToInt32(boxPendulumsAmount.Text);
            } catch(Exception e) {
                newAmount = 1;
                MessageBox.Show("Invalid input!");
            }

            this.pendulumsAmount = newAmount;
        }

        private void timerProgramLoop_Tick( object sender, EventArgs e ) {
            graphics.Clear(Color.White);

            robot.Move();

            sources.ForEach(delegate (Source source) {
                if(source is Pendulum) {
                    var pend = (Pendulum)source;
                    pend.Move();
                }

                source.Draw(graphics);
            });

            robot.Draw(graphics);

            if(checkEndCondition()) {
                timerProgramLoop.Stop();
                MessageBox.Show("Success!");
            }

            updateRobotPositionAndForce();

            movementFieldBox.Invalidate();
        }

        private bool checkEndCondition() {
            double dx = robot.x - destination.x;
            double dy = robot.y - destination.y;

            double distance = Math.Sqrt(dx * dx + dy * dy);

            return distance < 20;
        }

        private void generateRandomStartState() {
            Random rand = new Random();

            sources = new List<Source>();

            destination = new RobotDestination(this.Width + rand.Next(-150, -50), this.Height + rand.Next(-150,-50));
            sources.Add(destination);

            int spacer = 200;
            for(int i = 0; i < pendulumsAmount; i++) {

                int x0 = rand.Next(spacer, this.Width - spacer) + rand.Next(-20, 20);
                int y0 = rand.Next(spacer, this.Height - spacer) + rand.Next(-20, 20);
                double charge = -2.0;
                int radius = 40;

                double startAngle = rand.Next(0, 359) * Math.PI / 180.0;
                double lineAngle = rand.Next(0, 359) * Math.PI / 180.0;
                int range = rand.Next(40, 120);
                pendulum = new Pendulum(x0 , y0, charge, radius, startAngle, range, lineAngle);
                sources.Add(pendulum);
            }

            robot = new Robot(10, 10, 10, sources);
        }

        private void movementFieldBox_Paint( object sender, PaintEventArgs e ) {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void ArtificialPotentialFieldPathFinding_ResizeEnd( object sender, EventArgs e ) {
            //movementFieldBox.SetBounds(0, 0, this.Width, this.Height);
            updateBitmap();
        }

        private void updateRobotPositionAndForce() {
            labelPosition.Text = "Position: (x: " + robot.x + ", y: " + robot.y + ")";

            double dx = Math.Round(robot.currentDx, 2);
            double dy = Math.Round(robot.currentDy, 2);
            labelForceVector.Text = "Vector: (dx: " + dx + ", dy: " + dy + ")";
        }
    }
}
