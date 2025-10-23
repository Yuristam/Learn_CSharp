/*
    String Methods:
    1. ToLower(), ToUpper()
    2. Contains()
    3. StartsWith(), EndsWith()
    4. Equals()
    5. IndexOf(), LastIndexOf()
    6. Insert()
    7. PadLeft(), PadRight()
    8. Remove(), Replace()
    9. Substring()
    10. ToCharArray()
    11. Trim(), TrimStart(), TrimEnd()
    12. Split()

    String Fields:
    1. Length
*/


string myStr1 = "Hard choices, easy life. Easy choices, hard life.";
string myStr2 = "Hello!";
string myStr3 = "f";
string myStr4 = "John";
string myStr5 = "You can (not) do it";


// String Length
int length2 = myStr1.Length;               // Output: 49
int length1 = myStr2.Length;               // Output: 6


// To lower and upper cases
string lowerCase = myStr2.ToLower();      // Output: hello!
string upperCase = myStr2.ToUpper();      // Output: HELLO!


// If string contains value
myStr1.Contains("choice");                // Output: True
myStr1.Contains(myStr2);                // Output: False


// Starts & Ends With
myStr1.StartsWith('H');                   // Output: True
myStr1.StartsWith("h",true,null);         // Output: True (ignoring uppercase, lowercase)
myStr1.EndsWith(".");                     // Output: True
myStr1.EndsWith("h",true,null);           // Output: False (ignoring uppercase, lowercase)


// Equals
myStr3.Equals('f');    // Output: False
myStr3.Equals("f");    // Output: True


// Index Of
myStr2.IndexOf('j');   // Output: -1 (this word doesn't contain this char)
myStr2.IndexOf('o');   // Output: 4
myStr2.LastIndexOf('l'); // Output: 3 (second 'l' in 'Hello!')


// Insert
myStr2.Insert(2, myStr4); // Output; HelJohnlo!
myStr2.Insert(0, myStr4); // Output; JohnHello!
myStr2.Insert(length1, myStr4); // Output; Hello!John


// Padding (Смещение)
myStr2.PadLeft(7);      // Output; ' Hello!'
myStr2.PadLeft(14);      // Output; '        Hello!'
myStr2.PadLeft(9, 'e'); // Output: eeeHello!
myStr2.PadRight(8,'e'); // Output: Hello!ee


// Remove
myStr5.Remove(8,6); // Output: You can do it
myStr5.Remove(8);   // Output: You can


// Replace
myStr2.Replace("He","Ok"); // Output: Okllo!


// Substring
myStr2.Substring(1);   // Output: ello!
myStr4.Substring(0,1); // Output: J
myStr5.Substring(14,5); // Output: do it


// ToCharArray
myStr4.ToCharArray(); // Result: new char array {'J' 'o' 'h' 'n'}


// Trim
myStr2.Trim();
myStr2.TrimEnd();
myStr2.TrimStart();


// Split
string[] subs = myStr5.Split(' ');

foreach (var sub in subs)
{
    Console.WriteLine($"Substring: {sub}");
}

// This example produces the following output:
//
// Substring: You
// Substring: can
// Substring: (not)
// Substring: do
// Substring: it.
