/* 
    Operator Overloading - это механизм, который позволяет определить, как стандартные операторы 
    (например +, -, ==, <, >) будут работать с объектами пользовательских (своих) классов и структур.

    ❕ Проще говоря: ты можешь «научить» C# понимать, что значит, например, сложить два ТВОИХ объекта.

    
    ⚙️ Правила перегрузки операторов:

    1. Метод обязательно должен быть public static.
    2. Можно перегружать только определённые операторы (например +, -, *, /, %, ==, !=, <, >, <=, >=, !, true, false, ++, --, и т.д.).
    3. Нельзя перегружать логические операторы && и || напрямую — нужно перегрузить true и false.
    4. Оператор присваивания = не перегружается.
    5. Если перегружаешь ==, нужно также перегрузить !=.
    6. Перегрузка операторов часто требует переопределения Equals() и GetHashCode(), особенно для сравнения. 
*/


var v1 = new Vector(2, 3);
var v2 = new Vector(1, 4);
var result = v1 + v2;

Console.WriteLine(result);


public class Vector
{
    public double X { get; set; }
    public double Y { get; set; }

    public Vector(double x, double y)
    {
        X = x;
        Y = y;
    }

    public static Vector operator +(Vector a, Vector b)
    {
        return new Vector(a.X + b.X, a.Y + b.Y);
    }

    public static bool operator ==(Vector a, Vector b)
    {
        return a.X == b.X && a.Y == b.Y;
    }

    public static bool operator !=(Vector a, Vector b)
    {
        return !(a == b);
    }

    public override string ToString() => $"({X}, {Y})";
}





Apple redApple = new Apple("Red Apple", 100);
Apple greenApple = new Apple("Green Apple", 120);


var sumApple = Apple.Add(redApple, greenApple);     // without operator overloading
var sumApple2 = redApple + greenApple;              // operator overloading
var sumApple3 = redApple + 300;                     // operator overloading with another parameter


Console.WriteLine(sumApple);                        // Output: 220
Console.WriteLine(sumApple2);                       // Output: 220
Console.WriteLine(sumApple3);                       // Output: 400


Console.WriteLine(redApple == greenApple);          // Output: False
Console.WriteLine(sumApple == sumApple2);           // Output: True



public class Apple
{
    public string Name { get; }
    public double Weight { get; }

    public Apple(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }


    // Это метод прибавления двух объектов
    public static Apple Add(Apple apple1, Apple apple2)
    {
        var totalWeight = apple1.Weight + apple2.Weight;
        var apple = new Apple("Apple", totalWeight);

        return apple;
    }

    // Перегрузка оператора + (делает тоже самое, что метод сверху)
    public static Apple operator +(Apple a, Apple b)
    {
        var totalWeight = a.Weight + b.Weight;
        var apple = new Apple("Apple", totalWeight);

        return apple;
    }


    // Перегрузка оператора с изменением параметров
    public static Apple operator +(Apple a, double weight)
    {
        var apple = new Apple(a.Name, a.Weight + weight);

        return apple;
    }


    // Перегрузка операторов сравнения
    public static bool operator ==(Apple apple1, Apple apple2)
    {
        return apple1.Name == apple2.Name;
    }

    public static bool operator !=(Apple apple1, Apple apple2)
    {
        return apple1.Name != apple2.Name;
    }


    public override string ToString()
    {
        return $"{Name}. Weight: {Weight}";
    }
}
