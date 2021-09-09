using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ReSet();
        }

        private void ReSet()
        {
            cbb_MaHV.Text = "";
            rdNam.Checked = false;
            rdNu.Checked = false;
            txt_HoTen.Text = "";
            ckb_TinHocA.Checked = false;
            ckbTinHocB.Checked = false;
            ckbTiengAnhA.Checked = false;
            ckbTiengAnhB.Checked = false;
            txt_TongTien.Text = "";
            dtpk_NgayDK.Value = DateTime.Now;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_TinhTien_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (ckb_TinHocA.Checked == true) s += int.Parse(lblTHA.Text.Split('.')[0]);
            if (ckbTinHocB.Checked == true) s += int.Parse(lblTHB.Text.Split('.')[0]);
            if (ckbTiengAnhA.Checked == true) s += int.Parse(lblTAA.Text.Split('.')[0]);
            if (ckbTiengAnhB.Checked == true) s += int.Parse(lblTAB.Text.Split('.')[0]);
            txt_TongTien.Text = s.ToString() + ".000 đồng";
        }
    }
}
