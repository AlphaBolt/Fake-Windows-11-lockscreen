namespace Win11Lockscreen
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            wifi_pictureBox = new PictureBox();
            battery_pictureBox = new PictureBox();
            unlock_pictureBox = new PictureBox();
            customTextBox1 = new CustomTextBox();
            time_customTextBox = new CustomTextBox();
            date_customTextBox = new CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)wifi_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)battery_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unlock_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // wifi_pictureBox
            // 
            wifi_pictureBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            wifi_pictureBox.BackColor = Color.Transparent;
            wifi_pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            wifi_pictureBox.Image = (Image)resources.GetObject("wifi_pictureBox.Image");
            wifi_pictureBox.Location = new Point(835, 426);
            wifi_pictureBox.Name = "wifi_pictureBox";
            wifi_pictureBox.Size = new Size(24, 24);
            wifi_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            wifi_pictureBox.TabIndex = 0;
            wifi_pictureBox.TabStop = false;
            // 
            // battery_pictureBox
            // 
            battery_pictureBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            battery_pictureBox.BackColor = Color.Transparent;
            battery_pictureBox.Image = (Image)resources.GetObject("battery_pictureBox.Image");
            battery_pictureBox.Location = new Point(902, 426);
            battery_pictureBox.Name = "battery_pictureBox";
            battery_pictureBox.Size = new Size(24, 24);
            battery_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            battery_pictureBox.TabIndex = 1;
            battery_pictureBox.TabStop = false;
            // 
            // unlock_pictureBox
            // 
            unlock_pictureBox.Anchor = AnchorStyles.Top;
            unlock_pictureBox.BackColor = Color.Transparent;
            unlock_pictureBox.Image = (Image)resources.GetObject("unlock_pictureBox.Image");
            unlock_pictureBox.Location = new Point(456, 81);
            unlock_pictureBox.Name = "unlock_pictureBox";
            unlock_pictureBox.Size = new Size(64, 64);
            unlock_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            unlock_pictureBox.TabIndex = 2;
            unlock_pictureBox.TabStop = false;
            unlock_pictureBox.MouseDoubleClick += unlock_pictureBox_MouseDoubleClick;
            // 
            // customTextBox1
            // 
            customTextBox1.Anchor = AnchorStyles.Top;
            customTextBox1.BackColor = Color.Transparent;
            customTextBox1.BorderStyle = BorderStyle.None;
            customTextBox1.Enabled = false;
            customTextBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customTextBox1.ForeColor = Color.White;
            customTextBox1.Location = new Point(334, 151);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.ReadOnly = true;
            customTextBox1.Size = new Size(319, 27);
            customTextBox1.TabIndex = 3;
            customTextBox1.Text = "Press Ctrl+Alt+Delete to unlock.";
            // 
            // time_customTextBox
            // 
            time_customTextBox.Anchor = AnchorStyles.Top;
            time_customTextBox.BackColor = Color.Transparent;
            time_customTextBox.BorderStyle = BorderStyle.None;
            time_customTextBox.Enabled = false;
            time_customTextBox.Font = new Font("Segoe UI Variable Text Semibold", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            time_customTextBox.ForeColor = Color.White;
            time_customTextBox.Location = new Point(299, 181);
            time_customTextBox.Margin = new Padding(0);
            time_customTextBox.Multiline = true;
            time_customTextBox.Name = "time_customTextBox";
            time_customTextBox.ReadOnly = true;
            time_customTextBox.Size = new Size(391, 167);
            time_customTextBox.TabIndex = 4;
            time_customTextBox.Text = "11:03";
            time_customTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // date_customTextBox
            // 
            date_customTextBox.Anchor = AnchorStyles.Top;
            date_customTextBox.BackColor = Color.Transparent;
            date_customTextBox.BorderStyle = BorderStyle.None;
            date_customTextBox.Enabled = false;
            date_customTextBox.Font = new Font("Segoe UI Variable Text Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date_customTextBox.ForeColor = Color.White;
            date_customTextBox.Location = new Point(362, 376);
            date_customTextBox.Name = "date_customTextBox";
            date_customTextBox.ReadOnly = true;
            date_customTextBox.Size = new Size(287, 38);
            date_customTextBox.TabIndex = 5;
            date_customTextBox.Text = "Friday, 31 February";
            date_customTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(985, 481);
            Controls.Add(date_customTextBox);
            Controls.Add(time_customTextBox);
            Controls.Add(customTextBox1);
            Controls.Add(unlock_pictureBox);
            Controls.Add(battery_pictureBox);
            Controls.Add(wifi_pictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)wifi_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)battery_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)unlock_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox wifi_pictureBox;
        private PictureBox battery_pictureBox;
        private PictureBox unlock_pictureBox;
        private CustomTextBox customTextBox1;
        private CustomTextBox time_customTextBox;
        private CustomTextBox date_customTextBox;
    }
}
