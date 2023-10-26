using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Курсовая
{
    public partial class Form1 : Form
    {
        bool Play = false;
        string[] ArchivosMP3;
        string[] rutaArchivosMP3;

        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommand command;
        
        string connectionString = @" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kevin\Documents\Playlist.mdf;Integrated Security=True";
        string sql = "SELECT * FROM Playlist";
        public Form1()
        {
            InitializeComponent();
            dgvPlaylist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlaylist.AllowUserToAddRows = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);

                ds = new DataSet();
                adapter.Fill(ds);
                dgvPlaylist.DataSource = ds.Tables[0];
            }
        }
        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaDeBusquedaDeArchivos = new OpenFileDialog();
            CajaDeBusquedaDeArchivos.Multiselect = true;
            if (CajaDeBusquedaDeArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ArchivosMP3 = CajaDeBusquedaDeArchivos.SafeFileNames;
                rutaArchivosMP3 = CajaDeBusquedaDeArchivos.FileNames;
                foreach(var ArchivoMP3 in ArchivosMP3)
                {
                    lstCanciones.Items.Add(ArchivoMP3);
                }
                Reproductor.URL = rutaArchivosMP3[0];
                lstCanciones.SelectedIndex = 0;
                btnPlay.Image = Properties.Resources.pausa;
            }
        }

        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reproductor.URL = rutaArchivosMP3[lstCanciones.SelectedIndex];
            lbCancion.Text = ArchivosMP3[lstCanciones.SelectedIndex];
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            switch (Play)
            {
                case true:
                    Reproductor.Ctlcontrols.pause();
                    btnPlay.Image = Properties.Resources.play;
                    Play = false;
                    break;
                case false:
                    Reproductor.Ctlcontrols.play();
                    btnPlay.Image = Properties.Resources.pausa;
                    Play = true;
                    break;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.stop();
            btnPlay.Image = Properties.Resources.play;
            Play = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizarDatosTrack();
            mtrackStatus.Value = (int)Reproductor.Ctlcontrols.currentPosition;
            mtrackVolumen.Value = Reproductor.settings.volume;
        }
        private void ActualizarDatosTrack()
        {
            if (Reproductor.playState== WMPLib.WMPPlayState.wmppsPlaying)
            {
                //Control tiempo maximo de la cancion actual
                mtrackStatus.Maximum=(int)Reproductor.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if(Reproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                mtrackStatus.Value = 0;
            }
        }

        private void Reproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            ActualizarDatosTrack();
        }

        private void mtrackVolumen_ValueChanged(object sender, decimal value)
        {
            Reproductor.settings.volume = mtrackVolumen.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command = new SqlCommand("insert into PLaylist (Songs) values (@Songs)", connection);
                command.Parameters.AddWithValue("@Songs", lstCanciones.SelectedItem);
                command.ExecuteNonQuery();
                connection.Close();
                
                MessageBox.Show("Song Added");
            }
        }
        private void deletebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command = new SqlCommand("DELETE FROM PLaylist WHERE Songs =@Songs", connection);

                command.Parameters.AddWithValue("@Songs", lstCanciones.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Song Deleted");
            }
            foreach (DataGridViewRow row in dgvPlaylist.SelectedRows)
            {
                dgvPlaylist.Rows.Remove(row);
            }

        }
        private void refreshbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql,connection);
                ds = new DataSet();
                adapter.Fill(ds);
                dgvPlaylist.DataSource = ds.Tables[0];
                MessageBox.Show("Refresh");
            }
        }
        private void lstCanciones_MouseClick(object sender, MouseEventArgs e)
        {
            Reproductor.URL = rutaArchivosMP3[lstCanciones.SelectedIndex];
            lbCancion.Text = ArchivosMP3[lstCanciones.SelectedIndex];
        }

        private void dgvPlaylist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Reproductor.URL = rutaArchivosMP3[lstCanciones.SelectedIndex];
        }
    }
}
