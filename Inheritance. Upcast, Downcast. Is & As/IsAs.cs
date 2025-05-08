// "is" keyword
Builder john = new Builder();
Person man = john;

if (man is Builder builder)
{
    builder.Build();
}



// "as" keyword
Driver driver = man as Driver;

if (driver != null)
{
    driver.Drive();
}





// "is" keyword
Animal pet = new Dog();

if (pet is Dog)
{
    Console.WriteLine("It's a dog!");
    pet.Speak();  // Output: Woof!
}

// C# 7+: pattern matching with type cast
if (pet is Dog rex)
{
    rex.Speak(); // Output: Woof!
}
/// Checks if an object is of a given type (or can be cast to that type). It returns a boolean.
/// great for CHECKING THE TYPE





// "as" keyword
Animal newPet = new Cat();

Dog dog = newPet as Dog;

if (dog != null)
{
    dog.Speak(); // Won't run because pet is actually a Cat
}
else
{
    Console.WriteLine("pet is not a Dog"); // Output: pet is not a Dog
}
/// Attempts to cast an object to a specific type. Returns null if the cast fails, instead of throwing an exception
/// used for SAFE CASTING





class Animal
{
    public virtual void Speak() => Console.WriteLine("Animal sound");
}

class Dog : Animal
{
    public override void Speak() => Console.WriteLine("Woof!");
}

class Cat : Animal
{
    public override void Speak() => Console.WriteLine("Meow!");
}





class Person
{
    public void DoWork() => Console.WriteLine("Working");
}

class Driver : Person
{
    public void Drive() => Console.WriteLine("Driving");
}

class Builder : Person
{
    public void Build() => Console.WriteLine("Building");
}