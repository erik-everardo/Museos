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

        private byte[] imagen;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dialogoSeleccionarImagen.ShowDialog();
        }

        private void botonAgregarObra_Click(object sender, EventArgs e)
        {
            Obra nuevaObra = new()
            {
                Nombre = nombre.Text,
                Detalles = descripcion.Text,
                FechaIncorporacion = fechaIncorporacion.Value,
                FotoData = imagen
            };

            _db.Obras.Add(nuevaObra);
            _db.SaveChanges();

            MessageBox.Show("Obra agregada exitosamente");
            Close();
        }

        private async void dialogoSeleccionarImagen_FileOk(object sender, CancelEventArgs e)
        {
            vistaPrevia.Image = Image.FromStream(dialogoSeleccionarImagen.OpenFile()).GetThumbnailImage(147,108,null, IntPtr.Zero);
            var fileStream = dialogoSeleccionarImagen.OpenFile();
            var length = fileStream.Length;
            byte[] data = new byte[length];
            fileStream.Read(data);
            imagen = data;
        }
    }
}
