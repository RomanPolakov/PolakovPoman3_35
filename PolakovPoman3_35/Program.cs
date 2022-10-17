 
Console.WriteLine("Введите координаты белого слона (1 - 8)");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты черного ферзя (1 - 8)");
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите куда пойдёт белый слон (1 - 8)");
int e = Convert.ToInt32(Console.ReadLine());
int f = Convert.ToInt32(Console.ReadLine());


if (a - e == b - f || a - e == f - b)
{ 
    if ( c - e == d - f  || c - e == f - d || c == f || d == e)
    {
        Console.WriteLine("Слон может пойти на это поле, но подставляется под ферзя");
    }
    else
    {
        Console.WriteLine("Слон может пойти на это поле, и не подставляется под ферзя");
    }
}
else
{
    Console.WriteLine("Слон не может пойти на это поле");
}