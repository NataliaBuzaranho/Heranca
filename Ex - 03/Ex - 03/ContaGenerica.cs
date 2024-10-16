namespace Ex___03
{
    public abstract class ContaGenerica
    {
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public string Saldo { get; set; }

        public abstract void Depositar();
        public abstract void Sacar();
    }
    public class ContaCorrente1 : ContaGenerica
    {
        public override void Depositar()
        {
            Console.WriteLine("Você depositou 1000 reais.");
        }
        public override void Sacar()
        {
            Console.WriteLine("Você sacou 420 reais.");
        }
    }
    public class ContaCorrente2 : ContaGenerica
    {
        public override void Depositar()
        {
            Console.WriteLine("Você depositou 100 reais.");
        }
        public override void Sacar()
        {
            Console.WriteLine("Você sacou 500 reais.");
        }
    }
    public class ContaCorrente3 : ContaGenerica
    {
        public override void Depositar()
        {
            Console.WriteLine("Você depositou 680 reais.");
        }
        public override void Sacar()
        {
            Console.WriteLine("Você sacou 1200 reais.");
        }
    }

}
