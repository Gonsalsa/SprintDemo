// See https://aka.ms/new-console-template for more informationc



Console.WriteLine("Enter the temperature in Farenheit:");
int tempCelsius = Convert.ToInt32(Console.ReadLine());
var farenheit = tempCelsius * 1.8 + 32;

Console.WriteLine($"{farenheit}");

