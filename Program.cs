Animal animal;

while (true)
{
    Console.WriteLine("Do you want to create a dog or cat");
    Console.WriteLine("1 for dog");
    Console.WriteLine("2 for cat");
    Console.WriteLine("3 for give up");

    string respone = Console.ReadLine() ?? "none";
    Console.Clear();
    if (respone == "1")
    {
        CreateDog();
        break;
    }
    else if (respone == "2")
    {
        CreateCat();
        break;
    }
    else if (respone == "3")
    {
        Console.WriteLine("BYEEEE");
        Thread.Sleep(1000);
        return;
    }
    Console.WriteLine("Thats not a valid respone, try again");
    Thread.Sleep(1000);
    Console.Clear();
}

Console.WriteLine("Do you want to play with your animal if so type yes");
string resp = Console.ReadLine().ToUpper() ?? "";
if (resp == "YES")
{
    animal.Interact();
}

Console.WriteLine("BYEEEE");
Thread.Sleep(1000);


void CreateDog()
{
    string name = CreateName();
    int age = CreateIntegerValue("age");
    int legs = CreateIntegerValue("legs");
    animal = new Dog(name, age, legs);
}

void CreateCat()
{
    string name = CreateName();
    int age = CreateIntegerValue("age");
    int lives = CreateIntegerValue("lives");
    animal = new Cat(name, age, lives);
}

string CreateName()
{
    while (true)
    {
        Console.WriteLine("Whats the name of your animal?");
        string resp = Console.ReadLine() ?? "";

        if (resp == "" || resp == null)
        {
            Console.WriteLine("It cant be nothing");
            continue;
        }
        else
            return resp;
    }
}

int CreateIntegerValue(string valueName)
{
    while (true)
    {
        Console.WriteLine("Whats the " + valueName + " of your animal?");
        string resp = Console.ReadLine();
        int intResp;
        if (int.TryParse(resp, out intResp))
        {
            if (intResp < 0)
            {
                Console.WriteLine("The number needs to be possetive");
                continue;
            }
            return intResp;
        }
        else
        {
            Console.WriteLine("The " + valueName + " needs to be a number");
            continue;
        }
    }
}