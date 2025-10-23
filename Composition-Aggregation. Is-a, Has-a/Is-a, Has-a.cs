/*
    Composition/Aggregation. "Has-a" Relationship (Composition). "Is-a" Relationship (Inheritance)
    
    🔹 Has-a. Когда один объект содержит в себе другой, то мы говорим о связи has-a
    🔸 Is-a. Это когда один класс наследует другой. «Кошка является Животным» → Cat is an Animal.
*/

// Has-a
// ниже в коде класс Board имеет массив Task-ов (т.е. имеет класс Task), а класс Task имеет класс Performer (т.е. работника).

Performer worker1 = new Performer("Ren");
Performer worker2 = new Performer("Levi");

Task[] tasks = { new Task(worker1, "Dug a pit."), new Task(worker2, "carry out grunt.") };

Board schedule = new Board(tasks);

schedule.ShowAllTasks();

class Performer
{
    public string Name;
    public Performer(string name)
    {
        Name = name;
    }
}

class Board
{
    public Task[] Tasks;
    public Board(Task[]tasks)
    {
        Tasks  = tasks;
    }
    public void ShowAllTasks()
    {
        for (int i = 0; i < Tasks.Length; i++)
        {
            Tasks[i].ShowInfo();
        }
    }
}

class Task
{
    public Performer Worker;
    public string Description;

    public Task(Performer worker, string description)
    {
        Worker = worker;
        Description = description;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Ответственный: {Worker.Name}\nОписание задачи: {Description}\n");
    }
}



// Связь Is-a
// классы Knight и Barbarian являются Warrior-ами

Knight warrior1 = new Knight(100,10);
Barbarian warrior2 = new Barbarian(100, 1, 7, 2);

warrior1.TakeDamage(500);
warrior2.TakeDamage(250);

Console.Write("Рыцарь: ");
warrior1.ShowInfo();
Console.Write("Варвар: ");
warrior2.ShowInfo();


class Warrior
{
    private protected int Health;
    private protected int Armor;
    private protected int Damage;

    public Warrior(int health, int armor, int damage)
    {
        Health = health;
        Armor = armor;
        Damage = damage;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage - Armor;
    }

    public void ShowInfo()
    {
        Console.WriteLine(Health);
    }
}

class Knight : Warrior
{
    public Knight(int health, int damage): base(health, 5, damage)
    {

    }
    public void Pray()
    {
        Armor += 2;
    }
}

class Barbarian : Warrior
{
    public Barbarian(int health, int armor, int damage, int attackSpeed) : base(health, armor, damage * attackSpeed)
    {

    }

    public void Shout()
    {
        Armor -= 2;
        Health += 10;
    }
}
