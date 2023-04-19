using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUnidad1
{
    public partial class portada : Form
    {
        public portada()
        {
            InitializeComponent();
           
            
        }

        private void portada_Load(object sender, EventArgs e)
        {
            
        }

        private void Iniciador_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
            Iniciador.Stop();
        }
    }
}
