namespace Laba12
{
    partial class Form2
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

        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxText = new System.Windows.Forms.GroupBox();
            this.rbTextRed = new System.Windows.Forms.RadioButton();
            this.rbTextGreen = new System.Windows.Forms.RadioButton();
            this.rbTextYellow = new System.Windows.Forms.RadioButton();
            this.rbTextBlue = new System.Windows.Forms.RadioButton();
            this.groupBoxBack = new System.Windows.Forms.GroupBox();
            this.rbBackBlue = new System.Windows.Forms.RadioButton();
            this.rbBackYellow = new System.Windows.Forms.RadioButton();
            this.rbBackGreen = new System.Windows.Forms.RadioButton();
            this.rbBackRed = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxText.SuspendLayout();
            this.groupBoxBack.SuspendLayout();
            this.SuspendLayout();

            // groupBoxText
            this.groupBoxText.Controls.Add(this.rbTextRed);
            this.groupBoxText.Controls.Add(this.rbTextGreen);
            this.groupBoxText.Controls.Add(this.rbTextYellow);
            this.groupBoxText.Controls.Add(this.rbTextBlue);
            this.groupBoxText.Location = new System.Drawing.Point(24, 24);
            this.groupBoxText.Name = "groupBoxText";
            this.groupBoxText.Size = new System.Drawing.Size(200, 160);
            this.groupBoxText.TabIndex = 0;
            this.groupBoxText.TabStop = false;
            this.groupBoxText.Text = "Колір тексту";

            // rbTextRed
            this.rbTextRed.AutoSize = true;
            this.rbTextRed.Location = new System.Drawing.Point(24, 32);
            this.rbTextRed.Name = "rbTextRed";
            this.rbTextRed.Size = new System.Drawing.Size(80, 24);
            this.rbTextRed.TabIndex = 0;
            this.rbTextRed.Text = "Червоний";
            this.rbTextRed.UseVisualStyleBackColor = true;
            this.rbTextRed.CheckedChanged += new System.EventHandler(this.rbTextRed_CheckedChanged);
            // rbTextGreen
            this.rbTextGreen.AutoSize = true;
            this.rbTextGreen.Location = new System.Drawing.Point(24, 60);
            this.rbTextGreen.Name = "rbTextGreen";
            this.rbTextGreen.Size = new System.Drawing.Size(80, 24);
            this.rbTextGreen.TabIndex = 1;
            this.rbTextGreen.Text = "Зелений";
            this.rbTextGreen.UseVisualStyleBackColor = true;
            this.rbTextGreen.CheckedChanged += new System.EventHandler(this.rbTextGreen_CheckedChanged);
            
            // rbTextYellow
            this.rbTextYellow.AutoSize = true;
            this.rbTextYellow.Location = new System.Drawing.Point(24, 88);
            this.rbTextYellow.Name = "rbTextYellow";
            this.rbTextYellow.Size = new System.Drawing.Size(80, 24);
            this.rbTextYellow.TabIndex = 2;
            this.rbTextYellow.Text = "Жовтий";
            this.rbTextYellow.UseVisualStyleBackColor = true;
            this.rbTextYellow.CheckedChanged += new System.EventHandler(this.rbTextYellow_CheckedChanged);
            
            // rbTextBlue

            this.rbTextBlue.AutoSize = true;
            this.rbTextBlue.Location = new System.Drawing.Point(24, 116);
            this.rbTextBlue.Name = "rbTextBlue";
            this.rbTextBlue.Size = new System.Drawing.Size(80, 24);
            this.rbTextBlue.TabIndex = 3;
            this.rbTextBlue.Text = "Блакитний";
            this.rbTextBlue.UseVisualStyleBackColor = true;
            this.rbTextBlue.CheckedChanged += new System.EventHandler(this.rbTextBlue_CheckedChanged);

            // groupBoxBack
            this.groupBoxBack.Controls.Add(this.rbBackBlue);
            this.groupBoxBack.Controls.Add(this.rbBackYellow);
            this.groupBoxBack.Controls.Add(this.rbBackGreen);
            this.groupBoxBack.Controls.Add(this.rbBackRed);
            this.groupBoxBack.Location = new System.Drawing.Point(240, 24);
            this.groupBoxBack.Name = "groupBoxBack";
            this.groupBoxBack.Size = new System.Drawing.Size(200, 160);
            this.groupBoxBack.TabIndex = 1;
            this.groupBoxBack.TabStop = false;
            this.groupBoxBack.Text = "Колір фону";
        
            // rbBackBlue
            this.rbBackBlue.AutoSize = true;
            this.rbBackBlue.Location = new System.Drawing.Point(24, 32);
            this.rbBackBlue.Name = "rbBackBlue";
            this.rbBackBlue.Size = new System.Drawing.Size(80, 24);
            this.rbBackBlue.TabIndex = 0;
            this.rbBackBlue.Text = "Блакитний";
            this.rbBackBlue.UseVisualStyleBackColor = true;
            this.rbBackBlue.CheckedChanged += new System.EventHandler(this.rbBackBlue_CheckedChanged);
            // rbBackYellow
            this.rbBackYellow.AutoSize = true;
            this.rbBackYellow.Location = new System.Drawing.Point(24, 60);
            this.rbBackYellow.Name = "rbBackYellow";
            this.rbBackYellow.Size = new System.Drawing.Size(80, 24);
            this.rbBackYellow.TabIndex = 1;
            this.rbBackYellow.Text = "Жовтий";
            this.rbBackYellow.UseVisualStyleBackColor = true;
            this.rbBackYellow.CheckedChanged += new System.EventHandler(this.rbBackYellow_CheckedChanged);
            // rbBackGreen
            this.rbBackGreen.AutoSize = true;
            this.rbBackGreen.Location = new System.Drawing.Point(24, 88);
            this.rbBackGreen.Name = "rbBackGreen";
            this.rbBackGreen.Size = new System.Drawing.Size(80, 24);
            this.rbBackGreen.TabIndex = 2;
            this.rbBackGreen.Text = "Зелений";
            this.rbBackGreen.UseVisualStyleBackColor = true;
            this.rbBackGreen.CheckedChanged += new System.EventHandler(this.rbBackGreen_CheckedChanged);

            // rbBackRed
            this.rbBackRed.AutoSize = true;
            this.rbBackRed.Location = new System.Drawing.Point(24, 116);
            this.rbBackRed.Name = "rbBackRed";
            this.rbBackRed.Size = new System.Drawing.Size(80, 24);
            this.rbBackRed.TabIndex = 3;
            this.rbBackRed.Text = "Червоний";
            this.rbBackRed.UseVisualStyleBackColor = true;
            this.rbBackRed.CheckedChanged += new System.EventHandler(this.rbBackRed_CheckedChanged);

            // btnClose
            this.btnClose.Location = new System.Drawing.Point(180, 200);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // Form2
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 260);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBoxBack);
            this.Controls.Add(this.groupBoxText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Вибір кольору";
            this.groupBoxText.ResumeLayout(false);
            this.groupBoxText.PerformLayout();
            this.groupBoxBack.ResumeLayout(false);
            this.groupBoxBack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxText;
        private System.Windows.Forms.RadioButton rbTextRed;
        private System.Windows.Forms.RadioButton rbTextGreen;
        private System.Windows.Forms.RadioButton rbTextYellow;
        private System.Windows.Forms.RadioButton rbTextBlue;
        private System.Windows.Forms.GroupBox groupBoxBack;
        private System.Windows.Forms.RadioButton rbBackBlue;
        private System.Windows.Forms.RadioButton rbBackYellow;
        private System.Windows.Forms.RadioButton rbBackGreen;
        private System.Windows.Forms.RadioButton rbBackRed;
        private System.Windows.Forms.Button btnClose;
    }
}