namespace ProyectoUnidad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int cont= 0;
            if(tbUser.Text == "admin" && tbPass.Text == "admin")
            {
                Principal principal = new Principal();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrectos");
                cont++;
            }

            if(cont == 3)
            {
                MessageBox.Show("Ha excedido el n�mero de intentos");
                Application.Exit();
            }

        }
    }
}