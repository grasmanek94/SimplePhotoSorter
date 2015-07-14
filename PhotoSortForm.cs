using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace PhotoSorting
{
    public partial class PhotoSortForm : Form
    {
        private List<string> _FilesToProcess;
        private readonly string _SortedDirectory = ".\\gesorteerd";

        private List<string> ProcessDirectory(string targetDirectory, List<string> extensions, string ignoreDirectory)
        {
            List<string> matching_files = new List<string>();

            if (!Path.GetFullPath(targetDirectory).Equals(Path.GetFullPath(ignoreDirectory), StringComparison.CurrentCultureIgnoreCase))
            {
                // Process the list of files found in the directory. 
                string[] fileEntries = Directory.GetFiles(targetDirectory);
                foreach (string fileName in fileEntries)
                {
                    string fileExtension = Path.GetExtension(fileName).ToLower();
                    if (extensions.Contains(fileExtension))
                    {
                        matching_files.Add(Path.GetFullPath(fileName));
                    }
                }

                // Recurse into subdirectories of this directory. 
                string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
                foreach (string subdirectory in subdirectoryEntries)
                {
                    matching_files.AddRange(ProcessDirectory(subdirectory, extensions, ignoreDirectory));
                }
            }

            return matching_files;
        }

        public static Image FromFile(string path)
        {
            var bytes = File.ReadAllBytes(path);
            var ms = new MemoryStream(bytes);
            var img = Image.FromStream(ms);
            return img;
        }

        public PhotoSortForm()
        {
            InitializeComponent();

            _FilesToProcess = ProcessDirectory(".\\", new List<string>{ ".jpg", ".jpeg", ".bmp", ".png", ".gif", ".tif" }, _SortedDirectory);

            Directory.CreateDirectory(_SortedDirectory);
            Directory.CreateDirectory(_SortedDirectory + "\\Overige");

            string[] subdirectoryEntries = Directory.GetDirectories(_SortedDirectory);

            foreach (string subdirectory in subdirectoryEntries)
            {
                SortedFolders.Items.Add(Path.GetFileName(subdirectory));
            }

            SortedFolders.SelectedIndex = 0;

            Picture.SizeMode = PictureBoxSizeMode.StretchImage;

            Picture.ImageLocation = "";

            if (_FilesToProcess.Count == 0)
            {
                Picture.Image = Properties.Resources.nomore;
            }
            else
            {
                Picture.Image = FromFile(_FilesToProcess[0]);
            }

            Picture.Refresh();
        }

        private void SortedFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SortedFolders.SelectedIndex != -1)
            {
                MovePicture.Enabled = true;
                MovePicture.Text = "Verplaats naar: " + SortedFolders.SelectedItem.ToString();
            }
            else
            {
                MovePicture.Enabled = false;
                MovePicture.Text = "";
            }
        }

        private void NewFolder_Click(object sender, EventArgs e)
        {
            new NewFolder(SortedFolders, _SortedDirectory).ShowDialog();
        }

        private void MovePicture_Click(object sender, EventArgs e)
        {
            if (SortedFolders.SelectedIndex != -1 && _FilesToProcess.Count > 0)
            {
                try
                {
                    File.Move(_FilesToProcess[0], _SortedDirectory + "\\" + (string)SortedFolders.SelectedItem + "\\" + Path.GetFileName(_FilesToProcess[0]));
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Kan foto niet verplaatsen, foutmelding:\r\n" + ex.Message + "\r\nFout wordt genegeerd, volgende foto wordt getoond.", "Fout");
                }
                _FilesToProcess.RemoveAt(0);
            }

            if(_FilesToProcess.Count == 0)
            { 
                Picture.Image = Properties.Resources.nomore;
            }
            else
            {
                Picture.Image = FromFile(_FilesToProcess[0]);
            }
        }

        private void RotateRight_Click(object sender, EventArgs e)
        {
            Image img = Picture.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Picture.Image = img;
        }

        private void RotateLeft_Click(object sender, EventArgs e)
        {
            Image img = Picture.Image;
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            Picture.Image = img;
        }
    }
}
