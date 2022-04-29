using Museos.Tablas;

namespace Museos.Paneles
{
    public partial class PanelObras : UserControl
    {
        private readonly AppDbContext _db = new();
        private Obra? obraEnVistaPrevia = null;
        public PanelObras()
        {
            InitializeComponent();
            TraerObras();
        }

        Image foto;

        private void TraerObras()
        {
            listaDeObras.Controls.Clear();
            Obra[] obras = _db.Obras.ToArray();
            listaDeObras.Controls.Add(new ContainerControl
            { 
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                Width = 200 
            });
            foreach (var obra in obras)
            {
                Label text = new()
                {
                    AutoSize = true,
                    Text = obra.Nombre,
                    Dock = DockStyle.Fill,
                    Margin = new Padding(5),
                    Padding = new Padding(5),
                    Cursor = Cursors.Hand
                };
                text.Click += (object? sender, EventArgs e) =>
                {
                    VistaPrevia(obra);
                };
                listaDeObras.Controls.Add(text);
            }
        }


        private void VistaPrevia(Obra obra)
        {
            nombre.Text = obra.Nombre;
            detalles.Text = obra.Detalles;
            obraEnVistaPrevia = obra;

            nombre.ReadOnly = false;
            detalles.ReadOnly = false;
            if(obra.FotoData != null && Convert.FromBase64String(obra.FotoData).Length > 0)
            {
                try
                {
                    MemoryStream memoryStream = new();
                    memoryStream.Write(Convert.FromBase64String(obra.FotoData));
                    Image image = Image.FromStream(memoryStream);
                    int scaledWidth;
                    int scaledHeight;
                    var aspectRatio = (image.Width * 1f) / (image.Height * 1f);
                    if (image.Width > image.Height)
                    {
                        scaledWidth = 300;
                        scaledHeight = (int)Math.Floor(300 / aspectRatio);
                    }
                    else
                    {
                        if (image.Width == image.Height)
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

                    fotografia.Width = scaledWidth;
                    fotografia.Height = scaledHeight;
                    fotografia.Image = image.GetThumbnailImage(scaledWidth, scaledHeight, null, IntPtr.Zero);
                    memoryStream.Close();
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Ocurrió un error leyendo la imagen");
                    fotografia.Image = null;
                }
            }
        }

        private void botonAgregarObra_Click(object sender, EventArgs e)
        {
            DialogResult result = new FormularioAgregarObra().ShowDialog();
            if(result == DialogResult.OK)
            {
                TraerObras();
            }
        }

        private void fotografia_Click(object sender, EventArgs e)
        {
            if(obraEnVistaPrevia == null)
            {
                MessageBox.Show("No hay obra en vista previa");
                return;
            }
            dialogoSeleccionarImagen.ShowDialog();
        }

        private void dialogoSeleccionarImagen_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var filestream = dialogoSeleccionarImagen.OpenFile();
            foto = Image.FromStream(filestream);

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
                if(foto.Width == foto.Height)
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

            fotografia.Width = scaledWidth;
            fotografia.Height = scaledHeight;
            fotografia.Image = foto.GetThumbnailImage(scaledWidth,scaledHeight,null,IntPtr.Zero);
            filestream.Position = 0;
            if(filestream.Length > 0)
            {
                MemoryStream memoryStream = new();
                filestream.CopyTo(memoryStream);
                obraEnVistaPrevia.FotoData = Convert.ToBase64String(memoryStream.ToArray());
            }
            filestream.Close();
        }

        private void botonGuardarCambios_Click(object sender, EventArgs e)
        {
            // Hay que agregar validaciones

            if(obraEnVistaPrevia == null)
            {
                MessageBox.Show("No hay cambios que guardar");
                return;
            }
            // modifico el objeto en vista previa con los campos
            obraEnVistaPrevia.Nombre = nombre.Text;
            obraEnVistaPrevia.Detalles = detalles.Text;
            _db.Obras.Update(obraEnVistaPrevia);
            _db.SaveChanges();
            MessageBox.Show("Obra actualizada");
            TraerObras();
        }

        private void botonEliminarObra_Click(object sender, EventArgs e)
        {
            if(obraEnVistaPrevia == null)
            {
                MessageBox.Show("No hay nada que eliminar");
                return;
            }

            _db.Obras.Remove(obraEnVistaPrevia);
            _db.SaveChanges();
            MessageBox.Show("Obra eliminada");
            TraerObras();
            nombre.Text = "";
            detalles.Text = "";
            nombre.ReadOnly = true;
            detalles.ReadOnly = true;
            fotografia.Image = null;
            obraEnVistaPrevia = null;
        }
    }
}
