int n1, n2, resto;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Múltiplo");
Console.ResetColor();

Console.Write("Digite o primeiro número :");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número :");
n2 = Convert.ToInt32(Console.ReadLine());

resto = n1 % n2;

bool éMúltiplo = (resto ==0);

if (resto==0)
{
    Console.WriteLine($"{n1} é múltiplo de {n2}");
}
else
{
    Console.WriteLine($"{n1} não é múltiplo de {n2}");
}    