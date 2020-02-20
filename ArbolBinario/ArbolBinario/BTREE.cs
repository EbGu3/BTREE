using System;
namespace ArbolBinario.ArbolBinario
{
    public class BTREE
    {

        public Nodo Root { get; set; }

        public BTREE()
        {
            Root = null;
        }

        public void Insert(int key)
        {
            Root = Recursivo(Root, key);
        }

        Nodo Recursivo(Nodo Root, int Key)
        {
            if(Root == null )
            {
                Root = new Nodo(Key);
                return Root;
            }
            if(Key < Root.Key )
            {
                Root.Left = Recursivo(Root.Left, Key);
            }
            else if(Key > Root.Key)
            {
                Root.Right = Recursivo(Root.Right, Key);
            }

            return Root;
        }

        public void EnviarRaiz()
        {
            InOrder(Root);
        }

        public void InOrder(Nodo Root)
        {
            if(Root != null)
            {
                InOrder(Root.Left);
                Console.WriteLine(Root.Key);
                InOrder(Root.Right);
            }
        }
    }
}
