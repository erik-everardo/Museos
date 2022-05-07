using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace Museos.PanelesPublicos
{
    public partial class Boleto : UserControl
    {
        public Boleto()
        {
            InitializeComponent();
        }

        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;
        private bool readCode = false;
        private readonly AppDbContext _db = new();

        private void Boleto_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo device in filterInfoCollection)
            {
                comboBoxCameras.Items.Add(device.Name);
            }
            if(comboBoxCameras.Items.Count > 0)
            {
                comboBoxCameras.SelectedIndex = 0;
                videoCaptureDevice = new();
            }
            else
            {
                MessageBox.Show("No tiene camaras instaladas");
                btnAceptar.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBoxCameras.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            btnAceptar.Enabled = false;
            btnDetener.Enabled = true;
            btnDetener.Visible = true;
            comboBoxCameras.Enabled = false;
            timer1.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            videoCaptureDevice.SignalToStop();
            pictureBox1.Image = null;
            btnDetener.Visible = false;
            btnDetener.Enabled = false;
            btnAceptar.Enabled = true;
            comboBoxCameras.Enabled = true;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ZXing.BarcodeReader reader = new BarcodeReader();
            if(pictureBox1.Image != null)
            {
                var result = IronBarCode.BarcodeReader.QuicklyReadOneBarcode((Bitmap)pictureBox1.Image, BarcodeFormat: IronBarCode.BarcodeEncoding.QRCode);
                if(result != null)
                {
                    readCode = true;
                    timer1.Stop();
                }
                if (readCode)
                {
                    var boleto = _db.Boletos.Find(Guid.Parse(result.Text));
                    if(boleto != null && !boleto.Used)
                    {
                        if (MessageBox.Show("¿Entrar?") == DialogResult.OK)
                        {
                            boleto.Used = true;
                            _db.Boletos.Update(boleto);
                            _db.SaveChanges();
                            timer1.Start();
                        }
                    }
                    else
                    {
                        if(MessageBox.Show("El boleto es inválido") == DialogResult.OK)
                        {
                            timer1.Start();
                        }
                    }
                    readCode = false;
                }
            }
        }
    }
}
