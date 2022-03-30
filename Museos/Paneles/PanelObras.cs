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
    }
}
