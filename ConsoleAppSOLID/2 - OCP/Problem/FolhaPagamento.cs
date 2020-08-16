using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleAppSOLID._2___OCP.Problem
{
    public class FolhaPagamento
    {
        public decimal Saldo { get; set; }
        public void Calcular(object contrato)
        {
            if (contrato.GetType() == typeof(ContratoClt))
            {
                this.Saldo = ((ContratoClt)contrato).Salario();
            }
            else if (contrato.GetType() == typeof(Estagiario))
            {
                this.Saldo = ((Estagiario)contrato).BolsaAuxilio();
            }
        }
    }
    public class ContratoClt
    {
        public decimal Salario()
        {
            return 8000;
        }
    }
    public class Estagiario
    {
        public decimal BolsaAuxilio()
        {
            return 500;
        }
    }

}
