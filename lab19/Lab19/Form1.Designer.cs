namespace Lab19
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.TextBox txtResult;

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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(20, 20);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(120, 30);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Генерувати масив";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(160, 20);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(120, 30);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Обробити";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(20, 70);
            this.txtArray.Multiline = true;
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(260, 80);
            this.txtArray.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(20, 170);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(260, 100);
            this.txtResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(310, 300);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtArray);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Одновимірний масив";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
