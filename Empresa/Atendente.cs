namespace Empresa
{
    public class Atendente:Pessoa
    {
        public override void CartaoAlimentacao(double sal)
        {
           Console.WriteLine("Desconto padrão:"+(sal * 0.3));
        }
    }
}