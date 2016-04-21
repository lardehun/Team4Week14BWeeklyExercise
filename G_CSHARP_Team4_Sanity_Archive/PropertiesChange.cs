using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_CSHARP_Team4_Sanity_Archive
{
    class PropertiesChange
    {
        /// <summary>
        /// Make a fileinfo object from the listbox and the textbox and set it readonly. 
        /// </summary>
        /// <param name="dirListBox"></param>
        /// <param name="pathTextBox"></param>
        public void ChangeFileToReadOnly(ListBox dirListBox,TextBox pathTextBox)
        {
            string filePath = pathTextBox.Text + dirListBox.SelectedItem.ToString();
            if (new FileInfo(filePath).Exists == true)
            {
                File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.ReadOnly);
            }
        }

        /// <summary>
        /// Make a fileinfo object from the listbox and the textbox and set it hidden. 
        /// </summary>
        /// <param name="dirListBox"></param>
        /// <param name="pathTextBox"></param>
        public void ChangeFileToHidden(ListBox dirListBox, TextBox pathTextBox)
        {
            string filePath = pathTextBox.Text + dirListBox.SelectedItem.ToString();
            if (new FileInfo(filePath).Exists == true)
            {
                File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.Hidden);
            }
        }

        /// <summary>
        /// Make a fileinfo object from the listbox and the textbox and remove readonly attribute. 
        /// </summary>
        /// <param name="dirListBox"></param>
        /// <param name="pathTextBox"></param>
        public void ChangeFileToNotReadOnly(ListBox dirListBox, TextBox pathTextBox)
        {
            string filePath = pathTextBox.Text + dirListBox.SelectedItem.ToString();
            if (new FileInfo(filePath).Exists == true)
            {
                FileAttributes attributes = File.GetAttributes(filePath);
                attributes = RemoveAttribute(attributes, FileAttributes.ReadOnly);
                File.SetAttributes(filePath, attributes);
            }
        }

        /// <summary>
        /// Make a fileinfo object from the listbox and the textbox and remove hidden attribute. 
        /// </summary>
        /// <param name="dirListBox"></param>
        /// <param name="pathTextBox"></param>
        public void ChangeFileToNotHidden(ListBox dirListBox, TextBox pathTextBox)
        {
            string filePath = pathTextBox.Text + dirListBox.SelectedItem.ToString();
            if (new FileInfo(filePath).Exists == true)
            {
                FileAttributes attributes = File.GetAttributes(filePath);
                attributes = RemoveAttribute(attributes, FileAttributes.Hidden);
                File.SetAttributes(filePath, attributes);
            }
        }


        private static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
        {
            return attributes & ~attributesToRemove;
        }
    }
}
