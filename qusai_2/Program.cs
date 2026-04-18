//Switch

Console.WriteLine("Enter number 1 : ");
double num_1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number 2 : ");
double num_2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the operator : ");
char @operator = Convert.ToChar(Console.ReadLine());

switch (@operator)
{
    case '+':
        Console.WriteLine($"the result of operator {@operator} for {num_1} and {num_2} is : {num_1 + num_2} ");
            break;
    case '-':
        Console.WriteLine($"the result of operator {@operator} for {num_1} and {num_2} is : {num_1 - num_2} ");
        break;
    case '*':
        Console.WriteLine($"the result of operator {@operator} for {num_1} and {num_2} is : {num_1 * num_2} ");
        break;
    case '/':
        Console.WriteLine($"the result of operator {@operator} for {num_1} and {num_2} is : {num_1 / num_2} ");
        break;
    default:
        Console.WriteLine($"Incorrect operator ");
        break;
}
//qusai haron



