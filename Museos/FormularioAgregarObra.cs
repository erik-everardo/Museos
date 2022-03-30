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


namespace Museos
{
    public partial class FormularioAgregarObra : Form
    {
        private readonly AppDbContext _db = new();
        public FormularioAgregarObra()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dialogoSeleccionarImagen.ShowDialog();
        }

        private void botonAgregarObra_Click(object sender, EventArgs e)
        {

            byte[] data = new byte[0];
            Obra nuevaObra = new()
            {
                Nombre = nombre.Text,
                Detalles = descripcion.Text,
                FechaIncorporacion = fechaIncorporacion.Value,
                FotoData = data
            };

            _db.Obras.Add(nuevaObra);
            _db.SaveChanges();

            MessageBox.Show("Obra agregada exitosamente");
            Close();
        }
    }
}
