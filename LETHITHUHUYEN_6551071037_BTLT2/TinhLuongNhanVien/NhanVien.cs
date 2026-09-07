using System;

namespace TinhLuongNhanVien
{
    public class NhanVien
    {
        private string _maNV;
        private string _hoTen;
        private decimal _luongCoBan;
        private int _soNgayLam;
        private int _soNgayNghiPhep;

        public NhanVien()
        {
            _maNV = "NV000";
            _hoTen = "Chưa có tên";
            _luongCoBan = 0;
            _soNgayLam = 0;
            _soNgayNghiPhep = 0;
        }
        public NhanVien(string maNV, string hoTen)
        {
            _maNV = maNV;
            HoTen = hoTen;
            _luongCoBan = 0;
            _soNgayLam = 0;
            _soNgayNghiPhep = 0;
        }

        public NhanVien(string maNV, string hoTen, decimal luongCoBan, int soNgayLam, int soNgayNghiPhep)
        {
            _maNV = maNV;
            HoTen = hoTen;
            LuongCoBan = luongCoBan;
            SoNgayLam = soNgayLam;
            SoNgayNghiPhep = soNgayNghiPhep;
        }

        public NhanVien(string maNV, string hoTen, decimal luong = 5_000_000, int soNgayLam = 26)
        {
            _maNV = maNV;
            HoTen = hoTen;
            LuongCoBan = luong;
            SoNgayLam = soNgayLam;
            _soNgayNghiPhep = 0;
        }

        public string MaNV => _maNV;

        public string HoTen
        {
            get => _hoTen;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Họ tên không được để trống!");
                _hoTen = value;
            }
        }

        public decimal LuongCoBan
        {
            get => _luongCoBan;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(LuongCoBan), "Lương cơ bản không được âm!");
                _luongCoBan = value;
            }
        }

        public int SoNgayLam
        {
            get => _soNgayLam;
            set
            {
                if (value < 0 || value > 31)
                    throw new ArgumentOutOfRangeException(nameof(SoNgayLam), "Số ngày làm phải nằm trong khoảng 0 đến 31!");
                _soNgayLam = value;
            }
        }

        public int SoNgayNghiPhep
        {
            get => _soNgayNghiPhep;
            set
            {
                if (value < 0 || value > 31)
                    throw new ArgumentOutOfRangeException(nameof(SoNgayNghiPhep), "Số ngày nghỉ phép phải nằm trong khoảng 0 đến 31!");
                _soNgayNghiPhep = value;
            }
        }
        public decimal LuongThucNhan
        {
            get
            {
                decimal luongTheoNgay = _luongCoBan / 26m * _soNgayLam;
                decimal khauTruBHXH = _luongCoBan * 0.08m;
                return luongTheoNgay - khauTruBHXH;
            }
        }

        public decimal TinhThuong()
        {
            return 0;
        }

        public decimal TinhThuong(decimal heSo)
        {
            return _luongCoBan * heSo;
        }

        public decimal TinhThuong(decimal heSo, bool coPhucLoi)
        {
            decimal thuong = _luongCoBan * heSo;
            if (coPhucLoi)
                thuong += 500_000;
            return thuong;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Mã NV            : {_maNV}");
            Console.WriteLine($"Họ tên           : {_hoTen}");
            Console.WriteLine($"Lương cơ bản     : {_luongCoBan:N0} VNĐ");
            Console.WriteLine($"Số ngày làm      : {_soNgayLam}");
            Console.WriteLine($"Số ngày nghỉ phép: {_soNgayNghiPhep}");
            Console.WriteLine($"Lương thực nhận  : {LuongThucNhan:N0} VNĐ");
        }

        public override string ToString()
        {
            return $"[{_maNV}] {_hoTen} - Lương thực nhận: {LuongThucNhan:N0} VNĐ";
        }
    }
}