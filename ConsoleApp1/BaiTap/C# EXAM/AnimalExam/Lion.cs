namespace ConsoleApp1.BaiTap.C__EXAM.AnimalExam;

public class Lion : Animal
{
    public Lion(double weight, string name) : base(weight, name)
    {
    }
    public override void Show()
    {
        Console.WriteLine("Lion Information:");
        base.Show();
    }
}