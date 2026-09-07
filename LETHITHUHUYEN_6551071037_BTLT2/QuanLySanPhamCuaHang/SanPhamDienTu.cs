using System;

namespace QuanLySanPhamCuaHang
{
    public class SanPhamDienTu : SanPham
    {
        private int _baoHanhThang;
        private string _hangSanXuat;

        public SanPhamDienTu(string maSP, string tenSP, decimal gia, int soLuongTon)
            : base(maSP, tenSP, gia, soLuongTon)
        {
            _baoHanhThang = 12;
            _hangSanXuat = "Chưa rõ";
        }

        public int BaoHanhThang
        {
            get => _baoHanhThang;
            set => _baoHanhThang = value;
        }

        public string HangSanXuat
        {
            get => _hangSanXuat;
            set => _hangSanXuat = value;
        }

        // Nếu bảo hành > 12 tháng thì cộng thêm 10% phí bảo hành
        public override decimal TinhGiaBan()
        {
            if (_baoHanhThang > 12)
                return Gia * 1.1m;

            return Gia;
        }

        public override string MoTa()
        {
            string ghiChu = _baoHanhThang > 12 ? " (Bảo hành mở rộng - Cộng 10% phí)" : "";

            return $"[Điện tử] Mã: {MaSP} - Tên: {TenSP} - Hãng SX: {_hangSanXuat} " +
                   $"- Bảo hành: {_baoHanhThang} tháng - Giá bán: {TinhGiaBan():N0} VNĐ{ghiChu} - Tồn kho: {SoLuongTon}";
        }
    }
}