using System;

namespace SecondProgram
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Console.WriteLine("NUMERO DE PULSACIONES");
            char sexo ='o';
            int pulsaciones = 0;
            int edad;

            Console.Write("Ingrese su edad :");
            edad = int.Parse(Console.ReadLine());

            Console.Write("Seleccione su sexo (M OR F) :");
            sexo = char.Parse(Console.ReadLine());

            if (sexo== 'M'|| sexo== 'm')
            {
                pulsaciones = (210 - edad) / 10;
            }
            else if (sexo == 'F' || sexo == 'f')
            {
                pulsaciones = (220 - edad) / 10;
            }
            else
            {
                Console.WriteLine("Seleccion erronea intentelo nuevamente");
            }

            Console.WriteLine("Pulsaciones {0} por cada 10 segundos", pulsaciones);
            Console.ReadKey();

        }
    }
}
