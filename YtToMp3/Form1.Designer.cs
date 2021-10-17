
namespace YtToMp3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mp3 = new System.Windows.Forms.RadioButton();
            this.mp4 = new System.Windows.Forms.RadioButton();
            this.convert_button = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(159, 38);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(163, 13);
            this.title.TabIndex = 0;
            this.title.Text = "Youtube Mp3 / Mp4 Downloader";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "URL";
            // 
            // link
            // 
            this.link.Location = new System.Drawing.Point(112, 66);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(335, 20);
            this.link.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Format";
            // 
            // mp3
            // 
            this.mp3.AutoSize = true;
            this.mp3.Checked = true;
            this.mp3.Location = new System.Drawing.Point(112, 120);
            this.mp3.Name = "mp3";
            this.mp3.Size = new System.Drawing.Size(46, 17);
            this.mp3.TabIndex = 4;
            this.mp3.TabStop = true;
            this.mp3.Text = "Mp3";
            this.mp3.UseVisualStyleBackColor = true;
            this.mp3.CheckedChanged += new System.EventHandler(this.mp3_CheckedChanged);
            // 
            // mp4
            // 
            this.mp4.AutoSize = true;
            this.mp4.Location = new System.Drawing.Point(181, 120);
            this.mp4.Name = "mp4";
            this.mp4.Size = new System.Drawing.Size(46, 17);
            this.mp4.TabIndex = 5;
            this.mp4.Text = "Mp4";
            this.mp4.UseVisualStyleBackColor = true;
            this.mp4.CheckedChanged += new System.EventHandler(this.mp4_CheckedChanged);
            // 
            // convert_button
            // 
            this.convert_button.Location = new System.Drawing.Point(112, 175);
            this.convert_button.Name = "convert_button";
            this.convert_button.Size = new System.Drawing.Size(335, 45);
            this.convert_button.TabIndex = 6;
            this.convert_button.Text = "Convert";
            this.convert_button.UseVisualStyleBackColor = true;
            this.convert_button.Click += new System.EventHandler(this.convert_button_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(112, 253);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(335, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 312);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.convert_button);
            this.Controls.Add(this.mp4);
            this.Controls.Add(this.mp3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.link);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Youtube video downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox link;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton mp3;
        private System.Windows.Forms.RadioButton mp4;
        private System.Windows.Forms.Button convert_button;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

