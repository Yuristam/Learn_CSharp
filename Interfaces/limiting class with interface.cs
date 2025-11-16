// можно ограничить функционал класса используя интерфейсы
interface ISummator
{
    int Sum(int a, int b);
}

class Calculator : ISummator
{
    // метод интерфейса
    public int Sum(int a, int b)
    {
        return a + b;
    }
    
    // метод самого класса
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    // метод самого класса
    public int Multiply(int a, int b)
    {
        return a * b;
    }
    
    // метод самого класса
    public int Divide(int a, int b)
    {
        return a / b;
    }
}


Calculator calculator = new Calculator();
calculator.Subtract(5, 6);              // Работает, так как здесь класс Calculator


ISummator summator = new Calculator();
summator.Sum(5, 6);                     // Работает
summator.Subtract(5, 6);                // Error: этого метода нет у интерфейса
