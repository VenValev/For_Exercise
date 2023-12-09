int n = int.Parse(Console.ReadLine());
double p = double.Parse(Console.ReadLine());
double br = 0;
double avp = 0;
for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    switch (s)
    {
        case "W":
            p += 2000;
            avp += 2000;
            br++;
            break;
        case "F":
            p += 1200;
            avp += 1200;
            break;
        case "SF":
            p += 720;
            avp += 720;
            break;
    }
}
Console.WriteLine($"Final points: {p}");
Console.WriteLine($"Average points: {Math.Floor(avp / n)}");
Console.WriteLine($"{(br / n) * 100.0:f2}%");