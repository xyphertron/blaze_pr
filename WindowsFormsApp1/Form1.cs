using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Controls;
using System.Net.Http;
using System.Net.NetworkInformation;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string timestamp;
        public string selectedFolderPath=string.Empty;
        private string selectedFileName = string.Empty;
        public string ticketCategorySelected = string.Empty;
        public string ticketNumebr = string.Empty;
        public string fileNameBox = string.Empty;
        public string fileNameCombined = string.Empty;
        public string featureBranchName = string.Empty;
        public string commitMessage = string.Empty;



        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GitStatusBtn_Click(object sender, EventArgs e)
        {
            //try
            //{
            // Create a ProcessStartInfo object with the command and working directory
            ProcessStartInfo startInfo = new ProcessStartInfo("git", "status");
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.CreateNoWindow = true;
            // Set the working directory to the desired repository path
            startInfo.WorkingDirectory = selectedFolderPath;

            // Create a new process and start it
            using (Process process = new Process { StartInfo = startInfo })
            {
                process.Start();

                // Read the output from the process
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                // Display the output in the web browser control
                // Create a temporary HTML file
                string tempFilePath = Path.GetTempFileName() + ".html";

                // Create the HTML content
                string htmlContent = $"<pre>{output}</pre>";

                // Write the HTML content to the file
                File.WriteAllText(tempFilePath, htmlContent);

                // Navigate the WebBrowser to the temporary file
                LogBoxWindow.Navigate(new Uri(tempFilePath));


                process.WaitForExit();
            }
        }

        private void LogBoxWindow_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void SwitchBranchBtn_Click(object sender, EventArgs e)
        {
            featureBranchName = ticketCategorySelected + "-" + ticketNumebr + "-" + fileNameBox;
            ProcessStartInfo startInfo = new ProcessStartInfo("git", $"checkout -b {featureBranchName}");
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.CreateNoWindow = true;
            // Set the working directory to the desired repository path \"{featureBranchName}\"
            startInfo.WorkingDirectory = selectedFolderPath;

            // Create a new process and start it
            using (Process process = new Process { StartInfo = startInfo })
            {
                process.Start();

                // Read the output from the process
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                // Display the output in the web browser control
                // Create a temporary HTML file
                string tempFilePath = Path.GetTempFileName() + ".html";

                // Create the HTML content
                string htmlContent = $"<pre>{output}</pre>";

                // Write the HTML content to the file
                File.WriteAllText(tempFilePath, htmlContent);

                // Navigate the WebBrowser to the temporary file
                LogBoxWindow.Navigate(new Uri(tempFilePath));


                // Optionally display errors if any
                //if (!string.IsNullOrEmpty(error))
                //{
                //    MessageBox.Show($"Git Status Error:\n{error}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                //}

                GetCurrentBranch();

                process.WaitForExit();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Get current date and time
            DateTime now = DateTime.Now;

            // Format the timestamp string
            timestamp = $"V{now:yyyyMMddHHmm}";

            // Display the timestamp in the textbox
            textBox1.Text = timestamp;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timestamp = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ticketNumebr = textBox2.Text;  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog fbd = new CommonOpenFileDialog();
            
                fbd.IsFolderPicker = true;
                fbd.ShowHiddenItems = false;

                if (fbd.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    webBrowser1.Url = new Uri(fbd.FileName);
                    selectedFolderPath = fbd.FileName;
                    GetCurrentBranch();
                    textBox5.Text = selectedFolderPath;
                    label7.Text = selectedFolderPath;

                }
            
        }
        

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.Document == null)
            {
                //System.Windows.MessageBox.Show("He");
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        protected void GetCurrentBranch()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("git", "branch --show-current");
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            // Set the working directory to the desired repository path
            startInfo.WorkingDirectory = selectedFolderPath;

            // Create a new process and start it
            using (Process process = new Process { StartInfo = startInfo })
            {
                process.Start();

                // Read the output from the process
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                label8.Text = output;
                featureBranchName = output.Trim();

                process.WaitForExit();
            }
        }

        protected void GitAddFunction()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("git", "add .");
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.CreateNoWindow = true;
            // Set the working directory to the desired repository path
            startInfo.WorkingDirectory = selectedFolderPath;

            // Create a new process and start it
            using (Process process = new Process { StartInfo = startInfo })
            {
                process.Start();

                // Read the output from the process
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                // Display the output in the web browser control
                // Create a temporary HTML file
                string tempFilePath = Path.GetTempFileName() + ".html";

                // Create the HTML content
                string htmlContent = $"<pre>{output+error}</pre>";

                // Write the HTML content to the file
                File.WriteAllText(tempFilePath, htmlContent);

                // Navigate the WebBrowser to the temporary file
                LogBoxWindow.Navigate(new Uri(tempFilePath));

                //System.Windows.MessageBox.Show("add zala");

                process.WaitForExit();

            }
        }

        protected void CommitMessageFunction()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("git", $"commit -m \"{commitMessage}\"");
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.CreateNoWindow = true;
            // Set the working directory to the desired repository path
            startInfo.WorkingDirectory = selectedFolderPath;

            // Create a new process and start it
            using (Process process = new Process { StartInfo = startInfo })
            {
                process.Start();

                // Read the output from the process
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                // Display the output in the web browser control
                // Create a temporary HTML file
                string tempFilePath = Path.GetTempFileName() + ".html";

                // Create the HTML content
                string htmlContent = $"<pre>{output+error}</pre>";

                // Write the HTML content to the file
                File.WriteAllText(tempFilePath, htmlContent);

                // Navigate the WebBrowser to the temporary file
                LogBoxWindow.Navigate(new Uri(tempFilePath));

                //System.Windows.MessageBox.Show("commit zala");

                process.WaitForExit();

            }
        }

        protected void GitPullFunction()
        {

            
                ProcessStartInfo startInfo = new ProcessStartInfo("git", "pull origin master");
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;
                startInfo.CreateNoWindow = true;
                // Set the working directory to the desired repository path
                startInfo.WorkingDirectory = selectedFolderPath;

                using (Process process = new Process { StartInfo = startInfo })
                {
                    process.Start();

                    // Read the output from the process
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    // Display the output in the web browser control
                    // Create a temporary HTML file
                    string tempFilePath = Path.GetTempFileName() + ".html";

                    // Create the HTML content
                    string htmlContent = $"<pre>{output + error}</pre>";

                    // Write the HTML content to the file
                    File.WriteAllText(tempFilePath, htmlContent);

                    // Navigate the WebBrowser to the temporary file
                    LogBoxWindow.Navigate(new Uri(tempFilePath));

                    process.WaitForExit();

                }
            
        }

        protected void GitPushFunction()
        {
            
            if (commitMessage==string.Empty || commitMessage.Length < 8)
            {
                System.Windows.MessageBox.Show("Enter proper commit message");
            }
            else if(featureBranchName == "master")
            {
                System.Windows.MessageBox.Show("Can't push directly on master");
            }

            // Create a new process and start it
            else
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("git", $"push origin {featureBranchName}");
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;
                startInfo.CreateNoWindow = true;
                // Set the working directory to the desired repository path
                startInfo.WorkingDirectory = selectedFolderPath;

                using (Process process = new Process { StartInfo = startInfo })
                {
                    process.Start();

                    // Read the output from the process
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    // Display the output in the web browser control
                    // Create a temporary HTML file
                    string tempFilePath = Path.GetTempFileName() + ".html";

                    // Create the HTML content
                    string htmlContent = $"<pre>{output+error}</pre>";

                    // Write the HTML content to the file
                    File.WriteAllText(tempFilePath, htmlContent);

                    // Navigate the WebBrowser to the temporary file
                    LogBoxWindow.Navigate(new Uri(tempFilePath));

                    //System.Windows.MessageBox.Show("push zala");

                    process.WaitForExit();

                }
            }
        }

        protected void GitCheckoutMasterFunction()
        {

             ProcessStartInfo startInfo = new ProcessStartInfo("git", $"checkout master");
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;
                startInfo.CreateNoWindow = true;
                // Set the working directory to the desired repository path
                startInfo.WorkingDirectory = selectedFolderPath;

                using (Process process = new Process { StartInfo = startInfo })
                {
                    process.Start();

                    // Read the output from the process
                    //string output = process.StandardOutput.ReadToEnd();
                    //string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                }
            
        }

        protected void GitDeleteLocalBranchFunction()
        {

            ProcessStartInfo startInfo = new ProcessStartInfo("git", $"branch -D {featureBranchName}");
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.CreateNoWindow = true;
            // Set the working directory to the desired repository path
            startInfo.WorkingDirectory = selectedFolderPath;

            using (Process process = new Process { StartInfo = startInfo })
            {
                process.Start();

                // Read the output from the process
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            fileNameBox = textBox3.Text;

            if (fileNameBox.Contains(" "))
            {
                label11.Text = "Please remove whitespaces. You can add hypen or underscore instead.";
            }
            else
            {
                label11.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Windows.MessageBox.Show(ticketCategorySelected);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            featureBranchName = ticketCategorySelected + "-" + ticketNumebr + "-" + fileNameBox;
            fileNameCombined = timestamp + "__" + featureBranchName;
            // Copy the file name to the clipboard
            System.Windows.Clipboard.SetText(fileNameCombined);

            // Optionally, show a message indicating the file name was copied
            System.Windows.MessageBox.Show($"{fileNameCombined} has been copied to the clipboard.");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GitPullFunction();
            GitAddFunction();
            CommitMessageFunction();
            GitPushFunction();
            GitCheckoutMasterFunction();  
            GitDeleteLocalBranchFunction();
            GetCurrentBranch();
            textBox4.Text = string.Empty;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            commitMessage = textBox4.Text;    
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            ticketCategorySelected = textBox6.Text;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //GitAddFunction();
        }
    }
}
