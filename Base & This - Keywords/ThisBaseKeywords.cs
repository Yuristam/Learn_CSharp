/*// "this" keyword
class Foo
{
    int a;  // this "a" (variable)

    public void Bar(int a) // NOT this "a"
    {
        this.a = a;
    }
}


class Joo
{
    private int number; // this "number"

    public Joo(int number) // not this
    {
        this.number = number;
    }

    public void Print()
    {
        Console.WriteLine(this.number);
    }
}
/// Refers to the CURRENT class instance





// "base" keyword
public class Animal
{
    protected string name = "Bobik";

    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        base.Speak(); // Calls Animal.Speak()
        Console.WriteLine("Dog barks");
    }

    public void ShowName()
    {
        Console.WriteLine(base.name); // this name is from "Animal" class
    }
}
/// "base" - calls parent class method
*/