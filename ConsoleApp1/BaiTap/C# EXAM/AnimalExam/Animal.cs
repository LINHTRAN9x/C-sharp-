namespace ConsoleApp1.BaiTap.C__EXAM.AnimalExam;

public class Animal
{
    protected string name;
    protected double weight;
    
    public Animal(double weight, string name)
    {
        this.weight = weight;
        this.name = name;
    }
    
    public void SetMe(double weight, string name)
    {
        this.weight = weight;
        this.name = name;
    }
    
    public virtual void Show()
    {
        Console.WriteLine($"Name: {name}, Weight: {weight} kg");
    }
}