using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using System.IO;
using MediaToolkit;
using MediaToolkit.Model;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace YoutubeDownloader
{
    public partial class loadingScreen : Form
    {

        public Form1 form1;
        public loadingScreen()
        {
            InitializeComponent();
        }

        private void loadingScreen_Load(object sender, EventArgs e)
        {
            downloadVideo();
        }

        //downloading the video provided.
        private async Task downloadVideo()
        {
            timerDownload.Start();

            string values = form1.getSelected();
            string[] valuesArray = values.Split('|');

            string link = valuesArray[0];
            string path = valuesArray[1];
            string selected = valuesArray[2];
            
            var youtube = YouTube.Default;
            var video = youtube.GetVideo(link);

            //check if .mp3 is selected and download as .mp3
            if (selected == "1")
            {
                await Task.Run(() => File.WriteAllBytes(Directory.GetCurrentDirectory() + "temp.mp4", video.GetBytes()));
                var inputFile = new MediaFile { Filename = Directory.GetCurrentDirectory() + "temp.mp4" };
                var videoName = video.FullName.Replace(".mp4", "");
                var outputFile = new MediaFile { Filename = $"{path + @"\" + videoName}.mp3" };

                using (var engine = new Engine())
                {
                    engine.GetMetadata(inputFile);
                    engine.Convert(inputFile, outputFile);
                }
                MessageBox.Show("Done");
                this.Close();
                return;
            }
            //Download as .mp4
            var youtubeVideo = new YoutubeClient();
            await youtubeVideo.Videos.DownloadAsync(link, path + @"\" + video.FullName + ".mp4");

            MessageBox.Show("Done");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerDownload_Tick(object sender, EventArgs e)
        {
            //definitely a good way to do progressbars.
            if(pbDownloading.Value < 99)
            {
                pbDownloading.Value = pbDownloading.Value + 1;
                lblPercentage.Text = pbDownloading.Value + "%";
            } else
            {
                timerDownload.Stop();
            }
        }
    }
}
