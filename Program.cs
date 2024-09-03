using System;
public class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction();

        Console.WriteLine("Input first fraction:");
        fraction1.Input();

        Console.WriteLine("Input second fraction:");
        fraction2.Input();

        Console.WriteLine("First fraction:");
        fraction1.Display();
        fraction1.DisplayAsDecimal();

        Console.WriteLine("Second fraction:");
        fraction2.Display();
        fraction2.DisplayAsDecimal();

        Fraction sum = fraction1.Add(fraction2);
        Console.WriteLine("Sum:");
        sum.Display();
        sum.DisplayAsDecimal();

        Fraction difference = fraction1.Subtract(fraction2);
        Console.WriteLine("Difference:");
        difference.Display();
        difference.DisplayAsDecimal();

        Fraction product = fraction1.Multiply(fraction2);
        Console.WriteLine("Product:");
        product.Display();
        product.DisplayAsDecimal();

        Fraction quotient = fraction1.Divide(fraction2);
        Console.WriteLine("Quotient:");
        quotient.Display();
        quotient.DisplayAsDecimal();
    }
    //  static void Main(string[] args)
    // {
    //     // Sử dụng constructor mặc định
    //     Person person1 = new Person();
    //     person1.DisplayPerson();

    //     // Sử dụng constructor có tham số
    //     Person person2 = new Person(25, "Chi");
    //     person2.DisplayPerson();

    //     // Sử dụng phương thức Input để nhập thông tin từ người dùng
    //     Person person3 = new Person();
    //     person3.Input();
    //     person3.DisplayPerson();

    //      // Sử dụng constructor mặc định
    //     Student student1 = new Student();
    //     student1.DisplayStudent();

    //     // Sử dụng constructor có tham số (age, name, gpa)
    //     Student student2 = new Student(20, "Alice", 3.5);
    //     student2.DisplayStudent();

    //     // Sử dụng constructor nạp chồng (name, gpa)
    //     Student student3 = new Student("Bob", 3.8);
    //     student3.DisplayStudent();

    //     // Sử dụng phương thức Input để nhập thông tin từ người dùng
    //     Student student4 = new Student();
    //     student4.Input();
    //     student4.DisplayStudent();
    // }
    // public static void Main(string[] args)
    // {
    //     // Dice.Main(args);
    //     // Console.WriteLine("hello Chí");
    //     Dice dice = new Dice(20);
    //     Console.WriteLine(dice.Roll());
    // }
}
