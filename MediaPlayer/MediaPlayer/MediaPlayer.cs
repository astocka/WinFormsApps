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
using WMPLib;


namespace MediaPlayer
{
    public partial class MediaPlayer : Form
    {
        public MediaPlayer()
        {
            InitializeComponent();
        }

        private void PicOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "MP3|*.mp3|WMV|*.wmv|WAV|*.wav" })
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<MusicFile> files = new List<MusicFile>();

                    foreach (var fileName in fileDialog.FileNames)
                    {
                        FileInfo fileInfo = new FileInfo(fileName);
                        files.Add(new MusicFile() { FileName = Path.GetFileNameWithoutExtension(fileInfo.FullName), Path = fileInfo.FullName });
                    }

                    LstBxPlaylist.DataSource = files;
                    LstBxPlaylist.ValueMember = "Path";
                    LstBxPlaylist.DisplayMember = "FileName";

                    LstBxPlaylist.HorizontalScrollbar = true;
                }
            }
        }

        private void PicPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.play();
        }

        private void PicPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.pause();
        }

        private void PicStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.stop();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.settings.volume = trackBar.Value;
        }

        private void LstBxPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstBxPlaylist.SelectedItem is MusicFile file)
            {
                axWindowsMediaPlayer.URL = file.Path;
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
