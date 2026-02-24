Console.WriteLine("Choose your conversion:");
Console.WriteLine("1: Convert Fahrenheit to Celsius");
Console.WriteLine("2: Convert Celsius to Fahrenheit");

int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
   case 1:
      Console.Write("Enter the temperature in Fahrenheit: ");
      double fahrInput = Convert.ToDouble(Console.ReadLine()); 
      
      double toCelsius = (fahrInput - 32) / 1.8;
        
      Console.WriteLine($"{fahrInput}°F is {toCelsius}°C");
      break;

   case 2:
      Console.Write("Enter the temperature in Celsius: ");
      double celsInput = Convert.ToDouble(Console.ReadLine());
      
      double toFahrenheit = (celsInput * 1.8) + 32;
        
      Console.WriteLine($"{celsInput}°C is {toFahrenheit}F");
      break;

   default:
      Console.WriteLine("Invalid choice. Please pick 1 or 2.");
      break;
}