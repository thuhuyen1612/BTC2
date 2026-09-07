using System;
using System.Collections.Generic;

namespace QuanLySanPhamCuaHang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== BAI TAP: QuanLySanPhamCuaHang ===");
            Console.WriteLine("MSSV: 6551071087 - Ho ten SV: Tran Minh Tri");
            Console.WriteLine();

            List<SanPham> danhSachSanPham = new List<SanPham>
            {
                new SanPham("SP001", "Bình giữ nhiệt", 150_000, 30),

                new SanPhamThucPham("TP001", "Sữa tươi Vinamilk", 25_000, 50)
                {
                    NgayHetHan = DateTime.Now.AddDays(2),
                    NhietDoBaoQuan = 4
                },

                new SanPhamThucPham("TP002", "Bánh mì sandwich", 20_000, 40)
                {
                    NgayHetHan = DateTime.Now.AddDays(15),
                    NhietDoBaoQuan = 20
                },

                new SanPhamDienTu("DT001", "Tai nghe Bluetooth", 500_000, 20)
                {
                    BaoHanhThang = 24,
                    HangSanXuat = "Sony"
                },

                new SanPhamDienTu("DT002", "Chuột không dây", 300_000, 15)
                {
                    BaoHanhThang = 6,
                    HangSanXuat = "Logitech"
                }
            };

            Console.WriteLine("----- Danh sách sản phẩm (đa hình khi gọi TinhGiaBan() và MoTa()) -----");
            Console.WriteLine();

            decimal tongGiaTriKhoHang = 0;

            foreach (SanPham sp in danhSachSanPham)
            {
                decimal giaBan = sp.TinhGiaBan();
                string moTa = sp.MoTa();

                Console.WriteLine(moTa);
                Console.WriteLine($"   => Giá bán thực tế: {giaBan:N0} VNĐ");
                Console.WriteLine();

                tongGiaTriKhoHang += giaBan * sp.SoLuongTon;
            }

            Console.WriteLine("========================================");
            Console.WriteLine($"TỔNG GIÁ TRỊ KHO HÀNG (theo giá bán thực tế x tồn kho): {tongGiaTriKhoHang:N0} VNĐ");
            Console.WriteLine("========================================");

            Console.WriteLine();
            Console.WriteLine("Chương trình kết thúc.");
        }
    }
}