using System;
using System.Windows.Forms;

namespace laba
{
    public partial class Form1 : Form
    {
        private float fontSize = 12f;
        private readonly string correctPassword = "123qwerty";

        // Оголошуємо поля класу, щоб вони були видимі в ShowSelectedTask
        private Label lblDemoText;
        private Button btnIncrease;
        private Button btnDecrease;

        private Label lblCount;
        private ComboBox cbCount;
        private Button btnGenerate;
        private ListBox lbNumbers;

        private Label lblPass;
        private TextBox tbPass;
        private Button btnCheck;

        private Label lblA;
        private TextBox tbA;
        private Label lblB;
        private TextBox tbB;
        private Button btnSum;

        private Label lblX;
        private TextBox tbX;
        private Label lblY;
        private TextBox tbY;
        private RadioButton rbAdd;
        private RadioButton rbSub;
        private RadioButton rbMul;
        private RadioButton rbDiv;
        private Button btnCalculate;

        private Panel panelContent;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Лабораторна робота – 5 завдань";
            this.Size = new System.Drawing.Size(580, 520);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            SetupInterface();
        }

        private void SetupInterface()
        {
            // Вибір завдання
            var cbTasks = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new System.Drawing.Point(20, 15),
                Size = new System.Drawing.Size(520, 28),
                Font = new System.Drawing.Font("Segoe UI", 10f)
            };

            cbTasks.Items.AddRange(new[]
            {
                "Завдання 1 – Зміна розміру шрифту",
                "Завдання 2 – Генерація випадкових чисел",
                "Завдання 3 – Перевірка пароля",
                "Завдання 4 – Додавання двох чисел",
                "Завдання 5 – Простий калькулятор"
            });

            cbTasks.SelectedIndex = 0;
            cbTasks.SelectedIndexChanged += (s, e) => ShowSelectedTask(cbTasks.SelectedIndex);
            this.Controls.Add(cbTasks);

            // Контейнер для вмісту
            panelContent = new Panel
            {
                Location = new System.Drawing.Point(20, 55),
                Size = new System.Drawing.Size(520, 420),
                BorderStyle = BorderStyle.FixedSingle,
                AutoScroll = true
            };
            this.Controls.Add(panelContent);

            // Завдання 1
            lblDemoText = new Label
            {
                Text = "Це приклад тексту",
                AutoSize = true,
                Location = new System.Drawing.Point(30, 60),
                Font = new System.Drawing.Font("Segoe UI", fontSize)
            };

            btnIncrease = new Button { Text = "Збільшити", Location = new System.Drawing.Point(30, 140), Size = new System.Drawing.Size(110, 45) };
            btnDecrease = new Button { Text = "Зменшити", Location = new System.Drawing.Point(150, 140), Size = new System.Drawing.Size(110, 45) };

            btnIncrease.Click += (s, e) =>
            {
                fontSize += 1.5f;
                lblDemoText.Font = new System.Drawing.Font("Segoe UI", fontSize);
            };

            btnDecrease.Click += (s, e) =>
            {
                if (fontSize > 6) fontSize -= 1.5f;
                lblDemoText.Font = new System.Drawing.Font("Segoe UI", fontSize);
            };


            // Завдання 2

            lblCount = new Label { Text = "Кількість чисел:", Location = new System.Drawing.Point(30, 60), AutoSize = true };
            cbCount = new ComboBox
            {
                Location = new System.Drawing.Point(30, 90),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cbCount.Items.AddRange(new object[] { 5, 10, 15, 20, 30, 50 });
            cbCount.SelectedIndex = 1;

            btnGenerate = new Button { Text = "Згенерувати", Location = new System.Drawing.Point(30, 130), Size = new System.Drawing.Size(140, 45) };
            lbNumbers = new ListBox { Location = new System.Drawing.Point(30, 190), Size = new System.Drawing.Size(440, 200) };

            btnGenerate.Click += (s, e) =>
            {
                if (cbCount.SelectedItem == null) return;
                int n = (int)cbCount.SelectedItem;
                lbNumbers.Items.Clear();
                var rnd = new Random();
                for (int i = 0; i < n; i++)
                    lbNumbers.Items.Add(rnd.Next(1, 101));
            };

            // Завдання 3
            lblPass = new Label { Text = "Пароль:", Location = new System.Drawing.Point(30, 100), AutoSize = true };
            tbPass = new TextBox
            {
                Location = new System.Drawing.Point(30, 130),
                Size = new System.Drawing.Size(220, 28),
                UseSystemPasswordChar = true
            };
            btnCheck = new Button { Text = "Перевірити", Location = new System.Drawing.Point(30, 180), Size = new System.Drawing.Size(140, 45) };

            btnCheck.Click += (s, e) =>
            {
                string msg = tbPass.Text == correctPassword
                    ? "Пароль правильний!"
                    : "Пароль НЕ правильний!";

                MessageBox.Show(msg, "Результат перевірки",
                    MessageBoxButtons.OK,
                    tbPass.Text == correctPassword ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            };


            // Завдання 4

            lblA = new Label { Text = "Число A:", Location = new System.Drawing.Point(30, 100), AutoSize = true };
            tbA = new TextBox { Location = new System.Drawing.Point(30, 130), Size = new System.Drawing.Size(160, 28) };

            lblB = new Label { Text = "Число B:", Location = new System.Drawing.Point(30, 170), AutoSize = true };
            tbB = new TextBox { Location = new System.Drawing.Point(30, 200), Size = new System.Drawing.Size(160, 28) };

            btnSum = new Button { Text = "Додати", Location = new System.Drawing.Point(30, 250), Size = new System.Drawing.Size(140, 45) };

            btnSum.Click += (s, e) =>
            {
                if (double.TryParse(tbA.Text, out double a) && double.TryParse(tbB.Text, out double b))
                {
                    MessageBox.Show($"{a} + {b} = {a + b}", "Результат");
                }
                else
                {
                    MessageBox.Show("Введіть коректні числа", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };


            // Завдання 5

            lblX = new Label { Text = "X:", Location = new System.Drawing.Point(30, 80), AutoSize = true };
            tbX = new TextBox { Location = new System.Drawing.Point(30, 110), Size = new System.Drawing.Size(180, 28) };

            lblY = new Label { Text = "Y:", Location = new System.Drawing.Point(30, 150), AutoSize = true };
            tbY = new TextBox { Location = new System.Drawing.Point(30, 180), Size = new System.Drawing.Size(180, 28) };

            rbAdd = new RadioButton { Text = "+", Location = new System.Drawing.Point(30, 230), Checked = true };
            rbSub = new RadioButton { Text = "−", Location = new System.Drawing.Point(90, 230) };
            rbMul = new RadioButton { Text = "×", Location = new System.Drawing.Point(150, 230) };
            rbDiv = new RadioButton { Text = "÷", Location = new System.Drawing.Point(210, 230) };

            btnCalculate = new Button { Text = "Обчислити", Location = new System.Drawing.Point(30, 270), Size = new System.Drawing.Size(140, 45) };

            btnCalculate.Click += (s, e) =>
            {
                if (!double.TryParse(tbX.Text, out double x) || !double.TryParse(tbY.Text, out double y))
                {
                    MessageBox.Show("Введіть коректні числа", "Помилка");
                    return;
                }

                double result = 0;
                string operation = "";

                if (rbAdd.Checked) { result = x + y; operation = "+"; }
                else if (rbSub.Checked) { result = x - y; operation = "−"; }
                else if (rbMul.Checked) { result = x * y; operation = "×"; }
                else if (rbDiv.Checked)
                {
                    if (Math.Abs(y) < 1e-10)
                    {
                        MessageBox.Show("Ділення на нуль заборонено!", "Помилка");
                        return;
                    }
                    result = x / y; operation = "÷";
                }

                MessageBox.Show($"{x} {operation} {y} = {result}", "Результат");
            };


            ShowSelectedTask(0);
        }

        private void ShowSelectedTask(int index)
        {
            panelContent.Controls.Clear();

            switch (index)
            {
                case 0:
                    panelContent.Controls.Add(lblDemoText);
                    panelContent.Controls.Add(btnIncrease);
                    panelContent.Controls.Add(btnDecrease);
                    break;

                case 1:
                    panelContent.Controls.Add(lblCount);
                    panelContent.Controls.Add(cbCount);
                    panelContent.Controls.Add(btnGenerate);
                    panelContent.Controls.Add(lbNumbers);
                    break;

                case 2:
                    panelContent.Controls.Add(lblPass);
                    panelContent.Controls.Add(tbPass);
                    panelContent.Controls.Add(btnCheck);
                    break;

                case 3:
                    panelContent.Controls.Add(lblA);
                    panelContent.Controls.Add(tbA);
                    panelContent.Controls.Add(lblB);
                    panelContent.Controls.Add(tbB);
                    panelContent.Controls.Add(btnSum);
                    break;

                case 4:
                    panelContent.Controls.Add(lblX);
                    panelContent.Controls.Add(tbX);
                    panelContent.Controls.Add(lblY);
                    panelContent.Controls.Add(tbY);
                    panelContent.Controls.Add(rbAdd);
                    panelContent.Controls.Add(rbSub);
                    panelContent.Controls.Add(rbMul);
                    panelContent.Controls.Add(rbDiv);
                    panelContent.Controls.Add(btnCalculate);
                    break;
            }
        }
    }
}