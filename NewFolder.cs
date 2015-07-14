using System;
using System.IO;
using System.Windows.Forms;

namespace PhotoSorting
{
    public partial class NewFolder : Form
    {
        private ListBox _ListBox;
        private string _SubDirectory;

        public NewFolder(ListBox listbox, string subdirectory)
        {
            InitializeComponent();

            _ListBox = listbox;
            _SubDirectory = subdirectory;
        }

        private void NewFolderName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateNewFolderButton_Click(this, new EventArgs());
            }
        }

        private void CreateNewFolderButton_Click(object sender, EventArgs e)
        {
            if(NewFolderName.Text.Length == 0)
            {
                MessageBox.Show("Naam mag niet leeg zijn.", "Fout");
                return;
            }
            if(_ListBox.Items.Contains(NewFolderName.Text))
            {
                MessageBox.Show("Deze map bestaat al.", "Fout");
                return;
            }
            try
            {
                Path.GetFullPath(_SubDirectory + "\\" + NewFolderName.Text);
                Directory.CreateDirectory(_SubDirectory + "\\" + NewFolderName.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("De naam bevat ongeldige tekens.", "Fout");
                return;
            }

            _ListBox.Items.Add(NewFolderName.Text);          
            Close();
        }
    }
}
