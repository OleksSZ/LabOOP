using System;
using System.Windows.Forms;

namespace ComplexCal
{
    public class Complex
    {
        public double Real { get; set; }
        public double Imag { get; set; }

        public Complex() : this(0, 0) { }
        public Complex(double real) : this(real, 0) { }
        public Complex(double real, double imag)
        {
            Real = real;
            Imag = imag;
        }

        public Complex Add(Complex other) => new Complex(Real + other.Real, Imag + other.Imag);
        public Complex Subtract(Complex other) => new Complex(Real - other.Real, Imag - other.Imag);

        public Complex Multiply(Complex other)
        {
            return new Complex(
                Real * other.Real - Imag * other.Imag,
                Real * other.Imag + Imag * other.Real
            );
        }

        public Complex Divide(Complex other)
        {
            double den = other.Real * other.Real + other.Imag * other.Imag;
            if (Math.Abs(den) < 1e-10)
                throw new DivideByZeroException("Ділення на нуль (модуль ≈ 0)");

            double r = (Real * other.Real + Imag * other.Imag) / den;
            double i = (Imag * other.Real - Real * other.Imag) / den;
            return new Complex(r, i);
        }

        public Complex Conjugate() => new Complex(Real, -Imag);

        public double Magnitude() => Math.Sqrt(Real * Real + Imag * Imag);

        public override string ToString()
        {
            if (Math.Abs(Imag) < 1e-9)
                return Real.ToString("0.###");

            if (Math.Abs(Real) < 1e-9)
                return Imag >= 0 ? $"{Imag:0.###}i" : $"-{Math.Abs(Imag):0.###}i";

            string sign = Imag >= 0 ? " + " : " - ";
            return $"{Real:0.###}{sign}{Math.Abs(Imag):0.###}i";
        }

        public static Complex operator +(Complex a, Complex b) => a.Add(b);
        public static Complex operator -(Complex a, Complex b) => a.Subtract(b);
        public static Complex operator *(Complex a, Complex b) => a.Multiply(b);
        public static Complex operator /(Complex a, Complex b) => a.Divide(b);
    }


    // Основна форма

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Complex? ReadComplex(TextBox re, TextBox im, string fieldName)
        {
            if (!double.TryParse(re.Text, out double real) ||
                !double.TryParse(im.Text, out double imag))
            {
                MessageBox.Show($"Помилка в полі {fieldName}", "Некоректні дані",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return new Complex(real, imag);
        }

        private void ShowResult(Complex? z)
        {
            if (z is not null)
                txtResult.Text = z.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var a = ReadComplex(txtRe1, txtIm1, "z₁");
            var b = ReadComplex(txtRe2, txtIm2, "z₂");
            if (a != null && b != null) ShowResult(a + b);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            var a = ReadComplex(txtRe1, txtIm1, "z₁");
            var b = ReadComplex(txtRe2, txtIm2, "z₂");
            if (a != null && b != null) ShowResult(a - b);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            var a = ReadComplex(txtRe1, txtIm1, "z₁");
            var b = ReadComplex(txtRe2, txtIm2, "z₂");
            if (a != null && b != null) ShowResult(a * b);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            var a = ReadComplex(txtRe1, txtIm1, "z₁");
            var b = ReadComplex(txtRe2, txtIm2, "z₂");
            if (a == null || b == null) return;

            try
            {
                ShowResult(a / b);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConjugate_Click(object sender, EventArgs e)
        {
            var z = ReadComplex(txtRe1, txtIm1, "z₁");
            if (z != null) ShowResult(z.Conjugate());
        }

        private void btnMagnitude_Click(object sender, EventArgs e)
        {
            var z = ReadComplex(txtRe1, txtIm1, "z₁");
            if (z != null)
                txtResult.Text = $"|z₁| = {z.Magnitude():0.#####}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRe1.Clear(); txtIm1.Clear();
            txtRe2.Clear(); txtIm2.Clear();
            txtResult.Text = "0";
        }
    }
}