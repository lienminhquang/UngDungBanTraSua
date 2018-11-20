using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;


namespace DOAN.DTO
{
    class Table
    {
        private string tablename;//tên table
        private BunifuThinButton2 btn; //button table hiện hành 
        private string mahd; // mã hóa đơn
        private static Table current; //table đang hiện hành
        private static MainContent maincontent; 
        private static TextBox txtHD;
        private static BunifuThinButton2 btnThemMon;
        private static BunifuThinButton2 btnThanhTien;
        private DataSet cthd;//dataset chitiethoadon
        private int tongtien;
        public Table(BunifuThinButton2 btn, string tablename)
        {
            this.cthd = new DataSet();
            this.btn = btn;
            this.tablename = tablename;
            this.mahd = "";
            this.tongtien = 0;
            initButtonEvent();
        }
        private void initButtonEvent()
        {
            this.btn.Click += new EventHandler(button_click);
        }


        private void button_click(object sender, EventArgs e)
        {
            Table.current = this;
            Table.txtHD.Text = this.mahd;
            Table.current.cthd = DXApplication1.BS_layer.BLTHoaDon.Instance.laychitiethoadontheomahd(Table.current.mahd);
            fillListView();
           
        }

       

        private static void fillListView()
        {
            // Get the table from the data set
            //DataTable dtable = Table.current.cthd.Tables[0];
            //BindingSource sbind = new BindingSource();
            //sbind.DataSource = dtable;
            //Table.maincontent.chiTietHoaDon.Columns.Clear();
            //Table.maincontent.chiTietHoaDon.DataSource = sbind;
            //Table.maincontent.chiTietHoaDon.Refresh();
            //// Clear the ListView control
            Table.maincontent.chiTietHoaDon.DataSource = Table.current.cthd.Tables[0];
        }

        public static void setMainContent(MainContent maincontent)
        {
            Table.maincontent = maincontent;
            Table.btnThemMon = maincontent.btnThemMon;
            Table.btnThanhTien = maincontent.btnThanhTien;
            Table.txtHD = maincontent.txtHD;
            initStaticButtonEvetn();
        }

        private static void initStaticButtonEvetn()
        {
            Table.btnThemMon.Click += new EventHandler(ThemMon);
            Table.btnThanhTien.Click += new EventHandler(ThanhTien);
        }

        private static void ThanhTien(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("May thanh toan hong?", "Hoi Thanh Toan", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                Table.current.mahd = "";
                Table.current.tongtien = 0;
                Table.maincontent.chiTietHoaDon.Columns.Clear();
                Table.maincontent.chiTietHoaDon.Refresh();
                Table.maincontent.txtTongTien.Text = "";
                Table.current.btn.IdleFillColor = Color.White;
                Table.current.btn.IdleForecolor = Color.FromArgb(243, 156, 18);
                Table.current.btn.ActiveFillColor = Color.FromArgb(243, 156, 18);
            }
        }

        private static void ThemMon(object sender, EventArgs e)
        {
            if (String.Compare(Table.current.mahd, "", true) == 0)
            {

                Table.current.mahd = DXApplication1.BS_layer.BLTHoaDon.Instance.taoHD(Table.maincontent.txtMaNVPhucVu.Text);

                Table.current.btn.IdleFillColor = Color.Red;
                Table.current.btn.IdleForecolor = Color.White;
                Table.current.btn.ActiveFillColor = Color.Red;
            }
            string masp = ((DataRowView)Table.maincontent.tenMon.SelectedItem).Row["MaSP"].ToString();
            int soluong = (int) Table.maincontent.soSanPham.Value;
            DXApplication1.BS_layer.BLT_CTHD.Instance.ThemChiTietHD(Table.current.mahd, masp, soluong);
            Table.current.cthd = DXApplication1.BS_layer.BLTHoaDon.Instance.laychitiethoadontheomahd(Table.current.mahd);
            fillListView();
            Table.current.tongtien = DXApplication1.BS_layer.BLTHoaDon.Instance.LayTongTien(Table.current.mahd);
            Table.maincontent.txtTongTien.Text = Table.current.tongtien + "";
            Table.txtHD.Text = Table.current.mahd;
        }
    }
}
