Console.Clear();
 
double A, B, C, Delta, x1, x2;
 
Console.WriteLine("-- Equação do segundo grau --");
 
Console.Write("(a): ");
A = Convert.ToDouble(Console.ReadLine());
 
Console.Write("(b): ");
B = Convert.ToDouble(Console.ReadLine());
 
Console.Write("(c): ");
C = Convert.ToDouble(Console.ReadLine());
 
Console.WriteLine();
 
if (A == 0)
{
    Console.WriteLine("Não é uma equação de segundo grau!");
}
else
{
    Delta = B * B - 4 * A * C;
 
    if (Delta < 0)
    {
        Console.WriteLine($"Como delta = {Delta:N2}, a equação não possui raízes reais!");
    }
    else
    {
        x1 = (-B + Math.Sqrt(Delta)) / (2 * A);
        x2 = (-B - Math.Sqrt(Delta)) / (2 * A);
 
        Console.WriteLine($"x1 = {x1:N2} e x2 = {x2:N2}");
    }
}


