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
        public List<String> selectedBackupFilePathList = new List<String>();
        public List<String> selectedBackupFileNameList = new List<String>();
        public int copyOrPasteOption = (int)MoveOptions.None;

        public void EnableCopyAndCutButton(TextBox pathTextBox, ListBox dirListBox, Button theButton)
        {
            if (dirListBox.SelectedIndex == -1)
            {
                theButton.Enabled = false;
            }
            else
            {
                theButton.Enabled = true;
            }
        }

        public void SelectedItemFileList(ListBox dirListBox, TextBox pathTextBox, Button copyButton, Button pasteButton, Button cutButton)
        {
            foreach (String item in dirListBox.SelectedItems)
            {
                selectedBackupFilePathList.Add(pathTextBox.Text + item);
                selectedBackupFileNameList.Add(item);
            }
            MessageBox.Show("The selected file(s) on the clipboard.");
            copyButton.Enabled = false;
            cutButton.Enabled = false;
            pasteButton.Enabled = true;
        }

        public void PasteFiles(Button pasteButton, TextBox pathTextBox)
        {
            string backupDir = pathTextBox.Text;

            try
            {
                for (int i = 0; selectedBackupFileNameList.Count > i; i++)
                {
                    if (copyOrPasteOption == 1)
                    {
                        File.Copy(selectedBackupFilePathList[i], backupDir + selectedBackupFileNameList[i], true);
                    }
                    if (copyOrPasteOption == 2)
                    {
                        File.Move(selectedBackupFilePathList[i], backupDir + selectedBackupFileNameList[i]);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem while trying to copy the file(s).");
            }

            pasteButton.Enabled = false;
            copyOrPasteOption = (int)MoveOptions.None;
            selectedBackupFileNameList.Clear();
            selectedBackupFilePathList.Clear();
        }
    }
}
