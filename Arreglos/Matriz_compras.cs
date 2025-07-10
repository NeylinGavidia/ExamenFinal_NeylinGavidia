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
        int[,] matriz;
        string[] articulos = new string[] { "Chocosoda", "Oreo", "Pícaras", "Chocman", "Frac", "Tentación", "Gretel" };
        int[,] maxmin;
        double[,] promedio;
        int fil;
        public bool totalarticulos() //esto se uso en la T3, en el juego 1
        {
            int col = 7;
            bool def = false;
            do
            {
                Console.WriteLine("Ingresa el número de artículos que desea revisar (ventas semanales)");
                Console.WriteLine("*Recuerde que el orden de los artículos es: Chocosoda, Oreo, Pícaras, Chocman, Frac, Tentación, Gretel\n");

                fil = int.Parse(Console.ReadLine());

                if (fil <= 0 || fil > articulos.Length)
                {
                    Console.WriteLine("Has ingresado más artículos que los disponibles o un valor no válido. Intente nuevamente.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else
                {
                    matriz = new int[fil, col];
                    maxmin = new int[fil, 2];
                    promedio = new double[fil, 1];
                    def = true;
                }
            }
            while (def == false); //tambien podría ser !def

            return def;
        }

        public void Lunes()
        {
            int galleta = 0;
            Random r = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++) //lo que va dentro del getlength es la dimension se cuenta desde cero la posicion de los corchetes
            {
                int cantidad = r.Next(20, 201);
                matriz[i, galleta] = cantidad;
            }
        }
        public void Martes()
        {
            int galleta = 1;
            Random r = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++) //lo que va dentro del getlength es la dimension se cuenta desde cero la posicion de los corchetes
            {
                int cantidad = r.Next(20, 201);
                matriz[i, galleta] = cantidad;
            }
        }
        public void Miercoles()
        {
            int galleta = 2;
            Random r = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++) //lo que va dentro del getlength es la dimension se cuenta desde cero la posicion de los corchetes
            {
                int cantidad = r.Next(20, 201);
                matriz[i, galleta] = cantidad;
            }
        }
        public void Jueves()
        {
            int galleta = 3;
            Random r = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++) //lo que va dentro del getlength es la dimension se cuenta desde cero la posicion de los corchetes
            {
                int cantidad = r.Next(20, 201);
                matriz[i, galleta] = cantidad;
            }
        }
        public void Viernes()
        {
            int galleta = 4;
            Random r = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++) //lo que va dentro del getlength es la dimension se cuenta desde cero la posicion de los corchetes
            {
                int cantidad = r.Next(20, 201);
                matriz[i, galleta] = cantidad;
            }
        }
        public void Sabado()
        {
            int galleta = 5;
            Random r = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++) //lo que va dentro del getlength es la dimension se cuenta desde cero la posicion de los corchetes
            {
                int cantidad = r.Next(20, 201);
                matriz[i, galleta] = cantidad;
            }
        }
        public void Domingo()
        {
            int galleta = 6;
            Random r = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++) //lo que va dentro del getlength es la dimension se cuenta desde cero la posicion de los corchetes
            {
                int cantidad = r.Next(20, 201);
                matriz[i, galleta] = cantidad;
            }
        }
        public void Matriz()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{"Galletas compradas (semanal)",-40}{"Lunes",10}{"Martes",10}{"Miércoles",11}{"Jueves",10}{"Viernes",10}{"Sábado",10}{"Domingo",10}{"Total por galleta",20}");
            Console.ResetColor();
            //"Chocosoda", "Oreo", "Pícaras", "Chocman", "Frac", "Tentación", "Gretel"

            int[] sumaDias = new int[matriz.GetLength(1)];
            int sumaTotal = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write($"{articulos[i],-40}");

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j],10}");
                }
                int sumaGa = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    sumaGa += matriz[i, j]; // Sumar las compras de la galleta
                    sumaDias[j] += matriz[i, j];
                    sumaTotal += matriz[i, j];
                }
                //arreglar para que esto sume por galletas
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{sumaGa,15}");
                Console.WriteLine();
                Console.ResetColor();

            }
            //corregir sumas (suma por diar)
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"{"Ventas totales (semanal)",-40}");
            for (int j = 0; j < sumaDias.Length; j++)
            {
                Console.Write($"{sumaDias[j],10}");
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{sumaTotal,15}");
            Console.ResetColor();
        }
        public void Estadisticas()
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int min = matriz[i, 0];
                int max = matriz[i, 0];
                int suma = 0;

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    int valor = matriz[i, j];
                    if (valor < min)
                    {
                        min = valor;
                    }
                    if (valor > max)
                    {
                        max = valor;
                    }
                    suma += valor;
                }

                maxmin[i, 0] = min;
                maxmin[i, 1] = max;

                promedio[i, 0] = (double)suma / 7;
            }
        }
        public void Mostrarstats()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{"Artículo",-15}{"Mínimo",10}{"Máximo",10}{"Promedio Total",20}");
            Console.ResetColor();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                string titulo = articulos[i];
                Console.WriteLine($"{titulo,-15}{maxmin[i, 0],10}{maxmin[i, 1],10}{promedio[i, 0],15:F2}"); //para solo mostrar 2 decimales, en inter aparecio
            }
        }
    }
}
