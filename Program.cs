using System;
using System.Collections.Generic;

namespace consoleApp
{
    class Program
    {
        public static void Main(string[] args){

            //tablero 
            int filas = 8;
            int columnas = 8;
            int[,] tablero = new int[filas, columnas];

            //posición actual del caballo
            Console.WriteLine("Ingresa la posición del caballo (ej: d4): ");
            string posicion = Console.ReadLine().ToLower();

            if (posicion.Length != 2 || !char.IsLetter(posicion[0]) || !char.IsDigit(posicion[1])){
            Console.WriteLine("Entrada inválida. Digita la posición como el ejemplo ('d4') ");
            return;
            }
            int pCol = posicion[0]-'a';
            int pFila = int.Parse(posicion[1].ToString()) - 1;

            int[] movimientosFila = { 2, 1, -1, -2, -2, -1, 1, 2 };
            int[] movimientosColumna = { 1, 2, 2, 1, -1, -2, -2, -1 };
           //condiciones: no sean posiciones en numeros <= 0 ni >=9


        }
    }
}