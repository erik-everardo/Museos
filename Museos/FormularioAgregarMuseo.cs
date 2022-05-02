using System;
using System.Collections.Generic;
using Museos.Tablas;

namespace Museos
{
    public partial class FormularioAgregarMuseo : Form
    {
        private readonly AppDbContext _db = new();
        public FormularioAgregarMuseo()
        {
            InitializeComponent();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            Museo nuevoMuseo = new()
            {
                Nombre = nombre.Text,
                Historia = historia.Text,
                FechaFundacion = fechaFundacion.Value
            };

            _db.Museos.Add(nuevoMuseo);
            _db.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
