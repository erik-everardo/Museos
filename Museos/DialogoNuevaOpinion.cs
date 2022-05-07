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
    public partial class DialogoNuevaOpinion : Form
    {
        private readonly AppDbContext _db = new();
        private int obraId;
        public DialogoNuevaOpinion(int obraId)
        {
            InitializeComponent();
            this.obraId = obraId;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(nombre.Text.Length < 1 || comentarioText.Text.Length < 1)
            {
                MessageBox.Show("Por favor, complete todos los campos");
                return;
            }

            var visitante = new Visitante()
            {
                Nombre = nombre.Text,
                Fecha = DateTime.Now,
            };

            _db.Visitantes.Add(visitante);
            _db.SaveChanges();

            var comentario = new Comentario()
            {
                ObraId = obraId,
                UidVisitante = visitante.Id,
                Fecha = DateTime.Now,
                TextoContenido = comentarioText.Text
            };

            _db.Comentarios.Add(comentario);
            _db.SaveChanges();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
