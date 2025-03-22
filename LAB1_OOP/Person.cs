namespace LAB1_OOP;

public class Person
{
    public Guid Id { get; } = Guid.NewGuid();
    public string FirstName{ get; set; }
    public string LastName{ get; set; }
    public string? MiddleName { get; set; } = null;
    public int Age { get; set; }
    

    public virtual dynamic? InputDataPerson(dynamic? person)
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
    
    public void AddPerson(Person? person)
    {
        GlobalData.personList.Add(person);
    }
    
    
    public Person? SearchPerson(Guid personId)
    {
        Person? personToSearch = GlobalData.personList.FirstOrDefault(p => p.Id == Id);
        if (personToSearch != null)
        {
            Console.WriteLine("Person has been found ");
            return personToSearch;
        }

        else
        {
            Console.WriteLine("Person not found");
            return null;
        }
        
    }
    
    public virtual void UpdatePerson(Guid id)
    {
        Person? personToUpdate = SearchPerson(id);
        personToUpdate.FirstName = FirstName;
        personToUpdate.LastName = LastName;
        personToUpdate.MiddleName = MiddleName;
        personToUpdate.Age = Age;
    }
    
    public void InputUpdatePerson(Guid id)
    {
        Person? personToUpdate = SearchPerson(id);
        InputDataPerson(personToUpdate);
    }

    public virtual void RemovePerson(dynamic? person)
    {
        //Person person = GlobalData.personList.FirstOrDefault(p => p.Id == Id);
        GlobalData.personList.Remove(person);
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