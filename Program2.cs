using System;

namespace Practica_06___Constructor__Colaboracion_y_Herencia
{
   
    // Crear una clase Contacto. Esta clase deberá tener los atributos "nombre, apellidos, telefono y direccion". 
    // También deberá tener un método "SetContacto", de tipo void y con los parámetros string, que permita cambiar el valor de los atributos. 
    // También tendrá un método "Saludar", que escribirá en pantalla "Hola, soy " seguido de sus datos. Crear también una clase llamada ProbarContacto. 
    // Esta clase deberá contener sólo la función Main, que creará dos objetos de tipo Contacto, les asignará los datos del contacto y les pedirá que saluden.
   
    public class Contacto
    {   
        private string nombre, apellidos, telefono, direccion;

        public void SetContacto(string nombre, string apellidos, string telefono, string direccion)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.direccion = direccion;
        }

        public void Saludar()
        {
            Console.WriteLine("\n" + "Hola, soy " + nombre + " " + apellidos + ", mi telefono es " + telefono + " y vivo en " + direccion);
        }

    }
   
    class ProbarContacto
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Contacto cont1 = new Contacto();
            cont1.SetContacto ("Juan", "Rodriguez Perez", "829-310-7158", "Yamasa, Carretera 56A No. 51 - 81");
            cont1.Saludar();

            Contacto cont2 = new Contacto();
            cont2.SetContacto ("Raul", "Ramirez del Rosario", "849-582-6547", "Cabo Nuevo No. 51 - 81");
            cont2.Saludar();

            Console.ReadKey();
        }
   }
}
