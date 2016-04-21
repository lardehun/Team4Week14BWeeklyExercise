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
        PropertiesChange propChanger = new PropertiesChange();
        FileMover fileMover = new FileMover();
        public Form1()
        {
            InitializeComponent();
            explorerPanel.Visible = true;
            propertiesPanel.Visible = false;
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

        private void backToExplorerPanel_Click(object sender, EventArgs e)
        {
            explorerPanel.Visible = true;
            propertiesPanel.Visible = false;
        }

        private void propertiesButton_Click(object sender, EventArgs e)
        {
            propertiesPanel.Visible = true;
        }

        private void compressButton_Click(object sender, EventArgs e)
        {
            //           fileExplorer.Compress(dirListBox, pathTextBox);
        }

        private void dirListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileExplorer.CalculateDiskSpace(dirListBox, pathTextBox, spaceLabel);
            fileMover.EnableCopy(pathTextBox, dirListBox, copyButton);
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            fileMover.SelectedItemFileList(dirListBox, pathTextBox, copyButton, pasteButton);
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            fileMover.PasteCopiedFiles(pasteButton, pathTextBox, dirListBox);
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            propChanger.ChangeFileToHidden(dirListBox, pathTextBox);
        }

        private void unHideButton_Click(object sender, EventArgs e)
        {
            propChanger.ChangeFileToNotHidden(dirListBox, pathTextBox);
        }

        private void readOnlyButton_Click(object sender, EventArgs e)
        {
            propChanger.ChangeFileToReadOnly(dirListBox, pathTextBox);
        }

        private void removeReadOnlyButton_Click(object sender, EventArgs e)
        {
            propChanger.ChangeFileToNotReadOnly(dirListBox, pathTextBox);
        }

        private void encrypt_btn_Click(object sender, EventArgs e)
        {
 //           fileExplorer.Encrypt(dirListBox, pathTextBox);
        }

        private void decrypt_btn_Click(object sender, EventArgs e)
        {
 //           fileExplorer.Decrypt(dirListBox, pathTextBox);
        }
    }
}
