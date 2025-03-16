namespace LAB1_OOP;

public class Person
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string FirstName{ get; set; }
    public string LastName{ get; set; }
    public string? MiddleName { get; set; } = null;
    public int Age { get; set; }
        
    public static List<Person> PersonList { get; }= new List<Person>();

    public virtual Person AddPerson(Person person)
    {
        Console.WriteLine("Enter first name:   ");
        person.FirstName = Console.ReadLine();

        Console.WriteLine("Enter last name:   ");
        person.LastName = Console.ReadLine();

        Console.WriteLine("Enter middle name: ");
        person.MiddleName = Console.ReadLine();

        Console.WriteLine("Enter age: ");
        person.Age = int.Parse(Console.ReadLine());
    
        return person;
    }
    public virtual void UpdatePerson(Guid id)
    {
        Person personToUpdate = PersonList.FirstOrDefault(p => p.Id == Id);
        personToUpdate.FirstName = FirstName;
        personToUpdate.LastName = LastName;
        personToUpdate.MiddleName = MiddleName;
        personToUpdate.Age = Age;
    }

    public virtual void RemovePerson(Guid id)
    {
        Person person = PersonList.FirstOrDefault(p => p.Id == Id);
        PersonList.Remove(person);
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"First Name: {FirstName}");
        Console.WriteLine($"Last Name: {LastName}");
        Console.WriteLine($"Middle Name: {MiddleName ?? "Не указано" }");
        Console.WriteLine($"Age: {Age}");
                
    }

}