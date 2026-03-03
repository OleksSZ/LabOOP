namespace LabRobot
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBoxText = new GroupBox();
            this.rbTextRed = new RadioButton();
            this.rbTextGreen = new RadioButton();
            this.rbTextYellow = new RadioButton();
            this.rbTextBlue = new RadioButton();
            this.groupBoxBack = new GroupBox();
            this.rbBackBlue = new RadioButton();
            this.rbBackYellow = new RadioButton();
            this.rbBackGreen = new RadioButton();
            this.rbBackRed = new RadioButton();
            this.btnClose = new Button();
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
            this.groupBoxText.Text = "Колір тексту";

            // rbTextRed
            this.rbTextRed.AutoSize = true;
            this.rbTextRed.Location = new System.Drawing.Point(24, 32);
            this.rbTextRed.Name = "rbTextRed";
            this.rbTextRed.Size = new System.Drawing.Size(80, 24);
            this.rbTextRed.Text = "Червоний";
            this.rbTextRed.CheckedChanged += new EventHandler(this.rbTextRed_CheckedChanged);

            this.rbTextGreen.AutoSize = true;
            this.rbTextGreen.Location = new System.Drawing.Point(24, 60);
            this.rbTextGreen.Name = "rbTextGreen";
            this.rbTextGreen.Size = new System.Drawing.Size(80, 24);
            this.rbTextGreen.Text = "Зелений";
            this.rbTextGreen.CheckedChanged += new EventHandler(this.rbTextGreen_CheckedChanged);

            this.rbTextYellow.AutoSize = true;
            this.rbTextYellow.Location = new System.Drawing.Point(24, 88);
            this.rbTextYellow.Name = "rbTextYellow";
            this.rbTextYellow.Size = new System.Drawing.Size(80, 24);
            this.rbTextYellow.Text = "Жовтий";
            this.rbTextYellow.CheckedChanged += new EventHandler(this.rbTextYellow_CheckedChanged);

            this.rbTextBlue.AutoSize = true;
            this.rbTextBlue.Location = new System.Drawing.Point(24, 116);
            this.rbTextBlue.Name = "rbTextBlue";
            this.rbTextBlue.Size = new System.Drawing.Size(80, 24);
            this.rbTextBlue.Text = "Блакитний";
            this.rbTextBlue.CheckedChanged += new EventHandler(this.rbTextBlue_CheckedChanged);

            // groupBoxBack
            this.groupBoxBack.Controls.Add(this.rbBackBlue);
            this.groupBoxBack.Controls.Add(this.rbBackYellow);
            this.groupBoxBack.Controls.Add(this.rbBackGreen);
            this.groupBoxBack.Controls.Add(this.rbBackRed);
            this.groupBoxBack.Location = new System.Drawing.Point(240, 24);
            this.groupBoxBack.Name = "groupBoxBack";
            this.groupBoxBack.Size = new System.Drawing.Size(200, 160);
            this.groupBoxBack.Text = "Колір фону";

            this.rbBackBlue.AutoSize = true;
            this.rbBackBlue.Location = new System.Drawing.Point(24, 32);
            this.rbBackBlue.Name = "rbBackBlue";
            this.rbBackBlue.Size = new System.Drawing.Size(80, 24);
            this.rbBackBlue.Text = "Блакитний";
            this.rbBackBlue.CheckedChanged += new EventHandler(this.rbBackBlue_CheckedChanged);

            this.rbBackYellow.AutoSize = true;
            this.rbBackYellow.Location = new System.Drawing.Point(24, 60);
            this.rbBackYellow.Name = "rbBackYellow";
            this.rbBackYellow.Size = new System.Drawing.Size(80, 24);
            this.rbBackYellow.Text = "Жовтий";
            this.rbBackYellow.CheckedChanged += new EventHandler(this.rbBackYellow_CheckedChanged);

            this.rbBackGreen.AutoSize = true;
            this.rbBackGreen.Location = new System.Drawing.Point(24, 88);
            this.rbBackGreen.Name = "rbBackGreen";
            this.rbBackGreen.Size = new System.Drawing.Size(80, 24);
            this.rbBackGreen.Text = "Зелений";
            this.rbBackGreen.CheckedChanged += new EventHandler(this.rbBackGreen_CheckedChanged);

            this.rbBackRed.AutoSize = true;
            this.rbBackRed.Location = new System.Drawing.Point(24, 116);
            this.rbBackRed.Name = "rbBackRed";
            this.rbBackRed.Size = new System.Drawing.Size(80, 24);
            this.rbBackRed.Text = "Червоний";
            this.rbBackRed.CheckedChanged += new EventHandler(this.rbBackRed_CheckedChanged);

            // btnClose
            this.btnClose.Location = new System.Drawing.Point(180, 200);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.Text = "Закрити";
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // Form2
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 260);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBoxBack);
            this.Controls.Add(this.groupBoxText);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Вибір кольору";
            this.groupBoxText.ResumeLayout(false);
            this.groupBoxText.PerformLayout();
            this.groupBoxBack.ResumeLayout(false);
            this.groupBoxBack.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxText;
        private RadioButton rbTextRed;
        private RadioButton rbTextGreen;
        private RadioButton rbTextYellow;
        private RadioButton rbTextBlue;
        private GroupBox groupBoxBack;
        private RadioButton rbBackBlue;
        private RadioButton rbBackYellow;
        private RadioButton rbBackGreen;
        private RadioButton rbBackRed;
        private Button btnClose;
    }
}