using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private const int SaltSize = 8;


        /// <summary>
        /// Its fill the combobox given in the parameter with the name of the driver that on your PC.
        /// </summary>
        /// <param name="driverComboBox"></param>
        public void FillDriverComboBox(ComboBox driverComboBox)
        {
            foreach (DriveInfo driver in allDrives)
            {
                //Add each driver to the combobox.
                driverComboBox.Items.Add(driver.Name.ToString() + "    " + driver.DriveType.ToString());
            }
        }

        /// <summary>
        /// Fill the listbox with the files of previously selected item with the files in it and set the textbox to the root of the selected item.
        /// </summary>
        /// <param name="pathTextBox"></param>
        /// <param name="dirListBox"></param>
        public void OpenDirectoryAndRefreshTheBox(TextBox pathTextBox,ListBox dirListBox)
        {
            if (dirListBox.SelectedIndex < 0 || !dirListBox.SelectedItem.ToString().EndsWith(".txt"))
            {
                //Get a directory info from the selected item of the listbox and the textbox
                DirectoryInfo selectedDirectory = new DirectoryInfo(pathTextBox.Text + dirListBox.SelectedItem.ToString());
                pathTextBox.Text = pathTextBox.Text + dirListBox.SelectedItem.ToString() + @"\";
                dirListBox.Items.Clear();
                FillListBox(dirListBox, selectedDirectory);
            }
            else
            {
                string file = pathTextBox.Text + dirListBox.SelectedItem.ToString();
                Process.Start("notepad.exe", file);
            }
        }

        /// <summary>
        /// When driver is selected fill the listbox with the root directory files and set the textbox to the driver name.
        /// </summary>
        /// <param name="dirListBox"></param>
        /// <param name="pathTextBox"></param>
        /// <param name="driverComboBox"></param>
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


        /// <summary>
        /// This is the method used by other methods to fill the listbox.
        /// </summary>
        /// <param name="dirListBox"></param>
        /// <param name="selectedDriverDirectory"></param>
        private void FillListBox(ListBox dirListBox,DirectoryInfo selectedDriverDirectory)
        {
            foreach (DirectoryInfo dir in selectedDriverDirectory.GetDirectories())
            {
                //add each directory name to the listbox
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

        /// <summary>
        /// When one or several files are listed in a listbox, it will add the amount of disk space they use on the HDD, and display it in a label.
        /// </summary>
        /// <param name="dirListBox"></param>
        /// <param name="pathTextBox"></param>
        /// <param name="spaceLabel"></param>
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

 /*      public void Encrypt(ListBox dirListBox, TextBox pathTextBox) // Not working because of my OS?
        {
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
                    selectedFiles.Encrypt();
                }
            }
        } */
        

 /*       public void Decrypt(ListBox dirListBox, TextBox pathTextBox) // Not working because of my OS?
        {
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
                    selectedFiles.Encrypt();
                }
            }
        } */
        
    }
}
