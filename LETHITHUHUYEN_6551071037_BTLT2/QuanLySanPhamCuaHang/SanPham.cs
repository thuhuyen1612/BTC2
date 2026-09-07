using System;

namespace QuanLySanPhamCuaHang
{
    public class SanPham
    {
        private string _maSP;
        private string _tenSP;
        private decimal _gia;
        private int _soLuongTon;

        public SanPham(string maSP, string tenSP, decimal gia, int soLuongTon)
        {
            _maSP = maSP;
            TenSP = tenSP;
            Gia = gia;
            SoLuongTon = soLuongTon;
        }

        public string MaSP => _maSP;

        public string TenSP
        {
            get => _tenSP;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Tên sản phẩm không được để trống!");
                _tenSP = value;
            }
        }

        public decimal Gia
        {
            get => _gia;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Gia), "Giá sản phẩm không được âm!");
                _gia = value;
            }
        }

        public int SoLuongTon
        {
            get => _soLuongTon;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(SoLuongTon), "Số lượng tồn không được âm!");
                _soLuongTon = value;
            }
        }

        public virtual decimal TinhGiaBan()
        {
            return _gia;
        }

        public virtual string MoTa()
        {
            return $"[Sản phẩm thường] Mã: {_maSP} - Tên: {_tenSP} - Giá gốc: {_gia:N0} VNĐ - Tồn kho: {_soLuongTon}";
        }
    }
}