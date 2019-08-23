using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mazeScary
{
    public partial class Scare : Form1
    {
        public Scare()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;


            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.scare;
            player.Play();
        }
        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
