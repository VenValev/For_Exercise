int n = int.Parse(Console.ReadLine());
double sal = double.Parse(Console.ReadLine());
bool b = false;
for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    switch (s)
    {
        case "Facebook":
            sal = sal - 150;
            break;
        case "Instagram":
            sal = sal - 100;
            break;
        case "Reddit":
            sal = sal - 50;
            break;
    }
    if (sal <= 0)
    {
        Console.WriteLine("You have lost your salary.");
        b = true;
        break;
    }

}
if (b == false)
{
    Console.WriteLine(sal);
}