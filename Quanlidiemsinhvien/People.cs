using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using System.Data.SqlClient;
using System.Data;

namespace Quanlidiemsinhvien
{
  
    class Sinhvien
    {
        public String MaSV;
        public String HoSV;
        public String TenSV;
        public String Phai;
        public String NgaySinh;
        public String NoiSinh;
        public String MaKhoa;
        public String HocBong;

        public object ConfigurationManager { get; private set; }

        public Sinhvien()
        {
        }
        public Sinhvien(String Msv, String Hsv, String Tsv, String Phai, String Ngsinh, String Nsinh, String Mkhoa, String Hbong)
        {
            this.MaSV = Msv;
            this.HoSV = Hsv;
            this.TenSV = Tsv;
            this.Phai = Phai;
            this.NgaySinh = Ngsinh;
            this.NoiSinh = Nsinh;
            this.MaKhoa = Mkhoa;
            this.HocBong = Hbong;
        }

        

        
    
    
    }

}
