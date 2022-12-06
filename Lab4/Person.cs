using System;
using System.Security.Cryptography;

class Person
{
    private string name;
    private int birthYear;
    private DateTime date = DateTime.Today;

    public string Name
    {
        get { return name; }
    }

    public int BirthYear
    {
        get { return birthYear; }
    }

    public Person() : this("Vlad", 2003)
    {
    }
    public Person(string name, int birthYear)
    {
        this.name = name;
        this.birthYear = birthYear;
    }

    public void Age()
    {
        birthYear = date.Year - birthYear;
        Console.WriteLine(birthYear);
    }

    public void Input()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine("Введіть ім'я:");
        this.name = Console.ReadLine();
        Console.WriteLine("Рік народження:");
        this.birthYear = Convert.ToInt32(Console.ReadLine());
    }

    public void ChangeName(string newName)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        this.name = newName;
        Console.WriteLine($"Ваше ім'я було змінено на: {newName}");
    }

    public void Output()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine($"Ім'я: {this.name}, Вік: {this.birthYear}");
    }

    public override string ToString()
    {
        return $"Ім'я: {this.name}, Вік: {this.birthYear}";
    }

    public static bool operator ==(Person p1, Person p2)
    {
        return (p1.name == p2.name);
    }
    public static bool operator !=(Person p1, Person p2)
    {
        return (p1.name != p2.name);
    }
    public void Comparison(Person p1, Person p2)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        if (p1 == p2)
        {
            Console.WriteLine($"Особи з однаковими іменами, їх інформація: {p1}; {p2}");
        }
        else
        {
            Console.WriteLine($"В осіб не однакові імена");
        }
    }
}
