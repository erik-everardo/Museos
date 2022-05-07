using Museos.PanelesPublicos;

namespace Museos
{
    public partial class Publico : Form
    {
        private bool isFullscreen = false;
        private const AnchorStyles anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        private readonly AppDbContext _db;
        public Publico()
        {
            _db = new AppDbContext();
            InitializeComponent();
            isFullscreen = true;
            GoFullScreen(true);
            botonMuseo.Text = _db.Museos.First().Nombre;
        }
        private Museo _panelMuseo = new()
        {
            Anchor = anchor
        };
        private Obras _panelObras = new()
        {
            Anchor = anchor
        };
        private Boleto _panelBoleto = new()
        {
            Anchor = anchor
        };

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

        private void botonMuseo_Click(object sender, EventArgs e)
        {
            if (tabla.Controls.Count > 1)
            {
                tabla.Controls.RemoveAt(tabla.Controls.Count - 1);
            }
            tabla.Controls.Add(_panelMuseo, 0, 0);
            titulo.Text = "Museo";
        }

        private void botonObras_Click(object sender, EventArgs e)
        {
            if (tabla.Controls.Count > 1)
            {
                tabla.Controls.RemoveAt(tabla.Controls.Count - 1);
            }
            tabla.Controls.Add(_panelObras, 0, 0);
            titulo.Text = "Obras";
        }

        private void botonBoleto_Click(object sender, EventArgs e)
        {
            if (tabla.Controls.Count > 1)
            {
                tabla.Controls.RemoveAt(tabla.Controls.Count - 1);
            }
            tabla.Controls.Add(_panelBoleto, 0, 0);
            titulo.Text = "Boleto";
        }

        private void Publico_Load(object sender, EventArgs e)
        {
            var db = new AppDbContext();
            if(db.Museos.Count() < 1)
            {
                var result = new FormularioAgregarMuseo().ShowDialog();
                if(result != DialogResult.OK)
                {
                    MessageBox.Show("No se puede continuar sin agregar museo");
                }
            }
            if (tabla.Controls.Count > 1)
            {
                tabla.Controls.RemoveAt(tabla.Controls.Count - 1);
            }
            titulo.Text = "Museo";
            tabla.Controls.Add(_panelMuseo, 0, 0);
        }
    }
}
