using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuizPortaJavier_EDFinal.Models
{
    class Gato:Animal
    {
        private string raza;
        private string microchip;

        public Gato(string nombre, string raza, string fechaNacimiento, double peso, string microchip, string comentario):base(nombre,fechaNacimiento,peso,comentario) {

            this.raza = raza;
            this.microchip = microchip;

        }

        public override string ToString()
        {
            return "Ficha de Perro \n" + "Nombre: " + this.nombre + "\nRaza: " + this.raza + "\nFecha de Nacimiento: " + this.fechaNacimiento + "\nPeso: " + this.peso + " kg\nMicrochip: " + this.microchip + "\nComentarios: " + this.comentario;
        }

    }
}
