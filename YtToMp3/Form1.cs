using MediaToolkit;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using VideoLibrary;

namespace YtToMp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum FileFormat
        {
            Mp3 = 0,
            Mp4 = 1,
        }

        FileFormat format = FileFormat.Mp3;

        private async void convert_button_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Select a folder" })
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                {
                    GetTitle();
                    MessageBox.Show("Download started. Be patient please", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var yt = YouTube.Default;
                    var video = await yt.GetVideoAsync(link.Text);

                    var downloadedVideoFilePath = Path.Combine(fdb.SelectedPath, video.FullName);
                    var downloadedVideoFile = File.Open(downloadedVideoFilePath, FileMode.Create, FileAccess.Write, FileShare.Read);
                    var videoBytes = await video.GetBytesAsync();
                    await downloadedVideoFile.WriteAsync(videoBytes, 0, videoBytes.Length);
                    downloadedVideoFile.Close();

                    if(format == FileFormat.Mp4)
                    {
                        MessageBox.Show("Download completed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    
                    var mediaToolkitInputFile = new MediaToolkit.Model.MediaFile { Filename = downloadedVideoFilePath };
                    var outputFilePath = Path.ChangeExtension(downloadedVideoFilePath, ".mp3");
                    var mediaToolkitOutputFile = new MediaToolkit.Model.MediaFile { Filename = outputFilePath };

                    using (var engine = new Engine())
                    {

                        engine.GetMetadata(mediaToolkitInputFile);
                        engine.Convert(mediaToolkitInputFile, mediaToolkitOutputFile);
                    }

                    
                    File.Delete(downloadedVideoFilePath);
                    
                    progressBar1.Value = 100;
                    MessageBox.Show("Download completed. Just one sec please..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Choose a file path...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        void GetTitle()
        {
            WebRequest request = HttpWebRequest.Create(link.Text);
            WebResponse response;

            response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string incoming = reader.ReadToEnd();
            int start = incoming.IndexOf("<title>") + 7;
            int done = incoming.Substring(start).IndexOf("</title>");
            string incomingInfo = incoming.Substring(start, done);
            title.Text = (incomingInfo);
        }

        private void mp3_CheckedChanged(object sender, EventArgs e)
        {
            format = FileFormat.Mp3;
        }

        private void mp4_CheckedChanged(object sender, EventArgs e)
        {
            format = FileFormat.Mp4;
        }
    }
}
