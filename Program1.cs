using System;

namespace Practica_06___Constructor__Colaboracion_y_Herencia
{
   
   // Crear una clase Persona que tenga como atributos el "cedula, nombre, apellido y la edad 
   // (definir las propiedades para poder acceder a dichos atributos)". Definir como responsabilidad un método para mostrar ó imprimir. 
   // Crear una segunda clase Profesor que herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el método para imprimir su sueldo. 
   // Definir un objeto de la clase Persona y llamar a sus métodos y propiedades. También crear un objeto de la clase Profesor y llamar a sus métodos y 
   // propiedades.
   
    public class Persona
    {   
        protected string cedula;
        protected int edad; 
        public string Cedula
        {
            set
            {
                cedula = value;
            }
            get
            {
                return cedula;
            }
        }
        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }

        protected string nombre, apellido;
        public string Nombre
        {
            set 
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public string Apellido
        {
            set
            {
                apellido = value;
            }
            get
            {
                return apellido;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("La Cedula es: " + Cedula);
            Console.WriteLine("El Nombre es: " + Nombre);
            Console.WriteLine("El Apellido es: " + Apellido);
            Console.WriteLine("La Edad es: " + Edad);
        }
    }
   
    class Profesor: Persona
    {
        private int sueldo;
        public  int Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }

        public void imprimir1()
        {
            Console.WriteLine("El Sueldo es: " + Sueldo);
        }

        static void Main(string[] args)
        {
            Console.Clear();
            Profesor profesor1 = new Profesor();
            profesor1.Cedula = "402-3794707-8";
            profesor1.Nombre = "Moises ";
            profesor1.Apellido = "Nuñez del Rosario";
            profesor1.Edad = 19;
            profesor1.Sueldo = 45000;

            profesor1.Imprimir();
            profesor1.imprimir1();
            Console.ReadKey();
        }
   }
}
