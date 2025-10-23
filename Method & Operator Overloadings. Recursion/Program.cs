// Recursion
int Factorial(int value)
{
    if (value <= 1)
    {
        return 1;
    }
    else
    {
        return value * Factorial(value - 1);
    }
}


Factorial(3);     // Output: 6
Factorial(4);     // Output: 24
Factorial(5);     // Output: 120



int Fibonacci(int value)
{
    if (value <= 0) return 0;
    if (value == 1) return 1;

    return Fibonacci(value - 1) + Fibonacci(value - 2);
}


Fibonacci(4);     // Output: 3
Fibonacci(5);     // Output: 5
Fibonacci(6);     // Output: 8



// Method Overloading
class MathHelper
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Add(double a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}


var helper = new MathHelper();
helper.Add(1, 2);                       // int Add(int, int)
helper.Add(1.0, 2.0);                   // double Add(double, double)
helper.Add(1.0, 2);                     // double Add(double, int)
helper.Add(1, 2, 3);                    // int Add(int, int, int)



// Operator Overloading
