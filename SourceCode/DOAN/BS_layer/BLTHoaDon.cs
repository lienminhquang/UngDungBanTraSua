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
    class BLTHoaDon
    {
        private BLTHoaDon()
        {

        }

        private static BLTHoaDon instance;

        internal static BLTHoaDon Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLTHoaDon();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public DataTable LayDS()
        {
            return DBMain.Instance.executeFunctionDataset(Cons.fn_DSHoaDon).Tables[0];
        }

        public void Them(string ma, string manv, DateTime ngay)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@ma", ma));
            lstParam.Add(new SqlParameter("@manv", manv));
            lstParam.Add(new SqlParameter("@ngay", ngay));
            DBMain.Instance.executeStoredProc(Cons.p_ThemHD, lstParam);
        }

        public void Sua(string ma, string manv, DateTime ngay)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@ma", ma));
            lstParam.Add(new SqlParameter("@manv", manv));
            lstParam.Add(new SqlParameter("@ngay", ngay));
            DBMain.Instance.executeStoredProc(Cons.p_SuaHD, lstParam);
        }

        public void Xoa(string ma)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@ma", ma));
            DBMain.Instance.executeStoredProc(Cons.p_XoaHD, lstParam);
        }

        internal DataSet laychitiethoadontheomahd(string mahd)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@mahd", mahd));
            return DBMain.Instance.executeFunctionDataset(Cons.fn_layViewCTHD, lstParam);
        }

        internal int LayTongTien(string mahd)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@mahd", mahd));
            string s = DBMain.Instance.executeFunctionDataset(Cons.fn_LayTongTien, lstParam).Tables[0].Rows[0][0].ToString();
            return int.Parse(s);
        }

        internal string taoHD(string manv)
        {
            DateTime day = DateTime.Today;
            string daystring = string.Format("{0:yyyy/MM/dd}", day);
            return  DBMain.Instance.executeQueryDataset("exec pr_TuSinhMaHD '"+manv+"','"+daystring+"'").Tables[0].Rows[0][0].ToString();
        }
    }
}
