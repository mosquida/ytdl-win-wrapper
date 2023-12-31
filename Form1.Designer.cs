
namespace youtube_dl_mp3_wrapper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            startbtn = new Button();
            label2 = new Label();
            label3 = new Label();
            status = new Label();
            url = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "Youtube URL";
            label1.Click += label1_Click;
            // 
            // startbtn
            // 
            startbtn.Location = new Point(425, 77);
            startbtn.Name = "startbtn";
            startbtn.Size = new Size(75, 23);
            startbtn.TabIndex = 3;
            startbtn.Text = "Start";
            startbtn.UseVisualStyleBackColor = true;
            startbtn.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(14, 12);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 4;
            label2.Text = "ds";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 151);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 5;
            label3.Text = "Status: ";
            label3.Click += label3_Click;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            status.Location = new Point(63, 151);
            status.Name = "status";
            status.Size = new Size(0, 15);
            status.TabIndex = 6;
            status.Click += label4_Click;
            // 
            // url
            // 
            url.Location = new Point(13, 78);
            url.Name = "url";
            url.Size = new Size(408, 23);
            url.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 336);
            Controls.Add(url);
            Controls.Add(status);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(startbtn);
            Controls.Add(label1);
            Name = "Form1";
            Text = "YT to mp3 downloader (yt-dlp)";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            url.Text += url.Text.Length;
            //throw new NotImplementedException();
        }

#endregion
        private Label label1;
        private Button startbtn;
        private Label label2;
        private Label label3;
        private Label status;
        private TextBox url;
    }
}
