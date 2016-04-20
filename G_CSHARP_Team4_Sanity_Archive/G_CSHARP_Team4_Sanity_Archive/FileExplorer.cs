using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_CSHARP_Team4_Sanity_Archive
{
    class FileExplorer
    {
        DriveInfo[] allDrives = DriveInfo.GetDrives();

        public void FillDriverComboBox(ComboBox driverComboBox)
        {
            foreach (DriveInfo driver in allDrives)
            {
                driverComboBox.Items.Add(driver.Name.ToString() + "    " + driver.DriveType.ToString());
            }
        }

        public void OpenDirectoryAndRefreshTheBox(TextBox pathTextBox,ListBox dirListBox)
        {
            if (dirListBox.SelectedIndex < 0 || !dirListBox.SelectedItem.ToString().EndsWith(".txt"))
            {
                DirectoryInfo selectedDirectory = new DirectoryInfo(pathTextBox.Text + dirListBox.SelectedItem.ToString());
                pathTextBox.Text = pathTextBox.Text + dirListBox.SelectedItem.ToString() + @"\";
                dirListBox.Items.Clear();
                FillListBox(dirListBox, selectedDirectory);
            }
            else
            {
                string text = File.ReadAllText(pathTextBox.Text + dirListBox.SelectedItem.ToString());
                MessageBox.Show(text);
            }
        }

        public void DriverSelectChangeFillListBox(ListBox dirListBox,TextBox pathTextBox, ComboBox driverComboBox)
        {
            dirListBox.Items.Clear();
            DriveInfo selectedDriver = allDrives[driverComboBox.SelectedIndex];
            pathTextBox.Text = selectedDriver.RootDirectory.ToString();
            if (selectedDriver.DriveType != DriveType.CDRom)
            {
                DirectoryInfo selectedDriverDirectory = new DirectoryInfo(selectedDriver.RootDirectory.ToString());
                FillListBox(dirListBox, selectedDriverDirectory);
            }
        }

        public void FillListBox(ListBox dirListBox,DirectoryInfo selectedDriverDirectory)
        {
            foreach (DirectoryInfo dir in selectedDriverDirectory.GetDirectories())
            {
                dirListBox.Items.Add(dir.Name);
            }
            foreach (FileInfo file in selectedDriverDirectory.GetFiles())
            {
                    dirListBox.Items.Add(file.Name);
            }
        }
        /* TODO
        public void Compress(ListBox dirListBox, TextBox pathTextBox)
        {
            List<String> filelist = new List<String>();
            foreach (var item in dirListBox.SelectedItems)
            {
                filelist.Add(pathTextBox.Text + item.ToString());
            }
            string path = @"temp/";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(@"temp/");
                foreach (string file in filelist)
                {
                }
            }
            Directory.CreateDirectory(@"temp/");
            foreach (var item2 in filelist)
            {
                MessageBox.Show(item2);
            }
        }
        */
        public void CalculateDiskSpace(ListBox dirListBox, TextBox pathTextBox, Label spaceLabel)
        {
            long count = 0;
            List<String> FileList = new List<String>();
            foreach (String item in dirListBox.SelectedItems)
            {
                FileList.Add(pathTextBox.Text + item);
            }
            foreach (String item in FileList)
            {
                if (File.Exists(item))
                {
                    FileInfo selectedFiles = new FileInfo(item);
                    count += selectedFiles.Length;
                }
            }
            spaceLabel.Text = count.ToString() + "bytes";
        }
    }
}
