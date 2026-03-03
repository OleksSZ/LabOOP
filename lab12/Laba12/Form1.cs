using System;
using System.Text;
using System.Windows.Forms;

namespace Laba12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double Sum(double a, double b) => a + b;

        private double Sub(double a, double b) => a - b;

        private double Mul(double a, double b) => a * b;

        private double Div(double a, double b)
        {
            if (Math.Abs(b) < 1e-10)
                throw new DivideByZeroException("Ділення на нуль заборонено!");
            return a / b;
        }

        // Методи для зміни кольору з Form2
        public void SetTextColor(Color color)
        {
            labelTitle.ForeColor = color;
            labelResult.ForeColor = color;
        }

        public void SetBackColor(Color color)
        {
            this.BackColor = color;
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            using (var form2 = new Form2 { MainForm = this })
            {
                form2.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtA.Text, out double a) ||
                !double.TryParse(txtB.Text, out double b))
            {
                MessageBox.Show("Введіть коректні числа в обидва поля!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sb = new StringBuilder();
            sb.AppendLine($"Дано числа: {a} та {b}");
            sb.AppendLine("──────────────────────────────────────────────");

            bool anySelected = false;

            try
            {
                if (chkSum.Checked)
                {
                    sb.AppendLine($"Додавання     -  {Sum(a, b),12:F4}");
                    anySelected = true;
                }

                if (chkSub.Checked)
                {
                    sb.AppendLine($"Віднімання    -  {Sub(a, b),12:F4}");
                    anySelected = true;
                }

                if (chkMul.Checked)
                {
                    sb.AppendLine($"Множення      -  {Mul(a, b),12:F4}");
                    anySelected = true;
                }

                if (chkDiv.Checked)
                {
                    sb.AppendLine($"Ділення       →  {Div(a, b),12:F4}");
                    anySelected = true;
                }

                if (!anySelected)
                {
                    MessageBox.Show("Оберіть хоча б одну операцію!", "Попередження",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                sb.AppendLine("──────────────────────────────────────────────");
                sb.AppendLine("Обчислення виконано");

                labelResult.Text = sb.ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Непередбачена помилка:\n{ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}