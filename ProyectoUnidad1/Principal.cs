
using Microsoft.VisualBasic;

namespace ProyectoUnidad1
{
    public partial class Principal : Form
    {
       
        static List<Notas> notas = new List<Notas>();
        static List<Carpetas> Carpetas = new List<Carpetas>();
        Notas crear = new Notas();
      
        public Principal()
        {
            InitializeComponent();

            Carpetas.Add(new Carpetas("principal"));
            lbdorn_carpetas.Items.Add("principal"); 
            lbdorn_carpetas.SelectedIndex = 0;

        }

        private void lbdorn_notas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbdorn_notas.SelectedIndex != -1)
            {
                string nombreCarpeta = lbdorn_carpetas.SelectedItem.ToString();           
                Carpetas carpeta = Carpetas.FirstOrDefault(c => c.nombre == nombreCarpeta);
        
                if (carpeta != null)
                {
                    List<Notas> notasCarpeta = carpeta.notas;
                    Notas notaSeleccionada = notasCarpeta[lbdorn_notas.SelectedIndex];
                    txbnotas.Text = notaSeleccionada.Contenido;
                    lbfecha.Text = notaSeleccionada.Fecha;
                }
            }

        }

        private void btndorn_nuevo_Click(object sender, EventArgs e)
        {
            txbnotas.Enabled = true;
            lbfecha.Text = DateTime.Now.ToString("D");

            txbnotas.Text = "";
            lbdorn_notas.SelectedIndex = -1;

        }

        private void txbnotas_Leave(object sender, EventArgs e)
        {
            string titulo = txbnotas.Lines.FirstOrDefault();
            string contenido = txbnotas.Text;
            string fecha = lbfecha.Text;
            string hora = DateTime.Now.ToString("hh:mm");

            int index = lbdorn_notas.SelectedIndex;

            if (index != -1)
            {
                notas[index].Contenido = contenido;
                MessageBox.Show("La nota ha sido actualizada correctamente.");
            }
            else
            {
                bool notaExistente = notas.Any(n => n.Titulo == titulo && n.Contenido == contenido);

                string nombreCarpeta = lbdorn_carpetas.SelectedItem.ToString();
                Carpetas carpeta = Carpetas.FirstOrDefault(c => c.nombre == nombreCarpeta);

                if (carpeta == null)
                {
                    MessageBox.Show("No se ha seleccionado ninguna carpeta.");
                    return;
                }

                if (notaExistente)
                {
                    MessageBox.Show("La nota ya existe.");
                }
                else
                {
                    Notas notascrear = new Notas(titulo, contenido, fecha, hora);
                    notas.Add(notascrear); 
                    carpeta.notas.Add(notascrear);
                    lbdorn_notas.Items.Add(notascrear.Titulo);
                    MessageBox.Show("La nota ha sido creada correctamente.");
                }
            }


        }

        private void txbnotas_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lbdorn_carpetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbdorn_notas.Items.Clear(); 

            string nombreCarpeta = lbdorn_carpetas.SelectedItem.ToString();
            Carpetas carpeta = Carpetas.FirstOrDefault(c => c.nombre == nombreCarpeta);
            if (carpeta != null)
            {
                foreach (Notas nota in carpeta.notas)
                {
                    lbdorn_notas.Items.Add(nota.Titulo);
                }
            }

            lbdorn_notas_SelectedIndexChanged(sender, e);


        }

        private void btndorn_newCar_Click(object sender, EventArgs e)
        {

            //se abre una ventanda donde se le pregunta al usuario el nomnre qu ele quiere dar a la carpeta, sale una advertencia si la carpeta ya existe
            string nombre = Interaction.InputBox("Ingrese el nombre de la carpeta", "Nueva Carpeta", "", -1, -1);
            bool carpetaExistente = Carpetas.Any(c => c.nombre == nombre);
            if (carpetaExistente)
            {
                MessageBox.Show("La carpeta ya existe.");
            }
            else
            {
                Carpetas carpetascrear = new Carpetas(nombre);
                Carpetas.Add(carpetascrear);
                lbdorn_carpetas.Items.Add(nombre);
                MessageBox.Show("La carpeta ha sido creada correctamente.");
            }

        }
    }
}
