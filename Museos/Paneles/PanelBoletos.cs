using Museos.Tablas;

namespace Museos.Paneles
{
    public partial class PanelBoletos : UserControl
    {
        private readonly AppDbContext _db = new();
        public PanelBoletos()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            var boleto = new Boleto()
            {
                DateIssued = DateTime.Now,
                Used = false
            };

            _db.Boletos.Add(boleto);
            _db.SaveChanges();
        }
    }
}
