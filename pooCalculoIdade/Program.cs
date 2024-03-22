//using System;
namespace pooCalculoIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Pessoa();
             Console.WriteLine("Digite o nome :");
             person.Name = Console.ReadLine();
             Console.WriteLine("Digite  a data de nascimento :");
             person.AnoNascimento = Convert.ToInt32(Console.ReadLine());
             person.ExibirDados();
            
             
        }
    }
}
