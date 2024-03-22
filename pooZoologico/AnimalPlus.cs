namespace pooZoologico
{
    public class AnimalPlus:Animal
    {
        public string? TipoAlimentacao{get;set;}

        public AnimalPlus():base()
        {
            this.TipoAlimentacao = "";
        }
        public AnimalPlus(string especie , double peso , string tipoAlimentacao):base(especie, peso)
        {
            this.TipoAlimentacao = tipoAlimentacao;
        }

        public void ExibirDados()
        {
            Console.WriteLine("Especie:"+Especie);
            Console.WriteLine("Peso:"+Peso);
            Console.WriteLine("Tipo de Alimentação:"+TipoAlimentacao);
        }
    }
}