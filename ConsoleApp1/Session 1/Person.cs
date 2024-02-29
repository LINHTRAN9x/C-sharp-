namespace ConsoleApp1.Session_1;

public class Person
{
    // attribute - field
    private int id;
    private string name;
    private int age;
    private string address;
    private List<string> telephones = new List<string>();

    public Person()
    {
    }

    public Person(int id, string name, int age, string address)
    {
        this.id = id;
        this.name = name;
        this.age = age;
        this.address = address;
    }
    
    //indexer :ki thuat bien 1 object co the gan them chi muc (index) nhin giong nhu array 
    public string this[int index]
    {
        get => telephones[index];
        set => telephones[index] = value;
    }

    public List<string> Telephones
    {
        get => telephones;
        set => telephones = value ?? throw new ArgumentNullException(nameof(value));
    }

    // property
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    public int Age
    {
        get => age;
        set => age = value;
    }

    // read-only property
    //public string Address => address;
    public string Address
    {
        get => address;
    }

    public void ShowInfo()
    {
        Console.WriteLine(id+"-"+name+"-"+age+"-"+address);
    }

    public string ShowInfo(string key)
    {
        return "Hello";
    }

    public virtual void Run()
    {
        Console.WriteLine("Run........");
    }
}