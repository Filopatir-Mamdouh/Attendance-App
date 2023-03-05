namespace Attendance_app
{
    partial class Attendance
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.PictureBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataTablePanel = new System.Windows.Forms.Panel();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.close);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 44);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Attendance_app.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Traditional Arabic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.Snow;
            this.Title.Location = new System.Drawing.Point(538, 1);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(103, 42);
            this.Title.TabIndex = 1;
            this.Title.Text = "نظام حضور";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.Image = global::Attendance_app.Properties.Resources.icons8_cancel_48;
            this.close.Location = new System.Drawing.Point(1148, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(41, 44);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.controlPanel.Location = new System.Drawing.Point(859, 108);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(306, 512);
            this.controlPanel.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 8;
            this.guna2Elipse1.TargetControl = this.controlPanel;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 8;
            this.guna2Elipse2.TargetControl = this.dataTablePanel;
            // 
            // dataTablePanel
            // 
            this.dataTablePanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.dataTablePanel.Location = new System.Drawing.Point(12, 108);
            this.dataTablePanel.Name = "dataTablePanel";
            this.dataTablePanel.Size = new System.Drawing.Size(808, 512);
            this.dataTablePanel.TabIndex = 2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 8;
            this.guna2Elipse3.TargetControl = this.dataTablePanel;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1189, 650);
            this.Controls.Add(this.dataTablePanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attendance";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendace";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox close;
        private Label Title;
        private PictureBox pictureBox1;
        private Panel controlPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Panel dataTablePanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
    }
}