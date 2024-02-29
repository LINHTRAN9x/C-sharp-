namespace ConsoleApp1.Session2;

public abstract class Student
{
    private int id;
    private string name;
    private DateTime dob;
    private string tel;

    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public DateTime Dob
    {
        get => dob;
        set => dob = value;
    }

    public string Tel
    {
        get => tel;
        set => tel = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    //abstract method
    public abstract void Learn();
    public abstract void Play();
    
}