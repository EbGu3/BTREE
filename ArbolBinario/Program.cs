using System;
using ArbolBinario.ArbolBinario;

namespace ArbolBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            BTREE arbolito = new BTREE();

            arbolito.Insert(50);
            arbolito.Insert(30);
            arbolito.Insert(20);
            arbolito.Insert(40);
            arbolito.Insert(70);
            arbolito.Insert(60);
            arbolito.Insert(80);

            arbolito.EnviarRaiz();
            Console.ReadLine();

        }
    }
}
