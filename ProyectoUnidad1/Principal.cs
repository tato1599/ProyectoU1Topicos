
using Microsoft.VisualBasic;

namespace ProyectoUnidad1
{
    public partial class Principal : Form
    {

        static List<Notas> notas = new List<Notas>();
        static List<Carpetas> Carpetas = new List<Carpetas>();
        static Font fuente;
        static Color color;

        public Principal()
        {
            InitializeComponent();

            Carpetas.Add(new Carpetas("principal"));
            lbdorn_carpetas.Items.Add("principal");
            lbdorn_carpetas.SelectedIndex = 0;
            fuente = new Font("Arial", 12, FontStyle.Regular);
            color = Color.Black;

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
                    txbnotas.Font = notaSeleccionada.Fuente;
                    txbnotas.ForeColor = notaSeleccionada.Color;
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
            Font fuente = txbnotas.Font;
            Color color = txbnotas.ForeColor;

            int index = lbdorn_notas.SelectedIndex;

            if (index != -1)
            {
                notas[index].Titulo = titulo;
                notas[index].Contenido = contenido;
                notas[index].Fecha = fecha;
                notas[index].Hora = hora;
                notas[index].Fuente = fuente;
                notas[index].Color = color;

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
                    try
                    {
                        Notas notascrear = new Notas(titulo, contenido, fecha, hora, fuente, color);

                        notas.Add(notascrear);
                        carpeta.notas.Add(notascrear);
                        lbdorn_notas.Items.Add(notascrear.Titulo);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error " + ex.Message);
                    }
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

        private ContextMenuStrip menu = new ContextMenuStrip();
        private ToolStripMenuItem menuItem1 = new ToolStripMenuItem();
        private ToolStripMenuItem menuItem2 = new ToolStripMenuItem();

        private void CrearMenu()
        {
            menuItem1.Text = "Eliminar nota";
            menuItem1.Click += MenuItem1_Click;
            menuItem2.Text = "Acerca de";
            menuItem2.Click += MenuItem2_Click;

            menu.Items.AddRange(new ToolStripItem[] { menuItem1, menuItem2 });
        }
        private void MenuItem1_Click(object sender, EventArgs e)
        {
            //Eliminar la nota que esta activa
            string nombreCarpeta = lbdorn_carpetas.SelectedItem.ToString();
            Carpetas carpeta = Carpetas.FirstOrDefault(c => c.nombre == nombreCarpeta);
            if (carpeta != null && lbdorn_notas.SelectedIndex != (-1))
            {
                List<Notas> notasCarpeta = carpeta.notas;
                Notas notaSeleccionada = notasCarpeta[lbdorn_notas.SelectedIndex];
                notasCarpeta.Remove(notaSeleccionada);
                lbdorn_notas.Items.Remove(notaSeleccionada.Titulo);
                txbnotas.Text = "";
                lbfecha.Text = "";
            }
        }

        private void MenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creado por: Daniel Octavio Ramirez Neri\nEstudiante de Ing. En sistemas computacionales \n Version 1.0.0");
         }



        private void btndorn_mas_Click(object sender, EventArgs e)
        {
            CrearMenu();
            menu.Show(Cursor.Position);
        }

        public Font cambiarFuente()
        {
            // Mostrar un cuadro de diálogo de selección de fuente
            FontDialog dialog = new FontDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                return dialog.Font;
            }
            return fuente;
        }

        private void btndorn_fuente_Click(object sender, EventArgs e)
        {

            txbnotas.Font = cambiarFuente();
        }

        private void btndorn_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
                txbnotas.ForeColor = color;
            }
        }
    }
}
