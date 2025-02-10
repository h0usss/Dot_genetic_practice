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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PicBox = new PictureBox();
            lbEpochCount = new Label();
            panel1 = new Panel();
            lbName = new Label();
            panColor = new Panel();
            panPopulations = new Panel();
            btnNewPop = new Button();
            groupBox1 = new GroupBox();
            rbBarrier = new RadioButton();
            rbFinish = new RadioButton();
            rbStart = new RadioButton();
            lbDraw = new Label();
            btnRestart = new Button();
            btnStart = new Button();
            lbSpeed = new Label();
            tbSpeed = new TrackBar();
            lbType = new Label();
            lbMinStep = new Label();
            ((System.ComponentModel.ISupportInitialize)PicBox).BeginInit();
            panel1.SuspendLayout();
            panPopulations.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbSpeed).BeginInit();
            SuspendLayout();
            // 
            // PicBox
            // 
            PicBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PicBox.BackColor = Color.Transparent;
            PicBox.Location = new Point(12, 12);
            PicBox.Name = "PicBox";
            PicBox.Size = new Size(748, 685);
            PicBox.TabIndex = 0;
            PicBox.TabStop = false;
            PicBox.MouseDown += PicBox_MouseDown;
            PicBox.MouseMove += PicBox_MouseMove;
            PicBox.MouseUp += PicBox_MouseUp;
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
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(lbName);
            panel1.Controls.Add(panColor);
            panel1.Controls.Add(panPopulations);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(lbDraw);
            panel1.Controls.Add(btnRestart);
            panel1.Controls.Add(btnStart);
            panel1.Controls.Add(lbSpeed);
            panel1.Controls.Add(tbSpeed);
            panel1.Controls.Add(lbType);
            panel1.Controls.Add(lbMinStep);
            panel1.Controls.Add(lbEpochCount);
            panel1.Location = new Point(769, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 685);
            panel1.TabIndex = 2;
            // 
            // lbName
            // 
            lbName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbName.Location = new Point(14, 617);
            lbName.Name = "lbName";
            lbName.Size = new Size(234, 23);
            lbName.TabIndex = 12;
            lbName.Text = "Name: ";
            lbName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panColor
            // 
            panColor.Location = new Point(74, 647);
            panColor.Name = "panColor";
            panColor.Size = new Size(160, 23);
            panColor.TabIndex = 11;
            // 
            // panPopulations
            // 
            panPopulations.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panPopulations.AutoScroll = true;
            panPopulations.Controls.Add(btnNewPop);
            panPopulations.Location = new Point(3, 87);
            panPopulations.Name = "panPopulations";
            panPopulations.Size = new Size(247, 338);
            panPopulations.TabIndex = 10;
            // 
            // btnNewPop
            // 
            btnNewPop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNewPop.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnNewPop.Location = new Point(0, 0);
            btnNewPop.Name = "btnNewPop";
            btnNewPop.Size = new Size(230, 43);
            btnNewPop.TabIndex = 0;
            btnNewPop.Text = "+";
            btnNewPop.UseVisualStyleBackColor = true;
            btnNewPop.Click += btnNewPop_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(rbBarrier);
            groupBox1.Controls.Add(rbFinish);
            groupBox1.Controls.Add(rbStart);
            groupBox1.Location = new Point(3, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 73);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // rbBarrier
            // 
            rbBarrier.AutoSize = true;
            rbBarrier.Font = new Font("Verdana", 12F);
            rbBarrier.Location = new Point(151, 16);
            rbBarrier.Name = "rbBarrier";
            rbBarrier.Size = new Size(80, 22);
            rbBarrier.TabIndex = 2;
            rbBarrier.TabStop = true;
            rbBarrier.Text = "Barrier";
            rbBarrier.UseVisualStyleBackColor = true;
            // 
            // rbFinish
            // 
            rbFinish.AutoSize = true;
            rbFinish.Font = new Font("Verdana", 12F);
            rbFinish.Location = new Point(78, 16);
            rbFinish.Name = "rbFinish";
            rbFinish.Size = new Size(74, 22);
            rbFinish.TabIndex = 1;
            rbFinish.TabStop = true;
            rbFinish.Text = "Finish";
            rbFinish.UseVisualStyleBackColor = true;
            // 
            // rbStart
            // 
            rbStart.AutoSize = true;
            rbStart.Checked = true;
            rbStart.Font = new Font("Verdana", 12F);
            rbStart.Location = new Point(6, 16);
            rbStart.Name = "rbStart";
            rbStart.Size = new Size(66, 22);
            rbStart.TabIndex = 0;
            rbStart.TabStop = true;
            rbStart.Text = "Start";
            rbStart.UseVisualStyleBackColor = true;
            // 
            // lbDraw
            // 
            lbDraw.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbDraw.Location = new Point(11, 0);
            lbDraw.Name = "lbDraw";
            lbDraw.Size = new Size(234, 48);
            lbDraw.TabIndex = 8;
            lbDraw.Text = "Draw";
            lbDraw.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRestart
            // 
            btnRestart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestart.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestart.Location = new Point(123, 431);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(113, 33);
            btnRestart.TabIndex = 7;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(12, 431);
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
            tbSpeed.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbSpeed.Location = new Point(14, 509);
            tbSpeed.Maximum = 100;
            tbSpeed.Minimum = 1;
            tbSpeed.Name = "tbSpeed";
            tbSpeed.RightToLeft = RightToLeft.Yes;
            tbSpeed.Size = new Size(228, 45);
            tbSpeed.TabIndex = 4;
            tbSpeed.TickFrequency = 10;
            tbSpeed.Value = 25;
            tbSpeed.Scroll += tbSpeed_Scroll;
            // 
            // lbType
            // 
            lbType.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbType.Location = new Point(14, 647);
            lbType.Name = "lbType";
            lbType.Size = new Size(234, 23);
            lbType.TabIndex = 3;
            lbType.Text = "Color: ";
            lbType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbMinStep
            // 
            lbMinStep.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbMinStep.Location = new Point(14, 587);
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
            ClientSize = new Size(1034, 709);
            Controls.Add(panel1);
            Controls.Add(PicBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dots";
            ((System.ComponentModel.ISupportInitialize)PicBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panPopulations.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button btnRestart;
        private Label lbDraw;
        private GroupBox groupBox1;
        private RadioButton rbBarrier;
        private RadioButton rbFinish;
        private RadioButton rbStart;
        private Panel panPopulations;
        private Button btnNewPop;
        private Panel panColor;
        private Label lbName;
    }
}
