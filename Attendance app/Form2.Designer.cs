namespace Attendance_app
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Fromdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Accept = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Traditional Arabic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(30, 80, 163);
            guna2HtmlLabel1.Location = new Point(12, 47);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(23, 39);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "مـن";
            guna2HtmlLabel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // Fromdate
            // 
            Fromdate.Checked = true;
            Fromdate.CustomFormat = "dddd, dd-MMM-yyyy";
            Fromdate.CustomizableEdges = customizableEdges7;
            Fromdate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Fromdate.Format = DateTimePickerFormat.Custom;
            Fromdate.Location = new Point(52, 50);
            Fromdate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            Fromdate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            Fromdate.Name = "Fromdate";
            Fromdate.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Fromdate.Size = new Size(184, 36);
            Fromdate.TabIndex = 1;
            Fromdate.Value = new DateTime(2023, 3, 21, 0, 0, 0, 0);
            // 
            // ToDate
            // 
            ToDate.Checked = true;
            ToDate.CustomFormat = "dddd, dd-MMM-yyyy";
            ToDate.CustomizableEdges = customizableEdges9;
            ToDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ToDate.Format = DateTimePickerFormat.Custom;
            ToDate.Location = new Point(318, 47);
            ToDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            ToDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            ToDate.Name = "ToDate";
            ToDate.ShadowDecoration.CustomizableEdges = customizableEdges10;
            ToDate.Size = new Size(184, 36);
            ToDate.TabIndex = 3;
            ToDate.Value = new DateTime(2023, 3, 21, 0, 0, 0, 0);
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Traditional Arabic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(30, 80, 163);
            guna2HtmlLabel2.Location = new Point(277, 44);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(25, 39);
            guna2HtmlLabel2.TabIndex = 2;
            guna2HtmlLabel2.Text = "إلـى";
            guna2HtmlLabel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // Accept
            // 
            Accept.DisabledState.BorderColor = Color.DarkGray;
            Accept.DisabledState.CustomBorderColor = Color.DarkGray;
            Accept.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Accept.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Accept.FillColor = Color.MediumSeaGreen;
            Accept.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Accept.ForeColor = Color.White;
            Accept.Location = new Point(65, 118);
            Accept.Name = "Accept";
            Accept.ShadowDecoration.CustomizableEdges = customizableEdges11;
            Accept.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            Accept.Size = new Size(145, 64);
            Accept.TabIndex = 5;
            Accept.Text = "تأكيد";
            Accept.Click += Accept_Click;
            // 
            // guna2CircleButton2
            // 
            guna2CircleButton2.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton2.FillColor = Color.IndianRed;
            guna2CircleButton2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2CircleButton2.ForeColor = Color.White;
            guna2CircleButton2.Location = new Point(327, 118);
            guna2CircleButton2.Name = "guna2CircleButton2";
            guna2CircleButton2.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton2.Size = new Size(145, 64);
            guna2CircleButton2.TabIndex = 6;
            guna2CircleButton2.Text = "إلغاء";
            guna2CircleButton2.Click += guna2CircleButton2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 80, 163);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 31);
            panel1.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(518, 197);
            Controls.Add(panel1);
            Controls.Add(Accept);
            Controls.Add(ToDate);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(Fromdate);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2CircleButton2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "popupForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker Fromdate;
        private Guna.UI2.WinForms.Guna2DateTimePicker ToDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CircleButton Accept;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Panel panel1;
    }
}