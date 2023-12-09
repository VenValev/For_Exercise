int y = int.Parse(Console.ReadLine());
double per = double.Parse(Console.ReadLine());
double money = 0;
double toy = double.Parse(Console.ReadLine());
int br = 0;
for (int i = 1; i <= y; i++)
{

    if (i % 2 == 1)
    {

        money += toy;
    }
    else
    {
        money = money + ((i / 2.0) * 10);
        br++;
    }
}
if (money - br >= per)
{
    Console.WriteLine($"Yes! {money - br - per:f2}");
}
else
{
    Console.WriteLine($"No! {per - (money - br):f2}");
}