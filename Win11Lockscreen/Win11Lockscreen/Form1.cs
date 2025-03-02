namespace Win11Lockscreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Initialize background image
            string folderpath = @"C:\Users\Ayush.Mukherjee\AppData\Local\Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets";
            if(!Directory.Exists(folderpath))
            {
                folderpath = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets";
            }

            DirectoryInfo di = new DirectoryInfo(folderpath);
            
            // Get all files and order them by LastWriteTime descending
            FileInfo latestFile = di.GetFiles().OrderByDescending(file => file.LastWriteTime).FirstOrDefault();

            if (latestFile != null)
            {
                Image selectedImage = Image.FromFile(latestFile.FullName);
                this.BackgroundImage = selectedImage;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }

            // Initialize date and time
            time_customTextBox.Text = DateTime.Now.ToString("HH:mm");
            date_customTextBox.Text = DateTime.Now.ToString("dddd, dd MMMM");
        }

        private void unlock_pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

    }
}
