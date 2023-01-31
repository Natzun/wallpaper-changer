using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WallpaperChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        private static readonly int MAX_PATH = 260;
        private static readonly int SPI_GETDESKWALLPAPER = 0x73;
        private static readonly int SPI_SETDESKWALLPAPER = 0x14;
        private static readonly int SPIF_UPDATEINIFILE = 0x01;
        private static readonly int SPIF_SENDWININICHANGE = 0x02;

        Bitmap currentWallpaper = new Bitmap(GetDesktopWallpaper());

        static string GetDesktopWallpaper()
        {
            string wallpaper = new string('\0', MAX_PATH);
            Console.WriteLine("wallpaper: ", wallpaper);

            SystemParametersInfo(SPI_GETDESKWALLPAPER, (int)wallpaper.Length, wallpaper, 0);

            var result = wallpaper.Substring(0, wallpaper.IndexOf('\0'));
            Console.WriteLine("result: ", result);

            return result;
        }

        static void SetDesktopWallpaper(string path)
        {
            Console.WriteLine("path: ", path);
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("FormWallpaperChanger_Load");

            pictureBox1.Image = currentWallpaper;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.
            openFileDialog1.InitialDirectory = "C://Desktop";
            //Your opendialog box title name.
            openFileDialog1.Title = "Select image to be upload.";
            //which type image format you want to upload in database. just add them.
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        directoryPath.Text = path;
                        pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload image.");
                }
            }
            catch (Exception ex)
            {
                //it will give if file is already exits..
                MessageBox.Show(ex.Message);
            }
        }

        private void directoryPath_Click(object sender, EventArgs e)
        {

        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (directoryPath.Text == "Directory Path")
            {
                MessageBox.Show("No image selected.");

                return;
            };

            SetDesktopWallpaper(directoryPath.Text);

            MessageBox.Show("Wallpaper applied!");
        }
    }
}