namespace Empresa
{
    public class Pessoa
    {
    
           
       public virtual void CartaoAlimentacao(double sal)
       {
         Console.WriteLine("Desconto padrão:"+(sal * 0.1));
       }
    }
}