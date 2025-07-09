using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arreglos
{
    public class Matriz_compras
    {
        int[,] matriz = new int[7, 7];
        string[] articulos = new string[] { "Chocosoda", "Oreo", "Pícaras", "Chocman", "Frac", "Tentación", "Gretel" };
        public void Lunes()
        {
            int galleta = 0;
            Random r = new Random();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("________Lunes________\n");
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < matriz.GetLength(0); i++) //lo que va dentro del getlength es la dimension se cuenta desde cero la posicion de los corchetes
            {
                //Console.Write(estudiantes[i] +": "); //esto si quieres ingresar nota
                //matriz[i, col] = int.Parse(Console.ReadLine()); //Igualar a la variable que indicara el numero de la columna
                int precio = r.Next(0, 201);
                Console.WriteLine(articulos[i] + ": " + precio);
                Thread.Sleep(500);
                matriz[i, galleta] = precio;
            }
        }
        public void GenerarT2()
        {
            int galleta = 1;
            Random r = new Random();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("________T2________\n");
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < matriz.GetLength(0); i++) //lo que va dentro del getlength es la dimension se cuenta desde cero la posicion de los corchetes
            {
                int precio = r.Next(0, 201);
                Console.WriteLine(articulos[i] + ": " + precio);
                Thread.Sleep(500);
                matriz[i, galleta] = precio;
            }
        }
        public void GenerarT3()
        {
            int galleta = 2;
            Random r = new Random();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("________T3________\n");
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < matriz.GetLength(0); i++) //lo que va dentro del getlength es la dimension se cuenta desde cero la posicion de los corchetes
            {
                int precio = r.Next(0, 201);
                Console.WriteLine(articulos[i] + ": " + precio);
                Thread.Sleep(500);
                matriz[i, galleta] = precio;
            }
        }
        public void GenerarEF()
        {
            int galleta = 3;
            Random r = new Random();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("________EF________\n");
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < matriz.GetLength(0); i++) //lo que va dentro del getlength es la dimension se cuenta desde cero la posicion de los corchetes
            {
                int precio = r.Next(0, 201);
                Console.WriteLine(articulos[i] + ": " + precio);
                Thread.Sleep(500);
                matriz[i, galleta] = precio;
            }
        }
        public void Registro()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{"Galletas compradas (semanal)",-30}{"Lunes",5}{"Martes",5}{"Miércoles",5}{"Jueves",5}{"Viernes",5}{"Sábado",5}{"Domingo",5}");
            Console.ResetColor();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write($"{articulos[i],-30}");

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j],5}");
                }

                Console.WriteLine();
            }
        }
}
