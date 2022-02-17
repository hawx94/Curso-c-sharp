using System;
using System.Collections.Generic;
using System.Text;

namespace Vetor
{
    class Apartamentos
    {
        public string Nome { get; set; }
        public string EMail { get; set; }
        public int NumeroDoQuarto { get; set; }


        public override string ToString()
        {
            return NumeroDoQuarto
                + ": "
                + Nome
                + ", "
                + EMail;
        }
    }
}

