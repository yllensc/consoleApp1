using System;
using System.Collections.Generic;

namespace consoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool continuar = true;
            //tablero 
            int filas = 8;
            int columnas = 8;
            int[,] tablero = new int[filas, columnas];

            //posición actual del caballo
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Bienvenid@, te recordamos los posibles movimientos de tu caballo 🎠 jiji");

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Ingresa la posición del caballo (ej: d4): ");
                string posicion = Console.ReadLine().ToLower();

                if (posicion.Length != 2 || !char.IsLetter(posicion[0]) || !char.IsDigit(posicion[1]))
                {
                    Console.WriteLine("Entrada inválida. Digita la posición como el ejemplo ('d4') ");
                    return;
                }
                int pCol = posicion[0] - 'a';
                int pFila = int.Parse(posicion[1].ToString()) - 1;

                int[] movFil = { 2, 1, -1, -2, -2, -1, 1, 2 };
                int[] movCol = { 1, 2, 2, 1, -1, -2, -2, -1 };
                //condiciones: no sean posiciones en numeros <= 0 ni >=9
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Las posiciones a las que puede moverse el 🐴 son:");
                for (int i = 0; i < movFil.Length; i++)
                {
                    int nuevaFil = pFila + movFil[i];
                    int nuevaCol = pCol + movCol[i];

                    if (nuevaFil >= 0 && nuevaFil < 8 && nuevaCol >= 0 && nuevaCol < 8)
                    {
                        char letCol = (char)('a' + nuevaCol);
                        int numFil = nuevaFil + 1;
                        Console.WriteLine($"{letCol}{numFil}");
                    }
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Desea seguir consultando: S/N");
                Console.ResetColor();
                var desicion = Console.ReadLine().ToLower();
                if (desicion != "s")
                {
                    continuar = false;
                }
            } while (continuar);
        }
    }
}