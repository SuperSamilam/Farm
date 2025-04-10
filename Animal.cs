public class Animal
{
    private string name;
    private int age;

    public string Name 
    { 
        get { return name; } 
        set { name = value; } 
    }

    public int Age 
    { 
        get { return age; } 
        set { age = value; } 
    }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void Interact()
    {
        Console.WriteLine("Muu eller något");
    }
}