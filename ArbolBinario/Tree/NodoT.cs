namespace ArbolBinario.Tree
{
    public class NodoT
    {
        public string Key;
        public NodoT Derecho, Izquierdo;

        public NodoT()
        {
            Derecho = null;
            Izquierdo = null;
        }

    }
    public class Arbol
    {

        public NodoT Root { get; set; }

        public Arbol()
        {
            Root = null;
            
        }

        public void Insert(NodoT Key, int Direccion)
        {
            Root = Recursivo(Root, Key, Direccion);
        }

        NodoT Recursivo(NodoT Root, NodoT _key,int Direccion)
        {
            if(Root == null)
            {
                 Root = new NodoT
                {
                    Key = _key.Key,
                    Derecho = _key.Derecho,
                    Izquierdo = _key.Izquierdo,
                    
                };

                Direccion = 0;
            }

            if(Direccion == 1)
            {
                Root.Derecho = Recursivo(Root.Derecho, _key, 1);
            }
            else if(Direccion == 2)
            {
                Root.Izquierdo = Recursivo(Root.Izquierdo, _key, 2);
            }

            return Root;
        }

        public NodoT Return()
        {
            return Root;
        }
    }



}


