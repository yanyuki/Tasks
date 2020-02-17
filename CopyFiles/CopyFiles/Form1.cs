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

namespace CopyFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtSource_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDistination_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            // Path
            try
            {
                // This part should be functionized, maybe.
                var checkPath1 = txtFromPath.Text.ToString();
                var checkPath2 = txtToPath.Text.ToString();
                var checkPath3 = Directory.EnumerateFiles(checkPath1);
                var checkPath4 = Directory.EnumerateFiles(checkPath2);
            }
            catch (Exception ex)
            {
                if (ex is ArgumentException || ex is DirectoryNotFoundException)
                {
                    DialogResult result = MessageBox.Show("Either directory name is wrong. Try again.",
                            "Caution",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.OK)
                    {
                        return;
                    }
                }
            }

            // List of Files
            var sourcePath = txtFromPath.Text.ToString();
            var distinationPath = txtToPath.Text.ToString();
            var sourceFileNamePath = Directory.EnumerateFiles(sourcePath);
            var distinationFileNamePath = Directory.EnumerateFiles(distinationPath);
            var sourceFileNames = sourceFileNamePath.Select(f => f.Split('\\').LastOrDefault());
            var distinationFileNames = distinationFileNamePath.Select(f => f.Split('\\').LastOrDefault());

            // If distinationFileNames contains same name files of sourceFileNames, pop up caution.
            foreach (string f in sourceFileNames)
            {
                if (distinationFileNames.Contains(f))
                {
                    DialogResult result = MessageBox.Show("This process overrides same name files. Is it OK？",
                        "Caution",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button2);
                    if (result != DialogResult.OK)//Cancel or NO
                    {
                        //txtFromPath.Focus();//focus to from textbox

                        return; 
                    }
                    // Below is needless
                    /*if (result == DialogResult.No)//cancel?
                    {
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }*/
                   // txtFromPath.Focus();//focus to from textbox
                   // break;//stop loop 
                }
            }

            // Copy each file
            foreach (string f in sourceFileNames)
            {
                File.Copy(sourcePath + Path.DirectorySeparatorChar + f
                    , distinationPath + Path.DirectorySeparatorChar + f, true);
            }
            /* Below doesn't work 
             * sourceFileNamePath.Select(f=>File.Copy(f, distinationPath));
             */
        }

        private void btnRefSource_Click(object sender, EventArgs e)
        {
            var folderRef = new FolderBrowserDialog();
            DialogResult resultRef = folderRef.ShowDialog();

            if (resultRef == DialogResult.OK)
            {
                txtFromPath.Text = folderRef.SelectedPath;
            }
        }

        private void btnRefDistination_Click(object sender, EventArgs e)
        {
            var folderRef = new FolderBrowserDialog();
            DialogResult resultRef = folderRef.ShowDialog();

            if (resultRef == DialogResult.OK)
            {
                txtToPath.Text = folderRef.SelectedPath;
            }
        }
    }
}
