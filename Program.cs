// выясните кратно ли число заданному, если нет, вывести остаток
Console.WriteLine("введите число");
int a=int.Parse(Console.ReadLine());
int b=4;
if (a % b==0)
{
    Console.WriteLine("кратно числу");
}
else
{
    Console.WriteLine("число не кратно, остаток от деления =");
    Console.WriteLine(a % b);
}