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
                FotoData = Convert.ToBase64String(imagen)
            };

            _db.Obras.Add(nuevaObra);
            _db.SaveChanges();

            MessageBox.Show("Obra agregada exitosamente");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void dialogoSeleccionarImagen_FileOk(object sender, CancelEventArgs e)
        {
            
            var fileStream = dialogoSeleccionarImagen.OpenFile();
            var length = fileStream.Length;
            byte[] data = new byte[length];
            fileStream.Read(data);
            imagen = data;

            fileStream.Position = 0;

            var foto = Image.FromStream(fileStream);

            int scaledWidth;
            int scaledHeight;
            var aspectRatio = (foto.Width * 1f) / (foto.Height * 1f);
            if (foto.Width > foto.Height)
            {
                scaledWidth = 300;
                scaledHeight = (int)Math.Floor(300 / aspectRatio);
            }
            else
            {
                if (foto.Width == foto.Height)
                {
                    scaledHeight = 300;
                    scaledWidth = 300;
                }
                else
                {
                    scaledHeight = 300;
                    scaledWidth = (int)Math.Floor(aspectRatio * 300);
                }
            }

            vistaPrevia.Width = scaledWidth;
            vistaPrevia.Height = scaledHeight;

            vistaPrevia.Image = foto.GetThumbnailImage(scaledWidth, scaledHeight, null, IntPtr.Zero);
        }
    }
}
