namespace MoviesApp
{
    partial class Main
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
            this.lbl_appName = new System.Windows.Forms.Label();
            this.lbl_searchMovie = new System.Windows.Forms.Label();
            this.txtBox_searchMovie = new System.Windows.Forms.TextBox();
            this.btn_searchMovie = new System.Windows.Forms.Button();
            this.lbl_released = new System.Windows.Forms.Label();
            this.lbl_genre = new System.Windows.Forms.Label();
            this.lbl_director = new System.Windows.Forms.Label();
            this.lbl_writer = new System.Windows.Forms.Label();
            this.lbl_actors = new System.Windows.Forms.Label();
            this.lbl_website = new System.Windows.Forms.Label();
            this.lbl_directorMovie = new System.Windows.Forms.Label();
            this.lbl_genreMovie = new System.Windows.Forms.Label();
            this.lbl_releasedMovie = new System.Windows.Forms.Label();
            this.lbl_yearMovie = new System.Windows.Forms.Label();
            this.lbl_titleMovie = new System.Windows.Forms.Label();
            this.lbl_websiteMovie = new System.Windows.Forms.LinkLabel();
            this.lbl_plotMovie = new System.Windows.Forms.RichTextBox();
            this.picBox_posterMovie = new System.Windows.Forms.PictureBox();
            this.lbl_actorsMovie = new System.Windows.Forms.RichTextBox();
            this.btn_saveMovieToFile = new System.Windows.Forms.Panel();
            this.panel_dark1 = new System.Windows.Forms.Panel();
            this.lbl_exitApp = new System.Windows.Forms.Label();
            this.btn_trailer = new System.Windows.Forms.Button();
            this.lbl_runtimeMovie = new System.Windows.Forms.Label();
            this.lbl_writerMovie = new System.Windows.Forms.RichTextBox();
            this.lbl_production = new System.Windows.Forms.Label();
            this.lbl_productionMovie = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_dark2 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_clearSearch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_posterMovie)).BeginInit();
            this.btn_saveMovieToFile.SuspendLayout();
            this.panel_dark1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_appName
            // 
            this.lbl_appName.AutoSize = true;
            this.lbl_appName.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_appName.ForeColor = System.Drawing.Color.Gold;
            this.lbl_appName.Location = new System.Drawing.Point(136, 36);
            this.lbl_appName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_appName.Name = "lbl_appName";
            this.lbl_appName.Size = new System.Drawing.Size(219, 50);
            this.lbl_appName.TabIndex = 0;
            this.lbl_appName.Text = "MoviesApp";
            // 
            // lbl_searchMovie
            // 
            this.lbl_searchMovie.AutoSize = true;
            this.lbl_searchMovie.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_searchMovie.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_searchMovie.Location = new System.Drawing.Point(4, 5);
            this.lbl_searchMovie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_searchMovie.Name = "lbl_searchMovie";
            this.lbl_searchMovie.Size = new System.Drawing.Size(101, 37);
            this.lbl_searchMovie.TabIndex = 1;
            this.lbl_searchMovie.Text = "Search:";
            // 
            // txtBox_searchMovie
            // 
            this.txtBox_searchMovie.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBox_searchMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_searchMovie.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBox_searchMovie.Location = new System.Drawing.Point(112, 11);
            this.txtBox_searchMovie.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_searchMovie.Name = "txtBox_searchMovie";
            this.txtBox_searchMovie.Size = new System.Drawing.Size(349, 29);
            this.txtBox_searchMovie.TabIndex = 2;
            // 
            // btn_searchMovie
            // 
            this.btn_searchMovie.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_searchMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_searchMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_searchMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_searchMovie.Location = new System.Drawing.Point(260, 48);
            this.btn_searchMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btn_searchMovie.Name = "btn_searchMovie";
            this.btn_searchMovie.Size = new System.Drawing.Size(95, 31);
            this.btn_searchMovie.TabIndex = 3;
            this.btn_searchMovie.Text = "Enter";
            this.btn_searchMovie.UseVisualStyleBackColor = false;
            this.btn_searchMovie.Click += new System.EventHandler(this.btn_searchMovie_Click);
            // 
            // lbl_released
            // 
            this.lbl_released.AutoSize = true;
            this.lbl_released.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_released.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_released.Location = new System.Drawing.Point(14, 626);
            this.lbl_released.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_released.Name = "lbl_released";
            this.lbl_released.Size = new System.Drawing.Size(114, 32);
            this.lbl_released.TabIndex = 6;
            this.lbl_released.Text = "Released:";
            // 
            // lbl_genre
            // 
            this.lbl_genre.AutoSize = true;
            this.lbl_genre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_genre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_genre.Location = new System.Drawing.Point(13, 532);
            this.lbl_genre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_genre.Name = "lbl_genre";
            this.lbl_genre.Size = new System.Drawing.Size(84, 32);
            this.lbl_genre.TabIndex = 7;
            this.lbl_genre.Text = "Genre:";
            // 
            // lbl_director
            // 
            this.lbl_director.AutoSize = true;
            this.lbl_director.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_director.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_director.Location = new System.Drawing.Point(13, 400);
            this.lbl_director.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_director.Name = "lbl_director";
            this.lbl_director.Size = new System.Drawing.Size(105, 32);
            this.lbl_director.TabIndex = 8;
            this.lbl_director.Text = "Director:";
            // 
            // lbl_writer
            // 
            this.lbl_writer.AutoSize = true;
            this.lbl_writer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_writer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_writer.Location = new System.Drawing.Point(14, 449);
            this.lbl_writer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_writer.Name = "lbl_writer";
            this.lbl_writer.Size = new System.Drawing.Size(85, 32);
            this.lbl_writer.TabIndex = 9;
            this.lbl_writer.Text = "Writer:";
            // 
            // lbl_actors
            // 
            this.lbl_actors.AutoSize = true;
            this.lbl_actors.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_actors.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_actors.Location = new System.Drawing.Point(13, 339);
            this.lbl_actors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_actors.Name = "lbl_actors";
            this.lbl_actors.Size = new System.Drawing.Size(86, 32);
            this.lbl_actors.TabIndex = 10;
            this.lbl_actors.Text = "Actors:";
            // 
            // lbl_website
            // 
            this.lbl_website.AutoSize = true;
            this.lbl_website.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_website.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_website.Location = new System.Drawing.Point(14, 670);
            this.lbl_website.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_website.Name = "lbl_website";
            this.lbl_website.Size = new System.Drawing.Size(105, 32);
            this.lbl_website.TabIndex = 13;
            this.lbl_website.Text = "Website:";
            // 
            // lbl_directorMovie
            // 
            this.lbl_directorMovie.AutoSize = true;
            this.lbl_directorMovie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_directorMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_directorMovie.Location = new System.Drawing.Point(176, 402);
            this.lbl_directorMovie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_directorMovie.Name = "lbl_directorMovie";
            this.lbl_directorMovie.Size = new System.Drawing.Size(81, 28);
            this.lbl_directorMovie.TabIndex = 18;
            this.lbl_directorMovie.Text = "director";
            // 
            // lbl_genreMovie
            // 
            this.lbl_genreMovie.AutoSize = true;
            this.lbl_genreMovie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_genreMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_genreMovie.Location = new System.Drawing.Point(176, 534);
            this.lbl_genreMovie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_genreMovie.Name = "lbl_genreMovie";
            this.lbl_genreMovie.Size = new System.Drawing.Size(62, 28);
            this.lbl_genreMovie.TabIndex = 17;
            this.lbl_genreMovie.Text = "genre";
            // 
            // lbl_releasedMovie
            // 
            this.lbl_releasedMovie.AutoSize = true;
            this.lbl_releasedMovie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_releasedMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_releasedMovie.Location = new System.Drawing.Point(176, 628);
            this.lbl_releasedMovie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_releasedMovie.Name = "lbl_releasedMovie";
            this.lbl_releasedMovie.Size = new System.Drawing.Size(84, 28);
            this.lbl_releasedMovie.TabIndex = 16;
            this.lbl_releasedMovie.Text = "released";
            // 
            // lbl_yearMovie
            // 
            this.lbl_yearMovie.AutoSize = true;
            this.lbl_yearMovie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_yearMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_yearMovie.Location = new System.Drawing.Point(15, 128);
            this.lbl_yearMovie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_yearMovie.Name = "lbl_yearMovie";
            this.lbl_yearMovie.Size = new System.Drawing.Size(49, 28);
            this.lbl_yearMovie.TabIndex = 15;
            this.lbl_yearMovie.Text = "year";
            // 
            // lbl_titleMovie
            // 
            this.lbl_titleMovie.AutoSize = true;
            this.lbl_titleMovie.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_titleMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_titleMovie.Location = new System.Drawing.Point(12, 76);
            this.lbl_titleMovie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titleMovie.Name = "lbl_titleMovie";
            this.lbl_titleMovie.Size = new System.Drawing.Size(75, 45);
            this.lbl_titleMovie.TabIndex = 14;
            this.lbl_titleMovie.Text = "title";
            // 
            // lbl_websiteMovie
            // 
            this.lbl_websiteMovie.AutoSize = true;
            this.lbl_websiteMovie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_websiteMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_websiteMovie.LinkColor = System.Drawing.Color.White;
            this.lbl_websiteMovie.Location = new System.Drawing.Point(176, 672);
            this.lbl_websiteMovie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_websiteMovie.Name = "lbl_websiteMovie";
            this.lbl_websiteMovie.Size = new System.Drawing.Size(43, 28);
            this.lbl_websiteMovie.TabIndex = 23;
            this.lbl_websiteMovie.TabStop = true;
            this.lbl_websiteMovie.Text = "link";
            this.lbl_websiteMovie.VisitedLinkColor = System.Drawing.Color.White;
            this.lbl_websiteMovie.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_websiteMovie_LinkClicked);
            // 
            // lbl_plotMovie
            // 
            this.lbl_plotMovie.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_plotMovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_plotMovie.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_plotMovie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_plotMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_plotMovie.Location = new System.Drawing.Point(20, 214);
            this.lbl_plotMovie.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_plotMovie.Name = "lbl_plotMovie";
            this.lbl_plotMovie.ReadOnly = true;
            this.lbl_plotMovie.Size = new System.Drawing.Size(791, 119);
            this.lbl_plotMovie.TabIndex = 25;
            this.lbl_plotMovie.Text = "plot";
            // 
            // picBox_posterMovie
            // 
            this.picBox_posterMovie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picBox_posterMovie.Location = new System.Drawing.Point(48, 31);
            this.picBox_posterMovie.Margin = new System.Windows.Forms.Padding(4);
            this.picBox_posterMovie.Name = "picBox_posterMovie";
            this.picBox_posterMovie.Size = new System.Drawing.Size(377, 434);
            this.picBox_posterMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_posterMovie.TabIndex = 26;
            this.picBox_posterMovie.TabStop = false;
            // 
            // lbl_actorsMovie
            // 
            this.lbl_actorsMovie.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_actorsMovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_actorsMovie.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_actorsMovie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_actorsMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_actorsMovie.Location = new System.Drawing.Point(181, 341);
            this.lbl_actorsMovie.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_actorsMovie.Name = "lbl_actorsMovie";
            this.lbl_actorsMovie.ReadOnly = true;
            this.lbl_actorsMovie.Size = new System.Drawing.Size(630, 57);
            this.lbl_actorsMovie.TabIndex = 27;
            this.lbl_actorsMovie.Text = "actors";
            // 
            // btn_saveMovieToFile
            // 
            this.btn_saveMovieToFile.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_saveMovieToFile.Controls.Add(this.panel_dark1);
            this.btn_saveMovieToFile.Controls.Add(this.btn_trailer);
            this.btn_saveMovieToFile.Controls.Add(this.lbl_runtimeMovie);
            this.btn_saveMovieToFile.Controls.Add(this.lbl_writerMovie);
            this.btn_saveMovieToFile.Controls.Add(this.lbl_production);
            this.btn_saveMovieToFile.Controls.Add(this.lbl_productionMovie);
            this.btn_saveMovieToFile.Controls.Add(this.lbl_actorsMovie);
            this.btn_saveMovieToFile.Controls.Add(this.lbl_released);
            this.btn_saveMovieToFile.Controls.Add(this.lbl_plotMovie);
            this.btn_saveMovieToFile.Controls.Add(this.lbl_genre);
            this.btn_saveMovieToFile.Controls.Add(this.lbl_websiteMovie);
            this.btn_saveMovieToFile.Controls.Add(this.lbl_director);
            this.btn_saveMovieToFile.Controls.Add(this.lbl_writer);
            this.btn_saveMovieToFile.Controls.Add(this.lbl_directorMovie);
            this.btn_saveMovieToFile.Controls.Add(this.lbl_actors);
            this.btn_saveMovieToFile.Controls.Add(this.lbl_genreMovie);
            this.btn_saveMovieToFile.Controls.Add(this.lbl_releasedMovie);
            this.btn_saveMovieToFile.Controls.Add(this.lbl_website);
            this.btn_saveMovieToFile.Controls.Add(this.lbl_yearMovie);
            this.btn_saveMovieToFile.Controls.Add(this.lbl_titleMovie);
            this.btn_saveMovieToFile.Location = new System.Drawing.Point(490, 0);
            this.btn_saveMovieToFile.Margin = new System.Windows.Forms.Padding(4);
            this.btn_saveMovieToFile.Name = "btn_saveMovieToFile";
            this.btn_saveMovieToFile.Size = new System.Drawing.Size(878, 727);
            this.btn_saveMovieToFile.TabIndex = 28;
            // 
            // panel_dark1
            // 
            this.panel_dark1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_dark1.Controls.Add(this.lbl_exitApp);
            this.panel_dark1.Location = new System.Drawing.Point(831, 0);
            this.panel_dark1.Name = "panel_dark1";
            this.panel_dark1.Size = new System.Drawing.Size(44, 727);
            this.panel_dark1.TabIndex = 36;
            // 
            // lbl_exitApp
            // 
            this.lbl_exitApp.AutoSize = true;
            this.lbl_exitApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_exitApp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_exitApp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_exitApp.Location = new System.Drawing.Point(2, 3);
            this.lbl_exitApp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_exitApp.Name = "lbl_exitApp";
            this.lbl_exitApp.Size = new System.Drawing.Size(38, 41);
            this.lbl_exitApp.TabIndex = 32;
            this.lbl_exitApp.Text = "X";
            this.lbl_exitApp.Click += new System.EventHandler(this.lbl_exitApp_Click);
            // 
            // btn_trailer
            // 
            this.btn_trailer.BackColor = System.Drawing.Color.Gold;
            this.btn_trailer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_trailer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trailer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_trailer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_trailer.Location = new System.Drawing.Point(20, 13);
            this.btn_trailer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_trailer.Name = "btn_trailer";
            this.btn_trailer.Size = new System.Drawing.Size(152, 31);
            this.btn_trailer.TabIndex = 35;
            this.btn_trailer.Text = "See trailer";
            this.btn_trailer.UseVisualStyleBackColor = false;
            this.btn_trailer.Click += new System.EventHandler(this.btn_trailer_Click);
            // 
            // lbl_runtimeMovie
            // 
            this.lbl_runtimeMovie.AutoSize = true;
            this.lbl_runtimeMovie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_runtimeMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_runtimeMovie.Location = new System.Drawing.Point(15, 170);
            this.lbl_runtimeMovie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_runtimeMovie.Name = "lbl_runtimeMovie";
            this.lbl_runtimeMovie.Size = new System.Drawing.Size(80, 28);
            this.lbl_runtimeMovie.TabIndex = 34;
            this.lbl_runtimeMovie.Text = "runtime";
            // 
            // lbl_writerMovie
            // 
            this.lbl_writerMovie.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_writerMovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_writerMovie.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_writerMovie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_writerMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_writerMovie.Location = new System.Drawing.Point(181, 451);
            this.lbl_writerMovie.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_writerMovie.Name = "lbl_writerMovie";
            this.lbl_writerMovie.ReadOnly = true;
            this.lbl_writerMovie.Size = new System.Drawing.Size(630, 77);
            this.lbl_writerMovie.TabIndex = 33;
            this.lbl_writerMovie.Text = "writer";
            // 
            // lbl_production
            // 
            this.lbl_production.AutoSize = true;
            this.lbl_production.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_production.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_production.Location = new System.Drawing.Point(14, 579);
            this.lbl_production.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_production.Name = "lbl_production";
            this.lbl_production.Size = new System.Drawing.Size(136, 32);
            this.lbl_production.TabIndex = 29;
            this.lbl_production.Text = "Production:";
            // 
            // lbl_productionMovie
            // 
            this.lbl_productionMovie.AutoSize = true;
            this.lbl_productionMovie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_productionMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_productionMovie.Location = new System.Drawing.Point(176, 581);
            this.lbl_productionMovie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_productionMovie.Name = "lbl_productionMovie";
            this.lbl_productionMovie.Size = new System.Drawing.Size(110, 28);
            this.lbl_productionMovie.TabIndex = 31;
            this.lbl_productionMovie.Text = "production";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lbl_appName);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(13, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 121);
            this.panel1.TabIndex = 29;
            // 
            // panel_dark2
            // 
            this.panel_dark2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_dark2.Location = new System.Drawing.Point(481, 0);
            this.panel_dark2.Name = "panel_dark2";
            this.panel_dark2.Size = new System.Drawing.Size(21, 724);
            this.panel_dark2.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.btn_clearSearch);
            this.panel2.Controls.Add(this.lbl_searchMovie);
            this.panel2.Controls.Add(this.txtBox_searchMovie);
            this.panel2.Controls.Add(this.btn_searchMovie);
            this.panel2.Location = new System.Drawing.Point(13, 121);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 99);
            this.panel2.TabIndex = 30;
            // 
            // btn_clearSearch
            // 
            this.btn_clearSearch.BackColor = System.Drawing.Color.LightCoral;
            this.btn_clearSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_clearSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_clearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_clearSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_clearSearch.Location = new System.Drawing.Point(366, 48);
            this.btn_clearSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clearSearch.Name = "btn_clearSearch";
            this.btn_clearSearch.Size = new System.Drawing.Size(95, 31);
            this.btn_clearSearch.TabIndex = 4;
            this.btn_clearSearch.Text = "Clear";
            this.btn_clearSearch.UseVisualStyleBackColor = false;
            this.btn_clearSearch.Click += new System.EventHandler(this.btn_clearSearch_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.picBox_posterMovie);
            this.panel3.Location = new System.Drawing.Point(13, 218);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 509);
            this.panel3.TabIndex = 31;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1364, 725);
            this.ControlBox = false;
            this.Controls.Add(this.panel_dark2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_saveMovieToFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picBox_posterMovie)).EndInit();
            this.btn_saveMovieToFile.ResumeLayout(false);
            this.btn_saveMovieToFile.PerformLayout();
            this.panel_dark1.ResumeLayout(false);
            this.panel_dark1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_appName;
        private System.Windows.Forms.Label lbl_searchMovie;
        private System.Windows.Forms.TextBox txtBox_searchMovie;
        private System.Windows.Forms.Button btn_searchMovie;
        private System.Windows.Forms.Label lbl_released;
        private System.Windows.Forms.Label lbl_genre;
        private System.Windows.Forms.Label lbl_director;
        private System.Windows.Forms.Label lbl_writer;
        private System.Windows.Forms.Label lbl_actors;
        private System.Windows.Forms.Label lbl_website;
        private System.Windows.Forms.Label lbl_directorMovie;
        private System.Windows.Forms.Label lbl_genreMovie;
        private System.Windows.Forms.Label lbl_releasedMovie;
        private System.Windows.Forms.Label lbl_yearMovie;
        private System.Windows.Forms.Label lbl_titleMovie;
        private System.Windows.Forms.LinkLabel lbl_websiteMovie;
        private System.Windows.Forms.RichTextBox lbl_plotMovie;
        private System.Windows.Forms.PictureBox picBox_posterMovie;
        private System.Windows.Forms.RichTextBox lbl_actorsMovie;
        private System.Windows.Forms.Panel btn_saveMovieToFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_production;
        private System.Windows.Forms.Label lbl_productionMovie;
        private System.Windows.Forms.Button btn_clearSearch;
        private System.Windows.Forms.Label lbl_exitApp;
        private System.Windows.Forms.RichTextBox lbl_writerMovie;
        private System.Windows.Forms.Label lbl_runtimeMovie;
        private System.Windows.Forms.Button btn_trailer;
        private System.Windows.Forms.Panel panel_dark1;
        private System.Windows.Forms.Panel panel_dark2;
    }
}

