Joo joo = new Joo();
Foo foo = new Foo();

Console.WriteLine(joo.GetMax(4,5));                                     // Output: 5
Console.WriteLine(joo.GetMax("Hello", "Hi"));                           // Output: Hello
Console.WriteLine(foo.GetMax(4, 5, 8, 9, 1, 2, 4, 13, 25, 88, 15));     // Output: 88       // with params

int[] arr = new int[] { 1, 2, 3, 52, 32, 15, 2 };
Console.WriteLine(foo.GetMax(arr));                                     // Output: 52       // with params





// Method overloading
public class Joo
{
    public int GetMax(int a, int b)
    {
        return a > b ? a : b;
    }

    public string GetMax(string a, string b)
    {
        return a.Length > b.Length ? a : b;
    }
}


// params
public class Foo
{
    // gets 2 parameters
    public int GetMax(int a, int b)
    {
        return a > b ? a : b;
    }

    // gets 3 parameters
    public int GetMax(int a, int b, int c)
    {
        int[] args = new int[] { a, b, c };
        int result = args[0];

        for (int i = 0; i < args.Length; i++)
        {
            if (result < args[i])
            {
                result = args[i];
            }
        }

        return result;
    }

    // gets 4 parameters
    public int GetMax(int a, int b, int c, int d)
    {
        int[] args = new int[] { a, b, c, d };
        int result = args[0];

        for (int i = 0; i < args.Length; i++)
        {
            if (result < args[i])
            {
                result = args[i];
            }
        }

        return result;
    }

    // params gets ♾ parameters (with the same data type)
    public int GetMax(params int[] args)
    {
        int result = args[0];

        for (int i = 0; i < args.Length; i++)
        {
            if (result < args[i])
            {
                result = args[i];
            }
        }

        return result;
    }
}