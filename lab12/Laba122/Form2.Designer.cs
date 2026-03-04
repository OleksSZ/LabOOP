namespace Laba122
{
    partial class Form2
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
            this.lblY = new Label();
            this.btnOK = new Button();

            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(40, 20);
            this.lblTitle.Text = "Результат обчислення:";

            // lblX
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(40, 70);
            this.lblX.Text = "x = ?";

            // lblA
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(40, 100);
            this.lblA.Text = "a = ?";

            // lblY
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblY.Location = new System.Drawing.Point(40, 140);
            this.lblY.Size = new System.Drawing.Size(200, 25);
            this.lblY.Text = "y = ?";

            // btnOK
            this.btnOK.Location = new System.Drawing.Point(120, 190);
            this.btnOK.Size = new System.Drawing.Size(120, 40);
            this.btnOK.Text = "OK";
            this.btnOK.Click += new EventHandler(this.btnOK_Click);

            // форма
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 260);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Результат";

            this.ResumeLayout(false);
        }

        private Label lblTitle;
        private Label lblX;
        private Label lblA;
        private Label lblY;
        private Button btnOK;
    }
}