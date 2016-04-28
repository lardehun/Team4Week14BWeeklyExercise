using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_CSHARP_Team4_Sanity_Archive
{
    class FileExplorer
    {
        DriveInfo[] allDrives = DriveInfo.GetDrives();


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
        public void OpenDirectoryAndRefreshTheBox(TextBox pathTextBox, ListBox dirListBox)
        {
            if (dirListBox.SelectedIndex < 0 || !dirListBox.SelectedItem.ToString().EndsWith(".txt"))
            {
                //Get a directory info from the selected item of the listbox and the textbox
                DirectoryInfo selectedDirectory = new DirectoryInfo(pathTextBox.Text + dirListBox.SelectedItem.ToString());
                if (!dirListBox.SelectedItem.ToString().Equals(".."))
                {
                    pathTextBox.Text = pathTextBox.Text + dirListBox.SelectedItem.ToString() + @"\";
                }
                else
                {
                    String[] words = pathTextBox.Text.Split('\\');
                    pathTextBox.Text = "";
                    for (int i = 0; i < words.Length - 2; i++)
                    {
                        pathTextBox.Text += words[i] + "\\";
                    }
                    //                    string pattern = @"/\w+\\$/";
                    //string correctPath = pathTextBox.Text.Replace(dirListBox.SelectedItem.ToString(), "");
                    //                   Regex rgx = new Regex(pattern);
                    //pathTextBox.Text.Replace(@"/\w+\\$/", "");
                    //pathTextBox.Text.Split(rgx);

                }
                dirListBox.Items.Clear();
                FillListBox(dirListBox, selectedDirectory);
                dirListBox.Items.Insert(0, "..");
                /*if (dirListBox.SelectedItem.ToString() == "..")
                {
                    pathTextBox.Text.Replace("..", "kuki");
                }*/
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

        public void Compress(ListBox dirListBox, TextBox pathTextBox)
        {
            List<String> filelist = new List<String>();
            String ZipPath = pathTextBox.Text + "compressed.zip";
            foreach (var item in dirListBox.SelectedItems)
            {
                filelist.Add(item.ToString());
            }
            string path = Path.GetTempPath() + @"tmp";
                Directory.CreateDirectory(path + "\\");
                foreach (var item in filelist)
                {
                    File.Copy(pathTextBox.Text + item, path + "/" + item, true);
                }
            ZipFile.CreateFromDirectory(path, ZipPath);
            Directory.Delete(path);
        }
        
        public void Uncompress(ListBox dirListBox, TextBox pathTextBox)
        {
            List<String> filelist = new List<String>();
            if (!dirListBox.SelectedItem.ToString().EndsWith(".zip"))
            {
                MessageBox.Show("Sorry. You are only allowed to decompress zip files.");
            }
            try
            {
                ZipFile.ExtractToDirectory(pathTextBox.Text + dirListBox.SelectedItem.ToString(), pathTextBox.Text);
            }
            catch(IOException e)
            {
                MessageBox.Show(e.ToString());
            }
        }


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

        /// <summary>
        /// Fill back the dirListbox from the pathTextBox
        /// </summary>
        /// <param name="pathTextBox"></param>
        /// <param name="dirListBox"></param>
        public void Refresh(TextBox pathTextBox, ListBox dirListBox)
        {
            dirListBox.Items.Clear();
            string path = pathTextBox.Text;
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            foreach (DirectoryInfo dir in dirInfo.GetDirectories())
            {
                //add each directory name to the listbox
                dirListBox.Items.Add(dir.Name);
            }
            foreach (FileInfo file in dirInfo.GetFiles())
            {
                dirListBox.Items.Add(file.Name);
            }
        }
    }
}
