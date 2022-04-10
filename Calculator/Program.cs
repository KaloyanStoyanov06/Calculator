#region main
string command = Console.ReadLine();
double result = double.MinValue;
while (command != "End")
{
    switch (command)
    {
        case "Add":
            {
                result = Add(getNumbersFromUser());
            }
            break;
        case "Subtract":
            {
                result = Subtract(getNumbersFromUser());
            }
            break;
        case "Multiply":
            {
                double number1 = double.Parse(Console.ReadLine());
                double number2 = double.Parse(Console.ReadLine());

                result = Multiply(number1, number2);
            }
            break;
        case "Divide":
            {
                double number1 = double.Parse(Console.ReadLine());
                double number2 = double.Parse(Console.ReadLine());

                result = Divide(number1, number2);
            }
            break;
        case "Power":
            {
                result = Power(getNumbersFromUser());
            }
            break;
        case "End":
            break;
        default:
            Console.WriteLine("Invalid Command!");
            break;
    }
    if (result != double.MinValue)
    {
        Console.WriteLine($"Result: {result}");
    }
    command = Console.ReadLine();
}

double Power(double[] vs)
{
    throw new NotImplementedException();
}
 double Divide(double number1, double number2)
{
    return number1 / number2;
}    
double Multiply(double number1, double number2)
{
    return number1 * number2;
}

double Subtract(double[] vs)
{
    throw new NotImplementedException();
}

double Add(double[] vs)
{
    throw new NotImplementedException();
}
#endregion

static double[] getNumbersFromUser()
{
    Console.WriteLine("Please enter a number:");
    double firstNum = double.Parse(Console.ReadLine());
    Console.WriteLine("Please enter a second number:");
    double secondNum = double.Parse(Console.ReadLine());

    return new double[] { firstNum, secondNum };
}