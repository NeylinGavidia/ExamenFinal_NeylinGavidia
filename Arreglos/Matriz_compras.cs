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
                int precio = r.Next(20, 201);
                Console.WriteLine(articulos[i] + ": " + precio);
                Thread.Sleep(500);
                matriz[i, galleta] = precio;
            }
        }
        public void Martes()
        {
            int galleta = 1;
            Random r = new Random();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("________Martes________\n");
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < matriz.GetLength(0); i++) //lo que va dentro del getlength es la dimension se cuenta desde cero la posicion de los corchetes
            {
                int precio = r.Next(20, 201);
                Console.WriteLine(articulos[i] + ": " + precio);
                Thread.Sleep(500);
                matriz[i, galleta] = precio;
            }
        }
        public void Miercoles()
        {
            int galleta = 2;
            Random r = new Random();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("________Miercoles________\n");
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < matriz.GetLength(0); i++) //lo que va dentro del getlength es la dimension se cuenta desde cero la posicion de los corchetes
            {
                int precio = r.Next(20, 201);
                Console.WriteLine(articulos[i] + ": " + precio);
                Thread.Sleep(500);
                matriz[i, galleta] = precio;
            }
        }
        public void Jueves()
        {
            int galleta = 3;
            Random r = new Random();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("________Jueves________\n");
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < matriz.GetLength(0); i++) //lo que va dentro del getlength es la dimension se cuenta desde cero la posicion de los corchetes
            {
                int precio = r.Next(20, 201);
                Console.WriteLine(articulos[i] + ": " + precio);
                Thread.Sleep(500);
                matriz[i, galleta] = precio;
            }
        }
        public void Viernes()
        {
            int galleta = 4;
            Random r = new Random();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("________Viernes________\n");
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < matriz.GetLength(0); i++) //lo que va dentro del getlength es la dimension se cuenta desde cero la posicion de los corchetes
            {
                int precio = r.Next(20, 201);
                Console.WriteLine(articulos[i] + ": " + precio);
                Thread.Sleep(500);
                matriz[i, galleta] = precio;
            }
        }
        public void Sabado()
        {
            int galleta = 5;
            Random r = new Random();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("________Sábado________\n");
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < matriz.GetLength(0); i++) //lo que va dentro del getlength es la dimension se cuenta desde cero la posicion de los corchetes
            {
                int precio = r.Next(20, 201);
                Console.WriteLine(articulos[i] + ": " + precio);
                Thread.Sleep(500);
                matriz[i, galleta] = precio;
            }
        }
        public void Domingo()
        {
            int galleta = 6;
            Random r = new Random();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("________Domingo________\n");
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < matriz.GetLength(0); i++) //lo que va dentro del getlength es la dimension se cuenta desde cero la posicion de los corchetes
            {
                int precio = r.Next(20, 201);
                Console.WriteLine(articulos[i] + ": " + precio);
                Thread.Sleep(500);
                matriz[i, galleta] = precio;
            }
        }
        public void Matriz()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{"Galletas compradas (semanal)",-40}{"Lunes",10}{"Martes",10}{"Miércoles",11}{"Jueves",10}{"Viernes",10}{"Sábado",10}{"Domingo",10}{"Total por galleta",20}");
            Console.ResetColor();
            //"Chocosoda", "Oreo", "Pícaras", "Chocman", "Frac", "Tentación", "Gretel"
            int SumaGa = 1000;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write($"{articulos[i],-40}");

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j],10}");
                    
                }
                //arreglar para que esto sume por galletas
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{SumaGa,15}");
                Console.WriteLine();
                Console.ResetColor();

            }
            //corregir sumas (suma por diar)
            int sumaL = 1000;
            int sumaMa = 1000;
            int sumaMi = 1000;
            int sumaJ = 1000;
            int sumaV = 1000;
            int sumaS = 1000;
            int sumaD = 1000;
            int sumaTotal = 7000;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"{"Ventas totales (semanal)",-40}{sumaL,10}{sumaMa,10}{sumaMi,11}{sumaJ,10}{sumaV,10}{sumaS,10}{sumaD,10}");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{sumaTotal,15}");
            Console.ResetColor();
        }
    }
}
