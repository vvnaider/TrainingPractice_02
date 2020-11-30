using System;
using System.Windows.Forms;

namespace WinEquation
{
    public partial class FormEquation : Form
    {
        private EquationColor fc;
        public EquationColor Fc
        {
            get
            {
                return fc;
            }
        }
        public FormEquation(EquationColor fc)
        {
            InitializeComponent();
            this.fc = fc;

            textBoxEquation.Text = fc.Equation;
            panelColor.BackColor = fc.Color;
        }

        private void panelColor_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialogEquation.ShowDialog();
            panelColor.BackColor = colorDialogEquation.Color;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            fc.Equation = textBoxEquation.Text;
            fc.Color = panelColor.BackColor;

            this.DialogResult = DialogResult.OK;
            this.Visible = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Visible = false;
        }

        private void buttonText_Click(object sender, EventArgs e)
        {
            textBoxEquation.Text = textBoxEquation.Text.Insert(
                textBoxEquation.SelectionStart, ((Button)sender).Text);
        }

        private void FormEquation_Load(object sender, EventArgs e)
        {

        }

        private void textBoxEquation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
