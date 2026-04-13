namespace Lab25

{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSumNeg;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.TextBox txtResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSumNeg = new System.Windows.Forms.Button();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(20, 20);
            this.btnGenerate.Size = new System.Drawing.Size(120, 30);
            this.btnGenerate.Text = "Генерувати масив";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSumNeg
            // 
            this.btnSumNeg.Location = new System.Drawing.Point(160, 20);
            this.btnSumNeg.Size = new System.Drawing.Size(150, 30);
            this.btnSumNeg.Text = "Сума від’ємних";
            this.btnSumNeg.Click += new System.EventHandler(this.btnSumNeg_Click);
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(20, 70);
            this.txtArray.Multiline = true;
            this.txtArray.Size = new System.Drawing.Size(290, 60);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(20, 150);
            this.txtResult.Multiline = true;
            this.txtResult.Size = new System.Drawing.Size(290, 60);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(340, 240);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtArray);
            this.Controls.Add(this.btnSumNeg);
            this.Controls.Add(this.btnGenerate);
            this.Text = "Індексатори та масиви";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
