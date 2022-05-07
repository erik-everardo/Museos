using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
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

            CargarImagenInteractiva(museo);
        }

        private void CargarImagenInteractiva(Tablas.Museo museo)
        {
            if(museo.Mapa != null)
            {
                var stream = new MemoryStream(museo.Mapa);
                var imagen = Image.FromStream(stream);
                pictureBox1.Image = imagen;
                if (museo.Coordenadas != null)
                {
                    try
                    {
                        var list = JsonSerializer.Deserialize<List<MarcaEnImagen>>(museo.Coordenadas);
                        if(list != null)
                        {
                            list.ForEach(m =>
                            {
                                var button = new Button()
                                {
                                    Text = m.Nombre,
                                    AutoEllipsis = true,
                                    Location = new Point(m.Coordenada.X, m.Coordenada.Y),
                                    Size = new Size(75, 23),
                                    Name = $"{m.Coordenada.X},{m.Coordenada.Y}",
                                    UseVisualStyleBackColor = true,
                                    Cursor = Cursors.Default
                                };
                                button.Click += (object? sender, EventArgs e) =>
                                {
                                    MessageBox.Show(m.Info,m.Nombre);
                                };
                                var indexOfPic = panel1.Controls.IndexOf(pictureBox1);
                                panel1.Controls.Add(button);
                                panel1.Controls.SetChildIndex(button, indexOfPic);
                                panel1.Controls.Add(pictureBox1);
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            
        }
    }
}
