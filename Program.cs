using System;

namespace Ejer4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos estudiantes quieres calificar?");
            int numEstudiantes = int.Parse(Console.ReadLine());
            string[] nombres = new string[numEstudiantes];
            int[] nota1 = new int[numEstudiantes];
            int[] nota2 = new int[numEstudiantes];

            for (int i = 0; i < numEstudiantes; i++)
            {
                Console.WriteLine("Nombre del estudiante:");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("Nota 1:");
                nota1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Nota 2:");
                nota2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            int suma = 0;
            for (int i = 0; i < numEstudiantes; i++)
            {
                int promedio = (nota1[i] + nota2[i]) / 2;
                Console.WriteLine("Nombre: " + nombres[i]);
                Console.WriteLine("Nota 1: " + nota1[i]);
                Console.WriteLine("Nota 2: " + nota2[i]);
                Console.WriteLine("Promedio: " + promedio);
                suma += promedio;
            }

            Console.WriteLine("Suma Total: " + suma);
            Console.WriteLine("Media Aritmética: " + suma / numEstudiantes);

            Console.ReadKey();
        }
    }
}





