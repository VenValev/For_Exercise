int n = int.Parse(Console.ReadLine());
int min = 0;
int max = 0;
for (int i = 0; i < n; i++)
{
    int m = int.Parse(Console.ReadLine());
    if (i == 0)
    {
        min = m;
        max = m;
    }
    if (m > max)
    {
        max = m;
    }
    if (m < min)
    {
        min = m;
    }

}
Console.WriteLine($"Max number: {max}");
Console.WriteLine($"Min number: {min}");