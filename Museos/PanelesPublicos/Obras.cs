using Museos.Tablas;
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
    public partial class Obras : UserControl
    {
        private readonly AppDbContext _db = new();
        private Obra? obraEnVistaPrevia = null;
        Image foto;

        public Obras()
        {
            InitializeComponent();
        }

        private void TraerObras()
        {
            listaDeObras.Controls.Clear();
            Obra[] obras = _db.Obras.ToArray();
            listaDeObras.Controls.Add(new ContainerControl
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                Width = 200
            });
            foreach (var obra in obras)
            {
                Label text = new()
                {
                    AutoSize = true,
                    Text = obra.Nombre,
                    Dock = DockStyle.Fill,
                    Margin = new Padding(5),
                    Padding = new Padding(5),
                    Cursor = Cursors.Hand,
                    Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
            };
                text.Click += (object? sender, EventArgs e) =>
                {
                    VistaPrevia(obra);
                };
                listaDeObras.Controls.Add(text);
            }
        }


        private void VistaPrevia(Obra obra)
        {
            nombre.Text = obra.Nombre;
            detalles.Text = obra.Detalles;
            obraEnVistaPrevia = obra;

            if (obra.FotoData != null && Convert.FromBase64String(obra.FotoData).Length > 0)
            {
                try
                {
                    MemoryStream memoryStream = new();
                    memoryStream.Write(Convert.FromBase64String(obra.FotoData));
                    Image image = Image.FromStream(memoryStream);
                    int scaledWidth;
                    int scaledHeight;
                    var aspectRatio = (image.Width * 1f) / (image.Height * 1f);
                    if (image.Width > image.Height)
                    {
                        scaledWidth = flowLayoutPanel1.Size.Width;
                        scaledHeight = (int)Math.Floor(flowLayoutPanel1.Size.Width / aspectRatio);
                    }
                    else
                    {
                        if (image.Width == image.Height)
                        {
                            scaledHeight = flowLayoutPanel1.Size.Width;
                            scaledWidth = flowLayoutPanel1.Size.Width;
                        }
                        else
                        {
                            scaledHeight = flowLayoutPanel1.Width;
                            scaledWidth = (int)Math.Floor(aspectRatio * flowLayoutPanel1.Size.Width);
                        }
                    }

                    fotografia.Width = scaledWidth;
                    fotografia.Height = scaledHeight;
                    fotografia.Image = image.GetThumbnailImage(scaledWidth, scaledHeight, null, IntPtr.Zero);
                    memoryStream.Close();
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Ocurrió un error leyendo la imagen");
                    fotografia.Image = null;
                }
            }
        }

        private void Obras_Load(object sender, EventArgs e)
        {
            TraerObras();
        }
    }
}
