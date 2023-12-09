int n = int.Parse(Console.ReadLine());
double br1 = 0;
double br2 = 0;
double br3 = 0;
double br4 = 0;
double br5 = 0;
for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num < 200)
    {
        br1++;
    }
    else if (num >= 200 && num < 400)
    {
        br2++;
    }
    else if (num >= 400 && num < 600)
    {
        br3++;
    }
    else if (num >= 600 && num < 800)
    {
        br4++;
    }
    else if (num >= 800 && num <= 1000)
    {
        br5++;
    }
}
Console.WriteLine($"{(br1 / (br1 + br2 + br3 + br4 + br5)) * 100.0:f2}%");
Console.WriteLine($"{br2 / (br1 + br2 + br3 + br4 + br5) * 100.0:f2}%");
Console.WriteLine($"{br3 / (br1 + br2 + br3 + br4 + br5) * 100.0:f2}%");
Console.WriteLine($"{br4 / (br1 + br2 + br3 + br4 + br5) * 100.0:f2}%");
Console.WriteLine($"{br5 / (br1 + br2 + br3 + br4 + br5) * 100.0:f2}%");