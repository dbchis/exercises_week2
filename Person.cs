public class Person
{
    // Fields
    private int age;
    private string name;

    // Properties
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Age cannot be negative.");
            age = value;
        }
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty or whitespace.");
            name = value;
        }
    }

    // Constructors
    public Person()
    {
        age = 0;
        name = "None";
    }

    public Person(int age, string name)
    {
        Age = age;
        Name = name;
    }
    // New constructor to accept only name
    public Person(string name)
    {
        age = 0; // Default age
        Name = name;
    }
    // Methods
    public void DisplayPerson()
    {
        Console.WriteLine(ToString());
    }

    public void Input()
    {
        Console.Write("Enter name: ");
        Name = Console.ReadLine();

        Console.Write("Enter age: ");
        while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer for age.");
            Console.Write("Enter age: ");
        }
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
   
}