using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museos
{
    public partial class Publico : Form
    {
        private bool isFullscreen = false;
        public Publico()
        {
            InitializeComponent();
            isFullscreen = true;
            GoFullScreen(true);
        }

        private void Publico_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.Instance.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isFullscreen)
            {
                isFullscreen = false;
                GoFullScreen(false);
            }
            else
            {
                isFullscreen = true;
                GoFullScreen(true);
            }
        }

        private void GoFullScreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }
    }
}
