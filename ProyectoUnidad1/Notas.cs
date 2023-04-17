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

        public Notas()
        {
            titulo = "";
            contenido = "";
            fecha = "";
            hora = "";
        }
        public Notas(string titulo, string contenido, string fecha, string hora)
        {
            this.titulo = titulo;
            this.contenido = contenido;
            this.fecha = fecha;
            this.hora = hora;
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
        public void crearNota()
        {
            List<string> notas = new List<string>();

            string titulo = this.titulo;
            string contenido = this.contenido;
            string fecha = this.fecha;
            string hora = this.hora;
                
            notas.Add(titulo);
            notas.Add(contenido);
            notas.Add(fecha);
            notas.Add(hora);



        }
        public void eliminarNota()
        {
           List<string> notas = new List<string>();
            string titulo = this.titulo;
            string contenido = this.contenido;
            string fecha = this.fecha;
            string hora = this.hora;
                
            notas.Remove(titulo);
            notas.Remove(contenido);
            notas.Remove(fecha);
            notas.Remove(hora);
        }
        public void mostrarNota()
        {


            
            
        }



    }
}
