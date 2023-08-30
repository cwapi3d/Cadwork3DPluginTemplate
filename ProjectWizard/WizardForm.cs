using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWizard
{
    public partial class WizardForm : Form
    {
        public static string pluginAuthorName = "";
        public static string pluginAuthorEmail = "";
        public static string pluginCleanExit = "true";
        public static string cadworkExePath = "";
        public static string cadworkUserprofilPath = "";

        public WizardForm()
        {
            InitializeComponent();
        }

        private void cadworkExecutablePathBrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                cadworkExecutablePathTextBox.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void cadworkUserprofilePathBrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog3.ShowDialog() == DialogResult.OK)
            {
                cadworkUserprofilePathTextBox.Text = folderBrowserDialog3.SelectedPath;
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            pluginAuthorName = authorNameTextBox.Text;
            pluginAuthorEmail = authorEmailTextBox.Text;
            cadworkExePath = cadworkExecutablePathTextBox.Text;
            cadworkUserprofilPath = cadworkUserprofilePathTextBox.Text;

            if (string.IsNullOrEmpty(pluginAuthorName))
            {
                MessageBox.Show("Author name must be filled in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (string.IsNullOrEmpty(pluginAuthorEmail))
            {
                MessageBox.Show("Author email address must be filled in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (string.IsNullOrEmpty(cadworkExePath))
            {
                MessageBox.Show("Cadwork executable path must be filled in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (string.IsNullOrEmpty(cadworkUserprofilPath))
            {
                MessageBox.Show("Cadwork userprofile path must be filled in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/cwapi3d/");
        }

        private void cadworkExeFromCadworkButton_Click(object sender, EventArgs e)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\cadwork Informatik\\ENV");
            var keyValue = registryKey.GetValue("CADWORK_EXE") as String;
            cadworkExecutablePathTextBox.Text = keyValue;
        }

        private void cadworkUPFromCadworkButton_Click(object sender, EventArgs e)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\cadwork Informatik\\ENV");
            var keyValue = registryKey.GetValue("CADWORK_USP") as String;
            cadworkUserprofilePathTextBox.Text = keyValue;
        }
    }
}
