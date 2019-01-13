namespace MediaPlayer
{
    partial class MediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayer));
            this.PanelControls = new System.Windows.Forms.Panel();
            this.LblCurrentSong = new System.Windows.Forms.Label();
            this.PicStop = new System.Windows.Forms.PictureBox();
            this.PicPause = new System.Windows.Forms.PictureBox();
            this.PicPlay = new System.Windows.Forms.PictureBox();
            this.PicOpen = new System.Windows.Forms.PictureBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialogImport = new System.Windows.Forms.OpenFileDialog();
            this.LblPlaylist = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LstBxPlaylist = new System.Windows.Forms.ListBox();
            this.LblMediaPlayer = new System.Windows.Forms.Label();
            this.LblExit = new System.Windows.Forms.Label();
            this.PanelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControls
            // 
            this.PanelControls.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelControls.Controls.Add(this.LblExit);
            this.PanelControls.Controls.Add(this.LblMediaPlayer);
            this.PanelControls.Controls.Add(this.LblCurrentSong);
            this.PanelControls.Controls.Add(this.trackBar);
            this.PanelControls.Controls.Add(this.PicStop);
            this.PanelControls.Controls.Add(this.PicPause);
            this.PanelControls.Controls.Add(this.PicPlay);
            this.PanelControls.Controls.Add(this.PicOpen);
            this.PanelControls.Controls.Add(this.axWindowsMediaPlayer);
            this.PanelControls.Location = new System.Drawing.Point(6, 3);
            this.PanelControls.Name = "PanelControls";
            this.PanelControls.Size = new System.Drawing.Size(281, 112);
            this.PanelControls.TabIndex = 0;
            // 
            // LblCurrentSong
            // 
            this.LblCurrentSong.AutoSize = true;
            this.LblCurrentSong.Location = new System.Drawing.Point(15, 9);
            this.LblCurrentSong.Name = "LblCurrentSong";
            this.LblCurrentSong.Size = new System.Drawing.Size(0, 13);
            this.LblCurrentSong.TabIndex = 1;
            // 
            // PicStop
            // 
            this.PicStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicStop.Image = ((System.Drawing.Image)(resources.GetObject("PicStop.Image")));
            this.PicStop.Location = new System.Drawing.Point(218, 42);
            this.PicStop.Name = "PicStop";
            this.PicStop.Size = new System.Drawing.Size(30, 30);
            this.PicStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicStop.TabIndex = 4;
            this.PicStop.TabStop = false;
            this.PicStop.Click += new System.EventHandler(this.PicStop_Click);
            // 
            // PicPause
            // 
            this.PicPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicPause.Image = ((System.Drawing.Image)(resources.GetObject("PicPause.Image")));
            this.PicPause.Location = new System.Drawing.Point(160, 42);
            this.PicPause.Name = "PicPause";
            this.PicPause.Size = new System.Drawing.Size(30, 30);
            this.PicPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPause.TabIndex = 2;
            this.PicPause.TabStop = false;
            this.PicPause.Click += new System.EventHandler(this.PicPause_Click);
            // 
            // PicPlay
            // 
            this.PicPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicPlay.Image = ((System.Drawing.Image)(resources.GetObject("PicPlay.Image")));
            this.PicPlay.Location = new System.Drawing.Point(97, 42);
            this.PicPlay.Name = "PicPlay";
            this.PicPlay.Size = new System.Drawing.Size(30, 30);
            this.PicPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPlay.TabIndex = 1;
            this.PicPlay.TabStop = false;
            this.PicPlay.Click += new System.EventHandler(this.PicPlay_Click);
            // 
            // PicOpen
            // 
            this.PicOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicOpen.Image = ((System.Drawing.Image)(resources.GetObject("PicOpen.Image")));
            this.PicOpen.Location = new System.Drawing.Point(36, 42);
            this.PicOpen.Name = "PicOpen";
            this.PicOpen.Size = new System.Drawing.Size(30, 30);
            this.PicOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicOpen.TabIndex = 0;
            this.PicOpen.TabStop = false;
            this.PicOpen.Click += new System.EventHandler(this.PicOpen_Click);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(58, 79);
            this.trackBar.Maximum = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(169, 45);
            this.trackBar.TabIndex = 2;
            this.trackBar.Value = 40;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(239, 89);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(36, 20);
            this.axWindowsMediaPlayer.TabIndex = 5;
            this.axWindowsMediaPlayer.Visible = false;
            // 
            // openFileDialogImport
            // 
            this.openFileDialogImport.FileName = "openFileDialog1";
            // 
            // LblPlaylist
            // 
            this.LblPlaylist.AutoSize = true;
            this.LblPlaylist.Font = new System.Drawing.Font("MicraC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPlaylist.Location = new System.Drawing.Point(9, 9);
            this.LblPlaylist.Name = "LblPlaylist";
            this.LblPlaylist.Size = new System.Drawing.Size(77, 12);
            this.LblPlaylist.TabIndex = 7;
            this.LblPlaylist.Text = "Playlist";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.LstBxPlaylist);
            this.panel1.Controls.Add(this.LblPlaylist);
            this.panel1.Location = new System.Drawing.Point(6, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 334);
            this.panel1.TabIndex = 8;
            // 
            // LstBxPlaylist
            // 
            this.LstBxPlaylist.Font = new System.Drawing.Font("Micra", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LstBxPlaylist.FormattingEnabled = true;
            this.LstBxPlaylist.ItemHeight = 11;
            this.LstBxPlaylist.Location = new System.Drawing.Point(10, 27);
            this.LstBxPlaylist.Name = "LstBxPlaylist";
            this.LstBxPlaylist.Size = new System.Drawing.Size(262, 290);
            this.LstBxPlaylist.TabIndex = 0;
            this.LstBxPlaylist.SelectedIndexChanged += new System.EventHandler(this.LstBxPlaylist_SelectedIndexChanged);
            // 
            // LblMediaPlayer
            // 
            this.LblMediaPlayer.AutoSize = true;
            this.LblMediaPlayer.Font = new System.Drawing.Font("MicraC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMediaPlayer.Location = new System.Drawing.Point(58, 9);
            this.LblMediaPlayer.Name = "LblMediaPlayer";
            this.LblMediaPlayer.Size = new System.Drawing.Size(168, 16);
            this.LblMediaPlayer.TabIndex = 8;
            this.LblMediaPlayer.Text = "Media Player";
            // 
            // LblExit
            // 
            this.LblExit.AutoSize = true;
            this.LblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblExit.Font = new System.Drawing.Font("Micra", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExit.Location = new System.Drawing.Point(258, 7);
            this.LblExit.Name = "LblExit";
            this.LblExit.Size = new System.Drawing.Size(17, 12);
            this.LblExit.TabIndex = 10;
            this.LblExit.Text = "X";
            this.LblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(293, 460);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelControls);
            this.Name = "MediaPlayer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelControls.ResumeLayout(false);
            this.PanelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelControls;
        private System.Windows.Forms.TrackBar trackBar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.PictureBox PicStop;
        private System.Windows.Forms.PictureBox PicPause;
        private System.Windows.Forms.PictureBox PicPlay;
        private System.Windows.Forms.PictureBox PicOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialogImport;
        private System.Windows.Forms.Label LblPlaylist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox LstBxPlaylist;
        private System.Windows.Forms.Label LblCurrentSong;
        private System.Windows.Forms.Label LblExit;
        private System.Windows.Forms.Label LblMediaPlayer;
    }
}

