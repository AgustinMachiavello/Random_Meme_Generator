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
            this.lInput = new System.Windows.Forms.Label();
            this.lOutput = new System.Windows.Forms.Label();
            this.lMemeNumber = new System.Windows.Forms.Label();
            this.lFileNumber = new System.Windows.Forms.Label();
            this.folderbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.lFolder = new System.Windows.Forms.Label();
            this.bBrowse = new System.Windows.Forms.Button();
            this.bAutoMode = new System.Windows.Forms.Button();
            this.timerAutomode = new System.Windows.Forms.Timer(this.components);
            this.lModes = new System.Windows.Forms.Label();
            this.lClickme = new System.Windows.Forms.Label();
            this.lmNumber = new System.Windows.Forms.Label();
            this.lFilesNumb = new System.Windows.Forms.Label();
            this.bFullscreen = new System.Windows.Forms.Button();
            this.tbamspeed = new System.Windows.Forms.TrackBar();
            this.lAutomodeSpeed = new System.Windows.Forms.Label();
            this.lspeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbamspeed)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateMeme
            // 
            this.GenerateMeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.GenerateMeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateMeme.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateMeme.Image = ((System.Drawing.Image)(resources.GetObject("GenerateMeme.Image")));
            this.GenerateMeme.Location = new System.Drawing.Point(17, 334);
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
            // lInput
            // 
            this.lInput.AutoSize = true;
            this.lInput.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInput.Location = new System.Drawing.Point(7, 7);
            this.lInput.Name = "lInput";
            this.lInput.Size = new System.Drawing.Size(74, 30);
            this.lInput.TabIndex = 2;
            this.lInput.Text = "Input:";
            // 
            // lOutput
            // 
            this.lOutput.AutoSize = true;
            this.lOutput.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOutput.Location = new System.Drawing.Point(298, 8);
            this.lOutput.Name = "lOutput";
            this.lOutput.Size = new System.Drawing.Size(83, 30);
            this.lOutput.TabIndex = 3;
            this.lOutput.Text = "Output:";
            // 
            // lMemeNumber
            // 
            this.lMemeNumber.AutoSize = true;
            this.lMemeNumber.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMemeNumber.Location = new System.Drawing.Point(12, 37);
            this.lMemeNumber.Name = "lMemeNumber";
            this.lMemeNumber.Size = new System.Drawing.Size(101, 23);
            this.lMemeNumber.TabIndex = 4;
            this.lMemeNumber.Text = "Meme number:";
            // 
            // lFileNumber
            // 
            this.lFileNumber.AutoSize = true;
            this.lFileNumber.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFileNumber.Location = new System.Drawing.Point(12, 60);
            this.lFileNumber.Name = "lFileNumber";
            this.lFileNumber.Size = new System.Drawing.Size(42, 23);
            this.lFileNumber.TabIndex = 5;
            this.lFileNumber.Text = "Files:";
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFolder.Location = new System.Drawing.Point(16, 109);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(281, 20);
            this.textBoxFolder.TabIndex = 7;
            this.textBoxFolder.Text = "NO FOLDER SELECTED. B-BAKA! (OwO)";
            // 
            // lFolder
            // 
            this.lFolder.AutoSize = true;
            this.lFolder.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFolder.Location = new System.Drawing.Point(12, 83);
            this.lFolder.Name = "lFolder";
            this.lFolder.Size = new System.Drawing.Size(82, 23);
            this.lFolder.TabIndex = 8;
            this.lFolder.Text = "Le Folder:";
            // 
            // bBrowse
            // 
            this.bBrowse.BackColor = System.Drawing.Color.Plum;
            this.bBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBrowse.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBrowse.Location = new System.Drawing.Point(16, 135);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(281, 38);
            this.bBrowse.TabIndex = 9;
            this.bBrowse.Text = "SELECT MEME SOURCE !!!11";
            this.bBrowse.UseVisualStyleBackColor = false;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // bAutoMode
            // 
            this.bAutoMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bAutoMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAutoMode.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAutoMode.Image = ((System.Drawing.Image)(resources.GetObject("bAutoMode.Image")));
            this.bAutoMode.Location = new System.Drawing.Point(16, 209);
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
            this.lModes.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lModes.Location = new System.Drawing.Point(12, 176);
            this.lModes.Name = "lModes";
            this.lModes.Size = new System.Drawing.Size(76, 30);
            this.lModes.TabIndex = 12;
            this.lModes.Text = "Mode:";
            // 
            // lClickme
            // 
            this.lClickme.AutoSize = true;
            this.lClickme.Font = new System.Drawing.Font("Tw Cen MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClickme.Location = new System.Drawing.Point(80, 175);
            this.lClickme.Name = "lClickme";
            this.lClickme.Size = new System.Drawing.Size(142, 28);
            this.lClickme.TabIndex = 13;
            this.lClickme.Text = "(Click me <3)";
            this.lClickme.Visible = false;
            // 
            // lmNumber
            // 
            this.lmNumber.AutoSize = true;
            this.lmNumber.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmNumber.Location = new System.Drawing.Point(119, 35);
            this.lmNumber.Name = "lmNumber";
            this.lmNumber.Size = new System.Drawing.Size(24, 30);
            this.lmNumber.TabIndex = 14;
            this.lmNumber.Text = "0";
            // 
            // lFilesNumb
            // 
            this.lFilesNumb.AutoSize = true;
            this.lFilesNumb.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFilesNumb.Location = new System.Drawing.Point(57, 58);
            this.lFilesNumb.Name = "lFilesNumb";
            this.lFilesNumb.Size = new System.Drawing.Size(24, 30);
            this.lFilesNumb.TabIndex = 15;
            this.lFilesNumb.Text = "0";
            // 
            // bFullscreen
            // 
            this.bFullscreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFullscreen.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFullscreen.Image = ((System.Drawing.Image)(resources.GetObject("bFullscreen.Image")));
            this.bFullscreen.Location = new System.Drawing.Point(17, 390);
            this.bFullscreen.Name = "bFullscreen";
            this.bFullscreen.Size = new System.Drawing.Size(205, 50);
            this.bFullscreen.TabIndex = 16;
            this.bFullscreen.Text = "IMMERSION (OFF)";
            this.bFullscreen.UseVisualStyleBackColor = false;
            this.bFullscreen.Click += new System.EventHandler(this.bFullscreen_Click);
            // 
            // tbamspeed
            // 
            this.tbamspeed.Location = new System.Drawing.Point(12, 283);
            this.tbamspeed.Maximum = 30;
            this.tbamspeed.Minimum = 1;
            this.tbamspeed.Name = "tbamspeed";
            this.tbamspeed.Size = new System.Drawing.Size(210, 45);
            this.tbamspeed.TabIndex = 17;
            this.tbamspeed.TickFrequency = 3;
            this.tbamspeed.Value = 1;
            this.tbamspeed.Scroll += new System.EventHandler(this.tbamspeed_Scroll);
            // 
            // lAutomodeSpeed
            // 
            this.lAutomodeSpeed.AutoSize = true;
            this.lAutomodeSpeed.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAutomodeSpeed.Location = new System.Drawing.Point(14, 262);
            this.lAutomodeSpeed.Name = "lAutomodeSpeed";
            this.lAutomodeSpeed.Size = new System.Drawing.Size(139, 18);
            this.lAutomodeSpeed.TabIndex = 18;
            this.lAutomodeSpeed.Text = "Changing speed (ms):";
            // 
            // lspeed
            // 
            this.lspeed.AutoSize = true;
            this.lspeed.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lspeed.Location = new System.Drawing.Point(159, 264);
            this.lspeed.Name = "lspeed";
            this.lspeed.Size = new System.Drawing.Size(36, 16);
            this.lspeed.TabIndex = 19;
            this.lspeed.Text = "3000";
            // 
            // RandomMemes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(980, 535);
            this.Controls.Add(this.lspeed);
            this.Controls.Add(this.lAutomodeSpeed);
            this.Controls.Add(this.tbamspeed);
            this.Controls.Add(this.bFullscreen);
            this.Controls.Add(this.lFilesNumb);
            this.Controls.Add(this.lmNumber);
            this.Controls.Add(this.lClickme);
            this.Controls.Add(this.lModes);
            this.Controls.Add(this.bAutoMode);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.lFolder);
            this.Controls.Add(this.textBoxFolder);
            this.Controls.Add(this.lFileNumber);
            this.Controls.Add(this.lMemeNumber);
            this.Controls.Add(this.lOutput);
            this.Controls.Add(this.lInput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GenerateMeme);
            this.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RandomMemes";
            this.Text = "Ah...Memes";
            this.Load += new System.EventHandler(this.RandomMemes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbamspeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateMeme;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lInput;
        private System.Windows.Forms.Label lOutput;
        private System.Windows.Forms.Label lMemeNumber;
        private System.Windows.Forms.Label lFileNumber;
        private System.Windows.Forms.FolderBrowserDialog folderbd1;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Label lFolder;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.Button bAutoMode;
        private System.Windows.Forms.Timer timerAutomode;
        private System.Windows.Forms.Label lModes;
        private System.Windows.Forms.Label lClickme;
        private System.Windows.Forms.Label lmNumber;
        private System.Windows.Forms.Label lFilesNumb;
        private System.Windows.Forms.Button bFullscreen;
        private System.Windows.Forms.TrackBar tbamspeed;
        private System.Windows.Forms.Label lAutomodeSpeed;
        private System.Windows.Forms.Label lspeed;
    }
}

