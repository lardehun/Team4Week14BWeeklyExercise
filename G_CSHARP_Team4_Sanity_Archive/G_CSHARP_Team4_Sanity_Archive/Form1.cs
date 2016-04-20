using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_CSHARP_Team4_Sanity_Archive
{
    public partial class Form1 : Form
    {
        DriveInfo[] allDrives = DriveInfo.GetDrives();
        FileExplorer fileExplorer = new FileExplorer();

        public Form1()
        {
            InitializeComponent();
            driverComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fileExplorer.FillDriverComboBox(driverComboBox);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            fileExplorer.OpenDirectoryAndRefreshTheBox(pathTextBox, dirListBox);
        }

        private void driverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileExplorer.DriverSelectChangeFillListBox(dirListBox, pathTextBox, driverComboBox);
        }

        private void compressButton_Click(object sender, EventArgs e)
        {
 //           fileExplorer.Compress(dirListBox, pathTextBox);
        }

        private void dirListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileExplorer.CalculateDiskSpace(dirListBox, pathTextBox, spaceLabel);
        }
    }
}
