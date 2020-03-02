using System;
using System.Collections.Generic;
using ArbolBinario.ArbolBinario;
using ArbolBinario.Tree;


namespace ArbolBinario
{
    class Program
    {
        static void Main(string[] args)
        {


            /*BTREE arbolito = new BTREE();

            arbolito.Insert(50);
            arbolito.Insert(30);
            arbolito.Insert(20);
            arbolito.Insert(40);
            arbolito.Insert(70);
            arbolito.Insert(60);
            arbolito.Insert(80);

            arbolito.EnviarRaiz();
            Console.ReadLine();*/


            Stack<NodoT> PilaS = new Stack<NodoT>();

            

            NodoT noditoA = new NodoT();
            noditoA.Key = "A";
            

            NodoT nodoB = new NodoT();
            nodoB.Key = "B";
          

            NodoT noditoc = new NodoT();
            noditoc.Key = "c";
           

            Arbol arbolito = new Arbol();

            arbolito.Insert(noditoA, 0);
            arbolito.Insert(nodoB, 1);
            arbolito.Insert(noditoc, 2);

            PilaS.Push(arbolito.Return());


            Arbol arbo = new Arbol();

            NodoT nodito = new NodoT();
            nodito.Key = "e";

            NodoT nodo = new NodoT();
            nodo.Key = "f";
 
           

            arbo.Insert(nodito, 0);
            arbo.Insert(nodo, 1);

            arbo.Insert(PilaS.Pop(), 2);


            Console.ReadLine();








        }
    }
}
