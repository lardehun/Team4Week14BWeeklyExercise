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
            dirListBox.ClearSelected();
            string searchText = searchTextBox.Text;
            for (int i = 0; i < dirListBox.Items.Count; i++)
            {
                if (dirListBox.Items[i].ToString().ToLower().Contains(searchText))
                {
                    dirListBox.SetSelected(i, true);
                }
            }
        }
    }
}
