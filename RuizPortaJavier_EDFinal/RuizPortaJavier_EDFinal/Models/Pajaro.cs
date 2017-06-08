using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuizPortaJavier_EDFinal.Models
{
    class Pajaro:Animal
    {
        private string especie;
        private string cantor;

        public Pajaro(string nombre, string especie, string fechaNacimiento, double peso, string cantor, string comentario):base(nombre,fechaNacimiento,peso,comentario) {

            this.especie = especie;
            this.cantor = cantor;

        }

        public override string ToString()
        {
            return "Ficha de Perro \n" + "Nombre: " + this.nombre + "\nespecie: " + this.especie + "\nFecha de Nacimiento: " + this.fechaNacimiento + "\nPeso: " + this.peso + " kg\nCantor: " + this.cantor + "\nComentarios: " + this.comentario;
        }
    }
}
