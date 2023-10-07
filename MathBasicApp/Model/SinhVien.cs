using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MathBasicApp.Model
{
    public class SinhVien
    {
        public string MaSinhVien { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh{ get; set; }
        public GIOITINH GioiTinh { get; set; }
        public string NoiSinh { get; set; }
        public string QueQuan { get; set; }
        public string HinhDaiDien { get; set; }

        public override string ToString()
        {
            var json = JsonSerializer.Serialize(this);
            return json;
        }

        public static SinhVien FromJson(string json)
        {
            var sinhVien = JsonSerializer.Deserialize<SinhVien>(json);
            return sinhVien;
        }

    }

    public enum GIOITINH
    {
        Nam, Nu, Khac
    }
}
