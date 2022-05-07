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
    public partial class DialogoVerOpiniones : Form
    {
        private readonly AppDbContext _db = new();
        private int obraId;
        public DialogoVerOpiniones(int obraId)
        {
            InitializeComponent();
            this.obraId = obraId;
        }

        private void DialogoVerOpiniones_Load(object sender, EventArgs e)
        {
            RenderizarOpiniones(_db.Comentarios.Where(comentario => comentario.ObraId == obraId).ToList());
        }

        private void RenderizarOpiniones(List<Comentario> comentarios)
        {
            comentarios.ForEach(comentario =>
            {
                var visitante = _db.Visitantes.Find(comentario.UidVisitante);

                flowLayoutPanel1.Controls.Add(new Label()
                {
                    AutoSize = true,
                    Text = $"({comentario.Fecha}) {(visitante == null ? "Desconocido" : visitante.Nombre)}: {comentario.TextoContenido}",
                    Dock = DockStyle.Fill,
                    Margin = new Padding(5),
                    Padding = new Padding(5),
                });
            });
        }
    }
}
