using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinâmica
{
    internal class PilhaDinamica
    {
        Node topo;

        public PilhaDinamica()
        {
            this.topo = topo;
        }

        internal Node Topo { get => topo; }

        public void Push(int elemento)
        {
            Node node = new Node(elemento);
            node.Elo = topo;
            topo = node;
        }

        public int Pop()
        {
            Node t;
            if(topo == null)
            {
                return -1;
            }
            else
            {
                t = topo;
                topo = t.Elo;
                return t.Dado;
            }
        }


        public void ListarPilha()
        {
            Node t;
            Console.Write("Pilha: ");
            if(topo == null)
            {
                Console.Write("Vazia");
            }
            else
            {
                t = topo;
                while(t != null)
                {
                    Console.Write(t.Dado + " ");
                    t = t.Elo;
                }
            }
            Console.WriteLine();
        }
    }
}
