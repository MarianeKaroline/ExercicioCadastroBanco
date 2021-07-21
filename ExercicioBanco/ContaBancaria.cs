using System.Globalization;

namespace ExercicioBanco
{
    class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(int num, string nome, double deposito)
        {
            NumeroConta = num;
            Nome = nome;
            Saldo = deposito;
        }

        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }

        public void Sacar(double saque)
        {
            Saldo = Saldo - saque - 5.00;
        }

        public override string ToString()
        {
            return "\nNuméro da conta: " + NumeroConta 
                + "\nPessoa Física: " + Nome 
                + "\nSaldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
