namespace GeneticPractice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PicBox = new PictureBox();
            lbEpochCount = new Label();
            panel1 = new Panel();
            btnStop = new Button();
            btnStart = new Button();
            lbSpeed = new Label();
            tbSpeed = new TrackBar();
            lbType = new Label();
            lbMinStep = new Label();
            ((System.ComponentModel.ISupportInitialize)PicBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbSpeed).BeginInit();
            SuspendLayout();
            // 
            // PicBox
            // 
            PicBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PicBox.BackColor = Color.Transparent;
            PicBox.Location = new Point(12, 12);
            PicBox.Name = "PicBox";
            PicBox.Size = new Size(748, 658);
            PicBox.TabIndex = 0;
            PicBox.TabStop = false;
            // 
            // lbEpochCount
            // 
            lbEpochCount.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbEpochCount.Location = new Point(14, 557);
            lbEpochCount.Name = "lbEpochCount";
            lbEpochCount.Size = new Size(234, 23);
            lbEpochCount.TabIndex = 1;
            lbEpochCount.Text = "Epoch: 1";
            lbEpochCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(btnStop);
            panel1.Controls.Add(btnStart);
            panel1.Controls.Add(lbSpeed);
            panel1.Controls.Add(tbSpeed);
            panel1.Controls.Add(lbType);
            panel1.Controls.Add(lbMinStep);
            panel1.Controls.Add(lbEpochCount);
            panel1.Location = new Point(776, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 658);
            panel1.TabIndex = 2;
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStop.Location = new Point(125, 431);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(112, 33);
            btnStop.TabIndex = 7;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(14, 431);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(113, 33);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lbSpeed
            // 
            lbSpeed.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbSpeed.Location = new Point(14, 483);
            lbSpeed.Name = "lbSpeed";
            lbSpeed.Size = new Size(234, 23);
            lbSpeed.TabIndex = 5;
            lbSpeed.Text = "Speed ";
            lbSpeed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbSpeed
            // 
            tbSpeed.Location = new Point(14, 509);
            tbSpeed.Maximum = 100;
            tbSpeed.Minimum = 1;
            tbSpeed.Name = "tbSpeed";
            tbSpeed.RightToLeft = RightToLeft.Yes;
            tbSpeed.Size = new Size(223, 45);
            tbSpeed.TabIndex = 4;
            tbSpeed.TickFrequency = 10;
            tbSpeed.Value = 25;
            tbSpeed.Scroll += tbSpeed_Scroll;
            // 
            // lbType
            // 
            lbType.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbType.Location = new Point(14, 623);
            lbType.Name = "lbType";
            lbType.Size = new Size(234, 23);
            lbType.TabIndex = 3;
            lbType.Text = "Color: ";
            lbType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbMinStep
            // 
            lbMinStep.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbMinStep.Location = new Point(14, 590);
            lbMinStep.Name = "lbMinStep";
            lbMinStep.Size = new Size(234, 23);
            lbMinStep.TabIndex = 2;
            lbMinStep.Text = "Min steps:";
            lbMinStep.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1036, 682);
            Controls.Add(panel1);
            Controls.Add(PicBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dots";
            ((System.ComponentModel.ISupportInitialize)PicBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbSpeed).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PicBox;
        private Label lbEpochCount;
        private Panel panel1;
        private Label lbMinStep;
        private Label lbType;
        private TrackBar tbSpeed;
        private Label lbSpeed;
        private Button btnStart;
        private Button btnStop;
    }
}
