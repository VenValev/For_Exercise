string name = Console.ReadLine();
double points = double.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
bool b = true;
for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    double p = double.Parse(Console.ReadLine());
    points = points + ((s.Length * p) / 2.0);
    if (points >= 1250.5)
    {
        Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {points:f1}!");
        b = false;
        break;
    }

}
if (b == true)
{
    Console.WriteLine($"Sorry, {name} you need {1250.5 - points:f1} more!");
}