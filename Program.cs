int natural = 0;
int cavab = default;


for (int i = 1; i <= natural; i*=10)
{
    cavab = i;
}
if (cavab == 0)
{
    int b = 3 * 10 + natural;
    System.Console.WriteLine(b);
    return;
}
cavab *= 10;
int a = 3 * cavab + natural;
System.Console.WriteLine(a);

