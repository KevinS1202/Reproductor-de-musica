namespace Курсовая
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.lstCanciones = new System.Windows.Forms.ListBox();
            this.btnAdjuntar = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mtrackVolumen = new XComponent.SliderBar.MACTrackBar();
            this.mtrackStatus = new XComponent.SliderBar.MACTrackBar();
            this.lbCancion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgvPlaylist = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(49, 457);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(37, 31);
            this.Reproductor.TabIndex = 0;
            this.Reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Reproductor_PlayStateChange);
            // 
            // lstCanciones
            // 
            this.lstCanciones.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstCanciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCanciones.FormattingEnabled = true;
            this.lstCanciones.Location = new System.Drawing.Point(17, 163);
            this.lstCanciones.Name = "lstCanciones";
            this.lstCanciones.Size = new System.Drawing.Size(377, 247);
            this.lstCanciones.TabIndex = 1;
            this.lstCanciones.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstCanciones_MouseClick);
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdjuntar.Image")));
            this.btnAdjuntar.Location = new System.Drawing.Point(384, 12);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(62, 62);
            this.btnAdjuntar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAdjuntar.TabIndex = 2;
            this.btnAdjuntar.TabStop = false;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = global::Курсовая.Properties.Resources.detener___copia;
            this.btnStop.Image = global::Курсовая.Properties.Resources.detener___copia;
            this.btnStop.Location = new System.Drawing.Point(127, 27);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(62, 62);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnStop.TabIndex = 5;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(633, 27);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(62, 62);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnPlay.TabIndex = 6;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(371, 95);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // mtrackVolumen
            // 
            this.mtrackVolumen.BackColor = System.Drawing.Color.Transparent;
            this.mtrackVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtrackVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtrackVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtrackVolumen.IndentHeight = 6;
            this.mtrackVolumen.Location = new System.Drawing.Point(413, 95);
            this.mtrackVolumen.Maximum = 100;
            this.mtrackVolumen.Minimum = 0;
            this.mtrackVolumen.Name = "mtrackVolumen";
            this.mtrackVolumen.Size = new System.Drawing.Size(97, 33);
            this.mtrackVolumen.TabIndex = 9;
            this.mtrackVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackVolumen.TickColor = System.Drawing.Color.Transparent;
            this.mtrackVolumen.TickHeight = 4;
            this.mtrackVolumen.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.mtrackVolumen.TrackerSize = new System.Drawing.Size(16, 16);
            this.mtrackVolumen.TrackLineColor = System.Drawing.Color.Black;
            this.mtrackVolumen.TrackLineHeight = 3;
            this.mtrackVolumen.TrackLineSelectedColor = System.Drawing.Color.Black;
            this.mtrackVolumen.Value = 0;
            this.mtrackVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.mtrackVolumen_ValueChanged);
            // 
            // mtrackStatus
            // 
            this.mtrackStatus.BackColor = System.Drawing.Color.Transparent;
            this.mtrackStatus.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtrackStatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtrackStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtrackStatus.IndentHeight = 6;
            this.mtrackStatus.Location = new System.Drawing.Point(17, 120);
            this.mtrackStatus.Maximum = 10;
            this.mtrackStatus.Minimum = 0;
            this.mtrackStatus.Name = "mtrackStatus";
            this.mtrackStatus.Size = new System.Drawing.Size(377, 37);
            this.mtrackStatus.TabIndex = 10;
            this.mtrackStatus.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackStatus.TickColor = System.Drawing.Color.Transparent;
            this.mtrackStatus.TickHeight = 4;
            this.mtrackStatus.TrackerColor = System.Drawing.Color.Blue;
            this.mtrackStatus.TrackerSize = new System.Drawing.Size(10, 20);
            this.mtrackStatus.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtrackStatus.TrackLineHeight = 3;
            this.mtrackStatus.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtrackStatus.Value = 0;
            // 
            // lbCancion
            // 
            this.lbCancion.AutoSize = true;
            this.lbCancion.Location = new System.Drawing.Point(29, 104);
            this.lbCancion.Name = "lbCancion";
            this.lbCancion.Size = new System.Drawing.Size(13, 13);
            this.lbCancion.TabIndex = 11;
            this.lbCancion.Text = "--";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgvPlaylist
            // 
            this.dgvPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylist.Location = new System.Drawing.Point(524, 163);
            this.dgvPlaylist.Name = "dgvPlaylist";
            this.dgvPlaylist.Size = new System.Drawing.Size(218, 108);
            this.dgvPlaylist.TabIndex = 12;
            this.dgvPlaylist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlaylist_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 54);
            this.button1.TabIndex = 13;
            this.button1.Text = "ADD TO PLAYLIST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.Location = new System.Drawing.Point(527, 120);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(96, 34);
            this.refreshbtn.TabIndex = 14;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(698, 120);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(105, 34);
            this.deletebtn.TabIndex = 15;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 432);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPlaylist);
            this.Controls.Add(this.lbCancion);
            this.Controls.Add(this.mtrackStatus);
            this.Controls.Add(this.mtrackVolumen);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.lstCanciones);
            this.Controls.Add(this.Reproductor);
            this.Name = "Form1";
            this.Text = "Reproductor MP3";
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.ListBox lstCanciones;
        private System.Windows.Forms.PictureBox btnAdjuntar;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox pictureBox3;
        private XComponent.SliderBar.MACTrackBar mtrackVolumen;
        private XComponent.SliderBar.MACTrackBar mtrackStatus;
        private System.Windows.Forms.Label lbCancion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvPlaylist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Button deletebtn;
    }
}

