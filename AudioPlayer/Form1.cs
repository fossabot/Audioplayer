using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AudioPlayer
{
    /// <summary>
    /// Main form
    /// </summary>
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        /// <summary>
        /// Class constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StyleManager = metroStyleManager1;
            this.Text = "Audioplayer";
        }

        /// <summary>
        /// Object of the Windows Media Player class
        /// </summary>
        private static WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        /// <summary>
        /// Timer
        /// Responsible for the progress bar and audiofile metadata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((player.controls.currentPosition != 0) && (player.controls.currentItem.duration != 0))
                metroProgressBar1.Value = (int)((player.controls.currentPosition / player.controls.currentItem.duration) * 100.0);

            if (this.BackgroundImage == null && player.URL != "")
            {
                try
                {
                    TagLib.File file_TAG = TagLib.File.Create(player.URL);

                    if (file_TAG.Tag.Pictures.Length >= 1)
                    {
                        try
                        {
                            var bin = (byte[])(file_TAG.Tag.Pictures[0].Data.Data);
                            pictureBox1.Image = Image.FromStream(new MemoryStream(bin));
                        }

                        catch (Exception) { }

                        lbTags.Text = "Album: " + file_TAG.Tag.Album +
                                        "\nArtist: " + String.Join(", ", file_TAG.Tag.Performers) +
                                        "\nName: " + file_TAG.Tag.Title +
                                        "\nYear: " + file_TAG.Tag.Year +
                                        "\nDuretion: " + file_TAG.Properties.Duration.ToString("mm\\:ss");
                    }
                }

                catch (Exception ex)
                {
                    timer1.Stop();
                    MetroFramework.MetroMessageBox.Show(this, $"{ex.Message}", "Error of reading metadata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            AudioPosition.Text = player.controls.currentPositionString;
            lbNameAudio.Text = Path.GetFileName(player.URL);
        }

        #region Tile handlers

        /// <summary>
        /// Handler for open tile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenTile_Click(object sender, EventArgs e)
        {
            try
            {
                Openfile();
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Creating open file dialog and starting the player
        /// </summary>
        private void Openfile()
        {
            OpenFileDialog openSound = new OpenFileDialog()
            {
                Filter = "MP3|*.mp3|WAV|*.wav|FLAC|*.flac|All files|*.*",
                Multiselect = true,
                ValidateNames = true
            };

            if (openSound.ShowDialog() == DialogResult.OK)
            {
                foreach (string item in openSound.FileNames)
                    listBox1.Items.Add(item);

                listBox1.SelectedIndex = 0;

                player.URL = openSound.FileNames[listBox1.Items.Count - 1];

                player.controls.play();
            }
        }

        /// <summary>
        /// Handler for pause/play tile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayTile_Click(object sender, EventArgs e)
        {
            if (PlayTile.Text == "Pause")
            {
                player.controls.pause();
                PlayTile.Text = "Play";
            }

            else
            {
                player.controls.play();
                PlayTile.Text = "Pause";
            }
        }

        /// <summary>
        /// Handler for stop tile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopTile_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            metroProgressBar1.Value = 0;
        }

        /// <summary>
        /// Previous tile handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                player.URL = listBox1.Items[listBox1.SelectedIndex - 1].ToString();
                listBox1.SelectedIndex--;
            }

            catch (Exception) { MetroFramework.MetroMessageBox.Show(this, "Previous item not found", "Oooops..."); }
        }

        /// <summary>
        /// Next tile handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                player.URL = listBox1.Items[listBox1.SelectedIndex + 1].ToString();
                listBox1.SelectedIndex++;
            }

            catch (Exception) { MetroFramework.MetroMessageBox.Show(this, "Next item not found", "Oooops..."); }
        }

        /// <summary>
        /// Remove track from list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTile3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        #endregion

        #region Manipulations with progress bar

        /// <summary>
        /// Mouse down handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroProgressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            this.metroProgressBar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScrollProgress);
        }

        /// <summary>
        /// Mouse up handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroProgressBar1_MouseUp(object sender, MouseEventArgs e)
        {
            this.metroProgressBar1.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.ScrollProgress);

            metroProgressBar1.Value = ((e.Location.X * 100) / metroProgressBar1.Width);

            player.controls.currentPosition = ((double)e.Location.X / (double)metroProgressBar1.Width) * player.controls.currentItem.duration;
        }

        /// <summary>
        /// Keeps track of the cursor position and sets the progress bar position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScrollProgress(object sender, MouseEventArgs e)
        {
            metroProgressBar1.Value = ((e.Location.X * 100) / metroProgressBar1.Width);
        }

        #endregion

        /// <summary>
        /// Handler for selecting tracks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
