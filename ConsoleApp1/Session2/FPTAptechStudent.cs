namespace ConsoleApp1.Session2;

public class FPTAptechStudent : Student, IStudent
{
    public override void Learn()
    {
        Console.WriteLine("leaning...");
    }

    public override void Play()
    {
        Console.WriteLine("Playing...");
    }

    public void Run()
    {
        throw new NotImplementedException();
    }

    public void Sing()
    {
        throw new NotImplementedException();
    }

    public void PlayFootball()
    {
        throw new NotImplementedException();
    }
}