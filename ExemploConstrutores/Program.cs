using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Log log = Log.GetInstace();

            // log.PropriedadeDeLog = "Teste de Instância";

            // Log log2 = Log.GetInstace();
            // System.Console.WriteLine(log2.PropriedadeDeLog);

            Pessoa p1 = new Pessoa("Flávio", "Alves");
            Aluno a1 = new Aluno("Ray","Alves","POrtugês");

            p1.Apresentar();
            a1.Apresentar();
        }
    }
}
