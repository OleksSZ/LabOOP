namespace Laba12
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.chkSum = new System.Windows.Forms.CheckBox();
            this.chkSub = new System.Windows.Forms.CheckBox();
            this.chkMul = new System.Windows.Forms.CheckBox();
            this.chkDiv = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(80, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(340, 32);
            this.labelTitle.Text = "Лаба 12 — Калькулятор";

            // txtA
            this.txtA.Location = new System.Drawing.Point(140, 90);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(120, 27);
            this.txtA.Text = "0";

            // txtB
            this.txtB.Location = new System.Drawing.Point(140, 130);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(120, 27);
            this.txtB.Text = "0";

            // lblA
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(80, 95);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(30, 20);
            this.lblA.Text = "A =";

            // lblB
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(80, 135);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(30, 20);
            this.lblB.Text = "B =";

            // chkSum
            this.chkSum.AutoSize = true;
            this.chkSum.Location = new System.Drawing.Point(80, 180);
            this.chkSum.Name = "chkSum";
            this.chkSum.Size = new System.Drawing.Size(140, 24);
            this.chkSum.Text = "Додавання (+)";

            // chkSub
            this.chkSub.AutoSize = true;
            this.chkSub.Location = new System.Drawing.Point(80, 210);
            this.chkSub.Name = "chkSub";
            this.chkSub.Size = new System.Drawing.Size(140, 24);
            this.chkSub.Text = "Віднімання (−)";

            // chkMul
            this.chkMul.AutoSize = true;
            this.chkMul.Location = new System.Drawing.Point(80, 240);
            this.chkMul.Name = "chkMul";
            this.chkMul.Size = new System.Drawing.Size(140, 24);
            this.chkMul.Text = "Множення (×)";

            // chkDiv
            this.chkDiv.AutoSize = true;
            this.chkDiv.Location = new System.Drawing.Point(80, 270);
            this.chkDiv.Name = "chkDiv";
            this.chkDiv.Size = new System.Drawing.Size(140, 24);
            this.chkDiv.Text = "Ділення (÷)";

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(80, 320);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(260, 45);
            this.btnCalculate.Text = "Обчислити";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // labelResult
            this.labelResult.AutoSize = false;
            this.labelResult.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular);
            this.labelResult.Location = new System.Drawing.Point(80, 380);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(500, 180);
            this.labelResult.Text = "Результати з’являться тут...";

            // btnChooseColor
            this.btnChooseColor.Location = new System.Drawing.Point(80, 580);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(140, 40);
            this.btnChooseColor.Text = "Вибрати колір";
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);

            // btnClose
            this.btnClose.Location = new System.Drawing.Point(240, 580);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 40);
            this.btnClose.Text = "Закрити";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 650);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChooseColor);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkDiv);
            this.Controls.Add(this.chkMul);
            this.Controls.Add(this.chkSub);
            this.Controls.Add(this.chkSum);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота 12";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.CheckBox chkSum;
        private System.Windows.Forms.CheckBox chkSub;
        private System.Windows.Forms.CheckBox chkMul;
        private System.Windows.Forms.CheckBox chkDiv;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Button btnClose;
    }
}