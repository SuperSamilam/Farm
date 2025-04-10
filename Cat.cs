using System.Diagnostics;

public class Cat : Animal
{
    public int lives;
    public int Lives 
    { 
        get { return lives; } 
        set { lives = value; } 
    }
    public Cat(string name, int age, int lives) : base(name, age)
    {
        this.lives = lives;
    }

    public override void Interact()
    {
        Console.WriteLine(Name + " says Maow Maow"); //Maxi är en hund
        if (Age > 10)
        {
            Console.WriteLine(Name + " is tired because of fhis age. He is " + Age + " years old. But its fine because " + Name + " has " + lives + " lives left");
        }
    }
}