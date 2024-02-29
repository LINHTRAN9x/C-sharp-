namespace ConsoleApp1.Session2;

public class Factory
{
    static Student GetStudent(string x)
    {
        if (x == "apt")
        {
            return new FPTAptechStudent();
        }
        else
        {
            return new FPTArenaStudent();
        }
    }
}