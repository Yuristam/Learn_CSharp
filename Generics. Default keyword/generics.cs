// without Generic<T>
public class Product
{
    public string Name { get; set; }
    public int Weight { get; set; }
    public int Size { get; set; }

    public Product(string name, int weight, int size)
    {
        Name = name;
        Weight = weight;
        Size = size;
    }
}

// with Generic<T>
public class Product<T>
{
    public string Name { get; set; }
    public T Weight { get; set; }
    public int Size { get; set; }

    public Product(string name, T weight, int size)
    {
        Name = name;
        Weight = weight;
        Size = size;
    }
}

// with 2 parameter Generic<T>
public class Product<TWeight, TSize>
{
    public string Name { get; set; }
    public TWeight Weight { get; set; }
    public TSize Size { get; set; }

    public Product(string name, TWeight weight, TSize size)
    {
        Name = name;
        Weight = weight;
        Size = size;
    }
}


public class Apple : Product
{
    public Apple(string name, int weight, int size) : base(name, weight, size)
    {
        
    }
}

public class Banana : Product
{
    public Banana(string name, int weight, int size) : base(name, weight, size)
    {

    }
}


// using key word "where"
public class Eating<T> 
    where T : Product
{
    public int SatietyLevel { get; private set; }  

    public void Add(T product)
    {
        SatietyLevel += product.Weight * product.Size;
    }
}
/// ❕ "where" значит, что тип Т должен быть либо Product-ом, либо любым его наследником



// default 
public class Animal<T>
{
    public string Name { get; set; }
    public T Weight { get; set; }

    public Animal(string name, T weight)
    {
        Name = name;
        Weight = default(T);    // Значение по умолчанию, например для int это 0
    }
}





// Примеры использования


// without Generic<T>
var product = new Product("Red Apple", 34, 34);
var product2 = new Product("Green Apple", 53.3, 24);      // Error: не удается преобразовать тип int в тип double 

// with Generic<T>
var product3 = new Product<double, int>("Green Apple", 53.5, 24);      // работает


// пример для where
var eating = new Eating<int>();                     // Error: тип int не является наследником класса Product
var eatingSomething = new Eating<Product>();        // Работает
var eatingBanana = new Eating<Banana>();            // Работает
var eatingApple = new Eating<Apple>();              // Работает


// пример default
int a = default;
