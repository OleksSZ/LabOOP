namespace Lab22
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtClub;
        private System.Windows.Forms.Button btnFind;
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
            this.txtClub = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtClub
            // 
            this.txtClub.Location = new System.Drawing.Point(20, 20);
            this.txtClub.Name = "txtClub";
            this.txtClub.Size = new System.Drawing.Size(200, 22);
            this.txtClub.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(240, 20);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 25);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Знайти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(20, 60);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(320, 150);
            this.txtResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(370, 230);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtClub);
            this.Name = "Form1";
            this.Text = "Учні та гуртки";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
