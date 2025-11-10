namespace Beatrix_Formulario
{
    public partial class BeatrixForm : Form
    {
        public BeatrixForm()
        {
            InitializeComponent();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Run(new Inicio());
        }

        private void Beatrix_Load(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = '*';


        }


       
        private void Logo_Click(object sender, EventArgs e)
        {


        }
    }
}
