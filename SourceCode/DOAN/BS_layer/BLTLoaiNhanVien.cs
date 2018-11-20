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
    class BLTLoaiNhanVien
    {
        private BLTLoaiNhanVien()
        {

        }

        private static BLTLoaiNhanVien instance;

        internal static BLTLoaiNhanVien Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLTLoaiNhanVien();

                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public DataTable LayDS()
        {
            return DBMain.Instance.executeFunctionDataset(Cons.fn_DSLoaiNV).Tables[0];
        }

        public void Them(string ma, string ten)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@ma", ma));
            lstParam.Add(new SqlParameter("@ten", ten));
            DBMain.Instance.executeStoredProc(Cons.p_ThemLoaiNV, lstParam);
        }

        public void Sua(string ma, string ten)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@ma", ma));
            lstParam.Add(new SqlParameter("@ten", ten));
            DBMain.Instance.executeStoredProc(Cons.p_SuaLoaiNV, lstParam);
        }

        public void Xoa(string ma)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@ma", ma));
            DBMain.Instance.executeStoredProc(Cons.p_XoaLoaiNV, lstParam);
        }

        public string layTenLoai(string ma)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@maloai", ma));
            DataRowCollection d = DBMain.Instance.executeFunctionDataset(Cons.fn_LayLoaiNhanVien, lstParam).Tables[0].Rows;
            return d[0]["TenLoai"].ToString();
        }
    }
}
