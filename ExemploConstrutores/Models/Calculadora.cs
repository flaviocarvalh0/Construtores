namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        public static void Somar(int num1, int num2)
        {
            System.Console.WriteLine($"Adição {num1 + num2}");
        }
        public static void Subtratir(int num1, int num2)
        {
            System.Console.WriteLine($"Subtração {num1 - num2}");
        }
    }
}