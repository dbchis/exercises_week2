public class Student : Person
{
    // Fields
    private double gpa;

    // Properties
    public double Gpa
    {
        get { return gpa; }
        set
        {
            if (value < 0.0 || value > 4.0)
                throw new ArgumentException("GPA must be between 0.0 and 4.0.");
            gpa = value;
        }
    }

    // Constructors
    public Student() : base()
    {
        gpa = 0.0;
    }

    public Student(int age, string name, double gpa) : base(age, name)
    {
        Gpa = gpa;
    }

    // Overloaded constructor
    public Student(string name, double gpa) : base(name)
    {
        Gpa = gpa;
    }

    // Methods
    public void DisplayStudent()
    {
        Console.WriteLine(ToString());
    }

    public new void Input()
    {
        base.Input();

        Console.Write("Enter GPA: ");
        while (!double.TryParse(Console.ReadLine(), out gpa) || gpa < 0.0 || gpa > 4.0)
        {
            Console.WriteLine("Invalid input. Please enter a GPA between 0.0 and 4.0.");
            Console.Write("Enter GPA: ");
        }
    }

    public override string ToString()
    {
        return base.ToString() + $", GPA: {Gpa}";
    }


}