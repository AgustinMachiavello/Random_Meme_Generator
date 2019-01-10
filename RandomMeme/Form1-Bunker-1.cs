using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//DO THE MUSIC thing
namespace RandomMeme
{
    public partial class RandomMemes : Form
    {
        #region VAR
        //Count the actual picture position
        private int actual_picture { get; set; } = 0;
        //Here we store the file names
        private string[] file_names { get; set; }
        //Amount of memes
        private int memes_count { get; set; } = 0;
        //Boolean to check if form is in fullscreen
        private bool fullsceen { get; set; } = false;
        #endregion

        #region BUILDER & LOAD
        //BUILDER
        public RandomMemes()
        {
            InitializeComponent();
        }
        //FORM LOAD
        private void RandomMemes_Load(object sender, EventArgs e)
        {
        }
        #endregion

        #region FUNCTIONS
        //Generates random meme
        private void GenerateMeme_Click(object sender, EventArgs e)
        {
            try
            {
                //Get the path
                string temp_path = this.folderbd1.SelectedPath.ToString();
                //Count the memes
                int count_memes = this.CountMemes(temp_path);
                //Get a random number
                int numeroelegido = RandomNumber.RandomMemeNumber(count_memes);
                //Show image
                this.ShowImage(numeroelegido);
            }
            catch (Exception ex)
            {
                //Show the error
                MessageBox.Show("CHECK THE FOLDER SELECTED PLSSS: \n" + ex.Message, "Oh hell no... >:(");
            }
            
        }
        //Counts memes inside folder
        private int CountMemes(string dir)
        {
            int temp = Directory.GetFiles(@"" + dir + "").Length;
            return temp;
        }
        //Automatic change of the memes 
        private void bAutoMode_Click(object sender, EventArgs e)
        {
            //Enable or diable the timer
            if (!this.timerAutomode.Enabled)
            {
                this.timerAutomode.Enabled = true;
                //Change text
                this.bAutoMode.Text = "AUTO MODE (ON)";               
            }
            else
            {
                this.timerAutomode.Enabled = false;
                this.bAutoMode.Text = "AUTO MODE (OFF)";
            }
        }
        //Opens the fodler dialog
        private void bBrowse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BE SURE THAT THE FOLDER ONLY CONTAINS IMAGES!\n(sorry UnU)","BE CAREFUL HUMAN!");
            if (folderbd1.ShowDialog() == DialogResult.OK)
            {
                //Set the textbox text
                this.textBoxFolder.Text = folderbd1.SelectedPath;
                //Set the file names
                this.file_names = this.GetFileNames(this.folderbd1.SelectedPath);
                //Set the meme count
                this.memes_count = this.CountMemes(this.folderbd1.SelectedPath);
                //Show label click me
                this.lClickme.Visible = true;
                //Show amount of memes
                this.lFilesNumb.Text = this.memes_count.ToString();
            }
        }
        //Get the file names into an array
        private string[] GetFileNames(string _path)
        {
            string[] fileArray = Directory.GetFiles(@""+_path+"");
            return fileArray;
        }
        //Show image at X posiion inside the file_name array
        private void ShowImage(int _number)
        {
            try
            {
                string temp = @"" + this.file_names.ElementAt(_number);
                //Show image
                this.pictureBox1.Image = Image.FromFile(temp);
                //Set the label
                this.lmNumber.Text = _number.ToString();
            }
            catch (Exception e)
            {
                //Stop the timer
                this.timerAutomode.Enabled = false;
                //Show the error
                MessageBox.Show("CHECK THE FOLDER SELECTED PLSSS: \n" + e.Message, "Oh hell no... >:(");
                //Set to default text
                this.bAutoMode.Text = "AUTO MODE (OFF)";                                 
            }
            
        }
        //Timer for auto mode
        private void timerAutomode_Tick(object sender, EventArgs e)
        {
            //If the top is not reached show image
            if (this.actual_picture <= this.memes_count-1)
            {
                this.ShowImage(this.actual_picture);
                //Reset actual_meme if the meme is the last one
                this.actual_picture += 1;
            }
            else { this.actual_picture = 0; }
        }
        //Enables or disables full screen mode
        private void FullScreen()
        {
            if (this.fullsceen)//Set to fullscreen
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                this.bFullscreen.Text = "Immersion (OFF)";
                this.fullsceen = false;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                this.bFullscreen.Text = "Immersion (ON)";
                this.fullsceen = true;
            }            
        }
        //Calls to Fullscreen()
        private void bFullscreen_Click(object sender, EventArgs e)
        {
            this.FullScreen();
        }
        //Set auto mode speed
        private void tbamspeed_Scroll(object sender, EventArgs e)
        {
            this.timerAutomode.Interval = 3000;
            this.timerAutomode.Interval = this.timerAutomode.Interval / tbamspeed.Value;
            float memes_per_second = this.timerAutomode.Interval;
            this.lspeed.Text = Convert.ToString(memes_per_second);
        }
        #endregion

    }
}
