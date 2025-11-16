interface ICar
{
    int Move(int distance);
}

interface IHuman
{
    int Move(int distance);
}


class BMW : ICar
{
    public int Move(int distance)
    {
        return distance * 250;
    }
}

class Person : IHuman
{
    public int Move(int distance)
    {
        return distance * 5;
    }
}

// использование методов с похожими именами
class Cyborg : ICar, IHuman
{
    int ICar.Move(int distance)
    {
        return distance * 100;
    }

    int IHuman.Move(int distance)
    {
        return distance * 5;
    }
}





var car = new BMW();
var person = new Person();
var cyborg = new Cyborg();

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
