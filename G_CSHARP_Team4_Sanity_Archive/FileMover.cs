using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_CSHARP_Team4_Sanity_Archive
{
    class FileMover
    {
        public List<String> selectedFilePathList = new List<String>();
        public List<String> selectedFileNames = new List<String>();
        
        public void EnableCopy(TextBox pathTextBox, ListBox dirListBox, Button copyButton)
        {
            
            if (dirListBox.SelectedIndex == -1)
            {
                copyButton.Enabled = false;
            }
            else
            {
                copyButton.Enabled = true;
            }
        }

        public void SelectedItemFileList(ListBox dirListBox, TextBox pathTextBox, Button copyButton, Button pasteButton)
        {
            foreach (String item in dirListBox.SelectedItems)
            {
                selectedFilePathList.Add(pathTextBox.Text + item);
                selectedFileNames.Add(item);
            }
            MessageBox.Show("The item in clipboard.");
            copyButton.Enabled = false;
            pasteButton.Enabled = true;
        }

        public void PasteCopiedFiles(Button pasteButton, TextBox pathTextBox)
        {
            string backupDir = pathTextBox.Text;
            if (pasteButton.Enabled == true)
            {
                for (int i = 0; selectedFileNames.Count > i; i++)
                {
                        File.Copy(selectedFilePathList[i], backupDir + selectedFileNames[i], true);
                }
            }
            pasteButton.Enabled = false;
        }
    }
}
