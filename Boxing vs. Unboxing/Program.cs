// Boxing vs. Unboxing
// value type => object    boxing
// object => value type    unboxing



// boxing
int num = 42;
object boxed = num;     // boxing. This is a COPY of num(variable)

num = 100;

Console.WriteLine(boxed); // Output: 42 (COPY variable (in Heap))
Console.WriteLine(num);   // Output: 100 (ORIGINAL variable (in Stack))



// unboxing
object unbox = 78;
int num2 = (int)unbox; // unboxing

Console.WriteLine(num2); // Output: 78


/*



using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        var sw = Stopwatch.StartNew();

        string s = "";
        for (int i = 0; i < 100000; i++)
            s += "x";

        sw.Stop();
        Console.WriteLine("string += time: " + sw.ElapsedMilliseconds + " ms");

        sw.Restart();

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 100000; i++)
            sb.Append("x");

        string result = sb.ToString();

        sw.Stop();
        Console.WriteLine("StringBuilder time: " + sw.ElapsedMilliseconds + " ms");
    }
}

*/