namespace ConsoleApp1.BaiTap.C__EXAM.AnimalExam;

class Program
{
    static void Main(string[] args)
    {
        
        Lion lion = new Lion(100, "lion");
        Tiger tiger = new Tiger(200, "tiger");
        
        lion.SetMe(200,"li");
        lion.Show();
        tiger.Show();
    }
}