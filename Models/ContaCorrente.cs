namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldo)
        {
            NumeroConta = numeroConta;
            _saldo = saldo;
        }

        public int NumeroConta { get; set; }
        private decimal _saldo;

        public void Sacar(decimal valor)
        {
            if (_saldo >= valor)
            {
                _saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que o saldo disponível");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponível é: {_saldo}");
        }
    }
}