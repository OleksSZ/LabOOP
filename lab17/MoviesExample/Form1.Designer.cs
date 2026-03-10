namespace MoviesExample
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtTitle = new TextBox();
            this.txtDuration = new TextBox();
            this.lblTitle = new Label();
            this.lblDuration = new Label();
            this.btnAdd = new Button();
            this.lstMovies = new ListBox();
            this.btnStats = new Button();
            this.btnClear = new Button();
            this.lblCount = new Label();
            this.lblMax = new Label();
            this.lblLast = new Label();
            this.SuspendLayout();

            // txtTitle
            this.txtTitle.Location = new System.Drawing.Point(110, 20);
            this.txtTitle.Size = new System.Drawing.Size(240, 23);
            this.txtTitle.TabIndex = 0;

            // txtDuration
            this.txtDuration.Location = new System.Drawing.Point(110, 55);
            this.txtDuration.Size = new System.Drawing.Size(100, 23);
            this.txtDuration.TabIndex = 1;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 23);
            this.lblTitle.Size = new System.Drawing.Size(92, 15);
            this.lblTitle.Text = "Назва фільму:";

            // lblDuration
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(12, 58);
            this.lblDuration.Size = new System.Drawing.Size(88, 15);
            this.lblDuration.Text = "Тривалість (хв):";

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(230, 52);
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Додати";
            this.btnAdd.Click += btnAdd_Click;

            // lstMovies
            this.lstMovies.Location = new System.Drawing.Point(12, 95);
            this.lstMovies.Size = new System.Drawing.Size(338, 169);
            this.lstMovies.TabIndex = 3;

            // btnStats
            this.btnStats.Location = new System.Drawing.Point(12, 275);
            this.btnStats.Size = new System.Drawing.Size(165, 35);
            this.btnStats.TabIndex = 4;
            this.btnStats.Text = "Статистика";
            this.btnStats.Click += btnStats_Click;

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(185, 275);
            this.btnClear.Size = new System.Drawing.Size(165, 35);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Очистити список";
            this.btnClear.Click += btnClear_Click;

            // lblCount
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(12, 320);
            this.lblCount.Text = "Фільмів: 0";

            // lblMax
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(12, 340);
            this.lblMax.Text = "Макс тривалість: 0 хв";

            // lblLast
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(12, 360);
            this.lblLast.Text = "Останній фільм: —";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 395);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.lstMovies);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtTitle);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Фільми — облік";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtDuration;
        private Label lblTitle;
        private Label lblDuration;
        private Button btnAdd;
        private ListBox lstMovies;
        private Button btnStats;
        private Button btnClear;
        private Label lblCount;
        private Label lblMax;
        private Label lblLast;
    }
}