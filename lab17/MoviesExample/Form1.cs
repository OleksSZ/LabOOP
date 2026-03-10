using System;
using System.Windows.Forms;

namespace MoviesExample
{
    public partial class Form1 : Form
    {
        // Нестатичні поля
        private string movieTitle = string.Empty;
        private int movieDuration;

        // Статичні поля
        private static int totalMoviesCount;
        private static int maxDurationEver;

        // Статичний конструктор
        static Form1()
        {
            totalMoviesCount = 0;
            maxDurationEver = 0;
        }

        public Form1()
        {
            InitializeComponent();
            UpdateStatusLabels();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Введіть назву фільму.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtDuration.Text, out int duration) || duration <= 0)
            {
                MessageBox.Show("Введіть коректну тривалість (число > 0).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Запам'ятовуємо останній доданий фільм (нестатичні поля)
            movieTitle = title;
            movieDuration = duration;

            // Оновлюємо статистику
            totalMoviesCount++;
            if (duration > maxDurationEver)
            {
                maxDurationEver = duration;
            }

            lstMovies.Items.Add($"«{title}» — {duration} хв");

            txtTitle.Clear();
            txtDuration.Clear();

            UpdateStatusLabels();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            string message = $"Кількість фільмів: {totalMoviesCount:N0}\n" +
                             $"Найдовший фільм: {maxDurationEver} хв";

            if (totalMoviesCount == 0)
                message += "\n\nЩе не додано жодного фільму.";

            MessageBox.Show(message, "Статистика", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Нестатичний метод
        private void UpdateStatusLabels()
        {
            lblLast.Text = string.IsNullOrEmpty(movieTitle)
                ? "Останній фільм: —"
                : $"Останній: «{movieTitle}» — {movieDuration} хв";

            lblCount.Text = $"Фільмів: {totalMoviesCount}";
            lblMax.Text   = $"Макс тривалість: {maxDurationEver} хв";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstMovies.Items.Clear();
            txtTitle.Clear();
            txtDuration.Clear();
            UpdateStatusLabels();
        }
    }
}