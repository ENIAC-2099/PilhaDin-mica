using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinâmica
{
    internal class Node
    {
        int dado;
        Node elo;

        public Node(int dado)
        {
            this.dado = dado;
            this.elo = null;
        }

        public int Dado { get => dado; }
        internal Node Elo { get => elo; set => elo = value; }
    }
}
