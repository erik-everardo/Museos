using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Museos.Tablas;
using Microsoft.AspNetCore.Identity;

namespace Museos
{
    public partial class CrearCuenta : Form
    {
        private AppDbContext _db = new();

        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void HacerCuenta(string usuario, string password)
        {
            PasswordHasher<string> hasher = new PasswordHasher<string>();
            UsuarioAdmin nuevoUsuario = new()
            {
                Nombre = usuario,
                PasswordHash = hasher.HashPassword(usuario,password)
            };

            _db.UsuariosAdmin.Add(nuevoUsuario);
            _db.SaveChanges();
            MessageBox.Show("Cuenta creada con exito");
            Close();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            HacerCuenta(textBoxUsuario.Text, textBoxPassword.Text);
        }
    }
}
