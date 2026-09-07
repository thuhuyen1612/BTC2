using System;

namespace QuanLySachCoBan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("BAI TAP CAU 1: QuanLySachCoBan");
            Console.WriteLine("MSSV: 6551071087 - Ho ten SV: Tran Minh Tri");
            Console.WriteLine();
            Sach sach1 = new Sach("S001", "Lập trình C# cơ bản", "Nguyễn Thiện Dương", 2020, 120000);

            Sach sach2 = new Sach();
            sach2.TenSach = "Cấu trúc dữ liệu và giải thuật";
            sach2.TacGia = "Trần Thị Dung";
            sach2.NamXuatBan = 2018;
            Sach sach3 = new Sach
            {
                TenSach = "Cơ sở dữ liệu",
                TacGia = "Phạm Thị Miên",
                NamXuatBan = 2022
            };

            Console.WriteLine("Thông tin sách 1");
            sach1.HienThiThongTin();

            Console.WriteLine("Thông tin sách 2");
            sach2.HienThiThongTin();

            Console.WriteLine("Thông tin sách 3");
            sach3.HienThiThongTin();

            Console.WriteLine("Tóm tắt");
            Console.WriteLine(sach1);
            Console.WriteLine(sach2);
            Console.WriteLine(sach3);
            Console.WriteLine();

            Console.WriteLine("Thử gán NamXuatBan không hợp lệ ");
            try
            {
                sach1.NamXuatBan = 1800;
                Console.WriteLine("Gán năm 1800 thành công (không nên xảy ra).");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Lỗi bắt được: " + ex.Message);
            }

            try
            {
                sach2.NamXuatBan = 3000;
                Console.WriteLine("Gán năm 3000 thành công (không nên xảy ra).");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Lỗi bắt được: " + ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Thử gán TenSach rỗng ");
            try
            {
                sach3.TenSach = "";
                Console.WriteLine("Gán tên rỗng thành công (không nên xảy ra).");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Lỗi bắt được: " + ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Chương trình kết thúc.");
        }
    }
}