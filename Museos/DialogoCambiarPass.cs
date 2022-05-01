using Microsoft.AspNetCore.Identity;

namespace Museos
{
    public partial class DialogoCambiarPass : Form
    {
        public DialogoCambiarPass()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var db = new AppDbContext();
            var currentPassword = textBoxPassActual.Text;
            var newPassword = textBoxNuevaPass.Text;

            if(currentPassword.Length < 1)
            {
                MessageBox.Show("Ingrese la contraseña actual");
                return;
            }
            if(newPassword.Length < 1)
            {
                MessageBox.Show("La nueva contraseña no puede ser vacía");
            }

            var user = db.UsuariosAdmin.Find(EstadoLogin.UserId);
            if(user != null)
            {
                var passwordHasher = new PasswordHasher<string>();
                // verificamos la contraseña actual
                var result = passwordHasher.VerifyHashedPassword(user.Nombre, user.PasswordHash, currentPassword);
                if(result == PasswordVerificationResult.Success)
                {
                    user.PasswordHash = passwordHasher.HashPassword(user.Nombre, newPassword);
                    db.UsuariosAdmin.Update(user);
                    db.SaveChanges();
                    MessageBox.Show("Contraseña actualizada exitosamente");
                    Close();
                }
            }
        }
    }
}
