namespace ConsoleApp1.BaiTap.C__EXAM.AnimalExam;

public class Tiger : Animal
{
    public Tiger(double weight, string name) : base(weight, name)
    {
    }
    public override void Show()
    {
        Console.WriteLine("Tiger Information:");
        base.Show();
    }
}