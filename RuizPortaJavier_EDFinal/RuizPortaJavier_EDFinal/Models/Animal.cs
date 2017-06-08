using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuizPortaJavier_EDFinal.Models
{
    class Animal : Ipesable
    {
        protected string nombre;
        protected string fechaNacimiento;
        protected double peso;
        protected string comentario;


        public Animal(string nombre, string fechaNacimiento, double peso, string comentario) {

            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.peso = peso;
            this.comentario = comentario;

        }


        public string Nombre
        {
            get { return nombre; }
            set { }

        }
        public string FechaNacimiento {

            get { return fechaNacimiento; }
            set { }
            }

        public double Peso
        {
            get { return peso; }
            set { }
        }
        public string Comentario {
            get { return comentario; }
            set { }
        }




    }
}
