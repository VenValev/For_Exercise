int n = int.Parse(Console.ReadLine());
int sum1 = 0;
int sum2 = 0;
for (int i = 0; i < n * 2; i++)
{
    int m = int.Parse(Console.ReadLine());
    if (i < n)
    {
        sum1 = sum1 + m;
    }
    else
    {
        sum2 = sum2 + m;
    }
}
if (sum1 == sum2)
{
    Console.WriteLine($"Yes, sum = {sum1}");
}
else
{
    Console.WriteLine($"No, diff = {Math.Abs(sum1 - sum2)}");
}