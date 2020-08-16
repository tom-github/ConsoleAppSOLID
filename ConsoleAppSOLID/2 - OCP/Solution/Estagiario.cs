using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppSOLID._2___OCP.Solution
{
    public class Estagiario : IRemuneravel
    {
        public decimal valor { get; set; }
        public decimal Remuneracao()
        {
            return 500;
        }

    }
}
