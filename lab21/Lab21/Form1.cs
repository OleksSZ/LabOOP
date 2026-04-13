using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab21
{
    public partial class Form1 : Form
    {
        private List<Student> students;

        public Form1()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            // гуртки
            
            students = new List<Student>
            {
                new Student("Іван Петренко", new List<string>{"Футбол", "Математика"}),
                new Student("Олена Коваль", new List<string>{"Хореографія", "Музика"}),
                new Student("Сергій Бондар", new List<string>{"Футбол", "Програмування", "Шахи"}),
                new Student("Марія Сидоренко", new List<string>{"Музика"})
            };
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string club = txtClub.Text.Trim();
            if (string.IsNullOrEmpty(club))
            {
                MessageBox.Show("Введіть назву гуртка!");
                return;
            }

            var result = students
                .Where(s => s.AttendsClub(club))
                .Select(s => s.FullName)
                .ToList();

            txtResult.Clear();
            if (result.Count > 0)
            {
                txtResult.AppendText($"Гурток: {club}\n");
                foreach (var name in result)
                {
                    txtResult.AppendText(name + Environment.NewLine);
                }
            }
            else
            {
                txtResult.Text = $"Ніхто не відвідує гурток \"{club}\"";
            }
        }
    }
}
