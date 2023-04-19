using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUnidad1
{
    internal class Notas
    {

        private string titulo;
        private string contenido;
        private string fecha;
        private string hora;
        private Font fuente; // nuevo campo para la fuente
        private Color color;


        public Notas()
        {
            titulo = "";
            contenido = "";
            fecha = "";
            hora = "";
            fuente = SystemFonts.DefaultFont;
            color = Color.Black;
        }
        public Notas(string titulo, string contenido, string fecha, string hora, Font font, Color color )
        {
            this.titulo = titulo;
            this.contenido = contenido;
            this.fecha = fecha;
            this.hora = hora;
            this.fuente = font;
            this.color = color;

        }
        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }
        public string Contenido
        {
            get
            {
                return contenido;
            }
            set
            {
                contenido = value;
            }
        }
        public string Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }
        public string Hora
        {
            get
            {
                return hora;
            }
            set
            {
                hora = value;
            }
        }

        public Font Fuente
        {
            get
            {
                return fuente;
            }
            set
            {
                fuente = value;
            }
        }
        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        

       



    }
}
