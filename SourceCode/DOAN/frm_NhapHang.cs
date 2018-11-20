using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using System.IO;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;
using DXApplication1.BS_layer;

namespace DXApplication1
{
    public partial class frm_NhapHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_NhapHang()
        {
            InitializeComponent();
            
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            save(txt_Ma.Text, (int)txt_SoLuongNhapThem.Value);
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            save(txt_Ma.Text, (int)txt_SoLuongNhapThem.Value);
            Close();
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            save(txt_Ma.Text, (int)txt_SoLuongNhapThem.Value);
            txt_Ma.ResetText();
            txt_Ten.ResetText();
            txt_SoLuongHienTai.ResetText();
            txt_SoLuongNhapThem.ResetText();
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void save(string ma, int soluong)
        {
            try
            {
                BLTSanPham.Instance.NhapHang(txt_Ma.Text, (int)txt_SoLuongNhapThem.Value);
                MessageBox.Show("Done");
                DataRowView d = (DataRowView)txt_Ten.SelectedItem;
                txt_Ma.Text = d.Row["MaSP"].ToString();
                txt_SoLuongHienTai.Text = d.Row["SoLuong"].ToString();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void frm_NhapHang_Load(object sender, EventArgs e)
        {
            txt_Ten.DataSource = BLTSanPham.Instance.LayDS();
            txt_Ten.DisplayMember = "TenSP";
        }

        private void txt_Ma_SelectedIndexChanged(object sender, EventArgs e)
        {
           // DataRowView d = txt_Ma.
            //txt_Ten.Text = ;
        }

        private void txt_Ten_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView d = (DataRowView)txt_Ten.SelectedItem;
            txt_Ma.Text = d.Row["MaSP"].ToString();
            txt_SoLuongHienTai.Text = d.Row["SoLuong"].ToString();
            
        }
    }
}
