namespace Empresa
{
    public class Gerente:Pessoa
    {
        public override void CartaoAlimentacao(double sal)
        {
           Console.WriteLine("Desconto padrão:"+(sal * 0.4));
        }
    }
}