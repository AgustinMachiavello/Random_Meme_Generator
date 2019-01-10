namespace RandomMeme
{
    partial class RandomMemes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomMemes));
            this.GenerateMeme = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lMemeNumber = new System.Windows.Forms.Label();
            this.lFileNumber = new System.Windows.Forms.Label();
            this.folderbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.lFolder = new System.Windows.Forms.Label();
            this.bBrowse = new System.Windows.Forms.Button();
            this.bAutoMode = new System.Windows.Forms.Button();
            this.timerAutomode = new System.Windows.Forms.Timer(this.components);
            this.lModes = new System.Windows.Forms.Label();
            this.lmNumber = new System.Windows.Forms.Label();
            this.lFilesNumb = new System.Windows.Forms.Label();
            this.bFullscreen = new System.Windows.Forms.Button();
            this.tbamspeed = new System.Windows.Forms.TrackBar();
            this.lAutomodeSpeed = new System.Windows.Forms.Label();
            this.lspeed = new System.Windows.Forms.Label();
            this.panelmodes = new System.Windows.Forms.Panel();
            this.bsize = new System.Windows.Forms.Button();
            this.bBonfireMode = new System.Windows.Forms.Button();
            this.lMayCrash = new System.Windows.Forms.Label();
            this.panelinput = new System.Windows.Forms.Panel();
            this.timerBonfiremode = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbamspeed)).BeginInit();
            this.panelmodes.SuspendLayout();
            this.panelinput.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenerateMeme
            // 
            this.GenerateMeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.GenerateMeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateMeme.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateMeme.Image = ((System.Drawing.Image)(resources.GetObject("GenerateMeme.Image")));
            this.GenerateMeme.Location = new System.Drawing.Point(8, 100);
            this.GenerateMeme.Name = "GenerateMeme";
            this.GenerateMeme.Size = new System.Drawing.Size(205, 50);
            this.GenerateMeme.TabIndex = 0;
            this.GenerateMeme.Text = "RANDOM MEME";
            this.GenerateMeme.UseVisualStyleBackColor = false;
            this.GenerateMeme.Click += new System.EventHandler(this.GenerateMeme_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(303, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lMemeNumber
            // 
            this.lMemeNumber.AutoSize = true;
            this.lMemeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMemeNumber.Location = new System.Drawing.Point(300, 16);
            this.lMemeNumber.Name = "lMemeNumber";
            this.lMemeNumber.Size = new System.Drawing.Size(16, 16);
            this.lMemeNumber.TabIndex = 4;
            this.lMemeNumber.Text = "#";
            // 
            // lFileNumber
            // 
            this.lFileNumber.AutoSize = true;
            this.lFileNumber.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFileNumber.Location = new System.Drawing.Point(5, 90);
            this.lFileNumber.Name = "lFileNumber";
            this.lFileNumber.Size = new System.Drawing.Size(188, 27);
            this.lFileNumber.TabIndex = 5;
            this.lFileNumber.Text = "Number of memes:";
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFolder.Location = new System.Drawing.Point(8, 37);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(228, 20);
            this.textBoxFolder.TabIndex = 7;
            this.textBoxFolder.Text = "NO FOLDER SELECTED. B-BAKA! (OwO)";
            // 
            // lFolder
            // 
            this.lFolder.AutoSize = true;
            this.lFolder.Font = new System.Drawing.Font("High Tower Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFolder.Location = new System.Drawing.Point(5, 10);
            this.lFolder.Name = "lFolder";
            this.lFolder.Size = new System.Drawing.Size(68, 22);
            this.lFolder.TabIndex = 8;
            this.lFolder.Text = "Folder:";
            // 
            // bBrowse
            // 
            this.bBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBrowse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBrowse.ForeColor = System.Drawing.Color.Black;
            this.bBrowse.Location = new System.Drawing.Point(9, 63);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(228, 24);
            this.bBrowse.TabIndex = 9;
            this.bBrowse.Text = "SELECT MEME SOURCE";
            this.bBrowse.UseVisualStyleBackColor = false;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // bAutoMode
            // 
            this.bAutoMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bAutoMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAutoMode.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAutoMode.Image = ((System.Drawing.Image)(resources.GetObject("bAutoMode.Image")));
            this.bAutoMode.Location = new System.Drawing.Point(8, 212);
            this.bAutoMode.Name = "bAutoMode";
            this.bAutoMode.Size = new System.Drawing.Size(206, 50);
            this.bAutoMode.TabIndex = 10;
            this.bAutoMode.Text = "AUTO MODE (OFF)";
            this.bAutoMode.UseVisualStyleBackColor = false;
            this.bAutoMode.Click += new System.EventHandler(this.bAutoMode_Click);
            // 
            // timerAutomode
            // 
            this.timerAutomode.Interval = 3000;
            this.timerAutomode.Tick += new System.EventHandler(this.timerAutomode_Tick);
            // 
            // lModes
            // 
            this.lModes.AutoSize = true;
            this.lModes.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lModes.Location = new System.Drawing.Point(3, 5);
            this.lModes.Name = "lModes";
            this.lModes.Size = new System.Drawing.Size(86, 34);
            this.lModes.TabIndex = 12;
            this.lModes.Text = "Mode:";
            // 
            // lmNumber
            // 
            this.lmNumber.AutoSize = true;
            this.lmNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmNumber.Location = new System.Drawing.Point(313, 16);
            this.lmNumber.Name = "lmNumber";
            this.lmNumber.Size = new System.Drawing.Size(15, 16);
            this.lmNumber.TabIndex = 14;
            this.lmNumber.Text = "0";
            // 
            // lFilesNumb
            // 
            this.lFilesNumb.AutoSize = true;
            this.lFilesNumb.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFilesNumb.Location = new System.Drawing.Point(199, 92);
            this.lFilesNumb.Name = "lFilesNumb";
            this.lFilesNumb.Size = new System.Drawing.Size(19, 23);
            this.lFilesNumb.TabIndex = 15;
            this.lFilesNumb.Text = "0";
            // 
            // bFullscreen
            // 
            this.bFullscreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFullscreen.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFullscreen.Image = ((System.Drawing.Image)(resources.GetObject("bFullscreen.Image")));
            this.bFullscreen.Location = new System.Drawing.Point(8, 156);
            this.bFullscreen.Name = "bFullscreen";
            this.bFullscreen.Size = new System.Drawing.Size(205, 50);
            this.bFullscreen.TabIndex = 16;
            this.bFullscreen.Text = "IMMERSION (OFF)";
            this.bFullscreen.UseVisualStyleBackColor = false;
            this.bFullscreen.Click += new System.EventHandler(this.bFullscreen_Click);
            // 
            // tbamspeed
            // 
            this.tbamspeed.Enabled = false;
            this.tbamspeed.Location = new System.Drawing.Point(9, 285);
            this.tbamspeed.Maximum = 50;
            this.tbamspeed.Minimum = 1;
            this.tbamspeed.Name = "tbamspeed";
            this.tbamspeed.Size = new System.Drawing.Size(206, 45);
            this.tbamspeed.TabIndex = 20;
            this.tbamspeed.TickFrequency = 3;
            this.tbamspeed.Value = 1;
            this.tbamspeed.Scroll += new System.EventHandler(this.tbamspeed_Scroll);
            // 
            // lAutomodeSpeed
            // 
            this.lAutomodeSpeed.AutoSize = true;
            this.lAutomodeSpeed.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAutomodeSpeed.Location = new System.Drawing.Point(6, 265);
            this.lAutomodeSpeed.Name = "lAutomodeSpeed";
            this.lAutomodeSpeed.Size = new System.Drawing.Size(160, 18);
            this.lAutomodeSpeed.TabIndex = 18;
            this.lAutomodeSpeed.Text = "Memes per second (m/s):";
            // 
            // lspeed
            // 
            this.lspeed.AutoSize = true;
            this.lspeed.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lspeed.Location = new System.Drawing.Point(172, 266);
            this.lspeed.Name = "lspeed";
            this.lspeed.Size = new System.Drawing.Size(15, 16);
            this.lspeed.TabIndex = 19;
            this.lspeed.Text = "3";
            // 
            // panelmodes
            // 
            this.panelmodes.Controls.Add(this.bsize);
            this.panelmodes.Controls.Add(this.bBonfireMode);
            this.panelmodes.Controls.Add(this.lMayCrash);
            this.panelmodes.Controls.Add(this.lModes);
            this.panelmodes.Controls.Add(this.bFullscreen);
            this.panelmodes.Controls.Add(this.tbamspeed);
            this.panelmodes.Controls.Add(this.bAutoMode);
            this.panelmodes.Controls.Add(this.lspeed);
            this.panelmodes.Controls.Add(this.lAutomodeSpeed);
            this.panelmodes.Controls.Add(this.GenerateMeme);
            this.panelmodes.Location = new System.Drawing.Point(12, 145);
            this.panelmodes.Name = "panelmodes";
            this.panelmodes.Size = new System.Drawing.Size(250, 378);
            this.panelmodes.TabIndex = 21;
            this.panelmodes.Visible = false;
            // 
            // bsize
            // 
            this.bsize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bsize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bsize.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsize.Image = ((System.Drawing.Image)(resources.GetObject("bsize.Image")));
            this.bsize.Location = new System.Drawing.Point(7, 333);
            this.bsize.Name = "bsize";
            this.bsize.Size = new System.Drawing.Size(206, 26);
            this.bsize.TabIndex = 23;
            this.bsize.Text = "auto size";
            this.bsize.UseVisualStyleBackColor = false;
            this.bsize.Click += new System.EventHandler(this.bsize_Click);
            // 
            // bBonfireMode
            // 
            this.bBonfireMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bBonfireMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBonfireMode.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBonfireMode.Image = ((System.Drawing.Image)(resources.GetObject("bBonfireMode.Image")));
            this.bBonfireMode.Location = new System.Drawing.Point(9, 44);
            this.bBonfireMode.Name = "bBonfireMode";
            this.bBonfireMode.Size = new System.Drawing.Size(205, 50);
            this.bBonfireMode.TabIndex = 22;
            this.bBonfireMode.Text = "Bonfire Mode OFF";
            this.bBonfireMode.UseVisualStyleBackColor = false;
            this.bBonfireMode.Click += new System.EventHandler(this.bBonfireMode_Click);
            // 
            // lMayCrash
            // 
            this.lMayCrash.AutoSize = true;
            this.lMayCrash.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMayCrash.Location = new System.Drawing.Point(7, 316);
            this.lMayCrash.Name = "lMayCrash";
            this.lMayCrash.Size = new System.Drawing.Size(94, 14);
            this.lMayCrash.TabIndex = 21;
            this.lMayCrash.Text = "*it may crash lol";
            this.lMayCrash.Visible = false;
            // 
            // panelinput
            // 
            this.panelinput.Controls.Add(this.lFileNumber);
            this.panelinput.Controls.Add(this.lFilesNumb);
            this.panelinput.Controls.Add(this.lFolder);
            this.panelinput.Controls.Add(this.bBrowse);
            this.panelinput.Controls.Add(this.textBoxFolder);
            this.panelinput.Location = new System.Drawing.Point(12, 16);
            this.panelinput.Name = "panelinput";
            this.panelinput.Size = new System.Drawing.Size(250, 123);
            this.panelinput.TabIndex = 22;
            // 
            // timerBonfiremode
            // 
            this.timerBonfiremode.Tick += new System.EventHandler(this.timerBonfiremode_Tick);
            // 
            // RandomMemes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(980, 535);
            this.Controls.Add(this.panelinput);
            this.Controls.Add(this.panelmodes);
            this.Controls.Add(this.lmNumber);
            this.Controls.Add(this.lMemeNumber);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RandomMemes";
            this.Text = "Ah...Memes v4.20";
            this.Load += new System.EventHandler(this.RandomMemes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbamspeed)).EndInit();
            this.panelmodes.ResumeLayout(false);
            this.panelmodes.PerformLayout();
            this.panelinput.ResumeLayout(false);
            this.panelinput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateMeme;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lMemeNumber;
        private System.Windows.Forms.Label lFileNumber;
        private System.Windows.Forms.FolderBrowserDialog folderbd1;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Label lFolder;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.Button bAutoMode;
        private System.Windows.Forms.Timer timerAutomode;
        private System.Windows.Forms.Label lModes;
        private System.Windows.Forms.Label lmNumber;
        private System.Windows.Forms.Label lFilesNumb;
        private System.Windows.Forms.Button bFullscreen;
        private System.Windows.Forms.TrackBar tbamspeed;
        private System.Windows.Forms.Label lAutomodeSpeed;
        private System.Windows.Forms.Label lspeed;
        private System.Windows.Forms.Panel panelmodes;
        private System.Windows.Forms.Panel panelinput;
        private System.Windows.Forms.Label lMayCrash;
        private System.Windows.Forms.Button bBonfireMode;
        private System.Windows.Forms.Timer timerBonfiremode;
        private System.Windows.Forms.Button bsize;
    }
}

