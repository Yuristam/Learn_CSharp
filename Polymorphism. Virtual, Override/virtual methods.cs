NonPlayerCharacter[] characters =
{
    new NonPlayerCharacter(),
    new Farmer(),
    new Knight(),
    new Child()
};

foreach (var character in characters)
{
    character.ShowDescription();
    Console.WriteLine(new string('-', 40));
}


class NonPlayerCharacter
{
    public virtual void ShowDescription()
    {
        Console.WriteLine("I am NPC, I can only walk");
    }
}

class Farmer : NonPlayerCharacter
{
    public override void ShowDescription()
    {
        base.ShowDescription();
        Console.WriteLine("I'm also a farmer and I can work on fields.");
    }
}

class Knight : NonPlayerCharacter
{
    public override void ShowDescription()
    {
        Console.WriteLine("I'm a knight. I Can Fight");
    }
}

class Child : NonPlayerCharacter
{
    public override void ShowDescription()
    {
        base.ShowDescription();
    }
}
