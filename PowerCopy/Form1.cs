using System;
using System.IO;
using System.Windows.Forms;

namespace PowerCopy
{
    public partial class PowerCopyForm : Form
    {
        DirectoryInfo sourceDirectory;
        DirectoryInfo targetDirectory;

        public PowerCopyForm()
        {
            InitializeComponent();
        }

        public void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);
            foreach (FileInfo fi in source.GetFiles())
            {
                //Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        private void SourceButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = folderBrowserDialog.SelectedPath;
                SourceLabel.Text = path;
                sourceDirectory = new DirectoryInfo(path);
            }        
        }

        private void DestinationButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = folderBrowserDialog.SelectedPath;
                DestinationLabel.Text = path;
                targetDirectory = new DirectoryInfo(path);
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (sourceDirectory == null || targetDirectory == null)
            {
                MessageBox.Show("Please select a source and destination folder!");
                return;                      
            }
            string source = sourceDirectory.FullName;
            string target = targetDirectory.FullName;
            DialogResult res = MessageBox.Show("Are you sure you want to Copy " + source + " folder to all folders in " + target, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                foreach (DirectoryInfo diTargetSubDir in targetDirectory.GetDirectories())
                {                 
                    DirectoryInfo subTargetDir = new DirectoryInfo(diTargetSubDir.FullName + "\\" + sourceDirectory.Name);
                    CopyAll(sourceDirectory, subTargetDir);
                }
            }
        }
    }
}
