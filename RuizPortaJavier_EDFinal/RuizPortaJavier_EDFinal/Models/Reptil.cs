using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuizPortaJavier_EDFinal.Models
{
    class Reptil:Animal
    {
        private string especie;
        private string venenoso;

        public Reptil(string nombre, string especie, string fechaNacimiento, double peso, string venenoso, string comentario):base(nombre,fechaNacimiento,peso,comentario) {

            this.especie = especie;
            this.venenoso = venenoso;

        }

        public override string ToString()
        {
            return "Ficha de Perro \n" + "Nombre: " + this.nombre + "\nEspecie: " + this.especie + "\nFecha de Nacimiento: " + this.fechaNacimiento + "\nPeso: " + this.peso + " kg\nVenenoso: " + this.venenoso + "\nComentarios: " + this.comentario;
        }
    }
}
