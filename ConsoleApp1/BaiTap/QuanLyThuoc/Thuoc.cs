namespace ConsoleApp1.BaiTap.QuanLyThuoc;

public class Thuoc
{
    public string Ten { get; set; }
    public int SoLuong { get; set; }
    public double GiaBan { get; set; }
    public string DanhMuc { get; set; }
    public Dictionary<string, int> DuocPham { get; set; } // Dược phẩm và số lượng (mg)

    public Thuoc(string ten, int soLuong, double giaBan, string danhMuc, Dictionary<string, int> duocPham)
    {
        Ten = ten;
        SoLuong = soLuong;
        GiaBan = giaBan;
        DanhMuc = danhMuc;
        DuocPham = duocPham;
    }
}