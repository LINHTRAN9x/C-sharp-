using ConsoleApp1.Session_1;
using ConsoleApp1.Session2;
using ConsoleApp1.Session3;
/*Console.WriteLine("Hello, World!");

Person person = new Person(1,"Anh Vu",18,"HN");
Console.WriteLine(person.Id); // person.getId()
person.Id = 2; // person.setId(2)
person.ShowInfo();

Animal animal = new Animal(){Type = "Lion", Age = 3};
animal.Age = 2;

int[] arr = new int[5];
//List intArray la object chu k phai array
List<int> intArray = new List<int>();
intArray.Add(1);
intArray.Add(3);
intArray.Add(5);
intArray.Add(7);
intArray.Add(9);

Console.WriteLine(intArray[2]);//sd ki thuat indexer

person.Telephones[0] = "2345678";
person[0] = "11234567"; //idexer

Asian asian = new Asian();
asian.Id = 12; */


//DELEGATE//
/* static void DisplayHello(string str)
{
    Console.WriteLine("Hello: "+str);
}
DemoDelegate dd = new DemoDelegate();

PrintMessage pm = new PrintMessage(DisplayHello);
pm += dd.ShowInfo;
pm += new DemoDelegate().ShowInfo;
pm("Nguyen Van An");

Button login = new Button("Login",DisplayHello); */

void RunSubThread()
{
    for (int i = 0; i < 20; i++)
    {
        try
        {
            Console.WriteLine("Sub i = " + i);
            Thread.Sleep(100);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
Thread t = new Thread(RunSubThread);
t.Start();

//anonymous method ()=>{}
Thread t2 = new Thread(() =>
{
    
});
t2.Start();
for (int i = 0; i < 20; i++)
{
    try
    {
        Console.WriteLine("Main i = " + i);
        Thread.Sleep(100);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        throw;
    }
}

//thread co tham so la object.
void ShowMessage(object o)
{
    string s = o as string; //cast ep kieu
    string s2 = (string)o; //cast ep kieu
    Console.WriteLine(s);
}
Thread t3 = new Thread(ShowMessage);
t3.Start("hello");

////////////////////////
Person p = new Person();
p.Id = 1;
new Thread(() =>
{
    for (int i = 0; i < 20; i++)
    {
        try
        {
            lock (p)
            {
               p.Id = p.Id + 1;
               p.ShowInfo(); 
            }
            
            Thread.Sleep(1000);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }   
}).Start();

new Thread(() =>
{
    for (int i = 0; i < 20; i++)
    {
        try
        {
            lock (p)
            {
                p.Id = p.Id + 1;
                p.ShowInfo(); 
            }
            Thread.Sleep(1000);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    } 
}).Start();

/* xu ly bat dong bo ,ben JS co promis.
async Task<int> DemoAsync()
{
    
}; */