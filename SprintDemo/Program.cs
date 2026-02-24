


Console.WriteLine("===TEMPERATUR OMVANLDARE===");

Console.Write("Skriv in temperaturen i Farenheit:");
int inTemp = Int32.Parse(Console.ReadLine());

 static int FarToCels(int startTemp)
{
    var convertedTemp = (startTemp - 32) * (5 / 9);

    return convertedTemp;
}


Console.Write("Tempen i Celsius är: ");
Console.WriteLine(FarToCels(inTemp));