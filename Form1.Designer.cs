namespace MobileRobotAPF {
    partial class ArtificialPotentialFieldPathFinding {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.movementFieldBox = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timerProgramLoop = new System.Windows.Forms.Timer(this.components);
            this.boxPendulumsAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelForceVector = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.movementFieldBox)).BeginInit();
            this.SuspendLayout();
            // 
            // movementFieldBox
            // 
            this.movementFieldBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movementFieldBox.Location = new System.Drawing.Point(0, 0);
            this.movementFieldBox.Name = "movementFieldBox";
            this.movementFieldBox.Size = new System.Drawing.Size(784, 561);
            this.movementFieldBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movementFieldBox.TabIndex = 0;
            this.movementFieldBox.TabStop = false;
            this.movementFieldBox.Paint += new System.Windows.Forms.PaintEventHandler(this.movementFieldBox_Paint);
            // 
            // buttonStart
            // 
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timerProgramLoop
            // 
            this.timerProgramLoop.Interval = 40;
            this.timerProgramLoop.Tick += new System.EventHandler(this.timerProgramLoop_Tick);
            // 
            // boxPendulumsAmount
            // 
            this.boxPendulumsAmount.Location = new System.Drawing.Point(211, 15);
            this.boxPendulumsAmount.Name = "boxPendulumsAmount";
            this.boxPendulumsAmount.Size = new System.Drawing.Size(100, 20);
            this.boxPendulumsAmount.TabIndex = 2;
            this.boxPendulumsAmount.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount of pendulums:";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(317, 18);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(83, 13);
            this.labelPosition.TabIndex = 4;
            this.labelPosition.Text = "Current position:";
            // 
            // labelForceVector
            // 
            this.labelForceVector.AutoSize = true;
            this.labelForceVector.Location = new System.Drawing.Point(446, 18);
            this.labelForceVector.Name = "labelForceVector";
            this.labelForceVector.Size = new System.Drawing.Size(77, 13);
            this.labelForceVector.TabIndex = 5;
            this.labelForceVector.Text = "Current vector:";
            // 
            // ArtificialPotentialFieldPathFinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.labelForceVector);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxPendulumsAmount);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.movementFieldBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArtificialPotentialFieldPathFinding";
            this.Text = "Artificial Potential Field Path Finding";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.ArtificialPotentialFieldPathFinding_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.movementFieldBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox movementFieldBox;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timerProgramLoop;
        private System.Windows.Forms.TextBox boxPendulumsAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelForceVector;
    }
}

