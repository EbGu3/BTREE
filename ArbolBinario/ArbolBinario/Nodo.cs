using System;
namespace ArbolBinario.ArbolBinario
{
    public class Nodo
    {
        public int Key;
        public Nodo Left, Right;

        public Nodo(int item)
        {
            Key = item;
            Left = Right = null;
        }
    }
}
