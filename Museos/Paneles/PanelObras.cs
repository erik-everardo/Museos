using Museos.Tablas;

namespace Museos.Paneles
{
    public partial class PanelObras : UserControl
    {
        private readonly AppDbContext _db = new();
        public PanelObras()
        {
            InitializeComponent();
            TraerObras();
        }

        Image foto;

        private void TraerObras()
        {
            Obra[] obras = _db.Obras.ToArray();

            foreach (var obra in obras)
            {
                listaObras.Items.Add(new ListViewItem()
                {
                    ImageKey = obra.Id.ToString(),
                    Text = obra.Nombre
                }); ;
            }

            listaObras.SelectedIndexChanged += ListaObras_SelectedIndexChanged;
        }

        private void ListaObras_SelectedIndexChanged(object? sender, EventArgs e)
        {
            
        }

        private void VistaPrevia(Obra obra)
        {
            nombre.Text = obra.Nombre;
            detalles.Text = obra.Detalles;
            if(obra.FotoData != null)
            {
                MemoryStream memoryStream = new();
                memoryStream.Write(obra.FotoData);
                Image image = Image.FromStream(memoryStream);
                fotografia.Image = image;
                memoryStream.Close();
            }
        }

        private void botonAgregarObra_Click(object sender, EventArgs e)
        {
            new FormularioAgregarObra().ShowDialog();
        }

        private void fotografia_Click(object sender, EventArgs e)
        {
            dialogoSeleccionarImagen.ShowDialog();
        }

        private void dialogoSeleccionarImagen_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var filestream = dialogoSeleccionarImagen.OpenFile();
            foto = Image.FromStream(filestream);
            
            fotografia.Image = foto.GetThumbnailImage(205,109,null,IntPtr.Zero);
        }

        private void botonGuardarCambios_Click(object sender, EventArgs e)
        {
            // Hay que agregar validaciones

        }
    }
}
