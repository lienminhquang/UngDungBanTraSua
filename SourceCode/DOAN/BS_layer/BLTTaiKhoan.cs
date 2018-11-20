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
    class BLTTaiKhoan
    {

        private BLTTaiKhoan()
        {

        }

        private static BLTTaiKhoan instance;

        internal static BLTTaiKhoan Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLTTaiKhoan();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public bool DangNhapAdmin(string username, string password)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@username", username));
            lstParam.Add(new SqlParameter("@password", password));

            return (bool)DBMain.Instance.executeFunctionScalar(Cons.fn_DNAdmin, lstParam);
        }

        public DataTable LayDanhSachTaiKhoan()
        {
             return DBMain.Instance.executeFunctionDataset(Cons.fn_LayDSTaiKhoan).Tables[0];
        }

        public void ThemTaiKhoan(string manv, string username, string password)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@manv", manv));
            lstParam.Add(new SqlParameter("@login", username));
            lstParam.Add(new SqlParameter("@password", password));

            DBMain.Instance.executeStoredProc(Cons.p_TaoTK, lstParam);
        }

        public void SuaTaiKhoan(string manv, string new_password)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@manv", manv));      
            lstParam.Add(new SqlParameter("@new_password", new_password));

            DBMain.Instance.executeStoredProc(Cons.p_Admin_DoiMatKhau, lstParam);
        }

        public void XoaTaiKhoan(string manv)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@manv", manv));

            DBMain.Instance.executeStoredProc(Cons.p_XoaTK, lstParam);
        }

        internal int DangNhap(string tenDN, string matkhau)
        {
            if (!DBMain.Instance.login(tenDN, matkhau))
            {
                return -1;
            }


            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@username", tenDN));
            lstParam.Add(new SqlParameter("@password", matkhau));

            return int.Parse(DBMain.Instance.executeFunctionScalar(Cons.fn_login, lstParam).ToString());
        }

        internal string LayMaNV(string tenDN)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@tenDN", tenDN));

            return DBMain.Instance.executeQueryDataset("select MaNV from dbo.TaiKhoan where TenDN ='"+tenDN+"'").Tables[0].Rows[0][0].ToString();
        }

        public void DoiMatKhau(string manv, string mk_cu, string mk_moi)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@manv", manv));
            lstParam.Add(new SqlParameter("@mk_cu", mk_cu));
            lstParam.Add(new SqlParameter("@mk_moi", mk_moi));
            

            DBMain.Instance.executeStoredProc(Cons.p_DoiMK, lstParam);
        }
    }
}
