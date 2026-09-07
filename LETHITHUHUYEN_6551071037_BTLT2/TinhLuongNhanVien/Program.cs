using System;

namespace TinhLuongNhanVien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("BAI TAP: TinhLuongNhanVien");
            Console.WriteLine("MSSV: 6551071087 - Ho ten SV: Tran Minh Tri");
            Console.WriteLine();

            NhanVien nv1 = new NhanVien();
            nv1.HoTen = "Huỳnh Tấn Fat";
            nv1.LuongCoBan = 7_000_000;
            nv1.SoNgayLam = 24;
            nv1.SoNgayNghiPhep = 2;
            NhanVien nv2 = new NhanVien("NV002", "Trần Minh Trí", 8_500_000, 26, 0);
            NhanVien nv3 = new NhanVien(maNV: "NV003", hoTen: "Trần Tuấn Minh", soNgayLam: 20);

            Console.WriteLine(" Thông tin nhân viên 1 ");
            nv1.HienThiThongTin();

            Console.WriteLine(" Thông tin nhân viên 2 ");
            nv2.HienThiThongTin();

            Console.WriteLine(" Thông tin nhân viên 3 ");
            nv3.HienThiThongTin();

            Console.WriteLine(" Tóm tắt () ");
            Console.WriteLine(nv1);
            Console.WriteLine(nv2);
            Console.WriteLine(nv3);
            Console.WriteLine();

            Console.WriteLine(" So sánh 3 overload TinhThuong() cho nhân viên 2");
            decimal thuong1 = nv2.TinhThuong();
            decimal thuong2 = nv2.TinhThuong(0.2m);
            decimal thuong3 = nv2.TinhThuong(0.2m, true);
            decimal thuong4 = nv2.TinhThuong(0.2m, false);

            Console.WriteLine($"TinhThuong()                         = {thuong1:N0} VNĐ");
            Console.WriteLine($"TinhThuong(0.2)                      = {thuong2:N0} VNĐ");
            Console.WriteLine($"TinhThuong(0.2, coPhucLoi = true)     = {thuong3:N0} VNĐ");
            Console.WriteLine($"TinhThuong(0.2, coPhucLoi = false)    = {thuong4:N0} VNĐ");

            Console.WriteLine();
            Console.WriteLine("Chương trình kết thúc.");
        }
    }
}