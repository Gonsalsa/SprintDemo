


using SprintDemo;
using System.Threading.Channels;

Console.WriteLine("===TEMPERATUR OMVANLDARE===");

Console.Write("Skriv in temperaturen i Farenheit:");
int inTemp = Int32.Parse(Console.ReadLine());

var converted = FarenheitToCelcius.farToCels(inTemp);

Console.Write($"Tempen i Celsius är: {converted} C");
