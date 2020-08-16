using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleAppSOLID._2___OCP.Solution
{

    public class FolhaPagamento
    {
        public decimal Saldo { get; set; }
        public decimal Calcular(IRemuneravel remuneravel)
        {
            return remuneravel.Remuneracao();
        }
    }
}
