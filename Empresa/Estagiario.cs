namespace Empresa
{
    public class Estagiario:Pessoa
    {
        public override void CartaoAlimentacao(double sal)
        {
           Console.WriteLine("Desconto padrão:"+(sal * 0.2));
        }
    }
}