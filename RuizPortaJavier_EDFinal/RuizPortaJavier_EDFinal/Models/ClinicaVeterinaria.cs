using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuizPortaJavier_EDFinal.Models
{
    class ClinicaVeterinaria
    {
        private IList listaAnimales;

        public ClinicaVeterinaria() {

            listaAnimales = new List<Animal>();

        }
        public void InsertarAnimal(Animal a) {

            listaAnimales.Add(a);

        }
        public Animal BuscaAnimal(string nombre) {
            Animal aux = null;

            foreach (Animal i in listaAnimales) {

                if (i.Nombre.Equals(nombre)) {
                    aux = i;
                        break;
                }

            }

            return aux;

        }

        public void ModificarComentarioAnimal(string nuevoComentario, string nombre) {

            Animal aux = BuscaAnimal(nombre);
            if (aux != null)
            {

                aux.Comentario = nuevoComentario;
            }
            else {
                throw new ArgumentException("No se encontro el animal");
            }

        }
        public void ModificarPeso(double nuevoPeso, string nombre)
        {

            Animal aux = BuscaAnimal(nombre);
            if (aux != null)
            {

                aux.Peso = nuevoPeso;
            }
            else {
                throw new ArgumentException("No se encontro el animal");
            }

        }

        internal void InsertarAnimal()
        {
            throw new NotImplementedException();
        }
    }
}
