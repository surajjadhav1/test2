using MathOparation;

Console.WriteLine("Enter the lower limit");
int lower = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the upper limit");
int upper = int.Parse(Console.ReadLine());

var compute = new Computation(lower,upper);

Console.WriteLine($"The Sum of Even number between {lower} and {upper} numbers is {compute.GetSumOf(lower,upper,compute.IsEven)}");
Console.WriteLine($"The Sum of Odd number between {lower} and {upper} numbers is {compute.GetSumOf(lower,upper,compute.IsOdd)}");
Console.WriteLine($"The Sum of Prime number between {lower} and {upper} numbers is {compute.GetSumOf(lower,upper,compute.IsPrime)}");

