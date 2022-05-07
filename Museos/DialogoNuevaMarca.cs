using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museos
{
    public partial class DialogoNuevaMarca : Form
    {
        private Coordenada _coordenada;
        public MarcaEnImagen? Marca = null;
        public DialogoNuevaMarca(Coordenada coordenada)
        {
            InitializeComponent();
            _coordenada = coordenada;
        }

        private void DialogoNuevaMarca_Load(object sender, EventArgs e)
        {
            info.Text = $"Agregar una marca en las coordenadas: {_coordenada}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nombre.Text.Length < 1 || info.Text.Length < 1)
            {
                MessageBox.Show("Complete los campos");
                return;
            }

            Marca = new()
            {
                Nombre = nombre.Text,
                Info = informacion.Text,
                Coordenada = _coordenada
            };
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
