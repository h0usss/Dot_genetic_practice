using System.ComponentModel;

namespace GeneticPractice
{
    public partial class PopulationInfo : UserControl
    {
        Random random = new Random();

        public PopulationInfo()
        {
            InitializeComponent();

            panColor.BackColor = Color.FromArgb(random.Next(100, 256), random.Next(100, 256), random.Next(100, 256));
            FillComboBox(cbCrossover, typeof(CrossoverType));
            FillComboBox(cbSelection, typeof(SelectionType));
        }

        private void panColor_Click(object sender, EventArgs e)
        {
            using ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            colorDialog.AllowFullOpen = true;

            if (colorDialog.ShowDialog() == DialogResult.OK)
                panColor.BackColor = colorDialog.Color;
        }

        private void tbSize_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(tbSize.Text, out _))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSize, "The field must contain only integers!");
                return;
            }
            else
                errorProvider1.SetError(tbSize, "");

            if (int.TryParse(tbElite.Text, out int elite) && int.TryParse(tbSize.Text, out int size))
            {
                if (elite > 0 && ((elite % 2 == 0 && size % 2 != 0) || (elite % 2 != 0 && size % 2 == 0)))
                {
                    tbSize.Text = (size - 1).ToString();
                    errorProvider1.SetError(tbSize, "Without an elite, there should be an even number of individuals in the population.");
                }
                else
                    errorProvider1.SetError(tbSize, "");
            }
        }

        private void tbElite_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(tbElite.Text, out _))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbElite, "The field must contain only integers!");
                return;
            }
            else
                errorProvider1.SetError(tbElite, "");

            if (int.TryParse(tbSize.Text, out int size) && int.TryParse(tbElite.Text, out int elite))
            {
                if (size > 0 && ((elite % 2 == 0 && size % 2 != 0) || (elite % 2 != 0 && size % 2 == 0)))
                {
                    tbSize.Text = (size - 1).ToString();
                    errorProvider1.SetError(tbSize, "Without an elite, there should be an even number of individuals in the population.");
                }
                else
                    errorProvider1.SetError(tbSize, "");
            }
        }

        private void FillComboBox(ComboBox cb, Type enumType)
        {
            cb.Items.Clear();

            foreach (var val in Enum.GetValues(enumType))
                cb.Items.Add(val);

            cb.SelectedIndex = 0;
        }

        private void cbSelection_SelectedIndexChanged(object sender, EventArgs e) // Need to change  (- _ -  )
        {
            if (cbSelection.Text == "BestDot")
            {
                cbCrossover.Items.Clear();
                cbCrossover.Items.Add(CrossoverType.None);
                cbCrossover.SelectedIndex = 0;
            }
            else if (cbCrossover.Items.Count == 1)
                FillComboBox(cbCrossover, typeof(CrossoverType));
        }

        //internal string GetName()                 IDN what is the best way  (ᓀ ᓀ)
        //{
        //    return tbNamePop.Text;
        //}

        //internal Color GetColor()
        //{
        //    return panColor.BackColor;
        //}

        //internal int GetSize()
        //{
        //    return int.Parse(tbSize.Text);
        //}

        //internal int GetElite()
        //{
        //    return int.Parse(tbElite.Text);
        //}

        //internal SelectionType GetSelection()
        //{
        //    return (SelectionType)cbSelection.SelectedIndex;
        //}

        //internal CrossoverType GetCrossover()
        //{
        //    return (CrossoverType)cbCrossover.SelectedIndex;
        //}
    }
}
