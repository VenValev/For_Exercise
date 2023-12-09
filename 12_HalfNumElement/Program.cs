int n = int.Parse(Console.ReadLine());
int max = int.MinValue;
int sum = 0;
for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    sum = sum + num;
    if (num > max)
    {
        max = num;
    }
}
int sum1 = sum - max;

if (sum1 == max)
{
    Console.WriteLine("Yes");
    Console.WriteLine("Sum = " + max);
}
else
{
    Console.WriteLine("No");
    Console.WriteLine("Diff = " + Math.Abs(sum1 - max));
}