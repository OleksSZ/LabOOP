using System;
using System.Windows.Forms;

namespace SphericalSegmentCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double R = double.Parse(txtRadius.Text.Replace(".", ","));
                double H = double.Parse(txtHeight.Text.Replace(".", ","));

                if (R <= 0 || H <= 0)
                {
                    MessageBox.Show("Радіус і висота мають бути більше 0!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (H > 2 * R)
                {
                    MessageBox.Show("Висота сегмента не може бути більшою за діаметр кулі (2R)!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Обчислення
                double S_bok   = 2 * Math.PI * R * H;
                double S_pov   = Math.PI * H * (4 * R - H);
                double V       = Math.PI * H * H * (R - H / 3);

                // Виведення результатів
                lblSBokValue.Text   = S_bok.ToString("N2");
                lblSPovValue.Text   = S_pov.ToString("N2");
                lblVolumeValue.Text = V.ToString("N2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введіть коректні числа!\nВикористовуйте кому або крапку як десятковий роздільник.", 
                    "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Щось пішло не так:\n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRadius_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbersAndSeparator(e);
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbersAndSeparator(e);
        }

        private void AllowOnlyNumbersAndSeparator(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != ',' &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRadius.Clear();
            txtHeight.Clear();
            lblSBokValue.Text = "-";
            lblSPovValue.Text = "-";
            lblVolumeValue.Text = "-";
        }
    }
}