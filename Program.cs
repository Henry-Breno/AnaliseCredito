Console.WriteLine("Análise de Crédito");

Console.Write("Digite o valor de empréstimo desejado: ");
double valor = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor desejado das parcelas: ");
int parcelas = int.Parse(Console.ReadLine()!);

Console.Write("Digite sua renda mensal comprovada: ");
double renda = Convert.ToDouble(Console.ReadLine());

double autorizacao = 0.3*renda;
Console.WriteLine($"Empréstimos serão aprovados caso o valor das parcelas nao ultrapasse 30% da sua renda\nValor máximo permitido das parcelas: {autorizacao:N2}");
Thread.Sleep(1000);
if (parcelas <= autorizacao)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Empréstimo aprovado!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Empréstimo negado, valor de parcelas muito altas para sua renda!");
}

Console.ResetColor();
Console.WriteLine("Obrigado por usar nosso calculador!");