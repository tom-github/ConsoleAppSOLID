using ConsoleAppSOLID._2___OCP.Problem;
using ConsoleAppSOLID._2___OCP.Solution;
using System;

namespace ConsoleAppSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleAppSOLID._2___OCP.Solution.FolhaPagamento folhaPagamento = new ConsoleAppSOLID._2___OCP.Solution.FolhaPagamento();
            var teste1 = new ConsoleAppSOLID._2___OCP.Solution.Estagiario();
            teste1.valor = 1;
            
            Console.WriteLine(folhaPagamento.Calcular(teste1));
            Console.WriteLine(folhaPagamento.Calcular(new ConsoleAppSOLID._2___OCP.Solution.ContratoClt()));
            Console.ReadKey();
        }
    }
}
