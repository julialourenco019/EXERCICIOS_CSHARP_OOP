namespace Banco
{
    public class ContaBancaria
    {
        private string? titular;
        private string? numConta;
        private double  saldo;

        public string? Titular { get => titular; set => titular = value; }
        public string? NumConta { get => numConta; set => numConta = value; }
        public double Saldo { get => saldo;  }

        public ContaBancaria(string titular, string numConta)
        {
              this.titular = titular;
              this.numConta = numConta;
        }

        public void Deposito(double valor)
        {
               saldo += valor;
        }

        public double Saque(double valor)
        {
          if( valor > saldo)
          {
            Console.WriteLine("saldo insuficiente");
             
          }
            return saldo -= valor;
            

        }

         public void ShowMessagem()
       {
        Console.WriteLine($" Titular: {titular}  " );
        Console.WriteLine($" Número da conta: {numConta}");
         Console.WriteLine($" Saldo: {saldo} ");
        
        
        }


    }
}