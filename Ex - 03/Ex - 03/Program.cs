using Ex___03;

ContaCorrente1 contaCorrente1 = new ContaCorrente1
{
    Banco = "Caixa",
    Agencia = "0760",
    Conta = "6686",
    Saldo = "R$11.000"
};

Console.WriteLine($"Seu banco é: {contaCorrente1.Banco}\nSua agência é: {contaCorrente1.Agencia}\nSua conta é de número: {contaCorrente1.Conta} \nSeu saldo é de: {contaCorrente1.Saldo}");
contaCorrente1.Sacar();
contaCorrente1.Depositar();


ContaCorrente2 contaCorrente2 = new ContaCorrente2
{
    Banco = "Bradesco",
    Agencia = "6700",
    Conta = "8934",
    Saldo = "R$15.000"
};

Console.WriteLine($"\nSeu banco é: {contaCorrente2.Banco}\nSua agência é: {contaCorrente2.Agencia}\nSua conta é de número: {contaCorrente2.Conta} \nSeu saldo é de: {contaCorrente2.Saldo}");
contaCorrente2.Sacar();
contaCorrente2.Depositar();

ContaCorrente3 contaCorrente3 = new ContaCorrente3
{
    Banco = "Santander",
    Agencia = "2346",
    Conta = "6753",
    Saldo = "R$1.000,00"
};

Console.WriteLine($"\nSeu banco é: {contaCorrente3.Banco}\nSua agência é: {contaCorrente3.Agencia}\nSua conta é de número: {contaCorrente3.Conta} \nSeu saldo é de: {contaCorrente3.Saldo}");
contaCorrente3.Sacar();
contaCorrente3.Depositar();

Console.ReadKey();