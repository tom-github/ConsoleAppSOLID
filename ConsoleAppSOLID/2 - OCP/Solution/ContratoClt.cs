using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppSOLID._2___OCP.Solution
{
    public class ContratoClt : IRemuneravel
    {
        public decimal valor { get; }

        public decimal Remuneracao()
        {
            return 8000;
        }
    }
}
