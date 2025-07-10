using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Arreglos;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //cargue pantalla completa
            Matriz_compras funciones = new Matriz_compras();

            if (funciones.totalarticulos())
            {
                Console.WriteLine("\n ----------------------- C A R G A N D O ---------------------------");
                funciones.Lunes();
                Thread.Sleep(50); //para que no se repita
                funciones.Martes();
                Thread.Sleep(50);
                funciones.Miercoles();
                Thread.Sleep(50);
                funciones.Jueves();
                Thread.Sleep(50);
                funciones.Viernes();
                Thread.Sleep(50);
                funciones.Sabado();
                Thread.Sleep(50);
                funciones.Domingo();
                Thread.Sleep(50);
                Console.Clear();
                Console.WriteLine();
                funciones.Matriz();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("----------------------------PULSE ENTER PARA CONTINUAR----------------------------");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                funciones.Estadisticas();
                funciones.Mostrarstats();
            }
            else
            {
                return;
            }
        }
    }
}
