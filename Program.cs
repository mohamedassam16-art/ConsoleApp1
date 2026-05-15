// 1-what the whether (even/odd)

Console.WriteLine("enter the whether");
int number =
int.Parse(Console.ReadLine());
if(number % 2 == 0)
{
    Console.WriteLine("Even");
}    
else
{
     Console.WriteLine("odd");
}


// 2-the absolute value


Console.WriteLine("Enter The Value");
int number = int.Parse(Console.ReadLine());
if(number <  0)
{
    number = number * -1;
}
Console.WriteLine("The absolute value is :" + number);


// 3-find the larger

Console.WriteLine("Enter The x");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Enter The y");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Enter The z");
int z = int.Parse(Console.ReadLine());
int ruselt = Math.Max(x, Math.Max(y,z));
Console.WriteLine("The Max Value" + ruselt);


// 4-equel 2 x*3

Console.WriteLine("Enter The a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter The b");
int b = int.Parse(Console.ReadLine());
int sum = a + b;
if (a == b)
{ 
    sum = sum * 3; 
}
Console.WriteLine("The Value" + sum);


// 5-true or false
/*
Console.Write("Enter first integer: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Enter second integer: ");
int second = int.Parse(Console.ReadLine());
bool result = (first < 0 && second > 0) || (first > 0 && second < 0);
Console.WriteLine("Result: " + result);
*/
