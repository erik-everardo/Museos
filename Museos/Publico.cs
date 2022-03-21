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
        public Publico()
        {
            InitializeComponent();
        }

        private void Publico_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.Instance.Show();
        }
    }
}
