using System;
using System.Windows.Forms;

namespace RationalCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Rational? ReadRational(TextBox numBox, TextBox denBox, string name)
        {
            if (!long.TryParse(numBox.Text, out long num) ||
                !long.TryParse(denBox.Text, out long den))
            {
                MessageBox.Show($"Некоректне значення в {name}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            try
            {
                return new Rational(num, den);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void ShowResult(Rational? r)
        {
            if (r != null)
                txtResult.Text = r.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var a = ReadRational(txtNum1, txtDen1, "першої дроби");
            var b = ReadRational(txtNum2, txtDen2, "другої дроби");
            if (a != null && b != null) ShowResult(a + b);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            var a = ReadRational(txtNum1, txtDen1, "першої дроби");
            var b = ReadRational(txtNum2, txtDen2, "другої дроби");
            if (a != null && b != null) ShowResult(a - b);
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            var a = ReadRational(txtNum1, txtDen1, "першої дроби");
            var b = ReadRational(txtNum2, txtDen2, "другої дроби");
            if (a != null && b != null) ShowResult(a * b);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            var a = ReadRational(txtNum1, txtDen1, "першої дроби");
            var b = ReadRational(txtNum2, txtDen2, "другої дроби");
            if (a == null || b == null) return;

            try
            {
                ShowResult(a / b);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Ділення на нуль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtDen1.Clear();
            txtNum2.Clear();
            txtDen2.Clear();
            txtResult.Text = "0";
        }
    }

    // ───────────────────────────────────────────────
    // Клас Rational (раціональні дроби)
    // ───────────────────────────────────────────────
    public class Rational
    {
        public long Numerator { get; private set; }
        public long Denominator { get; private set; }

        public Rational(long num = 0, long den = 1)
        {
            if (den == 0)
                throw new ArgumentException("Знаменник не може бути нулем");

            if (den < 0)
            {
                num = -num;
                den = -den;
            }

            long g = GCD(Math.Abs(num), Math.Abs(den));
            Numerator = num / g;
            Denominator = den / g;
        }

        private static long GCD(long a, long b)
        {
            while (b != 0)
            {
                long t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        public Rational Add(Rational other)
        {
            long newNum = Numerator * other.Denominator + other.Numerator * Denominator;
            long newDen = Denominator * other.Denominator;
            return new Rational(newNum, newDen);
        }

        public Rational Sub(Rational other)
        {
            long newNum = Numerator * other.Denominator - other.Numerator * Denominator;
            long newDen = Denominator * other.Denominator;
            return new Rational(newNum, newDen);
        }

        public Rational Mul(Rational other)
        {
            return new Rational(
                Numerator * other.Numerator,
                Denominator * other.Denominator
            );
        }

        public Rational Div(Rational other)
        {
            if (other.Numerator == 0)
                throw new DivideByZeroException("Ділення на нуль");

            return new Rational(
                Numerator * other.Denominator,
                Denominator * other.Numerator
            );
        }

        public override string ToString()
        {
            if (Denominator == 1) return Numerator.ToString();
            if (Numerator == 0) return "0";
            return $"{Numerator}/{Denominator}";
        }

        public static Rational operator +(Rational a, Rational b) => a.Add(b);
        public static Rational operator -(Rational a, Rational b) => a.Sub(b);
        public static Rational operator *(Rational a, Rational b) => a.Mul(b);
        public static Rational operator /(Rational a, Rational b) => a.Div(b);
    }
}