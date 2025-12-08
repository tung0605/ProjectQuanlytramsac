using System;
using System.Data;

namespace ProjectQuanlytramsac.DTO
{
    public class bills
    {
        public int ID { get; set; }
        public int IdTruSac { get; set; }
        public DateTime? DateCheckIn { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public int Status { get; set; } // 0: Đang sạc, 1: Đã thanh toán

        public double SoKwhTieuThu { get; set; }
        public int ThoiGianSacPhut { get; set; }
        public double TongTien { get; set; }
        public int GiamGia { get; set; }
        public string CheDoSac { get; set; }
        public string LoaiKhachHang { get; set; }
        public bills(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IdTruSac = (int)row["idTruSac"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];

            var dateOutTemp = row["dateCheckOut"];
            if (dateOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateOutTemp;
            else
                this.DateCheckOut = null;

            this.Status = (int)row["status"];

            if (row["soKwhTieuThu"].ToString() != "")
                this.SoKwhTieuThu = Convert.ToDouble(row["soKwhTieuThu"]);

            if (row["thoiGianSacPhut"].ToString() != "")
                this.ThoiGianSacPhut = (int)row["thoiGianSacPhut"];

            if (row["tongTien"].ToString() != "")
                this.TongTien = Convert.ToDouble(row["tongTien"]);

            if (row["GiamGia"].ToString() != "")
                this.GiamGia = (int)row["GiamGia"];

            this.CheDoSac = row["CheDoSac"].ToString();
            this.LoaiKhachHang = row["LoaiKhachHang"].ToString();
        }
    }
}