namespace ComplexCal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRe1 = new System.Windows.Forms.TextBox();
            this.txtIm1 = new System.Windows.Forms.TextBox();
            this.txtRe2 = new System.Windows.Forms.TextBox();
            this.txtIm2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnConjugate = new System.Windows.Forms.Button();
            this.btnMagnitude = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblZ1 = new System.Windows.Forms.Label();
            this.lblPlus1 = new System.Windows.Forms.Label();
            this.lblI1 = new System.Windows.Forms.Label();
            this.lblZ2 = new System.Windows.Forms.Label();
            this.lblPlus2 = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRe1
            // 
            this.txtRe1.Location = new System.Drawing.Point(45, 45);
            this.txtRe1.Name = "txtRe1";
            this.txtRe1.Size = new System.Drawing.Size(80, 27);
            this.txtRe1.TabIndex = 0;
            this.txtRe1.Text = "0";
            // 
            // txtIm1
            // 
            this.txtIm1.Location = new System.Drawing.Point(135, 45);
            this.txtIm1.Name = "txtIm1";
            this.txtIm1.Size = new System.Drawing.Size(80, 27);
            this.txtIm1.TabIndex = 1;
            this.txtIm1.Text = "0";
            // 
            // txtRe2
            // 
            this.txtRe2.Location = new System.Drawing.Point(45, 105);
            this.txtRe2.Name = "txtRe2";
            this.txtRe2.Size = new System.Drawing.Size(80, 27);
            this.txtRe2.TabIndex = 2;
            this.txtRe2.Text = "0";
            // 
            // txtIm2
            // 
            this.txtIm2.Location = new System.Drawing.Point(135, 105);
            this.txtIm2.Name = "txtIm2";
            this.txtIm2.Size = new System.Drawing.Size(80, 27);
            this.txtIm2.TabIndex = 3;
            this.txtIm2.Text = "0";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(300, 75);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(220, 27);
            this.txtResult.TabIndex = 4;
            this.txtResult.Text = "0";
            this.txtResult.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 40);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(115, 165);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(60, 40);
            this.btnSubtract.TabIndex = 6;
            this.btnSubtract.Text = "−";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(185, 165);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(60, 40);
            this.btnMultiply.TabIndex = 7;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(255, 165);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(60, 40);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnConjugate
            // 
            this.btnConjugate.Location = new System.Drawing.Point(325, 165);
            this.btnConjugate.Name = "btnConjugate";
            this.btnConjugate.Size = new System.Drawing.Size(90, 40);
            this.btnConjugate.TabIndex = 9;
            this.btnConjugate.Text = "conj(z₁)";
            this.btnConjugate.UseVisualStyleBackColor = true;
            this.btnConjugate.Click += new System.EventHandler(this.btnConjugate_Click);
            // 
            // btnMagnitude
            // 
            this.btnMagnitude.Location = new System.Drawing.Point(425, 165);
            this.btnMagnitude.Name = "btnMagnitude";
            this.btnMagnitude.Size = new System.Drawing.Size(90, 40);
            this.btnMagnitude.TabIndex = 10;
            this.btnMagnitude.Text = "|z₁|";
            this.btnMagnitude.UseVisualStyleBackColor = true;
            this.btnMagnitude.Click += new System.EventHandler(this.btnMagnitude_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(525, 165);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 40);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblZ1
            // 
            this.lblZ1.AutoSize = true;
            this.lblZ1.Location = new System.Drawing.Point(45, 25);
            this.lblZ1.Name = "lblZ1";
            this.lblZ1.Size = new System.Drawing.Size(35, 20);
            this.lblZ1.TabIndex = 12;
            this.lblZ1.Text = "z₁ =";
            // 
            // lblPlus1
            // 
            this.lblPlus1.AutoSize = true;
            this.lblPlus1.Location = new System.Drawing.Point(125, 50);
            this.lblPlus1.Name = "lblPlus1";
            this.lblPlus1.Size = new System.Drawing.Size(15, 20);
            this.lblPlus1.TabIndex = 13;
            this.lblPlus1.Text = "+";
            // 
            // lblI1
            // 
            this.lblI1.AutoSize = true;
            this.lblI1.Location = new System.Drawing.Point(220, 50);
            this.lblI1.Name = "lblI1";
            this.lblI1.Size = new System.Drawing.Size(15, 20);
            this.lblI1.TabIndex = 14;
            this.lblI1.Text = "i";
            // 
            // lblZ2
            // 
            this.lblZ2.AutoSize = true;
            this.lblZ2.Location = new System.Drawing.Point(45, 85);
            this.lblZ2.Name = "lblZ2";
            this.lblZ2.Size = new System.Drawing.Size(35, 20);
            this.lblZ2.TabIndex = 15;
            this.lblZ2.Text = "z₂ =";
            // 
            // lblPlus2
            // 
            this.lblPlus2.AutoSize = true;
            this.lblPlus2.Location = new System.Drawing.Point(125, 110);
            this.lblPlus2.Name = "lblPlus2";
            this.lblPlus2.Size = new System.Drawing.Size(15, 20);
            this.lblPlus2.TabIndex = 16;
            this.lblPlus2.Text = "+";
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEquals.Location = new System.Drawing.Point(270, 80);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(25, 28);
            this.lblEquals.TabIndex = 17;
            this.lblEquals.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 240);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblPlus2);
            this.Controls.Add(this.lblZ2);
            this.Controls.Add(this.lblI1);
            this.Controls.Add(this.lblPlus1);
            this.Controls.Add(this.lblZ1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMagnitude);
            this.Controls.Add(this.btnConjugate);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtIm2);
            this.Controls.Add(this.txtRe2);
            this.Controls.Add(this.txtIm1);
            this.Controls.Add(this.txtRe1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Комплексний калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRe1;
        private System.Windows.Forms.TextBox txtIm1;
        private System.Windows.Forms.TextBox txtRe2;
        private System.Windows.Forms.TextBox txtIm2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnConjugate;
        private System.Windows.Forms.Button btnMagnitude;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblZ1;
        private System.Windows.Forms.Label lblPlus1;
        private System.Windows.Forms.Label lblI1;
        private System.Windows.Forms.Label lblZ2;
        private System.Windows.Forms.Label lblPlus2;
        private System.Windows.Forms.Label lblEquals;
    }
}