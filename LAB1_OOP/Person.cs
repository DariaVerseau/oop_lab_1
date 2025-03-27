namespace LAB1_OOP;

public class Person
{
    public Guid Id { get; } = Guid.NewGuid();
    public string FirstName{ get; set; }
    public string LastName{ get; set; }
    public string? MiddleName { get; set; } = null;
    public int Age { get; set; }
    

    public virtual void InputDataPerson(Person person)
    {
        Console.WriteLine("Enter first name:   ");
        person.FirstName = Console.ReadLine();

        Console.WriteLine("Enter last name:   ");
        person.LastName = Console.ReadLine();

        Console.WriteLine("Enter middle name: ");
        person.MiddleName = Console.ReadLine();

        Console.WriteLine("Enter age: ");
        person.Age = int.Parse(Console.ReadLine());
        
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"First Name: {FirstName}");
        Console.WriteLine($"Last Name: {LastName}");
        Console.WriteLine($"Middle Name: {MiddleName ?? "Не указано" }");
        Console.WriteLine($"Age: {Age}");
    }

}