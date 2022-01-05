using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {

        public delegate void Operacao(int x, int y);
        static void Main(string[] args)

        {

            // Operacao op = Operacao(Calculadora.Somar);
            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtratir;

            // op.Invoke(2, 8);




            //constante são valores q recebem valores em sua inicialização e não poderá ser mudado dps
            // const double PI = 3.14;
            // System.Console.WriteLine(PI);
            //PI = 0.2;
            // Log log = Log.GetInstace();

            // log.PropriedadeDeLog = "Teste de Instância";

            // Log log2 = Log.GetInstace();
            // System.Console.WriteLine(log2.PropriedadeDeLog);

            // Pessoa p1 = new Pessoa("Flávio", "Alves");
            // Aluno a1 = new Aluno("Ray","Alves","POrtugês");

            // p1.Apresentar();
            // a1.Apresentar();

            // Data d1 = new Data();
            // d1.data = 12;
            // System.Console.WriteLine(d1.data);

            // // d1.SetMes(12);
            // d1.ApresentarMes();
        }
    }
}
