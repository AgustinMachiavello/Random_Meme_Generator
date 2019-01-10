using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//DO THE MUSIC thing
namespace RandomMeme
{
    public partial class RandomMemes : Form
    {
        #region VAR
        //Songs
        private SongMap[] songs = new SongMap[1];
        //Count the actual picture position
        private int actual_picture { get; set; } = 0;
        //Here we store the file names
        private string[] file_names { get; set; }
        //Amount of memes
        private int memes_count { get; set; } = 0;
        //Boolean to check if form is in fullscreen
        private bool fullsceen { get; set; } = false;
        //Boolean to check if the song is being played 
        private bool songplaying { get; set; } = false;
        //Check the time for bonfire mode
        private int actual_time { get; set; } = 0;
        //Check if bonfire mode is activated
        private bool bonfire_mode { get; set; } = false;
        //Change image in bonfire mode
        int interval { get; set; } = 0;
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
            //Add bonfire song
            int[] beatsbonfire = { 0,1200,2100,2900,4200,//GOOD 1-5
4900,5600,7000,8300,9600,//GOOD 6-10
10200,12000,12800,13400,14500,//GOOD 11-15
15100,16100,17300,18800,20000,//GOOD 16-20
20800,21600,22700,23600,24300,//GOOD   21-25
25600,26400,27000,28400,29600,//GOOD 26-30
30800,31600,33400,34100,34700,//GOOD 31-35
35800,36500,37200,38500,40200,//GOOD 36-40
41400,42300,43000,44400,45000,//GOOD41-45
45600,47000,47700,48400,49700,//GOOD 46-50
51100,52400,53200   };//GOOD 51-55
            this.songs[0] = new SongMap("bonfire", beatsbonfire);
        }
        #endregion

        #region FUNCTIONS    
        //Counts memes inside folder
        private int CountMemes(string dir)
        {
            int temp = Directory.GetFiles(@"" + dir + "").Length;
            return temp;
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
        //Play/stop music
        private void playStopSong()
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources.bonfire); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            if (!this.songplaying)
            {
                audio.Play();
                this.songplaying = true;
            }
            else
            {
                audio.Stop();
                this.songplaying = false;
            }           
        }        
        #endregion

        #region FORM ACTIONS
        private void timerBonfiremode_Tick(object sender, EventArgs e)
        {
            if (interval < songs[0].beats.Length)
            {
                this.actual_time += 100;
                int temp = songs[0].beats[interval];//get bonfire songmap
                if (temp == actual_time)
                {
                    this.ShowImage(interval);
                    interval++;
                }
            }
            else { bBonfireMode.PerformClick(); }            
            
        }
        //Automatic change of the memes 
        private void bAutoMode_Click(object sender, EventArgs e)
        {
            //Enable or diable the timer
            if (!this.timerAutomode.Enabled)
            {
                this.tbamspeed.Enabled = true;//Enable the speed track bar
                this.timerAutomode.Enabled = true;
                //Change text
                this.bAutoMode.Text = "AUTO MODE (ON)";
            }
            else
            {
                this.tbamspeed.Enabled = false;//Disable the speed track bar
                this.timerAutomode.Enabled = false;
                this.bAutoMode.Text = "AUTO MODE (OFF)";
            }
        }
        //Opens the fodler dialog
        private void bBrowse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BE SURE THAT THE FOLDER ONLY CONTAINS IMAGES!\n(sorry UnU)", "BE CAREFUL HUMAN!");
            if (folderbd1.ShowDialog() == DialogResult.OK)
            {
                //Set the textbox text
                this.textBoxFolder.Text = folderbd1.SelectedPath;
                //Set the file names
                this.file_names = this.GetFileNames(this.folderbd1.SelectedPath);
                //Set the meme count
                this.memes_count = this.CountMemes(this.folderbd1.SelectedPath);
                //Show amount of memes
                this.lFilesNumb.Text = this.memes_count.ToString();
                //Turn visible the modes panel
                this.panelmodes.Visible = true;
            }
        }
        //Timer for auto mode
        private void timerAutomode_Tick(object sender, EventArgs e)
        {
            //If the top is not reached show image
            if (this.actual_picture <= this.memes_count - 1)
            {
                this.ShowImage(this.actual_picture);
                //Reset actual_meme if the meme is the last one
                this.actual_picture += 1;
            }
            else { this.actual_picture = 0; }
        }
        //Click perform for bonfire mode
        private void bBonfireMode_Click(object sender, EventArgs e)
        {
            if (this.memes_count >= 55)
            {
                if (!this.bonfire_mode)
                {
                    this.bBonfireMode.Text = "bonfire mode ON";
                    this.bonfire_mode = true;
                    this.playStopSong();
                    interval = 0;
                    actual_time = 0;
                    this.timerBonfiremode.Enabled = true;
                    this.ShowImage(interval);//image at time 0
                    interval++;
                }
                else
                {
                    this.bBonfireMode.Text = "bonfire mode OFF";
                    this.playStopSong();
                    this.bonfire_mode = false;
                    this.timerBonfiremode.Enabled = false;
                }
            }
            else { MessageBox.Show("The number of memes must be 56 or greater!"); }
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
            float second = 1000;
            float memes_per_second = second / this.timerAutomode.Interval;
            if (memes_per_second >= 10) { this.lMayCrash.Visible = true; } else { this.lMayCrash.Visible = false; }
            this.lspeed.Text = Convert.ToString(memes_per_second);
        }
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
        private void bsize_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1.SizeMode == PictureBoxSizeMode.Zoom)
            {
                this.bsize.Text = "auto size";
                this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else if (this.pictureBox1.SizeMode == PictureBoxSizeMode.AutoSize)
            {
                this.bsize.Text = "zoom size";
                this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        #endregion


    }
}
