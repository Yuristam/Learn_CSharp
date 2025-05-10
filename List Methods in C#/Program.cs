List<int> numbers = new List<int>() { 4, 25, 11, 52, 325, 62 };
List<string> messengers = ["WhatsApp", "Telegram"];
List<string> socialNetworks = new List<string>();
List<string> countries = ["USA", "Algeria", "Albania", "Germany", "China", "Canada"];
var words = new List<string> { "apple", "cat", "banana" };


// Add
socialNetworks.Add("YouTube");                           // [YouTube]
socialNetworks.Add("Facebook");                          // [YouTube, Facebook]
socialNetworks.Add("Instagram");                         // [YouTube, Facebook, Instagram]


// AddRange
socialNetworks.AddRange(messengers);                     // [YouTube, Facebook, Instagram] => [YouTube, Facebook, Instagram, WhatsApp, Telegram]


// Insert (index, <T> item)
socialNetworks.Insert(0, "TikTok");                      // [YouTube, Facebook, Instagram] => [TikTok, YouTube, Facebook, Instagram]


// InsertRange (index, list item)
socialNetworks.InsertRange(2, messengers);               // [YouTube, Facebook, Instagram] => [YouTube, Facebook, WhatsApp, Telegram, Instagram]


// Remove (<T> item)
socialNetworks.Remove("Instagram");                      // [YouTube, Facebook, Instagram] => [YouTube, Facebook]


// RemoveAt (index)
socialNetworks.RemoveAt(0);                              // [YouTube, Facebook, Instagram] => [Facebook, Instagram]


// RemoveRange (index, count)
socialNetworks.RemoveRange(0, 2);                        // [YouTube, Facebook, Instagram] => [Instagram]


// RemoveAll (condition)
socialNetworks.RemoveAll(x => x.StartsWith('I'));        // [YouTube, Facebook, Instagram] => [YouTube, Facebook]
numbers.RemoveAll(x => x < 25);                          // [4, 25, 11, 52, 325, 62] => [25, 52, 325, 62]


// Clear (delete everything)
socialNetworks.Clear();                                  // [YouTube, Facebook, Instagram] => []


// Contains(item)
socialNetworks.Contains("Reddit");                       // False


// IndexOf(item)
socialNetworks.IndexOf("Instagram");                     // [YouTube, Facebook, Instagram] => 2


// LastIndexOf(item)
socialNetworks.LastIndexOf("Instagram");                 // [YouTube, Facebook, Instagram] => 0


// Find (condition)
countries.Find(x => x.StartsWith("Al"));                 // [USA, Algeria, Albania, Germany, China, Canada] => Algeria
countries.Find(x => x.StartsWith("Ghana"));              // [USA, Algeria, Albania, Germany, China, Canada] => null


// FindLast (condition)
countries.FindLast(x => x.StartsWith("Al"));             // [USA, Algeria, Albania, Germany, China, Canada] => Albania


// FindAll (condition)
countries.FindLast(x => x.StartsWith('C'));              // [USA, Algeria, Albania, Germany, China, Canada] => China, Canada


// Exists (condition)
countries.Exists(x => x == "Zokovia");                   // [USA, Algeria, Albania, Germany, China, Canada] => false


// TrueForAll (condition)
bool allPositive = numbers.TrueForAll(n => n > 0);       // [4, 25, 11, 52, 325, 62] => True


// BinarySearch(item)
socialNetworks.BinarySearch("Instagram");                // [YouTube, Facebook, Instagram] => 2


// AsReadOnly  (can't modify)
socialNetworks.AsReadOnly();


// ConvertAll (converter)
List<string> strings = numbers.ConvertAll(n => n.ToString());    // [1, 2, 3] => ["1", "2", "3"]


// Reverse()
socialNetworks.Reverse();                                // [YouTube, Facebook, Instagram] => [Instagram, Facebook, YouTube]


// Reverse(index, count)
socialNetworks.Reverse(1,2);                             // [YouTube, Facebook, Instagram] => [YouTube, Instagram, Facebook]


// Sort()
socialNetworks.Sort();                                   // [YouTube, Facebook, Instagram] => [Facebook, Instagram, YouTube]


// Sort (comparer)
/// allows to create your own compare conditions
words.Sort(Compare);                                     // [apple, cat, banana] => [cat, apple, banana]

int Compare(string x, string y)
{
    return x.Length.CompareTo(y.Length);   // Compare by word length
}


// ToArray()
socialNetworks.ToArray();


// CopyTo(array)
var array = new string[] { };
socialNetworks.CopyTo(array);


// Capacity - size of list
socialNetworks.Capacity = 4;                             // Can hold 4 elements


// Count - gets all elements in list
Console.WriteLine(socialNetworks.Count);                 // [YouTube, Facebook, Instagram] => 3


foreach (var socialNetwork in socialNetworks)
{
    Console.WriteLine(socialNetwork);
}


// ForEach(action)
socialNetworks.ForEach(Console.WriteLine);


// TrimExcess (deletes empty slots of list)
socialNetworks.TrimExcess();