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
using System.IO;

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
            string path = File.ReadAllText(@"C:\tmp\defaultPath.txt");
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
            if(txtLink.Text == "")
            {
                MessageBox.Show("Please provide a link.");
                return;
            }
            loadingScreen form = new loadingScreen();
            form.form1 = this;
            form.ShowDialog();
        }

        public string getSelected()
        {
            //get all of the values for downloading.
            string link = txtLink.Text;
            string path = txtPath.Text;
            int selected = cbxFileType.SelectedIndex;

            return(link + "|" + path + "|" + selected); 
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
