namespace GeneticPractice
{
    partial class PopulationInfo
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tbNamePop = new TextBox();
            panColor = new Panel();
            tbSize = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbElite = new TextBox();
            cbSelection = new ComboBox();
            cbCrossover = new ComboBox();
            colorDialog1 = new ColorDialog();
            errorProvider1 = new ErrorProvider(components);
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tbNamePop
            // 
            tbNamePop.Cursor = Cursors.Hand;
            tbNamePop.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbNamePop.Location = new Point(-1, 4);
            tbNamePop.Margin = new Padding(3, 4, 3, 4);
            tbNamePop.Name = "tbNamePop";
            tbNamePop.Size = new Size(145, 27);
            tbNamePop.TabIndex = 0;
            tbNamePop.Text = "Population";
            tbNamePop.TextAlign = HorizontalAlignment.Center;
            // 
            // panColor
            // 
            panColor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panColor.Cursor = Cursors.Hand;
            panColor.Location = new Point(157, 4);
            panColor.Margin = new Padding(3, 4, 3, 4);
            panColor.Name = "panColor";
            panColor.Size = new Size(41, 27);
            panColor.TabIndex = 1;
            panColor.Click += panColor_Click;
            // 
            // tbSize
            // 
            tbSize.Cursor = Cursors.Hand;
            tbSize.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbSize.Location = new Point(47, 39);
            tbSize.Margin = new Padding(3, 4, 3, 4);
            tbSize.Name = "tbSize";
            tbSize.Size = new Size(74, 27);
            tbSize.TabIndex = 2;
            tbSize.Text = "200";
            tbSize.TextAlign = HorizontalAlignment.Center;
            tbSize.Validating += tbSize_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(2, 43);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 3;
            label1.Text = "Size";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(141, 43);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 5;
            label2.Text = "Elite";
            // 
            // tbElite
            // 
            tbElite.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbElite.Cursor = Cursors.Hand;
            tbElite.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbElite.Location = new Point(188, 39);
            tbElite.Margin = new Padding(3, 4, 3, 4);
            tbElite.Name = "tbElite";
            tbElite.Size = new Size(74, 27);
            tbElite.TabIndex = 4;
            tbElite.Text = "0";
            tbElite.TextAlign = HorizontalAlignment.Center;
            tbElite.Validating += tbElite_Validating;
            // 
            // cbSelection
            // 
            cbSelection.Cursor = Cursors.Hand;
            cbSelection.FormattingEnabled = true;
            cbSelection.Location = new Point(2, 94);
            cbSelection.Margin = new Padding(3, 4, 3, 4);
            cbSelection.Name = "cbSelection";
            cbSelection.Size = new Size(119, 28);
            cbSelection.TabIndex = 6;
            cbSelection.SelectedIndexChanged += cbSelection_SelectedIndexChanged;
            // 
            // cbCrossover
            // 
            cbCrossover.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbCrossover.Cursor = Cursors.Hand;
            cbCrossover.FormattingEnabled = true;
            cbCrossover.Location = new Point(141, 94);
            cbCrossover.Margin = new Padding(3, 4, 3, 4);
            cbCrossover.Name = "cbCrossover";
            cbCrossover.Size = new Size(119, 28);
            cbCrossover.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(2, 70);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 8;
            label3.Text = "Selection";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(134, 70);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 9;
            label4.Text = "Crossover";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(214, 4);
            button1.Name = "button1";
            button1.Size = new Size(48, 28);
            button1.TabIndex = 10;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PopulationInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbCrossover);
            Controls.Add(cbSelection);
            Controls.Add(label2);
            Controls.Add(tbElite);
            Controls.Add(label1);
            Controls.Add(tbSize);
            Controls.Add(panColor);
            Controls.Add(tbNamePop);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PopulationInfo";
            Size = new Size(271, 127);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal TextBox tbNamePop;
        internal Panel panColor;
        internal TextBox tbSize;
        private Label label1;
        private Label label2;
        internal TextBox tbElite;
        internal ComboBox cbSelection;
        internal ComboBox cbCrossover;
        private ColorDialog colorDialog1;
        private ErrorProvider errorProvider1;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}
