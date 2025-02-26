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
            PicBox.Location = new Point(14, 16);
            PicBox.Margin = new Padding(3, 4, 3, 4);
            PicBox.Name = "PicBox";
            PicBox.Size = new Size(855, 913);
            PicBox.TabIndex = 0;
            PicBox.TabStop = false;
            PicBox.MouseDown += PicBox_MouseDown;
            PicBox.MouseMove += PicBox_MouseMove;
            PicBox.MouseUp += PicBox_MouseUp;
            // 
            // lbEpochCount
            // 
            lbEpochCount.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbEpochCount.Location = new Point(16, 743);
            lbEpochCount.Name = "lbEpochCount";
            lbEpochCount.Size = new Size(267, 31);
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
            panel1.Location = new Point(879, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 913);
            panel1.TabIndex = 2;
            // 
            // lbName
            // 
            lbName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbName.Location = new Point(16, 823);
            lbName.Name = "lbName";
            lbName.Size = new Size(267, 31);
            lbName.TabIndex = 12;
            lbName.Text = "Name: ";
            lbName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panColor
            // 
            panColor.Location = new Point(85, 863);
            panColor.Margin = new Padding(3, 4, 3, 4);
            panColor.Name = "panColor";
            panColor.Size = new Size(183, 31);
            panColor.TabIndex = 11;
            // 
            // panPopulations
            // 
            panPopulations.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panPopulations.AutoScroll = true;
            panPopulations.Controls.Add(btnNewPop);
            panPopulations.Location = new Point(3, 116);
            panPopulations.Margin = new Padding(3, 4, 3, 4);
            panPopulations.Name = "panPopulations";
            panPopulations.Size = new Size(295, 451);
            panPopulations.TabIndex = 10;
            // 
            // btnNewPop
            // 
            btnNewPop.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnNewPop.Location = new Point(0, 0);
            btnNewPop.Margin = new Padding(3, 4, 3, 4);
            btnNewPop.Name = "btnNewPop";
            btnNewPop.Size = new Size(271, 57);
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
            groupBox1.Location = new Point(3, 47);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(295, 97);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // rbBarrier
            // 
            rbBarrier.AutoSize = true;
            rbBarrier.Font = new Font("Verdana", 12F);
            rbBarrier.Location = new Point(173, 21);
            rbBarrier.Margin = new Padding(3, 4, 3, 4);
            rbBarrier.Name = "rbBarrier";
            rbBarrier.Size = new Size(104, 29);
            rbBarrier.TabIndex = 2;
            rbBarrier.TabStop = true;
            rbBarrier.Text = "Barrier";
            rbBarrier.UseVisualStyleBackColor = true;
            // 
            // rbFinish
            // 
            rbFinish.AutoSize = true;
            rbFinish.Font = new Font("Verdana", 12F);
            rbFinish.Location = new Point(89, 21);
            rbFinish.Margin = new Padding(3, 4, 3, 4);
            rbFinish.Name = "rbFinish";
            rbFinish.Size = new Size(93, 29);
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
            rbStart.Location = new Point(7, 21);
            rbStart.Margin = new Padding(3, 4, 3, 4);
            rbStart.Name = "rbStart";
            rbStart.Size = new Size(84, 29);
            rbStart.TabIndex = 0;
            rbStart.TabStop = true;
            rbStart.Text = "Start";
            rbStart.UseVisualStyleBackColor = true;
            // 
            // lbDraw
            // 
            lbDraw.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbDraw.Location = new Point(13, 0);
            lbDraw.Name = "lbDraw";
            lbDraw.Size = new Size(267, 64);
            lbDraw.TabIndex = 8;
            lbDraw.Text = "Draw";
            lbDraw.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRestart
            // 
            btnRestart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestart.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestart.Location = new Point(154, 575);
            btnRestart.Margin = new Padding(3, 4, 3, 4);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(129, 44);
            btnRestart.TabIndex = 7;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(14, 575);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(129, 44);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lbSpeed
            // 
            lbSpeed.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbSpeed.Location = new Point(16, 644);
            lbSpeed.Name = "lbSpeed";
            lbSpeed.Size = new Size(267, 31);
            lbSpeed.TabIndex = 5;
            lbSpeed.Text = "Speed ";
            lbSpeed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbSpeed
            // 
            tbSpeed.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbSpeed.Location = new Point(16, 679);
            tbSpeed.Margin = new Padding(3, 4, 3, 4);
            tbSpeed.Maximum = 100;
            tbSpeed.Minimum = 1;
            tbSpeed.Name = "tbSpeed";
            tbSpeed.RightToLeft = RightToLeft.Yes;
            tbSpeed.Size = new Size(274, 56);
            tbSpeed.TabIndex = 4;
            tbSpeed.TickFrequency = 10;
            tbSpeed.Value = 25;
            tbSpeed.Scroll += tbSpeed_Scroll;
            // 
            // lbType
            // 
            lbType.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbType.Location = new Point(16, 863);
            lbType.Name = "lbType";
            lbType.Size = new Size(267, 31);
            lbType.TabIndex = 3;
            lbType.Text = "Color: ";
            lbType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbMinStep
            // 
            lbMinStep.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbMinStep.Location = new Point(16, 783);
            lbMinStep.Name = "lbMinStep";
            lbMinStep.Size = new Size(289, 31);
            lbMinStep.TabIndex = 2;
            lbMinStep.Text = "Min steps:";
            lbMinStep.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1193, 945);
            Controls.Add(panel1);
            Controls.Add(PicBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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
