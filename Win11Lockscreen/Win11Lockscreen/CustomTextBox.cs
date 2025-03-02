using System;
using System.Drawing;
using System.Windows.Forms;

namespace Win11Lockscreen
{
    public partial class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);
            BackColor = Color.Transparent;
            ForeColor = Color.White;  // Ensure the text is visible
        }

        public sealed override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Ensure text is painted over transparent background
            base.OnPaint(e);

            // If needed, draw additional custom elements here
            // For instance, drawing text explicitly:
            if (!string.IsNullOrEmpty(Text))
            {
                e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), 0, 0);
            }
        }
    }
}
