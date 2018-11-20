using DXApplication1.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.BS_layer
{
    class BLT_CTHD
    {
        private BLT_CTHD()
        {

        }

        private static BLT_CTHD instance;

        internal static BLT_CTHD Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLT_CTHD();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public DataTable LayDS()
        {
            return DBMain.Instance.executeFunctionDataset(Cons.fn_DSCTHD).Tables[0];
        }

        public void Them(string mahd, string masp, int soluong, int giaban)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@maHD", mahd));
            lstParam.Add(new SqlParameter("@maSP", masp));
            lstParam.Add(new SqlParameter("@soluong", soluong));
            lstParam.Add(new SqlParameter("@gia", giaban));
            DBMain.Instance.executeStoredProc(Cons.p_ThemCTHD, lstParam);
        }

        public void Sua(string mahd, string masp, int soluong, int giaban)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@maHD", mahd));
            lstParam.Add(new SqlParameter("@maSP", masp));
            lstParam.Add(new SqlParameter("@soluong", soluong));
            lstParam.Add(new SqlParameter("@gia", giaban));
            DBMain.Instance.executeStoredProc(Cons.p_SuaCTHD, lstParam);
        }

        public void Xoa(string mahd, string masp)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@maHD", mahd));
            lstParam.Add(new SqlParameter("@maSP", masp));
            DBMain.Instance.executeStoredProc(Cons.p_XoaCTHD, lstParam);
        }

        internal void ThemChiTietHD(string mahd, string masp, int soluong)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@mahd", mahd));
            lstParam.Add(new SqlParameter("@masp", masp));
            lstParam.Add(new SqlParameter("@soluongdat", soluong));
            DBMain.Instance.executeStoredProc(Cons.p_insertCTHD, lstParam);
        }
    }
}
