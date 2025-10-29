/*
    Equals() vs. ==

    Value Types       | Сравнивает по ЗНАЧЕНИЮ
    Reference Types   | Сравнивает по ССЫЛКЕ
    String            | Сравнивает по ЗНАЧЕНИЮ (Текст)
*/


// Value Types:
int a = 5;
int b = 5;

Console.WriteLine(a == b);              // ✅ Output: True (сравнивает по ЗНАЧЕНИЯМ, а значения равны)
Console.WriteLine(a.Equals(b));         // ✅ Output: True (сравнивает по ЗНАЧЕНИЯМ, а значения равны)


// Reference Types:
object o1 = new object();
object o2 = new object();

Console.WriteLine(o1 == o2);            // ❌ Output: False (сравнивает по ССЫЛКАМ, а ссылки разные)
Console.WriteLine(o1.Equals(o2));       // ❌ Output: False (сравнивает по ССЫЛКАМ, а ссылки разные)


// string:
string s1 = "hello";
string s2 = "hello";

Console.WriteLine(s1 == s2);            // ✅ Output: True (сравнивает по ТЕКСТУ)
Console.WriteLine(s1.Equals(s2));       // ✅ Output: True (сравнивает по ТЕКСТУ)





// object -> new string 
object o1 = "asdf";
object o2 = new string("asdf");

Console.WriteLine(o1 == o2);            // ❌ Output: False (сравнивает по ССЫЛКАМ, а ссылки разные)
Console.WriteLine(o1.Equals(o2));       // ✅ Output: True (сравнивает по ТЕКСТУ, так как Equals() переопределен по умолчанию)

/* 
    Метод Equals() — виртуальный, и вызывается реальная реализация типа, который хранится в переменной.
    Внутри o1 лежит объект типа string, а string переопределяет Equals, чтобы сравнивать содержимое текста.
    Поэтому вызывается string.Equals(...), а не object.Equals(...)
    Вот такая вот особенность!
*/





// Интернирование строк
object o1 = "asdf";
object o2 = "asdf";
// оба указывают на один и тот же участок в памяти, т.к. "asdf" кеширован 

Console.WriteLine(o1 == o2);            // ✅ Output: True
Console.WriteLine(o1.Equals(o2));       // ✅ Output: True

/*
    Что такое string interning?
    C# (и CLR) автоматически кэширует строковые литералы, чтобы одинаковые строки в коде указывали на один и тот же объект в памяти.
    
    Это делается для:
    ✅ экономии памяти, 
    ✅ ускорения сравнение строк, 
    ✅ избежать лишних аллокаций (new string)
*/

/// То есть "asdf" — это один объект, помещённый в так называемое string intern pool (пул строк).


object o1 = "asdf";
object o2 = new string("asdf");
/// указывают на разные участки в памяти, т.к. есть ключевое слово "new"

Console.WriteLine(object.ReferenceEquals(o1, o2));          // ❌ Output: False (сравнение по ссылкам, т.к. object)
Console.WriteLine(o1 == o2);                                // ❌ Output: False (сравнение по ссылкам, т.к. object)
Console.WriteLine(o1.Equals(o2));                           // ✅ Output: True  (сравнение по Тексту)


// string.Intern()
/// это принудительное интернирование строк вручную
string s1 = new string("asdf");
string s2 = string.Intern(s1);

Console.WriteLine(object.ReferenceEquals(s1, s2));          // ❌ Output: False (разные объекты)
Console.WriteLine(object.ReferenceEquals(s2, "asdf"));      // ✅ Output: True  (обе из пула)





// null
string a3 = null;   // переменная не ссылается ни на какой объект.
string a4 = null;   // переменная не ссылается ни на какой объект.

Console.WriteLine(a4 == a3);       // ✅ Output: True (== проверяет равны ли ссылки для объектов)
Console.WriteLine(a4.Equals(a3));  // ❌ Output: NullReferenceException

/// ==        -> проверяет равны ли ссылки для объектов. Так как обе ссылки null, то вернет True.
/// Equals()  -> Если переменной самой не существует (null) и вызвать на ней метод, будет исключение: NullReferenceException

/// Для ReferenceType: null — это «никакой объект», поэтому разные переменные null ФАКТИЧЕСКИ РАВНЫ по ссылке.
/// Для ValueType null возможен только через Nullable<T> (то есть, типа int?), и == тоже вернёт true, если обе null


int a = null;   // Error: Cannot convert null to 'int'
int? b = null;
int? c = null;

Console.WriteLine(b == c);          // ✅ Output: True (так как оба null)
Console.WriteLine(b.Equals(c));     // ✅ Output: True (так как оба null)





// a.Equals(b); vs. Equals(a, b);
string x = null;
string y = null;

Console.WriteLine(x.Equals(y));     // ❌ Output: NullReferenceException
Console.WriteLine(Equals(x, y));    // ✅ Output: True (так как оба null)

/// a.Equals(b)   -> кидает NullReferenceException при null
/// Equals(a, b)  -> статический метод object.Equals, НЕ кидает Exception при null, а возвращает false





// Equals() vs. ReferenceEquals()
string s1 = "hello";
string s2 = new string("hello");

Console.WriteLine(s1.Equals(s2));                      // ✅ Output: True  (сравнивает по тексту. true т.к. значения равны) 
Console.WriteLine(object.ReferenceEquals(s1, s2));     // ❌ Output: False (сравнивает СТРОГО по ссылке. false, т.к. объекты разные)


object o1 = null;
object o2 = null;

Console.WriteLine(object.ReferenceEquals(o1, o2));     // ✅ Output: True (сравнивает по ссылке, т.к. оба объекта null, возвращает true)
Console.WriteLine(o1.Equals(o2));                      // ❌ Output: NullReferenceException

/*
    ReferenceEquals():
    ✅ Проверяет: указывают ли переменные на один и тот же объект в памяти (т.е. сравнивает строго по ссылке).
    ✅ Нельзя переопределить.
    ✅ Работает только для ссылочных типов.
    ✅ При null, НЕ кидает Exception.

    Equals():
    ✅ Может быть переопределён в классе.
    ✅ Для value-типа сравнивает значения, для string — текст, для reference-типа — по умолчанию ссылки.
    ✅ При null, кидает NullReferenceException.
*/


object x = null;
object y = null;
object z = "z";

Console.WriteLine(Equals(x, y));                        // ✅ Output: True  (т.к. оба null)
Console.WriteLine(Equals(x, z));                        // ❌ Output: False (т.к. только один из них null)

Console.WriteLine(ReferenceEquals(x, y));               // ✅ Output: True  (т.к. оба null)
Console.WriteLine(ReferenceEquals(x, z));               // ❌ Output: False (т.к. только один из них null)
