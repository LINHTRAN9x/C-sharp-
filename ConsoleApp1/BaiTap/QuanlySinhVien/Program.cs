namespace ConsoleApp1.BaiTap.QuanlySinhVien;

class Program
{
    static List<Student> students = new List<Student>();

    static void Main(string[] args)
    {
        bool exit = false;
        Student student1 = new Student("1","Linh","Nam",18,10.5,20.1,21.5);
        Student student2 = new Student("2","An","Nam",18,10.5,20.1,21.5);
        Student student3 = new Student("3","Trung","Nam",18,1.5,2.1,1.5);
        students.Add(student1);
        students.Add(student2);
        students.Add(student3);
        while (!exit)
        {
            Console.WriteLine("Student Management System Menu:");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Update Student Information by ID");
            Console.WriteLine("3. Delete Student by ID");
            Console.WriteLine("4. Search Student by Name");
            Console.WriteLine("5. Sort Students by GPA");
            Console.WriteLine("6. Sort Students by Name");
            Console.WriteLine("7. Sort Students by ID");
            Console.WriteLine("8. Show Student List");
            Console.WriteLine("9. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    UpdateStudent();
                    break;
                case "3":
                    DeleteStudent();
                    break;
                case "4":
                    SearchStudent();
                    break;
                case "5":
                    SortStudentsByGPA();
                    break;
                case "6":
                    SortStudentsByName();
                    break;
                case "7":
                    SortStudentsById();
                    break;
                case "8":
                    ShowStudentList();
                    break;
                case "9":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 9.");
                    break;
            }

            Console.WriteLine();
            
        }
        
        void AddStudent()
        {
            
            Console.Write("Enter ID: ");
            string id = Console.ReadLine();
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Gender: ");
            string gender = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Math Score: ");
            double DiemToan = double.Parse(Console.ReadLine());
            Console.Write("Enter Physics Score: ");
            double DiemLy = double.Parse(Console.ReadLine());
            Console.Write("Enter Chemistry Score: ");
            double DiemHoa = double.Parse(Console.ReadLine());
            
            Student student = new Student(id,name,gender,age,DiemToan,DiemLy,DiemHoa);
            students.Add(student);
            Console.WriteLine("Student added successfully.");
        }
        static void UpdateStudent()
    {
        Console.Write("Enter ID of the student to update: ");
        string id = Console.ReadLine();
        Student student = students.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
            Console.WriteLine("Student found. Enter new information:");
            Console.Write("Enter Name: ");
            student.Name = Console.ReadLine();
            Console.Write("Enter Gender: ");
            student.Gender = Console.ReadLine();
            Console.Write("Enter Age: ");
            student.Age = int.Parse(Console.ReadLine());
            Console.Write("Enter Math Score: ");
            student.DiemToan = double.Parse(Console.ReadLine());
            Console.Write("Enter Physics Score: ");
            student.DiemLy = double.Parse(Console.ReadLine());
            Console.Write("Enter Chemistry Score: ");
            student.DiemHoa = double.Parse(Console.ReadLine());

            Console.WriteLine("Student information updated successfully.");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    static void DeleteStudent()
    {
        Console.Write("Enter ID of the student to delete: ");
        string id = Console.ReadLine();
        Student student = students.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
            students.Remove(student);
            Console.WriteLine("Student deleted successfully.");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    static void SearchStudent()
    {
        Console.Write("Enter Name of the student to search: ");
        string name = Console.ReadLine();
        List<Student> searchResults = students.Where(s => s.Name.ToLower().Contains(name.ToLower())).ToList();
        if (searchResults.Count > 0)
        {
            Console.WriteLine("Search results:");
            foreach (var student in searchResults)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Gender: {student.Gender}, GPA: {student.diemTB}, Academic Performance: {student.hocLuc}");
            }
        }
        else
        {
            Console.WriteLine("No student found with the given name.");
        }
    }

    static void SortStudentsByGPA()
    {
        List<Student> sortedList = students.OrderByDescending(s => s.diemTB).ToList();
        PrintStudentList(sortedList, "Sorted Students by GPA:");
    }

    static void SortStudentsByName()
    {
        List<Student> sortedList = students.OrderBy(s => s.Name).ToList();
        PrintStudentList(sortedList, "Sorted Students by Name:");
    }

    static void SortStudentsById()
    {
        List<Student> sortedList = students.OrderBy(s => s.Id).ToList();
        PrintStudentList(sortedList, "Sorted Students by ID:");
        
    }
        static void ShowStudentList()
        {
            PrintStudentList(students, "Student List:");
        }
        static void PrintStudentList(List<Student> list, string message)
        {
            Console.WriteLine(message);
            foreach (var student in list)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Gender: {student.Gender}, GPA: {student.diemTB}, Academic Performance: {student.hocLuc}");
            }
        }
    }
}

