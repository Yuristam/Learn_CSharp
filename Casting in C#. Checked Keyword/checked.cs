// Checked Keyword


// without "checked"
int a = int.MaxValue;      // Output: 2147483647 (Max Value of Int)
int b = a + 1;             // Output: -2147483648 (overflow)


// with "checked"
int c = int.MaxValue; 

checked
{
    int d = c + 1;          // throws OverflowException
    Console.WriteLine(d);
}