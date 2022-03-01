using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using VideoLibrary;
using System.IO;
using MediaToolkit;
using MediaToolkit.Model;

namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //check if the defaultPath text file exists and if it doesn't make one.
            if(!File.Exists(@"C:\tmp\defaultPath.txt"))
            {
                using (StreamWriter sw = File.CreateText(@"C:\tmp\defaultPath.txt")) ;
            }
            
            //preselect .mp3
            cbxFileType.SelectedIndex = 1;

            //select default path.
            string path = System.IO.File.ReadAllText(@"C:\tmp\defaultPath.txt");
            txtPath.Text = path;

        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            //open folder browser
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "+++Select Folder+++";
            fbd.ShowNewFolderButton = false;

            //put that path in the textbox.
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fbd.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string link = txtLink.Text;
            string path = txtPath.Text;
            downloadVideo(link, path);
        }

        //downloading the video provided.
        private async Task downloadVideo(string link, string path)
        {

            var youtube = YouTube.Default;
            var video = youtube.GetVideo(link);

            //check if .mp3 is selected and download as .mp3
            if(cbxFileType.SelectedIndex == 1)
            {
                await Task.Run(() => File.WriteAllBytes(Directory.GetCurrentDirectory() + "temp.mp4", video.GetBytes()));
                var inputFile = new MediaFile { Filename = Directory.GetCurrentDirectory() + "temp.mp4" };
                var outputFile = new MediaFile { Filename = $"{path + @"\" + video.FullName}.mp3" };

                using (var engine = new Engine())
                {
                    engine.GetMetadata(inputFile);
                    engine.Convert(inputFile, outputFile);
                }
                MessageBox.Show("Done");
                return;
            }
            //Download as .mp4
            await Task.Run(() => File.WriteAllBytes(path + @"\" + video.FullName, video.GetBytes()));
            MessageBox.Show("Done");
        }

        private void btnSetDefaultPath_Click(object sender, EventArgs e)
        {
            //changes defaultPath to whatever is inside txtPath.
            string path = txtPath.Text;
            string filePath = @"C:\tmp\defaultPath.txt";
            using (StreamWriter sw = File.CreateText(filePath));
            File.WriteAllText(@"C:\tmp\defaultPath.txt", path);
        }
    }
}
