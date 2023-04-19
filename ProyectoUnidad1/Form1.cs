namespace ProyectoUnidad1
{
    public partial class Form1 : Form
    {
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void inicio()
        {
            if (tbUser.Text == "admin" && tbPass.Text == "admin")
            {
                Principal principal = new Principal();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                cont++;
            }

            if (cont == 3)
            {
                MessageBox.Show("Ha excedido el número de intentos");
                Application.Exit();
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            inicio();

        }

        private void tbUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                inicio();
            }
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                inicio();
            }
        }
    }
}