using System.Text.Json;
using Museos.Tablas;
using System.ComponentModel;

namespace Museos
{
    public partial class DialogoCrearImagenInteractiva : Form
    {

        private List<MarcaEnImagen> marcas = new();
        private AppDbContext _db = new();
        private Museo museo;

        public DialogoCrearImagenInteractiva()
        {
            InitializeComponent();
            museo = _db.Museos.First();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void PoblarMarcas()
        {
            marcas.ForEach(m =>
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
                button.Click +=  (object? sender, EventArgs e) => {
                    MessageBox.Show(m.Info, m.Nombre);
                };

                var indexOfPic = panel1.Controls.IndexOf(pictureBox1);
                panel1.Controls.Add(button);
                panel1.Controls.SetChildIndex(button, indexOfPic);
                panel1.Controls.Add(pictureBox1);
            });
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DialogoCrearImagenInteractiva_Load(object sender, EventArgs e)
        {
            var museo = _db.Museos.First();
            if(museo.Mapa != null)
            {
                var stream = new MemoryStream(museo.Mapa);
                var imagen = Image.FromStream(stream);
                pictureBox1.Width = imagen.Width;
                pictureBox1.Height = imagen.Height;
                pictureBox1.Image = imagen;

                if (museo.Coordenadas != null)
                {
                    try
                    {
                        var list = JsonSerializer.Deserialize<List<MarcaEnImagen>>(museo.Coordenadas);
                        if (list != null)
                        {
                            marcas.AddRange(list);
                            PoblarMarcas();
                            RenderizarListaDeMarcas();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(e.ToString(), ex.Message);
                    }
                }
            }
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var stream = openFileDialog1.OpenFile();
            var memoryStream = new MemoryStream();
            stream.CopyTo(memoryStream);
            var imagen = Image.FromStream(stream);

            museo.Mapa = memoryStream.ToArray();

            marcas.Clear();
            RenderizarListaDeMarcas();
            pictureBox1.Width = imagen.Width;
            pictureBox1.Height = imagen.Height;
            pictureBox1.Image = imagen;
            panel1.Width = pictureBox1.Width;
            panel1.Height = pictureBox1.Height;
            panel1.Controls.Clear();
            panel1.Controls.Add(pictureBox1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            var mouseEvent = (MouseEventArgs)e;
            var dialog = new DialogoNuevaMarca(new Coordenada
            {
                X = mouseEvent.X,
                Y = mouseEvent.Y
            });
            var result = dialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                var marca = dialog.Marca;
                if (marca == null)
                {
                    return;
                }

                marcas.Add(marca);
                RenderizarListaDeMarcas();

                var button = new Button()
                {
                    Text = marca.Nombre,
                    AutoEllipsis = true,
                    Location = new Point(mouseEvent.X, mouseEvent.Y),
                    Size = new Size(75, 23),
                    Name = $"{mouseEvent.X},{mouseEvent.Y}",
                    UseVisualStyleBackColor = true,
                    Cursor = Cursors.Default
                };

                button.Click += (object? sender, EventArgs e) => {
                    MessageBox.Show(marca.Info, marca.Nombre);
                };

                var indexOfPic = panel1.Controls.IndexOf(pictureBox1);
                panel1.Controls.Add(button);
                panel1.Controls.SetChildIndex(button, indexOfPic);
                panel1.Controls.Add(pictureBox1);
            }
        }

       
        private void RenderizarListaDeMarcas()
        {
            listaDeMarcas.Controls.Clear();
            foreach (var marca in marcas)
            {
                var label = new Label()
                {
                    Text = $"{marca.Nombre} ({marca.Coordenada})",
                    AutoSize = true,
                    BackColor = Color.Gray,
                    Padding = new Padding(5, 5, 5, 5),
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Cursor = Cursors.Hand
                };
                label.Click += (s, e) =>
                {
                    MessageBox.Show(marca.Nombre, marca.Info);
                };
                listaDeMarcas.Controls.Add(label);
            }
        }

        private void guardarYSalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                museo.Coordenadas = JsonSerializer.Serialize(marcas);
                _db.Museos.Update(museo);
                _db.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            marcas.Clear();
            pictureBox1.Image = null;
            panel1.Controls.Clear();
            panel1.Controls.Add(pictureBox1);
            RenderizarListaDeMarcas();
        }

        private void limpiarCoordenadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marcas.Clear();
            RenderizarListaDeMarcas();
            panel1.Controls.Clear();
            panel1.Controls.Add(pictureBox1);
        }
    }
}
