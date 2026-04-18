Console.WriteLine("Entar the invalid amount");

double amount = Convert.ToDouble (Console.ReadLine());

if (amount <= 0)
{
    Console.WriteLine($"invalid amount : {amount}");
}
else if(amount >= 500)
{
    double discountAmount = (amount * 0.2);
    double finalAmount = amount - discountAmount;
    Console.WriteLine($"the final amount after discount (20%) : {finalAmount}");
}
else if(amount <500 && amount >= 300)
{
    double discountAmount = (amount * 0.1);
    double finalAmount = amount - discountAmount;
    Console.WriteLine($"the final amount after discount (10%) : {finalAmount}");
}
else
{
    Console.WriteLine($"the final amount : {amount}");
}