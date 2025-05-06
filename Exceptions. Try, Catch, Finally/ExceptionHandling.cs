// Exception handling


// Exception handling (catch without "exception")
double x;
double y;
double result;

try
{
    Console.Write("Enter number 1: ");
    x = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter number 2: ");
    y = Convert.ToDouble(Console.ReadLine());

    result = x / y;

    Console.WriteLine("result: " + result);
}
catch // default Exception
{
    Console.WriteLine("Enter only numbers please.");
}





// Exception handling (catch with specific exceptions)
int a;
int b;
int result2;

try
{
    Console.Write("Enter number 1: ");
    a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter number 2: ");
    b = Convert.ToInt32(Console.ReadLine());

    result2 = a / b;

    Console.WriteLine("result: " + result2);
}
catch (FormatException ex)
{
    Console.WriteLine("Enter only numbers please.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("You can't divide by zero.");
}
catch (Exception)
{
    Console.WriteLine("Something went wrong.");
}





// Exception handling (with finally)
int c;
int d;
int result3;

try
{
    Console.Write("Enter number 1: ");
    c = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter number 2: ");
    d = Convert.ToInt32(Console.ReadLine());

    result3 = c / d;

    Console.WriteLine("result: " + result3);
}
catch (FormatException ex)
{
    Console.WriteLine("Enter only numbers please.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("You can't divide by zero.");
}
catch (Exception)
{
    Console.WriteLine("Something went wrong.");
}
finally   // always executes regardless if exception is caught or not
{
    Console.WriteLine("Thanks for visiting!");
}
/// finally - used for closing files, DB connections, etc.





// Exception Handling (with additional verifications. "when" keyword)
int someNumber = 5;
//int someNumber = 6;

try
{
    throw new DivideByZeroException();
}
catch (DivideByZeroException ex) when (someNumber == 5)
{
    Console.WriteLine(ex.Message + " someNumber is 5.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}





// Exception Handling (with your custom message)
try
{
    throw new DivideByZeroException("Please Don't Divide By Zero. You will see this message in catch block.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}





// Exception Handling (with parameter name)
string name;

try
{
    throw new ArgumentNullException("name", "Name can't be null.");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}





// Exception Handling (throw to the higher-level methods)
try
{
    ProcessTransfer(-100);  // Trying an invalid amount (-100)
}
catch (Exception ex)
{
    Console.WriteLine($"[Top level] Error: {ex.Message}");
}

void ProcessTransfer(decimal amount)
{
    try
    {
        TransferMoney(amount);
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine("Logging transfer error...");
        throw; // throw to the higher-level
    }
}

void TransferMoney(decimal amount)
{
    if (amount <= 0)
        throw new ArgumentOutOfRangeException(nameof(amount), "Transfer amount must be positive.");

    // Transfer logic (this part would contain the real business logic)

    Console.WriteLine($"Transfer succeeded: {amount} $.");
}





// Creating Custom Exceptions
try
{
    throw new MyOwnException();
}
catch (MyOwnException ex)
{
    Console.WriteLine(ex.Message);
}

class MyOwnException : Exception
{
    // first constructor
    public MyOwnException() : base("This is my Exception")
    {

    }

    // second constructor
    public MyOwnException(string message) : base(message)
    {

    }
}
/// Custom Exception MUST have at least one CONSTRUCTOR
