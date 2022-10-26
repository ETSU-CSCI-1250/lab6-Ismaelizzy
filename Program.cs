
showCharacter("New York", 2);

CalculateRetail();

Celsius(80);

IsPrime(25);

#region showCharacter

static void showCharacter(string i, int o)
{
    Console.WriteLine("Showchracter");

    var p = i[o - 1];
    Console.WriteLine($"\"{p}\"");

}
#endregion

#region CR
static void CalculateRetail()
{
    Console.Write("What is the wholesale cost? $");
    double wholesaleCost = double.Parse(Console.ReadLine());
    Console.Write("What is the markup percentage? %");
    double markupPercentage = double.Parse(Console.ReadLine()) / 100;


    var totalMarkup = ((wholesaleCost * markupPercentage) + wholesaleCost);

    Console.WriteLine($"${totalMarkup}");

}
#endregion

#region C
static void Celsius(int f)
{
    int g = f;
    int c = (f - 32) * 5 / 9;

    Console.WriteLine($"inputed number is {g}");
    while (g > 0 && g <= 100)

        Console.WriteLine($"Celsius:{c++} Fahrenhit:{g++}");

}
#endregion

#region IP
static void IsPrime(int number)
{
    Console.WriteLine($"Entered number: {number}");

    int devisors = 0;

    for (int num = 1; num <= number; num++)
    {

        if (number % num == 0)

            devisors++;
    }
    Console.Write("Prime?");
    if (devisors == 2)
        Console.WriteLine("True");
    else
        Console.WriteLine("False");

}
#endregion
