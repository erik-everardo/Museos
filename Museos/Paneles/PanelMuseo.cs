using Museos.Tablas;

namespace Museos.Paneles
{
    public partial class PanelMuseo : UserControl
    {
        private readonly AppDbContext _db = new();
        private Museo? esteMuseo;

        public PanelMuseo()
        {
            InitializeComponent();

            if(_db.Museos.Count() < 1)
            {
                new FormularioAgregarMuseo().ShowDialog();
            }
            TraerInformacion();
        }

        private void TraerInformacion()
        {
            esteMuseo = _db.Museos.First();
            if(esteMuseo == null)
            {
                MessageBox.Show("No hay información almacenada");
                return;
            }

            // La información sí está presente, ahora hay que ponerla en los controles
            nombre.Text = esteMuseo.Nombre;
            historia.Text = esteMuseo.Historia;
            fechaFundación.Value = esteMuseo.FechaFundacion;
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            // TODO: agregar validacion

            // modificamos el objeto con la info actual
            esteMuseo.Nombre = nombre.Text;
            esteMuseo.Historia = historia.Text;
            esteMuseo.FechaFundacion = fechaFundación.Value;


            // actualizamos el registro
            // como este objeto es el que estamos mostrando, el Id ya lo tiene, de esa
            // forma Entity Framework Core ya sabe cual registro modificar
            _db.Museos.Update(esteMuseo);

            _db.SaveChanges();
            MessageBox.Show("Se ha actualizado la información adecuadamente");
        }
    }
}
