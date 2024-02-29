namespace ConsoleApp1.Session_1;

public class Asian : Person
{
    private string lastName;

    public Asian()
    {
    }

    public Asian(int id, string name, int age, string address, string lastName) : base(id,name,age,address)
    {
        this.lastName = lastName;
        
    }

    public override void Run()
    {
        base.Run();
        Console.WriteLine("Running.....");
    }
}