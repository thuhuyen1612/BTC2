using System;

namespace QuanLySanPhamCuaHang
{
    public class SanPhamThucPham : SanPham
    {
        private DateTime _ngayHetHan;
        private int _nhietDoBaoQuan;

        public SanPhamThucPham(string maSP, string tenSP, decimal gia, int soLuongTon)
            : base(maSP, tenSP, gia, soLuongTon)
        {
            _ngayHetHan = DateTime.Now.AddMonths(1);
            _nhietDoBaoQuan = 25;
        }

        public DateTime NgayHetHan
        {
            get => _ngayHetHan;
            set => _ngayHetHan = value;
        }

        public int NhietDoBaoQuan
        {
            get => _nhietDoBaoQuan;
            set => _nhietDoBaoQuan = value;
        }

        // Nếu còn <= 3 ngày là hết hạn thì giảm 30%
        public override decimal TinhGiaBan()
        {
            int soNgayConLai = (_ngayHetHan.Date - DateTime.Now.Date).Days;

            if (soNgayConLai >= 0 && soNgayConLai <= 3)
                return Gia * 0.7m;

            return Gia;
        }

        public override string MoTa()
        {
            int soNgayConLai = (_ngayHetHan.Date - DateTime.Now.Date).Days;
            string ghiChu = (soNgayConLai >= 0 && soNgayConLai <= 3) ? " (SẮP HẾT HẠN - Giảm 30%)" : "";

            return $"[Thực phẩm] Mã: {MaSP} - Tên: {TenSP} - Hạn sử dụng: {_ngayHetHan:dd/MM/yyyy} " +
                   $"- Nhiệt độ bảo quản: {_nhietDoBaoQuan}°C - Giá bán: {TinhGiaBan():N0} VNĐ{ghiChu} - Tồn kho: {SoLuongTon}";
        }
    }
}