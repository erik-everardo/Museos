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
    public partial class DialogoCambiarNombre : Form
    {
        public DialogoCambiarNombre()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(nombre.Text.Length < 1)
            {
                MessageBox.Show("El nombre no puede ser vacio");
            }

            var db = new AppDbContext();
            var user = db.UsuariosAdmin.Find(EstadoLogin.UserId);
            if(user == null)
            {
                MessageBox.Show("Error, no se pudo cambiar el nombre");
                return;
            }

            user.Nombre = nombre.Text;
            db.UsuariosAdmin.Update(user);
            db.SaveChanges();
            MessageBox.Show("Nombre cambiado exitosamente");
            DialogResult = DialogResult.OK;
        }
    }
}
