using MvcBookStore.Models;
using System.Linq;

public class MatHangMua
{
    QLBANSACHEntities db = new QLBANSACHEntities();
    public int MaSach { get; set; }
    public string TenSach { get; set; }
    public string AnhBia { get; set; }
    public double DonGia { get; set; }
    public int SoLuong { get; set; }

    public double ThanhTien()
    {
        return SoLuong * DonGia;
    }

    public MatHangMua(int MaSach)
    {
        this.MaSach = MaSach;
        var sach = db.SACHes.Single(s => s.Masach == this.MaSach);
        this.TenSach = TenSach;
        this.AnhBia = AnhBia;
        this.DonGia = DonGia;
        this.SoLuong = 1;
    }
}