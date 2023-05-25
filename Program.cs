System.Console.WriteLine("Emprestimo");
System.Console.Write("Informe o valor do empréstimo a partir de R$ 1000,00: ");
double valorSolicitado = double.Parse(Console.ReadLine());

double avista = valorSolicitado * 0.05;
double parcala3 = valorSolicitado / 3;
double parcala3 = valorSolicitado * 1.18 / 12;
double parcala3 = valorSolicitado * 1.32 / 24;

System.Console.Write("Informe em quantas vezes deseja parcelar: ");

//A vista
//Parcelado 3x S/J
//Parcelado 12x C/J
//Parcelado 24x C/J

switch (parcelas)
{
    case "A vista":
    System.Console.WriteLine($"O emprestimo solicitado é de {valorEmprestimo} e o pagamento será {avista} a vista.");

    case "3X":
    System.Console.WriteLine($"O emprestimo solicitado é de {valorEmprestimo} e o pagamento será {parcala3} em 3 parcelas.");

    case "12X":
    System.Console.WriteLine($"O emprestimo solicitado é de {valorEmprestimo} e o pagamento será {parcela12} em 12 parcelas.");

    case "24X":
    System.Console.WriteLine($"O emprestimo solicitado é de {valorEmprestimo} e o pagamento será {parcela24} em 24 parcelas.");

    default:
    System.Console.WriteLine("Escola pagar a vista, ou em parcelas de 3 , 12 ou 24 vezes");
}

valorEmprestimo(double avista, double parcela3, double parcela12, double parcela24, string pagto)
{
    return valorSolicitado;

}
Console.ReadKey();