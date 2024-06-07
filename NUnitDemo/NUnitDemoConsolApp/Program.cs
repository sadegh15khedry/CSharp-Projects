// See https://aka.ms/new-console-template for more information
using NUnitDemoConsoleApp;

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

int z = SimpleFunctions.Sum(x, y);
Console.WriteLine(z);