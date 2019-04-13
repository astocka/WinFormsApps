using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MoviesApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            HideData();
            ClearData();
        }

        private void btn_searchMovie_Click(object sender, EventArgs e)
        {
            if (txtBox_searchMovie.Text != null)
            {
                var search = txtBox_searchMovie.Text.Trim();
                GetMovie(search);
            }
            else
            {
                MessageBox.Show(@"Please write movie title.");
            }
        }

        private void btn_trailer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl_titleMovie.Text))
            {
                var trailer = $"http://www.youtube.com/results?search_query=trailer+{lbl_titleMovie.Text}";
                System.Diagnostics.Process.Start(trailer);
            }
            else
            {
                MessageBox.Show(@"Please search movie first.");
            }
        }

        private void lbl_websiteMovie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lbl_websiteMovie.Text);
        }

        private void btn_clearSearch_Click(object sender, EventArgs e)
        {
            ClearData();
            HideData();
        }

        private void lbl_exitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetMovie(string search)
        {
            using (var web = new WebClient())
            {
                const string apiKey = "";
                const string imdbId = "tt3896198";
                var url = $"http://www.omdbapi.com/?i={imdbId}&apikey={apiKey}&t={search}";

                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<Movie>(json);
                var output = result;

                try
                {
                    lbl_titleMovie.Text = output.Title;
                    lbl_yearMovie.Text = output.Year;
                    lbl_runtimeMovie.Text = output.Runtime;
                    lbl_releasedMovie.Text = output.Released;
                    lbl_genreMovie.Text = output.Genre;
                    lbl_directorMovie.Text = output.Director;
                    lbl_writerMovie.Text = output.Writer;
                    lbl_actorsMovie.Text = output.Actors;
                    lbl_plotMovie.Text = output.Plot;
                    lbl_productionMovie.Text = output.Production;
                    lbl_websiteMovie.Text = output.Website;
                    picBox_posterMovie.ImageLocation = output.Poster;

                    lbl_released.Show();
                    lbl_genre.Show();
                    lbl_director.Show();
                    lbl_writer.Show();
                    lbl_actors.Show();
                    lbl_production.Show();
                    lbl_website.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Please try again or search other movie.");
                }
            }
        }

        private void ClearData()
        {
            lbl_titleMovie.Text = "";
            lbl_yearMovie.Text = "";
            lbl_runtimeMovie.Text = "";
            lbl_releasedMovie.Text = "";
            lbl_genreMovie.Text = "";
            lbl_directorMovie.Text = "";
            lbl_writerMovie.Text = "";
            lbl_actorsMovie.Text = "";
            lbl_plotMovie.Text = "";
            lbl_productionMovie.Text = "";
            lbl_websiteMovie.Text = "";
            picBox_posterMovie.ImageLocation = "";
        }

        private void HideData()
        {
            lbl_released.Hide();
            lbl_genre.Hide();
            lbl_director.Hide();
            lbl_writer.Hide();
            lbl_actors.Hide();
            lbl_production.Hide();
            lbl_website.Hide();
        }
    }
}
