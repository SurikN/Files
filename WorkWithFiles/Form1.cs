using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WorkWithFiles
{
    public partial class Form1 : Form
    {
        private static string root = "C:/TestDirRoot";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Directory.CreateDirectory($"{root}/Folder_{i}");
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Directory.Delete($"{root}/Folder_{i}");
            }
        }

        private void buttonCreateFolded_Click(object sender, EventArgs e)
        {
            string path = root;
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    path += $"/Folder_{i}";
                    Directory.CreateDirectory(path);
                }
                catch (PathTooLongException)
                {
                    MessageBox.Show($"Path too long on step {i}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }

        private void buttonRemoveFolded_Click(object sender, EventArgs e)
        {
            Directory.Delete($"{root}/Folder_0", true);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string fullFileName;
            if ((fullFileName = SearchForFile(root, textBoxSearch.Text)) != null)
            {
                richTextBoxForSearched.BackColor = Color.Aquamarine;
                richTextBoxForSearched.Text = OpenReadFile(fullFileName);
            }
            else
            {
                richTextBoxForSearched.BackColor = Color.LightPink;
                richTextBoxForSearched.Text = "File was not found!";
            }
        }

        /// <summary>
        /// Recursive method to find the file with given name
        /// </summary>
        /// <param name="root">Starting directory</param>
        /// <param name="fileName">File name</param>
        /// <returns>Full path to the file, if file is present in current directory or subdirectories, null otherwise</returns>
        private string SearchForFile(string root, string fileName)
        {
            string result;
            //check if current directory contains the file
            if ((result = Directory.GetFiles(root).FirstOrDefault(f => f.EndsWith($"/{fileName}"))) != null)
            {
                return result;
            }

            //if not, applying itself for each subdirectory
            foreach (var directory in Directory.GetDirectories(root))
            {
                if ((result = SearchForFile(directory, fileName)) != null)
                {
                    return result;
                }
            }

            //if none of the subdirectories returned filename, returning null
            return null;
        }

        /// <summary>
        /// Opens a file with text stream and reads it
        /// </summary>
        /// <param name="fileName">Full path to the file</param>
        /// <returns>Content of the file</returns>
        private string OpenReadFile(string fileName)
        {
            using (StreamReader sr = new StreamReader(new FileStream(fileName, FileMode.Open)))
            {
                return sr.ReadToEnd();
            }
        }
    }
}
