using System;

class PrimerParcial
{
    static void Main(string[] args)
    {
        double Altura, Radio, Area, Base, Volumen;  // definimos variables inputs y outpus
        int Contador = 0;  //iniciamos el contandor de ciclos en 
        int Finalizar = 0;  // definimos una variable auxiliar para controlar cuando el usuario quiere cerrar el programa

        while (Finalizar == 0)
        {
            Console.WriteLine("Ingrese la altura del cilindro (0 para salir):");   //ingreso de inputs y chequeo de positividad
            while (!double.TryParse(Console.ReadLine(), out Altura) || Altura < 0)
            {
                Console.WriteLine("La altura debe ser un valor numérico mayor a 0. Por favor, ingrésela nuevamente:");
            }

            Console.WriteLine("Ingrese el radio del cilindro (0 para salir):"); //ingreso de inputs y chequeo de positividad
            while (!double.TryParse(Console.ReadLine(), out Radio) || Radio < 0)
            {
                Console.WriteLine("El radio debe ser un valor numérico mayor a 0. Por favor, ingréselo nuevamente:");
            }

            if (Radio == 0 && Altura == 0) // revisamos si el usuario quiere cerrar el programa
            {
                Console.WriteLine("Programa finalizado.");
                Finalizar = 1;
            }

            if (Finalizar == 0)
            {
                Base = 3.1416 * Math.Pow(Radio, 2);  //calculo 
                Area = 2 * 3.1416 * Radio * (Altura + Radio); //calculo
                Volumen = Base * Altura; //calculo

                Console.WriteLine("El área del cilindro es: " + Area);  //informamos output
                Console.WriteLine("El volumen del cilindro es: " + Volumen);  //informamos output

                Contador++; //aumentamos el contador en 1
            }
        }

        Console.WriteLine("Cantidad de cálculos realizados: " + Contador);
    }
}