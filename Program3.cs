using System;

namespace Practica_06___Constructor__Colaboracion_y_Herencia
{
   
    // Crear tres clases ClaseA, ClaseB, ClaseC que ClaseB herede de ClaseA y ClaseC herede de ClaseB. 
    // Definir un constructor a cada clase que muestre un mensaje. Luego definir un objeto de la clase ClaseC.
   
    public class ClaseA
    {   
        public ClaseA()
        {
            Console.WriteLine("\n" + "Este mensaje es de la Clase A");
        }
    }

    public class ClaseB : ClaseA
    {
        public ClaseB()
        {
            Console.WriteLine("\n" + "Este mensaje es de la Clase B");
        }
    }
   
    class ClaseC : ClaseB
    {
       
       public ClaseC()
       {
           Console.WriteLine("\n" + "Este mensaje es de la Clase C");
       }
       static void Main(string[] args)
        {
            Console.Clear();

            ClaseC imprimir = new ClaseC();

            Console.ReadKey();
        }
   }
}
