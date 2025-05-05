// Boxing vs. Unboxing
// value type => object    boxing
// object => value type    unboxing



// boxing
int num = 42;
object boxed = num;     // boxing. This is a COPY of num(variable)

num = 100;

Console.WriteLine(boxed); // Output: 42 (COPY variable (in Heap))
Console.WriteLine(num);   // Output: 100 (ORIGINAL variable (in Stack))



// unboxing
object unbox = 78;
int num2 = (int)unbox; // unboxing

Console.WriteLine(num2); // Output: 78
