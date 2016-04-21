﻿using System;
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
        Searching searchOption = new Searching();
        PropertiesChange propChanger = new PropertiesChange();

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
            if (dirListBox.SelectedIndex != -1)
            {
                fileExplorer.OpenDirectoryAndRefreshTheBox(pathTextBox, dirListBox);
            }
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

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            
            searchOption.search(searchTextBox, dirListBox, pathTextBox);
        }

        private void searchReset_Click(object sender, EventArgs e)
        {
            searchOption.FillBack(pathTextBox, dirListBox);
        }
    }
}
