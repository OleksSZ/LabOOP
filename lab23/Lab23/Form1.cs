using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab23

{
    public partial class Form1 : Form
    {
        private List<Flight> flights = new List<Flight>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var flight = new Flight(
                    txtNumber.Text,
                    txtDeparture.Text,
                    txtDestination.Text,
                    DateTime.Parse(txtTime.Text)
                );
                flights.Add(flight);
                UpdateList();
            }
            catch
            {
                MessageBox.Show("Помилка введення даних!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string number = txtNumber.Text;
            var flight = flights.FirstOrDefault(f => f.Number == number);
            if (flight != null)
            {
                flights.Remove(flight);
                UpdateList();
            }
            else
            {
                MessageBox.Show("Рейс не знайдено!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string dest = txtDestination.Text;
            var result = flights.Where(f => f.Destination == dest).ToList();

            txtResult.Clear();
            if (result.Count > 0)
            {
                foreach (var f in result)
                    txtResult.AppendText(f + Environment.NewLine);
            }
            else
            {
                txtResult.Text = "Рейси не знайдено.";
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            flights = flights.OrderBy(f => f.DepartureTime).ToList();
            UpdateList();
        }

        private void UpdateList()
        {
            txtResult.Clear();
            foreach (var f in flights)
                txtResult.AppendText(f + Environment.NewLine);
        }
    }
}
