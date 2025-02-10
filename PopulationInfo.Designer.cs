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
            tbNamePop.Location = new Point(3, 3);
            tbNamePop.Name = "tbNamePop";
            tbNamePop.Size = new Size(148, 23);
            tbNamePop.TabIndex = 0;
            tbNamePop.Text = "Population";
            tbNamePop.TextAlign = HorizontalAlignment.Center;
            // 
            // panColor
            // 
            panColor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panColor.Location = new Point(162, 3);
            panColor.Name = "panColor";
            panColor.Size = new Size(64, 23);
            panColor.TabIndex = 1;
            panColor.Click += panColor_Click;
            // 
            // tbSize
            // 
            tbSize.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbSize.Location = new Point(45, 30);
            tbSize.Name = "tbSize";
            tbSize.Size = new Size(65, 23);
            tbSize.TabIndex = 2;
            tbSize.Text = "200";
            tbSize.TextAlign = HorizontalAlignment.Center;
            tbSize.Validating += tbSize_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(5, 33);
            label1.Name = "label1";
            label1.Size = new Size(34, 16);
            label1.TabIndex = 3;
            label1.Text = "Size";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(121, 33);
            label2.Name = "label2";
            label2.Size = new Size(35, 16);
            label2.TabIndex = 5;
            label2.Text = "Elite";
            // 
            // tbElite
            // 
            tbElite.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbElite.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbElite.Location = new Point(162, 30);
            tbElite.Name = "tbElite";
            tbElite.Size = new Size(65, 23);
            tbElite.TabIndex = 4;
            tbElite.Text = "0";
            tbElite.TextAlign = HorizontalAlignment.Center;
            tbElite.Validating += tbElite_Validating;
            // 
            // cbSelection
            // 
            cbSelection.FormattingEnabled = true;
            cbSelection.Location = new Point(5, 59);
            cbSelection.Name = "cbSelection";
            cbSelection.Size = new Size(105, 23);
            cbSelection.TabIndex = 6;
            cbSelection.SelectedIndexChanged += cbSelection_SelectedIndexChanged;
            // 
            // cbCrossover
            // 
            cbCrossover.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbCrossover.FormattingEnabled = true;
            cbCrossover.Location = new Point(121, 59);
            cbCrossover.Name = "cbCrossover";
            cbCrossover.Size = new Size(105, 23);
            cbCrossover.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // PopulationInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Name = "PopulationInfo";
            Size = new Size(231, 90);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNamePop;
        private Panel panColor;
        private TextBox tbSize;
        private Label label1;
        private Label label2;
        private TextBox tbElite;
        private ComboBox cbSelection;
        private ComboBox cbCrossover;
        private ColorDialog colorDialog1;
        private ErrorProvider errorProvider1;
    }
}
