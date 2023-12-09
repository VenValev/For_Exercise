int n = int.Parse(Console.ReadLine());
double mus = 0;
double mon = 0;
double kil = 0;
double k2 = 0;
double evv = 0;
double br;
for (int i = 0; i < n; i++)
{
    int h = int.Parse(Console.ReadLine());
    if (h < 6) mus += h;
    if (h >= 6 && h <= 12) mon += h;
    if (h >= 13 && h <= 25) kil += h;
    if (h >= 26 && h <= 40) k2 += h;
    if (h > 40) evv += h;

}
br = mus + mon + kil + k2 + evv;
//Console.WriteLine(br);
Console.WriteLine($"{(mus / br) * 100.0:f2}%");
Console.WriteLine($"{(mon / br) * 100.0:f2}%");
Console.WriteLine($"{(kil / br) * 100.0:f2}%");
Console.WriteLine($"{(k2 / br) * 100.0:f2}%");
Console.WriteLine($"{(evv / br) * 100.0:f2}%");