namespace Lab23
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TextBox txtResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(20, 20);
            this.txtNumber.PlaceholderText = "Номер рейсу";
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(20, 50);
            this.txtDeparture.PlaceholderText = "Пункт відправлення";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(20, 80);
            this.txtDestination.PlaceholderText = "Пункт призначення";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(20, 110);
            this.txtTime.PlaceholderText = "Час (yyyy-MM-dd HH:mm)";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(250, 20);
            this.btnAdd.Text = "Додати";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(250, 50);
            this.btnDelete.Text = "Видалити";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(250, 80);
            this.btnSearch.Text = "Пошук";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(250, 110);
            this.btnSort.Text = "Сортувати";
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(20, 150);
            this.txtResult.Multiline = true;
            this.txtResult.Size = new System.Drawing.Size(330, 150);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(380, 320);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtDeparture);
            this.Controls.Add(this.txtNumber);
            this.Text = "Рейси";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
