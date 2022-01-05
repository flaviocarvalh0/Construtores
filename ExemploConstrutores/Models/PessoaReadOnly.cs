namespace ExemploConstrutores.Models
{
    public class PessoaReadOnly
    {

        //readonly é usado quando você quer impedir q um determinado valor não seja alterado, podendo apenas deifnir valor para ele no seu construtuor ou quando é inicializado
        private readonly string nome = "Leo";
        private readonly string sobrenome;

        public PessoaReadOnly(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }

        public void MudarNome()
        {
            //this.nome = "Flavio";
        }
    }
}