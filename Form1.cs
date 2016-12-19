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

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load( object sender, EventArgs e ) {
            
        }

        private void buttonStart_Click( object sender, EventArgs e ) {
            graphics = movementFieldBox.CreateGraphics();
            graphics.DrawLine(pen1, new Point(10, 10), new Point(790, 790));
            graphics.DrawRectangle(pen1, 30, 30, 50, 60);
        }

        private void timerProgramLoop_Tick( object sender, EventArgs e ) {
            
        }
    }
}
