namespace ConsoleApp1.BaiTap.QuanLyThuoc;

class Program
{
    static void Main(string[] args)
    {
        QuanLyThuoc quanLyThuoc = new QuanLyThuoc();

        // Thêm các loại thuốc mẫu
        quanLyThuoc.ThemThuoc(new Thuoc("Paracetamol", 50, 10000, "Thuoc dau", new Dictionary<string, int> { { "Paracetamol,Sizterato,hexa", 500 } }));
        quanLyThuoc.ThemThuoc(new Thuoc("Amoxicillin", 30, 20000, "Thuoc khang sinh", new Dictionary<string, int> { { "Amoxicillin,HExi9,Calor", 250 } }));

        // Thêm các chức năng khác ở đây...
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("-------------MENU-------------");
            Console.WriteLine("1.Them thuoc moi");
            Console.WriteLine("2.Hien thi danh sach thuoc theo danh muc");
            Console.WriteLine("3.Hien thi chi tiet thuoc");
            Console.WriteLine("4.Tim kiem thuoc");
            Console.WriteLine("5.Cap nhat thong tin thuoc");
            Console.WriteLine("6.Xoa thuoc");
            Console.WriteLine("0.Exit");
            Console.Write("Lua chon: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ThemThuoc();
                    break;
                case "2":
                    DsThuocTheoDanhMuc();
                    break;
                case "3":
                    HtChiTietThuoc();
                    break;
                case "4":
                    TimKiemThuoc();
                    break;
                case "5":
                    UpdateThuoc();
                    break;
                case "6":
                    XoaThuoc();
                    break;
                case "0":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    break;
            }
            Console.WriteLine();
        }

        void ThemThuoc()
        {
            Console.Write("Nhap ten thuoc: ");
            string name = Console.ReadLine();
            Console.Write("Nhap so luong: ");
            int soLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia ban thuoc: ");
            double giaBan = double.Parse(Console.ReadLine());
            Console.Write("Nhap danh muc cua thuoc: ");
            string danhMuc = Console.ReadLine();
            Console.Write("Nhap cac thanh phan cua thuoc: ");
            string thanhPhan = Console.ReadLine();
            Console.Write("Nhap don vi mg: ");
            int donVi = int.Parse(Console.ReadLine());
            
            quanLyThuoc.ThemThuoc(new Thuoc(name,soLuong,giaBan,danhMuc,new Dictionary<string, int>{{thanhPhan, donVi}}));
            Console.WriteLine("Them thuoc thanh cong!");

        }

        void DsThuocTheoDanhMuc()
        {
            Console.Write("Nhap ten danh muc: ");
            string danhMuc = Console.ReadLine();
            quanLyThuoc.HienThiTheoDanhMuc(danhMuc);
        }

        void HtChiTietThuoc()
        {
            Console.Write("Nhap ten thuoc: ");
            string tenThuoc = Console.ReadLine();
            quanLyThuoc.HienThiChiTietThuoc(tenThuoc);
        }

        void TimKiemThuoc()
        {
            Console.Write("Nhap ten thuoc: ");
            string tenThuoc = Console.ReadLine();
            quanLyThuoc.TimKiemThuoc(tenThuoc);
        }

        void UpdateThuoc()
        {
            Console.Write("Nhap ten thuoc can update: ");
            string name = Console.ReadLine();
            Console.Write("Nhap so luong moi: ");
            int soLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia ban thuoc moi: ");
            double giaBan = double.Parse(Console.ReadLine());
            Console.Write("Nhap thanh phan cua thuoc moi: ");
            string thanhPhan = Console.ReadLine();
            Console.Write("Nhap don vi mg: ");
            int donVi = int.Parse(Console.ReadLine());
            quanLyThuoc.CapNhatThongTinThuoc(name,soLuong,giaBan,new Dictionary<string,int> {{thanhPhan,donVi}} );
        }

        void XoaThuoc()
        {
            Console.Write("Nhap ten thuoc can xoa: ");
            string tenThuoc = Console.ReadLine();
            quanLyThuoc.XoaThuoc(tenThuoc);
        }
        
        Console.ReadLine(); // Dừng chương trình để xem kết quả
    }
}