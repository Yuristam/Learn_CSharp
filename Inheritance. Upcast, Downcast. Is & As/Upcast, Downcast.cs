Father father = new Father();
father.Name = "John";
father.Age = 50;
father.SayHello();
father.DoWork();

// Console.WriteLine(father.wallet);  // Error: can't access to the private field 
// Console.WriteLine(father.money);   // Error: can't access to the protected field 


/// Upcast - converting "child" class into "parent" class
Grandfather man = father;
// man.DoWork(); // Error: we can't use "child" class method 


/// Downcast - converting "parent" class into "child" class
Father dad = (Father)man;


class Grandfather
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void SayHello()
    {
        Console.WriteLine("How do you do?");
    }
}

class Father : Grandfather
{
    private Wallet wallet = new Wallet();  // only this class can access it (because it's private)
    protected Money money = new Money();   // only this class and "child" classes can access it (because it's protected)

    public void DoWork()
    {
        Console.WriteLine("Working");
    }
}

class Child : Father
{
    public void SpendMoney()
    {
        Console.WriteLine("Spending " + money);  // "money"(variable) from "parent" class
                                                 // we can't use wallet here, because it's private in "parent" class
    }
}

class Wallet { }
class Money { }