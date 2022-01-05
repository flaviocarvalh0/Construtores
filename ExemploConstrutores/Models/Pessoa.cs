namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private string Nome;
        private string Sobrenome;

        public Pessoa(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            System.Console.WriteLine("Connstrutor da classe pessoa");

        }

        // public Pessoa()
        // {
        //     Nome = string.Empty;
        //     Sobrenome = string.Empty;
        // }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá meu nome é {Nome} {Sobrenome}");
        }
    }
}