namespace ConsoleApp1.BaiTap.QuanLyThuoc;

public class QuanLyThuoc
{
    private List<Thuoc> danhSachThuoc;

    public QuanLyThuoc()
    {
        danhSachThuoc = new List<Thuoc>();
    }

    public void ThemThuoc(Thuoc thuoc)
    {
        danhSachThuoc.Add(thuoc);
    }

    public void HienThiTheoDanhMuc(string danhMuc)
    {
        Console.WriteLine("Danh sach thuoc trong danh muc: " +  $"'{danhMuc}'");
        foreach (var thuoc in danhSachThuoc)
        {
            if (thuoc.DanhMuc == danhMuc)
            {
                Console.WriteLine($"- Tên: {thuoc.Ten}, So luong: {thuoc.SoLuong}, Gia ban: {thuoc.GiaBan}");
            }
            else
            {
                Console.WriteLine("Khong tim thay thuoc trong danh muc nay");
            }
        }
    }

    public void HienThiChiTietThuoc(string tenThuoc)
    {
        var thuoc = danhSachThuoc.Find(t => t.Ten == tenThuoc);
        if (thuoc != null)
        {
            Console.WriteLine($"Thông tin chi tiet cua thuoc '{tenThuoc}':");
            Console.WriteLine($"- Số luong: {thuoc.SoLuong}");
            Console.WriteLine($"- Giá bán: {thuoc.GiaBan}");
            Console.WriteLine("Danh sach cac duoc pham bên trong:");
            foreach (var duocPham in thuoc.DuocPham)
            {
                Console.WriteLine($"  + {duocPham.Key}: {duocPham.Value} mg");
            }
        }
        else
        {
            Console.WriteLine($"Khong tìm thay thuoc có ten '{tenThuoc}'.");
        }
    }

    public void TimKiemThuoc(string tenThuoc)
    {
        var thuoc = danhSachThuoc.Find(t => t.Ten == tenThuoc);
        if (thuoc != null)
        {
            HienThiChiTietThuoc(tenThuoc);
        }
        else
        {
            Console.WriteLine($"Khong tìm thay thuoc có ten '{tenThuoc}'.");
        }
    }

    public void CapNhatThongTinThuoc(string tenThuoc, int soLuongMoi, double giaBanMoi, Dictionary<string, int> duocPhamMoi)
    {
        var thuoc = danhSachThuoc.Find(t => t.Ten == tenThuoc);
        if (thuoc != null)
        {
            thuoc.SoLuong = soLuongMoi;
            thuoc.GiaBan = giaBanMoi;
            thuoc.DuocPham = duocPhamMoi;
            Console.WriteLine($"Đã cập nhat thông tin cho thuoc '{tenThuoc}'.");
        }
        else
        {
            Console.WriteLine($"Khong tìm thay thuoc có ten '{tenThuoc}'.");
        }
    }

    public void XoaThuoc(string tenThuoc)
    {
        var thuoc = danhSachThuoc.Find(t => t.Ten == tenThuoc);
        if (thuoc != null)
        {
            danhSachThuoc.Remove(thuoc);
            Console.WriteLine($"Đã xóa thuoc '{tenThuoc}' khỏi danh sach.");
        }
        else
        {
            Console.WriteLine($"Khong tìm thay thuoc có ten '{tenThuoc}'.");
        }
    }
}