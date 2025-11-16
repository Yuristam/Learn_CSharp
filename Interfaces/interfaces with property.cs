interface ICar
{
    // Свойство интерфейса
    int Speed { get; set; }
    int Move(int distance);
}

interface IHuman
{
    int Move(int distance);
}


class BMW : ICar
{
    // Свойство интерфейса
    public int Speed { get; set; }

    public int Move(int distance)
    {
        return distance * Speed;
    }
}

class Person : IHuman
{
    public int Move(int distance)
    {
        return distance * 5;
    }
}


class Cyborg : ICar, IHuman
{
    // Свойство интерфейса
    public int Speed { get; set; }

    int ICar.Move(int distance)
    {
        return distance * Speed;
    }

    int IHuman.Move(int distance)
    {
        return distance * 5;
    }
}



var car = new BMW() { Speed = 250 };
var person = new Person();
var cyborg = new Cyborg() { Speed = 100 };

Console.WriteLine($"Машина проехала: {car.Move(25)} км");
Console.WriteLine($"Человек прошел: {person.Move(25)} км");

Console.WriteLine($"Киборг как машина проехал: {((ICar)cyborg).Move(25)} км");
Console.WriteLine($"Киборг как человек прошел: {((IHuman)cyborg).Move(25)} км");


/*
    Output: 
            Машина проехала: 6250 км
            Человек прошел: 125 км
            Киборг как машина проехал: 2500 км
            Киборг как человек прошел: 125 км
*/
