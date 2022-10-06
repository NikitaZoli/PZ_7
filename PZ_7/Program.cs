// See https://aka.ms/new-console-template for more information
Random rnd = new Random();
int n = int.Parse(Console.ReadLine());
int[] mass = new int[n];
int min;
int max;
int a;
int b;
for (int i = 0; i < n; i++)
{
    mass[i] = rnd.Next(0, 100);
    Console.Write(mass[i] + " ");
}
Console.WriteLine();

min = mass[0];
max = mass[0];
for (a = 1; a < n; a++)
{
    if (mass[a] < min)
        min = mass[a];
    if (mass[a] > max)
        max = mass[a];
}
Console.WriteLine(max * min);
Console.WriteLine(max + min);
