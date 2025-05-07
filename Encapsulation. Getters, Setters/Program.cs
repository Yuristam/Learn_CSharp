// Encapsulations. Getters, Setters


// Automatic Properties
public class Person
{
    public string Name { get; set; } // auto-property
    public string Address { get; set; } = "New-York"; // auto-property with default value
}





// Without validation (with properties)
class Human
{
    public string Name;
    public int Age;
}

Human human = new Human();
human.Name = "456^%$3";    // Incorrect Name
human.Age = -50;           // Incorrect Age


// Solving the Problem (Long Option)
class Human
{
    private int _age;
    
    public int GetAge()
    {
        return _age;
    }

    public void SetAge(int value)
    {
        // Validation for correct age value
        if (value > 0 || value < 100) {
            _age = value;
        }
    }
}


// Solving the Problem (Short Option: using getter & setter)
class Human
{
    private int _age;

    public int Age
    {
        get
        {
            return _age;
        }

        set
        {
            // Validation for correct age value
            if (value > 0 || value < 100)
            {
                _age = value;
            }
        }
    }
}





// Getter & Setter (with Access Modifiers)
public class Account
{
    private decimal _balance;

    public decimal Balance
    {
        get => _balance;
        private set  // private Access Modifier
        {
            if (value >= 0)
                _balance = value;
        }
    }
}





// Read-Only Properties
public string Email { get; } // only "get"


// Write-Only Properties
private string _secret;
public string Secret
{
    set { _secret = value; }
}





// Encapsulation in Constructors
public class User
{
    public string Username { get; }
    private string password;

    public User(string username, string password)
    {
        Username = username;
        SetPassword(password);
    }

    private void SetPassword(string pwd)
    {
        if (pwd.Length >= 8)
            password = pwd;
    }
}
