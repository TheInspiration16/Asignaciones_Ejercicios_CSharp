// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var calculator = new Calculator();
int result = calculator.sum(1, 2);
Console.WriteLine(result);

public class Calculator
{
    public int sum(int a, int b)
    {
        return a + b;
    }
}


