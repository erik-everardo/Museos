using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museos.PanelesPublicos
{
    public partial class Museo : UserControl
    {
        public Museo()
        {
            InitializeComponent();
        }

        private void Museo_Load(object sender, EventArgs e)
        {
            TraerInfoMuseo();
        }

        private void TraerInfoMuseo()
        {
            var db = new AppDbContext();
            var museo = db.Museos.First();
            if (museo == null)
            {
                MessageBox.Show("No hay información");
                return;
            }

            nombreMuseo.Text = museo.Nombre;
            detalles.Text = museo.Historia;
            fundado.Text = $"Fundado el {museo.FechaFundacion.Date.Day}/{museo.FechaFundacion.Date.Month}/{museo.FechaFundacion.Date.Year}";
        }
    }
}
