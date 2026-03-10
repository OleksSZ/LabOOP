namespace RationalCalculator
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtDen1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtDen2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFrac1 = new System.Windows.Forms.Label();
            this.lblSlash1 = new System.Windows.Forms.Label();
            this.lblFrac2 = new System.Windows.Forms.Label();
            this.lblSlash2 = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(40, 50);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(80, 27);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.Text = "0";
            // 
            // txtDen1
            // 
            this.txtDen1.Location = new System.Drawing.Point(140, 50);
            this.txtDen1.Name = "txtDen1";
            this.txtDen1.Size = new System.Drawing.Size(80, 27);
            this.txtDen1.TabIndex = 1;
            this.txtDen1.Text = "1";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(40, 110);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(80, 27);
            this.txtNum2.TabIndex = 2;
            this.txtNum2.Text = "0";
            // 
            // txtDen2
            // 
            this.txtDen2.Location = new System.Drawing.Point(140, 110);
            this.txtDen2.Name = "txtDen2";
            this.txtDen2.Size = new System.Drawing.Size(80, 27);
            this.txtDen2.TabIndex = 3;
            this.txtDen2.Text = "1";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(320, 80);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(180, 27);
            this.txtResult.TabIndex = 4;
            this.txtResult.Text = "0";
            this.txtResult.BackColor = System.Drawing.Color.White;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 40);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(110, 170);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(60, 40);
            this.btnSub.TabIndex = 6;
            this.btnSub.Text = "−";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(180, 170);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(60, 40);
            this.btnMul.TabIndex = 7;
            this.btnMul.Text = "×";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(250, 170);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(60, 40);
            this.btnDiv.TabIndex = 8;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(320, 170);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 40);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblFrac1
            // 
            this.lblFrac1.AutoSize = true;
            this.lblFrac1.Location = new System.Drawing.Point(40, 30);
            this.lblFrac1.Name = "lblFrac1";
            this.lblFrac1.Size = new System.Drawing.Size(50, 20);
            this.lblFrac1.TabIndex = 10;
            this.lblFrac1.Text = "a/b =";
            // 
            // lblSlash1
            // 
            this.lblSlash1.AutoSize = true;
            this.lblSlash1.Location = new System.Drawing.Point(120, 55);
            this.lblSlash1.Name = "lblSlash1";
            this.lblSlash1.Size = new System.Drawing.Size(15, 20);
            this.lblSlash1.TabIndex = 11;
            this.lblSlash1.Text = "/";
            // 
            // lblFrac2
            // 
            this.lblFrac2.AutoSize = true;
            this.lblFrac2.Location = new System.Drawing.Point(40, 90);
            this.lblFrac2.Name = "lblFrac2";
            this.lblFrac2.Size = new System.Drawing.Size(50, 20);
            this.lblFrac2.TabIndex = 12;
            this.lblFrac2.Text = "c/d =";
            // 
            // lblSlash2
            // 
            this.lblSlash2.AutoSize = true;
            this.lblSlash2.Location = new System.Drawing.Point(120, 115);
            this.lblSlash2.Name = "lblSlash2";
            this.lblSlash2.Size = new System.Drawing.Size(15, 20);
            this.lblSlash2.TabIndex = 13;
            this.lblSlash2.Text = "/";
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEquals.Location = new System.Drawing.Point(280, 85);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(25, 28);
            this.lblEquals.TabIndex = 14;
            this.lblEquals.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 250);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblSlash2);
            this.Controls.Add(this.lblFrac2);
            this.Controls.Add(this.lblSlash1);
            this.Controls.Add(this.lblFrac1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtDen2);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtDen1);
            this.Controls.Add(this.txtNum1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Раціональні дроби";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtDen1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtDen2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblFrac1;
        private System.Windows.Forms.Label lblSlash1;
        private System.Windows.Forms.Label lblFrac2;
        private System.Windows.Forms.Label lblSlash2;
        private System.Windows.Forms.Label lblEquals;
    }
}