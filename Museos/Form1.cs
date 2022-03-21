namespace Museos
{
    public partial class Form1 : Form
    {

        private static readonly Lazy<Form1> _instance = new(() => new Form1());

        public static Form1 Instance { get { return _instance.Value; } }

        private Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenAdmin_Click(object sender, EventArgs e)
        {
            new Administrador().Show();
            Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
        }

        private void buttonOpenPublic_Click(object sender, EventArgs e)
        {
            new Publico().Show();
            Hide();
        }
    }
}