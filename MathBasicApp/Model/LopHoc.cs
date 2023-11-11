using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MathBasicApp.Model
{
    public class LopHoc
    {
        public long MaLopHoc { get; set; }
        public String TenLopHoc { get; set; }
        public string GiangVien { get; set; }
        public string PhongHoc { get; set; }
        public int TuTiet { get; set; }
        public int DenTiet { get; set; }
        public List<SinhVien> SinhViens { get; set; }

        public static LopHoc GenerateLopHoc()
        {
            LopHoc lopHoc = new LopHoc
            {
                MaLopHoc = 1,
                TenLopHoc = ".Net Nhóm 1",
                GiangVien = "Ng Dũng",
                PhongHoc = "E102",
                TuTiet = 6,
                DenTiet = 8,
                SinhViens = new List<SinhVien>()
            };

            lopHoc.SinhViens.Add(new SinhVien{
                MaSinhVien = "101",
                Ho = "Trần",
                Ten = "Nguyên",
                NgaySinh = new DateTime(2000,1,11),
                GioiTinh = GIOITINH.Nu,
                NoiSinh = "Hà Nội",
                QueQuan = "Hà Nội"
            });

            lopHoc.SinhViens.Add(new SinhVien
            {
                MaSinhVien = "102",
                Ho = "Đào",
                Ten = "An",
                NgaySinh = new DateTime(2001, 2, 12),
                GioiTinh = GIOITINH.Nam,
                NoiSinh = "Huế",
                QueQuan = "Huế"
            });


            lopHoc.SinhViens.Add(new SinhVien
            {
                MaSinhVien = "103",
                Ho = "Lê",
                Ten = "Bình",
                NgaySinh = new DateTime(2002, 3, 13),
                GioiTinh = GIOITINH.Khac,
                NoiSinh = "HCM",
                QueQuan = "HCM"
            });


            return lopHoc;
        }

        public override string ToString()
        {
            var json = JsonSerializer.Serialize(this);

            return json;
        }

        public static LopHoc FromJson(string json)
        {
            var obj = JsonSerializer.Deserialize<LopHoc>(json);

            return obj;
        }

    }
}
