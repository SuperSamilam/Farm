using System.Diagnostics;

public class Dog : Animal
{
    private int legs;
    public int Legs 
    { 
        get { return legs; } 
        set { legs = value; } 
    }
    public Dog(string name, int age, int legs) : base(name, age)
    {
        this.legs = legs;
    }

    public override void Interact()
    {
        Console.WriteLine(Name + " says Woof Woof"); //Maxi är en hund
        if (Age > 10)
        {
            Console.WriteLine(Name + " is tired because of fhis age. He is " + Age + " years old");
        }
        if (legs != 4)
        {
            Console.WriteLine(Name + " looks weird! It seems like he only has " + legs + " legs");
        }
    }
}