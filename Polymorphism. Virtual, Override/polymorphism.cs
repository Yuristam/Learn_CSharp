// Polymorphism

Animal[] animals = new Animal[5];

Dog dog = new Dog();
dog.Name = "Rex";

Cat cat = new Cat();
cat.Name = "Barsik";

Fish fish = new Fish();
fish.Name = "Nemo";

Bird bird = new Bird();
bird.Name = "Falco";

Crocodile crocodile = new Crocodile();
crocodile.Name = "Shnappi";

animals[0] = dog;
animals[1] = cat;
animals[2] = fish;
animals[3] = bird;
animals[4] = crocodile;

for (int i = 0; i < animals.Length; i++)
{
    animals[i].Eat();
}

Cat pet = new Cat();
pet.Name = "Boris";

Animal animal = pet;
pet.Eat();      // Output: "Cat is eating"


class Animal
{
    public string Name { get; set; }
    
    public virtual void Eat()  // "virtual" keyword allows to OVERRIDE (Change) method in "child" classes
    {
        Console.WriteLine("Animal is eating.");
    }
}

class Dog : Animal
{
    public override void Eat()  // "override" keyword CHANGES method implementation in "child" class
    {
        Console.WriteLine("Dog is eating");
    }
}

class Cat: Animal
{
    public override void Eat()  // "override" keyword CHANGES method implementation in "child" class
    {
        Console.WriteLine("Cat is eating");
    }
}

class Fish : Animal
{
    public override void Eat() // "override" keyword CHANGES method implementation in "child" class
    {
        Console.WriteLine("Fish is eating");
    }
}

class Bird : Animal
{
    public override void Eat() // "override" keyword CHANGES method implementation in "child" class
    {
        Console.WriteLine("Bird is eating");
    }
}

class Crocodile : Animal
{
    // this class will implement "base"(parent) method
}