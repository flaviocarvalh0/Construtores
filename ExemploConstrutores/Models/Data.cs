namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int mes;
        private bool mesValido;

        public int GetMes()
        {
            return this.mes;
        }

        public void SetMes(int mes)
        {
            this.mes = mes;
            if (mes > 0 && mes <= 12)
            {
                this.mes = mes;
                this.mesValido = true;
            }
        }

        public int data
        {
            get
            {
                return this.mes;
            }

            set
            {
                if(value > 0 && value <= 12)
                {
                    this.mes = value;
                    this.mesValido = true;
                }
            }
        }

        public void ApresentarMes()
        {
            if (this.mesValido)
            {
                System.Console.WriteLine(this.mes);
            }
            else
            {
                System.Console.WriteLine("Mês Inválido");
            }
        }
    }
}