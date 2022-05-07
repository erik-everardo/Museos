using Museos.Paneles;
using System.Diagnostics;

namespace Museos
{
    public partial class Administrador : Form
    {
        private PanelMuseo panelMuseo = new();
        private PanelObras panelObras = new();
        private PanelValoraciones panelValoraciones = new();
        private PanelAjustes panelAjustes = new();
        private PanelBoletos panelBoletos = new();

        

        public Administrador()
        {
            InitializeComponent();
            var anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMuseo.Anchor = anchor;
            panelObras.Anchor = anchor;
            panelValoraciones.Anchor = anchor;
            panelAjustes.Anchor = anchor;
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            
        }

        private void Administrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.Instance.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonMuseo_Click(object sender, EventArgs e)
        {
            if(tableLayoutPanel1.Controls.Count > 1)
            {
                tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.Controls.Count - 1);
            }
            tableLayoutPanel1.Controls.Add(panelMuseo, 1, 0);
        }

        private void botonObras_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.Controls.Count > 1)
            {
                tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.Controls.Count - 1);
            }
            tableLayoutPanel1.Controls.Add(panelObras, 1, 0);
        }

        private void botonOpiniones_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.Controls.Count > 1)
            {
                tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.Controls.Count - 1);
            }
            tableLayoutPanel1.Controls.Add(panelValoraciones, 1, 0);
        }

        private void botonAjustes_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.Controls.Count > 1)
            {
                tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.Controls.Count - 1);
            }
            tableLayoutPanel1.Controls.Add(panelAjustes, 1, 0);
        }

        private void btnOpenDataDir_Click(object sender, EventArgs e)
        {
            var appDir = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\MuseosEQ3";
            Process.Start("explorer.exe",appDir);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.Controls.Count > 1)
            {
                tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.Controls.Count - 1);
            }
            tableLayoutPanel1.Controls.Add(panelBoletos, 1, 0);

        }
    }
}
