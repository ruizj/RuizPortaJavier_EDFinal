using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RuizPortaJavier_EDFinal.Models;

namespace RuizPortaJavier_EDFinal
{
    class Program
    {
        private static ClinicaVeterinaria cv;

        static void Main(string[] args)
        {
            cv = new ClinicaVeterinaria();
            double nuevoPeso = 0.0;
            string nuevoComentario = "";
           string venenoso;
            string cantor;
            string especie;
            string aux = "";
            bool esCorrecto = false;
            int seleccion = 0;
            string nombre = "";
            string raza = "";
            string fechaNacimiento = "";
            double peso = 0.0;
            string microchip = "";
            string comentario = "";



            do
            {
                Console.WriteLine("------------------------Seleccione una Opcion--------------------------");
                Console.WriteLine("1.Añadir animales");
                Console.WriteLine("2.Modificar los comentarios");
                Console.WriteLine("3.Pesar animal");
                Console.WriteLine("4.Mostrar Ficha Animal");
                Console.WriteLine("-----------------------Teclado Numerico--------------------------------");
                aux = Console.ReadLine();

                esCorrecto = Int32.TryParse(aux, out seleccion);

                if (esCorrecto)
                {

                    if (seleccion >= 1 && seleccion <= 4)
                    {

                        esCorrecto = true;

                    }
                    else {

                        esCorrecto = false;
                        throw new ArgumentException("No se introdujo un numero entre 1 y 4");
                    }

                }


            } while (!esCorrecto);


            switch (seleccion) {

                case 1:

                    do {
                        Console.Clear();
                        Console.WriteLine("------------------------------Seleccione Tipo de Animal----------------");
                        Console.WriteLine("1.Perro");
                        Console.WriteLine("2.Gato");
                        Console.WriteLine("3.Pajaro");
                        Console.WriteLine("4.Reptil");
                        Console.WriteLine("-----------------------------Teclado Numerico--------------------------");
                        aux = Console.ReadLine();

                        esCorrecto = Int32.TryParse(aux, out seleccion);
                        if (esCorrecto)
                        {

                            if (seleccion >= 1 && seleccion <= 4)
                            {

                                esCorrecto = true;

                            }
                            else {

                                esCorrecto = false;
                                throw new ArgumentException("No se introdujo un numero entre 1 y 4");
                            }

                        }


                    } while (!esCorrecto);
                    if (seleccion == 1)
                    {
                        do
                        {

                            Console.WriteLine("Nombre:");
                            nombre = Console.ReadLine();
                            if (!nombre.Equals(""))
                            {
                                esCorrecto = true;
                            }
                            else
                            {
                                esCorrecto = false;
                                throw new ArgumentNullException("El nombre no puede estar vacio");
                            }
                        } while (!esCorrecto);

                        do
                        {
                            Console.WriteLine("Raza: ");
                            raza = Console.ReadLine();

                            if (!raza.Equals(""))
                            {

                                esCorrecto = true;
                            }
                            else
                            {
                                esCorrecto = false;
                                throw new ArgumentNullException("La raza no puede estar vacio");

                            }


                        } while (!esCorrecto);
                        do
                        {
                            Console.WriteLine("Fecha de Nacimiento: ");
                            fechaNacimiento = Console.ReadLine();

                            if (!fechaNacimiento.Equals(""))
                            {

                                esCorrecto = true;
                            }
                            else
                            {
                                esCorrecto = false;
                                throw new ArgumentNullException("La fecha de nacimiento no puede estar vacio");

                            }


                        } while (!esCorrecto);
                        do
                        {
                            Console.WriteLine("Peso: ");
                            aux = Console.ReadLine();
                            esCorrecto = Double.TryParse(aux, out peso);
                            if (esCorrecto)
                            {
                                if (peso > 0)
                                {

                                    esCorrecto = true;
                                }
                                else
                                {
                                    esCorrecto = false;
                                    throw new ArgumentNullException("El Peso no puede ser inferior a 0");

                                }
                            }
                            else {

                                throw new ArgumentException("No pusistes un numero");
                            }


                        } while (!esCorrecto);
                        do
                        {
                            Console.WriteLine("Microchips: ");
                            microchip = Console.ReadLine();

                            if (!microchip.Equals(""))
                            {

                                esCorrecto = true;
                            }
                            else
                            {
                                esCorrecto = false;
                                throw new ArgumentNullException("El microchip no puede estar vacio");

                            }


                        } while (!esCorrecto);
                        do
                        {
                            Console.WriteLine("Comentario: ");
                            comentario = Console.ReadLine();

                            if (!comentario.Equals(""))
                            {

                                esCorrecto = true;
                            }
                            else
                            {
                                esCorrecto = false;
                                throw new ArgumentNullException("La fecha de nacimiento no puede estar vacio");

                            }


                        } while (!esCorrecto);

                        Animal perro = new Perro(nombre, raza, fechaNacimiento, peso, microchip, comentario);
                        cv.InsertarAnimal(perro);
                    }
                    else if (seleccion == 2)
                    {
                        do
                        {

                            Console.WriteLine("Nombre:");
                            nombre = Console.ReadLine();
                            if (!nombre.Equals(""))
                            {
                                esCorrecto = true;
                            }
                            else
                            {
                                esCorrecto = false;
                                throw new ArgumentNullException("El nombre no puede estar vacio");
                            }
                        } while (!esCorrecto);

                        do
                        {
                            Console.WriteLine("Raza: ");
                            raza = Console.ReadLine();

                            if (!raza.Equals(""))
                            {

                                esCorrecto = true;
                            }
                            else
                            {
                                esCorrecto = false;
                                throw new ArgumentNullException("La raza no puede estar vacio");

                            }


                        } while (!esCorrecto);
                        do
                        {
                            Console.WriteLine("Fecha de Nacimiento: ");
                            fechaNacimiento = Console.ReadLine();

                            if (!fechaNacimiento.Equals(""))
                            {

                                esCorrecto = true;
                            }
                            else
                            {
                                esCorrecto = false;
                                throw new ArgumentNullException("La fecha de nacimiento no puede estar vacio");

                            }


                        } while (!esCorrecto);
                        do
                        {
                            Console.WriteLine("Peso: ");
                            aux = Console.ReadLine();
                            esCorrecto = Double.TryParse(aux, out peso);
                            if (esCorrecto)
                            {
                                if (peso > 0)
                                {

                                    esCorrecto = true;
                                }
                                else
                                {
                                    esCorrecto = false;
                                    throw new ArgumentNullException("El Peso no puede ser inferior a 0");

                                }
                            }
                            else {

                                throw new ArgumentException("No pusistes un numero");
                            }


                        } while (!esCorrecto);
                        do
                        {
                            Console.WriteLine("Microchips: ");
                            microchip = Console.ReadLine();

                            if (!microchip.Equals(""))
                            {

                                esCorrecto = true;
                            }
                            else
                            {
                                esCorrecto = false;
                                throw new ArgumentNullException("El microchip no puede estar vacio");

                            }


                        } while (!esCorrecto);
                        do
                        {
                            Console.WriteLine("Comentario: ");
                            comentario = Console.ReadLine();

                            if (!comentario.Equals(""))
                            {

                                esCorrecto = true;
                            }
                            else
                            {
                                esCorrecto = false;
                                throw new ArgumentNullException("La fecha de nacimiento no puede estar vacio");

                            }


                        } while (!esCorrecto);
                        Animal gato = new Gato(nombre, raza, fechaNacimiento, peso, microchip, comentario);

                        cv.InsertarAnimal(gato);

                    }
                    else if (seleccion == 3)
                    {
                        do
                        {

                            Console.WriteLine("Nombre:");
                            nombre = Console.ReadLine();
                            if (!nombre.Equals(""))
                            {
                                esCorrecto = true;
                            }
                            else
                            {
                                esCorrecto = false;
                                throw new ArgumentNullException("El nombre no puede estar vacio");
                            }
                        } while (!esCorrecto);

                        do
                        {
                            Console.WriteLine("Especie: ");
                            especie = Console.ReadLine();

                            if (!especie.Equals(""))
                            {

                                esCorrecto = true;
                            }
                            else
                            {
                                esCorrecto = false;
                                throw new ArgumentNullException("La raza no puede estar vacio");

                            }


                        } while (!esCorrecto);
                        do
                        {
                            Console.WriteLine("Fecha de Nacimiento: ");
                            fechaNacimiento = Console.ReadLine();

                            if (!fechaNacimiento.Equals(""))
                            {

                                esCorrecto = true;
                            }
                            else
                            {
                                esCorrecto = false;
                                throw new ArgumentNullException("La fecha de nacimiento no puede estar vacio");

                            }


                        } while (!esCorrecto);
                        do
                        {
                            Console.WriteLine("Peso: ");
                            aux = Console.ReadLine();
                            esCorrecto = Double.TryParse(aux, out peso);
                            if (esCorrecto)
                            {
                                if (peso > 0)
                                {

                                    esCorrecto = true;
                                }
                                else
                                {
                                    esCorrecto = false;
                                    throw new ArgumentNullException("El Peso no puede ser inferior a 0");

                                }
                            }
                            else {

                                throw new ArgumentException("No pusistes un numero");
                            }


                        } while (!esCorrecto);
                        do
                        {
                            Console.WriteLine("Cantor: ");
                            cantor = Console.ReadLine();

                            if (cantor.Equals("si") || cantor.Equals("Si") || cantor.Equals("No") || cantor.Equals("no"))
                            {

                                esCorrecto = true;
                            }
                            else
                            {
                                esCorrecto = false;
                                throw new ArgumentNullException("No has dicho si o no");

                            }


                        } while (!esCorrecto);
                        do
                        {
                            Console.WriteLine("Comentario: ");
                            comentario = Console.ReadLine();

                            if (!comentario.Equals(""))
                            {

                                esCorrecto = true;
                            }
                            else
                            {
                                esCorrecto = false;
                                throw new ArgumentNullException("La fecha de nacimiento no puede estar vacio");

                            }


                        } while (!esCorrecto);

                        Animal pajaro = new Pajaro(nombre, especie, fechaNacimiento, peso, cantor, comentario);
                        cv.InsertarAnimal(pajaro);

                    }
                    else if (seleccion == 4) {
                        do
                        {

                            Console.WriteLine("Nombre:");
                            nombre = Console.ReadLine();
                            if (!nombre.Equals(""))
                            {
                                esCorrecto = true;
                            }
                            else
                            {
                                esCorrecto = false;
                                throw new ArgumentNullException("El nombre no puede estar vacio");
                            }
                        } while (!esCorrecto);

                        do
                        {
                            Console.WriteLine("Especie: ");
                            especie = Console.ReadLine();

                            if (!especie.Equals(""))
                            {

                                esCorrecto = true;
                            }
                            else
                            {
                                esCorrecto = false;
                                throw new ArgumentNullException("La raza no puede estar vacio");

                            }


                        } while (!esCorrecto);
                        do
                        {
                            Console.WriteLine("Fecha de Nacimiento: ");
                            fechaNacimiento = Console.ReadLine();

                            if (!fechaNacimiento.Equals(""))
                            {

                                esCorrecto = true;
                            }
                            else
                            {
                                esCorrecto = false;
                                throw new ArgumentNullException("La fecha de nacimiento no puede estar vacio");

                            }


                        } while (!esCorrecto);
                        do
                        {
                            Console.WriteLine("Peso: ");
                            aux = Console.ReadLine();
                            esCorrecto = Double.TryParse(aux, out peso);
                            if (esCorrecto)
                            {
                                if (peso > 0)
                                {

                                    esCorrecto = true;
                                }
                                else
                                {
                                    esCorrecto = false;
                                    throw new ArgumentNullException("El Peso no puede ser inferior a 0");

                                }
                            }
                            else {

                                throw new ArgumentException("No pusistes un numero");
                            }


                        } while (!esCorrecto);
                        do
                        {
                            Console.WriteLine("Venenosos: ");
                            venenoso = Console.ReadLine();

                            if (venenoso.Equals("si") || venenoso.Equals("Si") || venenoso.Equals("No") || venenoso.Equals("no"))
                            {

                                esCorrecto = true;
                            }
                            else
                            {
                                esCorrecto = false;
                                throw new ArgumentNullException("No has dicho si o no");

                            }


                        } while (!esCorrecto);
                        do
                        {
                            Console.WriteLine("Comentario: ");
                            comentario = Console.ReadLine();

                            if (!comentario.Equals(""))
                            {

                                esCorrecto = true;
                            }
                            else
                            {
                                esCorrecto = false;
                                throw new ArgumentNullException("La fecha de nacimiento no puede estar vacio");

                            }


                        } while (!esCorrecto);

                        Animal reptil = new Reptil(nombre, especie, fechaNacimiento, peso, venenoso, comentario);
                        cv.InsertarAnimal(reptil);

                    }
                    break;

                case 2:
                    
                        Console.Clear();
                        Console.WriteLine("Introduzca el nombre del animal");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Introduzca el nuevo comentario:");
                    nuevoComentario = Console.ReadLine();
                   


                    

                    cv.ModificarComentarioAnimal(nuevoComentario,nombre);

                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Introduzca el nombre del animal");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Introduzca el nuevo peso:");
                    aux = Console.ReadLine();
                    esCorrecto = Double.TryParse(aux, out peso);

                    cv.ModificarPeso(nuevoPeso, nombre);

                    break;
                case 4:
                    Console.WriteLine("Introduzca el nombre del animal para ver su ficha");
                    nombre = Console.ReadLine();

                    cv.BuscaAnimal(nombre);


                    break;





            }


        }
    }
}
