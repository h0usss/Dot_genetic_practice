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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tbNamePop
            // 
            tbNamePop.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbNamePop.Location = new Point(3, 4);
            tbNamePop.Margin = new Padding(3, 4, 3, 4);
            tbNamePop.Name = "tbNamePop";
            tbNamePop.Size = new Size(169, 27);
            tbNamePop.TabIndex = 0;
            tbNamePop.Text = "Population";
            tbNamePop.TextAlign = HorizontalAlignment.Center;
            // 
            // panColor
            // 
            panColor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panColor.Location = new Point(185, 4);
            panColor.Margin = new Padding(3, 4, 3, 4);
            panColor.Name = "panColor";
            panColor.Size = new Size(73, 31);
            panColor.TabIndex = 1;
            panColor.Click += panColor_Click;
            // 
            // tbSize
            // 
            tbSize.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbSize.Location = new Point(51, 40);
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
            label1.Location = new Point(6, 44);
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
            label2.Location = new Point(138, 44);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 5;
            label2.Text = "Elite";
            // 
            // tbElite
            // 
            tbElite.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbElite.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbElite.Location = new Point(185, 40);
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
            cbSelection.FormattingEnabled = true;
            cbSelection.Location = new Point(6, 79);
            cbSelection.Margin = new Padding(3, 4, 3, 4);
            cbSelection.Name = "cbSelection";
            cbSelection.Size = new Size(119, 28);
            cbSelection.TabIndex = 6;
            cbSelection.SelectedIndexChanged += cbSelection_SelectedIndexChanged;
            // 
            // cbCrossover
            // 
            cbCrossover.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbCrossover.FormattingEnabled = true;
            cbCrossover.Location = new Point(138, 79);
            cbCrossover.Margin = new Padding(3, 4, 3, 4);
            cbCrossover.Name = "cbCrossover";
            cbCrossover.Size = new Size(119, 28);
            cbCrossover.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // PopulationInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.FixedSingle;
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
            Size = new Size(264, 120);
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
    }
}
