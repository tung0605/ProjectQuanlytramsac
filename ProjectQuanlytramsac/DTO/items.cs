using System;
using System.Data;

namespace ProjectQuanlytramsac.DTO
{
    public class items
    {
        public static int itemwidth = 100;
        public static int itemheight = 100;

        public int ID { get; set; }
        public string TenTru { get; set; }
        public string TrangThai { get; set; }
        public string LoaiXe { get; set; }
        public double CongSuatKW { get; set; }

        public items(int id, string tenTru, string trangThai, string loaiXe, double congSuat)
        {
            this.ID = id;
            this.TenTru = tenTru;
            this.TrangThai = trangThai;
            this.LoaiXe = loaiXe;
            this.CongSuatKW = congSuat;
        }

        public items(DataRow row)
        {
            this.ID = (int)row["id"];
            this.TenTru = row["tenTru"].ToString();
            this.TrangThai = row["trangThai"].ToString();
            this.LoaiXe = row["LoaiXe"].ToString();

            if (row["CongSuatKW"].ToString() != "")
                this.CongSuatKW = Convert.ToDouble(row["CongSuatKW"]);
            else
                this.CongSuatKW = 0;
        }
    }
}