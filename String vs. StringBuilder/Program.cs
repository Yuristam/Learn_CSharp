using System.Diagnostics;
using System.Text;

// string +=
string str = "";

for (int i = 0; i < 3; i++)
{
    str += "x";
}

// 1. result = ""
// 2. result = "" + "x"     => "x"      → ❗ new object created (+1)
// 3. result = "x" + "x"    => "xx"     → ❗ second new object created (+2)
// 4. result = "xx" + "x"   => "xxx"    → ❗ third new object created (+3)


// StringBuilder
StringBuilder sb1 = new StringBuilder();

for (int i = 0; i < 3; i++)
{
    sb1.Append("x");
}

// 1. creates array of chars (char[])       size by default = 16 chars
// 2. adds each symbol to array =>     [x][x][x][ ][ ][ ][ ][ ]...
// 3. if symbols overflow array, it creates new array 2 times larger
// 3. sb.ToString() creates single string






// Time comparing
var sw = Stopwatch.StartNew();

string s = "";
for (int i = 0; i < 100000; i++)
    s += "x";

sw.Stop();
Console.WriteLine("string += time: " + sw.ElapsedMilliseconds + " ms");          // string +=

sw.Restart();

StringBuilder sb = new StringBuilder();
for (int i = 0; i < 100000; i++)
    sb.Append("x");

string result = sb.ToString();

sw.Stop();
Console.WriteLine("StringBuilder time: " + sw.ElapsedMilliseconds + " ms");      // StringBuilder.Append()
