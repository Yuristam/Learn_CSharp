// Constructors

// Constructor Example
public class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}


// Use case:
var person = new Person("Alice", 30);





// Constructor Overloading
public class Car
{
    public string Brand;
    public int Year;

    // Default Constructor
    public Car()
    {
        Brand = "Unknown";
        Year = 0;
    }

    // Constructor with 1 parameter
    public Car(string brand)
    {
        Brand = brand;
        Year = 2020;
    }

    // Constructor with 2 parameters
    public Car(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }
}


// Use cases:
var car1 = new Car();                 // Brand = "Unknown", Year = 0
var car2 = new Car("Toyota");         // Brand = "Toyota", Year = 2020
var car3 = new Car("BMW", 2023);      // Brand = "BMW", Year = 2023





// "this" keyword in Constructors
public class Book
{
    public string Title;
    public int Pages;
    public string AuthorName;

    public Book() : this("No Title", 0)
    {
    }

    public Book(string title) : this(title, 100)
    {
    }

    public Book(string title, int pages)
    {
        Title = title;
        Pages = pages;
    }

    public Book(string title, int pages, string authorName) : this(title, pages)   // "this" parameter from previous constructor
    {
        AuthorName = authorName;
    }
}


// Use cases:
var book1 = new Book();                                         // Title = "No Title", Pages = 0
var book2 = new Book("Harry Potter");                           // Title = "Harry Potter", Pages = 100
var book3 = new Book("The Lord of the Rings", 350);             // Title = "The Lord of the Rings", Pages = 350
var book4 = new Book("Human Lost", 176, "Osamu Dazai");         // Title = "Human Lost", Pages = 176, AuthorName = "Osamu Dazai"





// "base" keyword in Constructors
public class Animal
{
    public string Name;

    public Animal(string name)
    {
        Name = name;
    }
}

public class Dog : Animal
{
    public string Breed;

    public Dog(string name, string breed) : base(name)
    {
        Breed = breed;
    }
}


// Use cases:
var dog = new Dog("Rex", "Labrador");
Console.WriteLine(dog.Name);  // Rex
Console.WriteLine(dog.Breed); // Labrador





// Constructor with Validation
public class Animal
{
    public string Name { get; }

    public Animal(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Animal's name can't be null.");

        Name = name;
    }
}

public class Dog : Animal
{
    public string Breed { get; }

    public Dog(string name, string breed) : base(name)
    {
        if (string.IsNullOrWhiteSpace(breed))
            throw new ArgumentException("Breed can't be null.");

        Breed = breed;
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} ({Breed}) is barking!");
    }
}


// Use cases:
try
{
    Dog dog = new Dog("Barsik", "Akita Inu");
    dog.Bark();  // Barsik (Akita Inu) is barking!

    Dog errorDog = new Dog("", "");  // throws exception
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
