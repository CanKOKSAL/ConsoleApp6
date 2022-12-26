using System.Security.Cryptography;

Console.WriteLine("Please write value");
double Value;
int Request;

do
{   
    Value = Double.Parse(Console.ReadLine());
    calculator(); 
    Request = Int32.Parse(Console.ReadLine());
   
    
    if (Request == 1)
    {
         Console.WriteLine("Please write your second value to divide");
         double value = Double.Parse(Console.ReadLine());
         Console.WriteLine(Value / value);      
    }
    

    if (Request == 2)
    {
        Console.WriteLine("Please write your second value to multiply");
        double value = Double.Parse(Console.ReadLine());
        Console.WriteLine(Value * value);                
    } 
    
    if (Request == 3)
    {
        Console.WriteLine("Please write your second value to sum");
        double value = Double.Parse(Console.ReadLine());
        Console.WriteLine(Value + value);        
    } 
    
    if (Request == 4)
    {
        Console.WriteLine("Please write your second value to substract");
        double value = Double.Parse(Console.ReadLine());
        Console.WriteLine(Value - value);        
    }
    if (Request==5)
    {
        Console.WriteLine("Please write new value");
        double value = Double.Parse(Console.ReadLine());
        calculator();
    }
} while (Request<=5);

static void calculator()
{
    Console.WriteLine("Please select your request");
    Console.WriteLine("1)Divide");
    Console.WriteLine("2)Multiply");
    Console.WriteLine("3)Sum");
    Console.WriteLine("4)Subtract");
    Console.WriteLine("5)Clean");
}
