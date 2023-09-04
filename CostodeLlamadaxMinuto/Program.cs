using System;

namespace LlamadasxMinutos
{
    class progam
    {
        static void Main(string[] args)
        {
            bool finalizar = false;
            while (!finalizar)
            {
                Console.WriteLine("Elegir una opcion: ");
                Console.WriteLine("1. Calcular el costo de la llamada por minuto. ");
                Console.WriteLine("2. Finalizar el programa. ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        costoLlamada();
                        break;

                    case 2:
                        finalizar = true;
                        break;

                    default:
                        Console.WriteLine("Ingreso una opcion no valida");
                        break;
                }
            }
        }
        static void costoLlamada()
        {
            Console.WriteLine("Ingrese la clave (numero) segun la zona: ");
            Console.WriteLine("12 (America norte), 15 (America Central), 18 (America del Sur), 19 (Europa), 23 (Asia).");
            int clave = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("¿Cuantos minutos duro la llamda?: ");
            int minutos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double costo = 0;

            switch (clave)
            {
                case 12: costo = minutos * 2;
                    Console.WriteLine($"El costo de la llamada para America Norte es: {costo:C}");
                    break;

                case 15: costo = minutos * 2.2;
                    Console.WriteLine($"El costo de la llamada para America Central es: {costo:C}");
                    break;

                case 18: costo = minutos * 4.5;
                    Console.WriteLine($"El costo de la llamada para America del Sur es: {costo:C}");
                    break;

                case 19: costo = minutos * 3.5;
                    Console.WriteLine($"El costo de la llamada para Europa es: {costo:C}");
                    break;

                case 23: costo = minutos * 6;
                    Console.WriteLine($"El costo de la llamda para Asia es: {costo:C}");
                    break;

                default: Console.WriteLine("El dato ingresado es incorrecto: ");
                    break;
            }

        }
    }
}
