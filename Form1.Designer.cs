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
            label3 = new Label();
            lbMinStep = new Label();
            ((System.ComponentModel.ISupportInitialize)PicBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PicBox
            // 
            PicBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PicBox.BackColor = Color.DarkGray;
            PicBox.Location = new Point(12, 12);
            PicBox.Name = "PicBox";
            PicBox.Size = new Size(748, 658);
            PicBox.TabIndex = 0;
            PicBox.TabStop = false;
            // 
            // lbEpochCount
            // 
            lbEpochCount.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbEpochCount.Location = new Point(14, 593);
            lbEpochCount.Name = "lbEpochCount";
            lbEpochCount.Size = new Size(234, 23);
            lbEpochCount.TabIndex = 1;
            lbEpochCount.Text = "Epoch: ";
            lbEpochCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbMinStep);
            panel1.Controls.Add(lbEpochCount);
            panel1.Location = new Point(776, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 658);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(14, 25);
            label3.Name = "label3";
            label3.Size = new Size(234, 23);
            label3.TabIndex = 3;
            label3.Text = "Epoch: ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Visible = false;
            // 
            // lbMinStep
            // 
            lbMinStep.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbMinStep.Location = new Point(14, 627);
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
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PicBox).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PicBox;
        private Label lbEpochCount;
        private Panel panel1;
        private Label lbMinStep;
        private Label label3;
    }
}
