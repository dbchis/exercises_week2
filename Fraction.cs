public class Fraction
{
    // Fields
    private int numerator;
    private int denominator;

    // Properties
    public int Numerator
    {
        get { return numerator; }
        set { numerator = value; }
    }

    public int Denominator
    {
        get { return denominator; }
        set
        {
            if (value == 0)
                throw new ArgumentException("Denominator cannot be zero.");
            denominator = value;
        }
    }

    // Constructors
    public Fraction()
    {
        numerator = 0;
        denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
        Normalize();
    }

    // Methods
    public void Input()
    {
        Console.Write("Enter numerator: ");
        Numerator = int.Parse(Console.ReadLine());

        Console.Write("Enter denominator: ");
        Denominator = int.Parse(Console.ReadLine());

        Normalize();
    }

    public Fraction Add(Fraction other)
    {
        int newNumerator = this.Numerator * other.Denominator + other.Numerator * this.Denominator;
        int newDenominator = this.Denominator * other.Denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public Fraction Subtract(Fraction other)
    {
        int newNumerator = this.Numerator * other.Denominator - other.Numerator * this.Denominator;
        int newDenominator = this.Denominator * other.Denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public Fraction Multiply(Fraction other)
    {
        int newNumerator = this.Numerator * other.Numerator;
        int newDenominator = this.Denominator * other.Denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public Fraction Divide(Fraction other)
    {
        if (other.Numerator == 0)
            throw new DivideByZeroException("Cannot divide by a fraction with a numerator of zero.");
        
        int newNumerator = this.Numerator * other.Denominator;
        int newDenominator = this.Denominator * other.Numerator;
        return new Fraction(newNumerator, newDenominator);
    }

    public void Display()
    {
        Console.WriteLine($"({Numerator}/{Denominator})");
    }

    public void DisplayAsDecimal()
    {
        Console.WriteLine((double)Numerator / Denominator);
    }

    private void Normalize()
    {
        int gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
        Numerator /= gcd;
        Denominator /= gcd;

        // Ensure the denominator is positive
        if (Denominator < 0)
        {
            Numerator = -Numerator;
            Denominator = -Denominator;
        }
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}