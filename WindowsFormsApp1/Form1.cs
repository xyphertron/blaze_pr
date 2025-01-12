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
        public string[] ticketCategory { get; set; }
        public string timestamp;
        public string selectedFolderPath;
        private string selectedFileName = string.Empty;



        public Form1()
        {
            InitializeComponent();
            //webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
           //DisplayContent();
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

        private void GitAddBtn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("git", "add .");
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            // Set the working directory to the desired repository path
            startInfo.WorkingDirectory = @"F:\git testing pr\testing_blaze_pr";

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

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
                    //GetCurrentBranch();
                    textBox5.Text = selectedFolderPath;
                    label7.Text = selectedFolderPath;

                }
            
        }
        void DisplayContent()
        {
            // Create simple HTML content
            string htmlContent = @"
        <html>
            <head>
                <title>Sample Content</title>
            </head>
            <body>
                <h1>Welcome to the WebBrowser Control!</h1>
                <p>This is some <b>sample content</b> displayed in the WebBrowser control.</p>
            </body>
        </html>";

            // Set the HTML content to the WebBrowser control
            webBrowser1.DocumentText = htmlContent;
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

                process.WaitForExit();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
