using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_CSHARP_Team4_Sanity_Archive
{
    class Searching
    {
        /// <summary>
        /// Remove every other item from the given listbox only leaving the word in the searchtextbox
        /// </summary>
        /// <param name="searchTextBox"></param>
        /// <param name="dirListBox"></param>
        /// <param name="pathTextBox"></param>
        public void search(TextBox searchTextBox,ListBox dirListBox,TextBox pathTextBox)
        {
            
            string searchText = searchTextBox.Text;
            int index = dirListBox.FindString(searchText);
            for (int i = 0; i < dirListBox.Items.Count; i++)
            {
                if (i != index)
                {
                    dirListBox.Items.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// Fill back the dirListbox from the pathTextBox
        /// </summary>
        /// <param name="pathTextBox"></param>
        /// <param name="dirListBox"></param>
        public void FillBack(TextBox pathTextBox,ListBox dirListBox)
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
