namespace LabRobot
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
            this.label1 = new Label();
            this.btnChooseColor = new Button();
            this.btnClose = new Button();
            this.txtX = new TextBox();
            this.txtY = new TextBox();
            this.txtZ = new TextBox();
            this.labelX = new Label();
            this.labelY = new Label();
            this.labelZ = new Label();
            this.btnCalculate = new Button();
            this.labelResult = new Label();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(80, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 32);
            this.label1.Text = "Ура! Вийшло!";

            // btnChooseColor
            this.btnChooseColor.Location = new System.Drawing.Point(80, 80);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(140, 40);
            this.btnChooseColor.Text = "Вибрати колір";
            this.btnChooseColor.Click += new EventHandler(this.btnChooseColor_Click);

            // btnClose
            this.btnClose.Location = new System.Drawing.Point(240, 80);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 40);
            this.btnClose.Text = "Закрити";
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // txtX, txtY, txtZ
            this.txtX.Location = new System.Drawing.Point(140, 140);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 27);
            this.txtX.Text = "0";

            this.txtY.Location = new System.Drawing.Point(140, 175);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 27);
            this.txtY.Text = "0";

            this.txtZ.Location = new System.Drawing.Point(140, 210);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(100, 27);
            this.txtZ.Text = "0";

            // labelX, labelY, labelZ
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(80, 145);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(25, 20);
            this.labelX.Text = "x =";

            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(80, 180);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(25, 20);
            this.labelY.Text = "y =";

            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(80, 215);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(25, 20);
            this.labelZ.Text = "z =";

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(80, 260);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(260, 45);
            this.btnCalculate.Text = "Обчислити";
            this.btnCalculate.Click += new EventHandler(this.btnCalculate_Click);

            // labelResult
            this.labelResult.AutoSize = false;
            this.labelResult.Location = new System.Drawing.Point(80, 320);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(400, 120);
            this.labelResult.Font = new System.Drawing.Font("Consolas", 11F);
            this.labelResult.Text = "Результати з’являться тут...";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 460);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChooseColor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnChooseColor;
        private Button btnClose;
        private TextBox txtX;
        private TextBox txtY;
        private TextBox txtZ;
        private Label labelX;
        private Label labelY;
        private Label labelZ;
        private Button btnCalculate;
        private Label labelResult;
    }
}