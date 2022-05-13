namespace Museos.Paneles
{
    public partial class PanelAjustes : UserControl
    {
        public PanelAjustes()
        {
            InitializeComponent();
        }
        private void PanelAjustes_Load(object sender, EventArgs e)
        {
            TraerNombre();
        }

        private void btnCambiarPass_Click(object sender, EventArgs e)
        {
            new DialogoCambiarPass().ShowDialog();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            new CrearCuenta().ShowDialog();
        }

        private void TraerNombre()
        {
            var db = new AppDbContext();
            var user = db.UsuariosAdmin.Find(EstadoLogin.UserId);
            if (user == null)
            {
                nombre.Text = "Null";
                return;
            }
            nombre.Text = user.Nombre;
        }

        private void btnCambiarNombre_Click(object sender, EventArgs e)
        {
            var result = new DialogoCambiarNombre().ShowDialog();
            if(result == DialogResult.OK)
            {
                TraerNombre();
            }
        }
    }
}
