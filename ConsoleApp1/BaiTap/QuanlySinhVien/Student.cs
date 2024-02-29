namespace ConsoleApp1.BaiTap.QuanlySinhVien;

public class Student
{
    private string id;
    private string name;
    private string gender;
    private int age;
    private double diemToan;
    private double diemLy;
    private double diemHoa;
    public double diemTB { get { return Math.Round((diemToan + diemLy + diemHoa) / 3,2); } }

    public string hocLuc
    {
        get
        {
            if (diemTB >= 8)
                return "Gioi";
            else if (diemTB >= 6.5)
                return "Kha";
            else if (diemTB >= 5)
                return "Trung Binh";
            else
                return "Yeu";
        }
    }


    public Student(string id, string name, string gender, int age, double diemToan, double diemLy, double diemHoa)
    {
        this.id = id;
        this.name = name;
        this.gender = gender;
        this.age = age;
        this.diemToan = diemToan;
        this.diemLy = diemLy;
        this.diemHoa = diemHoa;
    }

    public string Id
    {
        get => id;
        set => id = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Gender
    {
        get => gender;
        set => gender = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Age
    {
        get => age;
        set => age = value;
    }

    public double DiemToan
    {
        get => diemToan;
        set => diemToan = value;
    }

    public double DiemLy
    {
        get => diemLy;
        set => diemLy = value;
    }

    public double DiemHoa
    {
        get => diemHoa;
        set => diemHoa = value;
    }

   
}