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
            var qr = IronBarCode.QRCodeWriter.CreateQrCode(boleto.Id.ToString());
            pictureBox1.Image = qr.Image;
            label1.Text = $"ID: {boleto.Id}";
            label2.Text = $"Fecha: {boleto.DateIssued}";
            printDialog1.Document = printDocument1;
            var printDialogResult = printDialog1.ShowDialog();
            if(printDialogResult == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var bitmap = new Bitmap(300, 200);

            pictureBox1.DrawToBitmap(bitmap, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            label1.DrawToBitmap(bitmap, new Rectangle(0, 160, label1.Width, 20));
            label2.DrawToBitmap(bitmap, new Rectangle(0, 185, label2.Width, 20));

            e.Graphics.DrawImage(bitmap, 50, 50);
            bitmap.Dispose();
        }
    }
}
