namespace pooZoologico
{
    class Program
    {
        static void Main(string[]args)
        {
           List<AnimalPlus> animais = new List<AnimalPlus>();
           int contCar = 0 , contHer = 0;
           Console.WriteLine("Programam que conta quantos animais são carnivoros e herbivoros ");
           for (int i = 0; i < 10; i++)
           {
             AnimalPlus animal = new AnimalPlus();
             Console.Write("Especie:");
             animal.Especie = Console.ReadLine();
             Console.Write("Peso:");
             animal.Peso = Convert.ToDouble(Console.ReadLine());
             Console.Write("Tipo de alimentação:");
             animal.TipoAlimentacao = Console.ReadLine();
             if( animal.TipoAlimentacao == "Carnivoro")
             {
                 contCar++;
             }
             else
             {
                contHer++;
             }
             animais.Add(animal);

           }
        }
    }
}