/* 
    Casting datatypes in C#

    1) Convert
    2) Parse
    3) TryParse
    4) implicit
    5) explicit
    6) as
    7) is
*/


// Convert
int number = Convert.ToInt32("123");            // Output: 123
int? nullableNum = Convert.ToInt32(null);       // Output: 0 (не выбросит исключение!)


// Parse
int number = int.Parse("123");                  // Output: 123
int number2 = int.Parse(null);                  // ❌ ArgumentNullException
int number3 = int.Parse("abc");                 // ❌ FormatException


// TryParse
if (int.TryParse("123", out int number))
{
    Console.WriteLine(number);                  // Output: 123
}
else
{
    Console.WriteLine("Ошибка, неверный формат!");
}


// implicit
int x = 10;
double y = x;


// explicit
double y = 9.8;
int x = (int)y;


// as
object obj = "hi";
string s = obj as string;           // Возвращает null, если нельзя привести. Не выбрасывает исключение!


// is 
if (obj is string str)
{
    Console.WriteLine(str);         // Проверяет тип перед приведением (возвращает true или false). Не выбрасывает исключение!
}
