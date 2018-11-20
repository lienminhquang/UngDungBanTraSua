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
    class BLTLoaiSP
    {
        private BLTLoaiSP()
        {

        }

        private static BLTLoaiSP instance;

        internal static BLTLoaiSP Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLTLoaiSP();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public DataTable LayDS()
        {
            return DBMain.Instance.executeFunctionDataset(Cons.fn_DSLoaiSP).Tables[0];
        }

        public string LayTenLoai(string ma)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@maloai", ma));         
            return DBMain.Instance.executeFunctionDataset(Cons.fn_LayLoai, lstParam).Tables[0].Rows[0]["TenLoai"].ToString();
        }

        public void Them(string ma, string ten, string chitiet)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@ma", ma));
            lstParam.Add(new SqlParameter("@ten", ten));
            lstParam.Add(new SqlParameter("@chitiet", chitiet));
            DBMain.Instance.executeStoredProc(Cons.p_ThemLoaiSP, lstParam);
        }

        public void Sua(string ma, string ten, string chitiet)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@ma", ma));
            lstParam.Add(new SqlParameter("@ten", ten));
            lstParam.Add(new SqlParameter("@chitiet", chitiet));
            DBMain.Instance.executeStoredProc(Cons.p_SuaLoaiSP, lstParam);
        }

        internal DataTable LayLoaiSP2()
        {
            DataTable sang = DBMain.Instance.executeFunctionDataset(Cons.fn_DSLoaiSP).Tables[0];
            return sang;
        }

        public void Xoa(string ma)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@ma", ma));         
            DBMain.Instance.executeStoredProc(Cons.p_XoaLoaiSP, lstParam);
        }

    }
}
