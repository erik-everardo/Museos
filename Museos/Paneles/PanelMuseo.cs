using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museos.Paneles
{
    public partial class PanelMuseo : UserControl
    {
        private readonly AppDbContext _db = new();
        public PanelMuseo()
        {
            InitializeComponent();

            if(_db.Museos.Count() < 1)
            {
                new FormularioAgregarMuseo().ShowDialog();
            }
        }


    }
}
