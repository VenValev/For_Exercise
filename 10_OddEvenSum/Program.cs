int n = int.Parse(Console.ReadLine());
int sum1 = 0;
int sum2 = 0;
int br = 1;
for (int i = 0; i < n; i++)
{

    int m = int.Parse(Console.ReadLine());
    if (br % 2 == 1)
    {
        sum1 = sum1 + m;
    }
    else
    {
        sum2 = sum2 + m;
    }
    br++;
}
if (sum1 == sum2)
{
    Console.WriteLine($"Yes");
    Console.WriteLine($"Sum = {sum1}");
}
else
{
    Console.WriteLine($"No");
    Console.WriteLine($"Diff = {Math.Abs(sum1 - sum2)}");
}