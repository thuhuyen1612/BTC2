using System;

namespace QuanLySachCoBan
{
    public class Sach
    {
        private string _maSach;
        private string _tenSach;
        private string _tacGia;
        private int _namXuatBan;
        private double _giaBan;
        public Sach(string maSach, string tenSach, string tacGia, int namXuatBan, double giaBan)
        {
            _maSach = maSach;
            TenSach = tenSach;       
            NamXuatBan = namXuatBan; 
            _tacGia = tacGia;
            _giaBan = giaBan;
        }

        public Sach()
        {
            _maSach = "SACH000";
            _tenSach = "Chưa có tên";
            _tacGia = "Chưa rõ tác giả";
            _namXuatBan = DateTime.Now.Year;
            _giaBan = 0;
        }
        public string MaSach => _maSach;
        public string TenSach
        {
            get => _tenSach;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Tên sách không được để trống!");
                _tenSach = value;
            }
        }
       public string TacGia
        {
            get => _tacGia;
            set => _tacGia = value;
        }
        public int NamXuatBan
        {
            get => _namXuatBan;
            set
            {
                int namHienTai = DateTime.Now.Year;
                if (value < 1900 || value > namHienTai)
                    throw new ArgumentOutOfRangeException(
                        nameof(NamXuatBan),
                        $"Năm xuất bản phải nằm trong khoảng từ 1900 đến {namHienTai}!");
                _namXuatBan = value;
            }
        }
        public double GiaBan => _giaBan;

        public void HienThiThongTin()
        {
            Console.WriteLine($"Mã sách     : {_maSach}");
            Console.WriteLine($"Tên sách    : {_tenSach}");
            Console.WriteLine($"Tác giả     : {_tacGia}");
            Console.WriteLine($"Năm XB      : {_namXuatBan}");
            Console.WriteLine($"Giá bán     : {_giaBan:N0} VNĐ");
        }

        public override string ToString()
        {
            return $"[{_maSach}] {_tenSach} - {_tacGia} ({_namXuatBan}) - {_giaBan:N0} VNĐ";
        }
    }
}