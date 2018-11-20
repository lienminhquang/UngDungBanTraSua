using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DOAN.DTO;

namespace DOAN
{
    public partial class MainContent : Form
    {
        private string manv;
        public MainContent()
        {
            this.manv = "";
            InitializeComponent();
            docMaNV();
            intiTableObject();
            LoadLoaiSP();
        }

        private void docMaNV()
        {
            this.txtMaNVPhucVu.Text = this.manv;
        }

        private void intiTableObject()
        {
            Table.setMainContent(this);
            Table tableobj1 = new Table(table1, "Ban 1");
            Table tableobj2 = new Table(table2, "Ban 2");
            Table tableobj3 = new Table(table3, "Ban 3");
            Table tableobj4 = new Table(table4, "Ban 4");
            Table tableobj5 = new Table(table5, "Ban 5");
            Table tableobj6 = new Table(table6, "Ban 6");
            Table tableobj7 = new Table(table7, "Ban 7");
            Table tableobj8 = new Table(table8, "Ban 8");
            Table tableobj9 = new Table(table9, "Ban 9");
            Table tableobj10 = new Table(table10, "Ban 10");
            Table tableobj11 = new Table(table11, "Ban 11");
            Table tableobj12 = new Table(table12, "Ban 12");
            Table tableobj13 = new Table(table13, "Ban 13");
            Table tableobj14 = new Table(table14, "Ban 14");
            Table tableobj15 = new Table(table15, "Ban 15");
            Table tableobj16 = new Table(table16, "Ban 16");
           
          
        }
        public void LoadLoaiSP()
        {
            loaiSP.DataSource = DXApplication1.BS_layer.BLTLoaiSP.Instance.LayLoaiSP2();
            loaiSP.DisplayMember = "TenLoai";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView obj = (DataRowView)loaiSP.SelectedItem;
            string ma = obj.Row["MaLoai"].ToString();
            tenMon.DataSource = DXApplication1.BS_layer.BLTSanPham.Instance.LayDSSPTheoLoai(ma);
            tenMon.DisplayMember = "TenSP";
        }

        internal void setMaNV(string v)
        {
            this.manv = v;
            this.docMaNV();
        }

       
    }
}
