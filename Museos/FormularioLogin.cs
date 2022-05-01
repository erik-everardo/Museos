using Microsoft.AspNetCore.Identity;
using Museos.Tablas;

namespace Museos
{
    public partial class FormularioLogin : Form
    {
        private AppDbContext _db = new();
        public FormularioLogin()
        {
            InitializeComponent();
        }

        private void AbrirVentanaAdministrador()
        {
            new Administrador().Show();
            Form1.Instance.Hide();
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string nombreDeUsuario = textBoxUsuario.Text;
            string password = textBoxPassword.Text;

            PasswordHasher<string> hasher = new PasswordHasher<string>();

            UsuarioAdmin usuarioAdmin = _db.UsuariosAdmin.Single(usuario => usuario.Nombre.Equals(nombreDeUsuario));

            PasswordVerificationResult result = hasher.VerifyHashedPassword(nombreDeUsuario, usuarioAdmin.PasswordHash, password);

            if (result == PasswordVerificationResult.Success)
            {
                EstadoLogin.UserId = usuarioAdmin.Id;
                AbrirVentanaAdministrador();
            } 
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos");
            }
            

            
        }
    }
}
