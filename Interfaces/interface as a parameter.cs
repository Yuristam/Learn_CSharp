public interface IFlyable
{
    void Fly();
}

public class Bird : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Bird flaps wings and flies");
    }
}

public class Airplane : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Airplane turns on engines and flies");
    }
}


public void MakeItFly(IFlyable thing)       // передаем интерфейс как параметр
{
    thing.Fly();
}



IFlyable b = new Bird();
IFlyable a = new Airplane();

MakeItFly(b); // Bird flaps wings and flies
MakeItFly(a); // Airplane turns on engines and flies



// Другой вариант полиморфизма + интерфейсов

public interface IFlyable
{
    void Fly();
}


public class Bird : IFlyable
{
    public void Fly() => Console.WriteLine("Bird flaps wings and flies");
}

public class Airplane : IFlyable
{
    public void Fly() => Console.WriteLine("Airplane turns on engines and flies");
}

public class Superhero : IFlyable
{
    public void Fly() => Console.WriteLine("Superhero flies using superpowers");
}


List<IFlyable> flyingThings = new List<IFlyable>()
{
    new Bird(),
    new Airplane(),
    new Superhero()
};

foreach (var thing in flyingThings)
{
    thing.Fly();
}

/*
    Output:
        Bird flaps wings and flies
        Airplane turns on engines and flies
        Superhero flies using superpowers
*/
