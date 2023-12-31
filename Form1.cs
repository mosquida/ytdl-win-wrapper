using System.Diagnostics;

namespace youtube_dl_mp3_wrapper
{
    public partial class Form1 : Form
    {
        string outName="";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(2323);
            string command = "cd " + GetDownloadsFolderPath() + " && yt-dlp.exe -i --extract-audio --audio-format mp3 " + url.Text;

            // Create a process to execute the command
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe"; // Use the command prompt
            process.StartInfo.Arguments = $"/c {command}"; // Pass the command as an argument
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            // Start the process
            process.Start();

            // Read the output of the command asynchronously
            // Initialize a StringBuilder to accumulate the output
            System.Text.StringBuilder outputBuilder = new System.Text.StringBuilder();

            process.OutputDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    // Append the data to the StringBuilder
                    outputBuilder.AppendLine(e.Data);

                    // Display the accumulated output in the label
                    status.Text = outputBuilder.ToString();

                    // Check if the line contains "Destination:"
                    if (e.Data.Contains("Destination:"))
                    {
                        // Extract the output filename from the line
                        string[] parts = e.Data.Split(':');
                        if (parts.Length > 1)
                        {
                            string outputFilename = parts[1].Trim();
                            outName = $"Output Filename: {outputFilename}";

                            // Display the output filename in a separate label
                            label1.Text = outName;
                        }
                    }
                }
            };

            // Begin asynchronous reading of the output
            process.BeginOutputReadLine();


            // Wait for the process to finish
            process.WaitForExit();

            // Display the output
            
            Console.WriteLine("sdsd");
            // status.Text = output;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            status.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        static string GetDownloadsFolderPath()
        {
            // Get the current user's folder path
            string downloadsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            // Append "Downloads" to the User path
            downloadsFolderPath = System.IO.Path.Combine(downloadsFolderPath, "Downloads");

            return downloadsFolderPath;
        }
    }
}
