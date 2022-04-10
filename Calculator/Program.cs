#region functions
double Power(double[] vs)
{
    throw new NotImplementedException();
}

double Divide(double[] nums)
{
    return nums[0] / nums[1];
}

double Multiply(double[] nums)
{
    return nums[0] * nums[1];
}

double Subtract(double[] nums)
{
    return nums[0] - nums[1];
}

double Add(double[] nums)
{
    throw new NotImplementedException();
}

double[] getNumbersFromUser()
{
    Console.WriteLine("Please enter a number:");
    double firstNum = double.Parse(Console.ReadLine());
    Console.WriteLine("Please enter a second number:");
    double secondNum = double.Parse(Console.ReadLine());

    return new double[] { firstNum, secondNum };
}
#endregion

#region main

Console.Write("Please enter an operator: ");
string command = Console.ReadLine();
double result = 0;

while (command != "End")
{
    switch (command)
    {
        case "+":
            result = Add(getNumbersFromUser());
            break;

        case "-":
            result = Subtract(getNumbersFromUser());
            break;

        case "*":
            result = Multiply(getNumbersFromUser());
            break;
        case "/":
            result = Divide(getNumbersFromUser());
            break;

        case "^":
            result = Power(getNumbersFromUser());
            break;

        case "End":
            return;

        default:
            Console.WriteLine("Invalid Command!");
            break;
    }

    Console.WriteLine($"Result: {result}");


    Console.Write("Please enter an operator: ");
    command = Console.ReadLine();
}

#endregion