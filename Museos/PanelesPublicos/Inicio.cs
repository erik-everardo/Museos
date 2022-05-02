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
    public partial class Inicio : UserControl
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
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

            textoBienvenidoA.Text = $"Bienvenido/a a {museo.Nombre}"; 
        }
    }
}
