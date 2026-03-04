namespace Laba122
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

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblX = new Label();
            this.lblA = new Label();
            this.txtX = new TextBox();
            this.txtA = new TextBox();
            this.btnCalculate = new Button();
            this.btnClose = new Button();

            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(50, 20);
            this.lblTitle.Text = "Обчислення функції";

            // lblX, txtX
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(50, 80);
            this.lblX.Text = "x =";

            this.txtX.Location = new System.Drawing.Point(100, 77);
            this.txtX.Size = new System.Drawing.Size(140, 27);
            this.txtX.Text = "2.5";

            // lblA, txtA
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(50, 120);
            this.lblA.Text = "a =";

            this.txtA.Location = new System.Drawing.Point(100, 117);
            this.txtA.Size = new System.Drawing.Size(140, 27);
            this.txtA.Text = "1.0";

            // кнопки
            this.btnCalculate.Location = new System.Drawing.Point(50, 170);
            this.btnCalculate.Size = new System.Drawing.Size(140, 40);
            this.btnCalculate.Text = "Обчислити";
            this.btnCalculate.Click += new EventHandler(this.btnCalculate_Click);

            this.btnClose.Location = new System.Drawing.Point(210, 170);
            this.btnClose.Size = new System.Drawing.Size(140, 40);
            this.btnClose.Text = "Закрити";
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // налаштування форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 240);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Laba12.2 - Кусочна функція";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitle;
        private Label lblX;
        private Label lblA;
        private TextBox txtX;
        private TextBox txtA;
        private Button btnCalculate;
        private Button btnClose;
    }
}