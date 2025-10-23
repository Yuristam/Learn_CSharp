/*
    | Ref                                        | Out                   | In
    |                                            |                       |
    | MUST BE initialized                        | CAN BE uninitialized  | ONLY for read, we CAN'T change value
    | can change the value, but NOT NECESSARY    | MUST change the value | USED mostly for big STRUCTURES (variable)
*/



// without ref
void Change(int x) // Method created the COPY of the variable
{
    x = 100;
}

int a = 5;
Change(a);
Console.WriteLine(a); // Output: 5



// ref
void AddBonus(ref int salary) // Method modified the ORIGINAL variable
{
    salary += 1000;
}

int mySalary = 5000;
AddBonus(ref mySalary);
Console.WriteLine(mySalary); // Output: 6000



// In this case we are using the same int(variable), so it won't create a COPY of this variable
int i = 1;

void Increment()
{
    i++;
}

Increment();
Console.WriteLine(i); // Output: 2



// out
void GetValues(out int a, out int b) // Method modified the ORIGINAL variables
{
    a = 10;
    b = 20;
}

int x = 4, y = 5;
GetValues(out x, out y);
Console.WriteLine($"{x}, {y}"); // Output: 10, 20



// in
void PrintPoint(in Point p)
{
    // p.X = 10; // ERROR: can't change the value, readonly
    Console.WriteLine($"X: {p.X}, Y:{p.Y}");
}

Point point = new Point { X = 1, Y = 2 };
PrintPoint(in point);

struct Point
{
    public int X;
    public int Y;
}
