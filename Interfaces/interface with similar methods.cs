interface ICar
{
    int Move(int distance);
}

interface IHuman
{
    int Move(int distance);
}


// способ реализации каджого метода каждого интерфейса отдельно
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


var cyborg = new Cyborg();

Console.WriteLine($"Киборг как машина проехал: {((ICar)cyborg).Move(25)} км");
Console.WriteLine($"Киборг как человек прошел: {((IHuman)cyborg).Move(25)} км");

/*
    Output: 
            Киборг как машина проехал: 2500 км
            Киборг как человек прошел: 125 км
*/





// Способ реализации одного общего метода обоих интерфейсов
class Cyborg : ICar, IHuman
{
    public int Move(int distance)
    {
        return distance * 100;
    }
}


var cyborg = new Cyborg();

Console.WriteLine($"Киборг проехал: {cyborg.Move(25)} км");

/*
    Output: 
            Киборг проехал: 2500 км
*/
