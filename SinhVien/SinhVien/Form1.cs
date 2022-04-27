using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region
        public void loadPB()
        {
            string sql = "select * from PhongBan";
            cbbphongban.DataSource = KetNoi.getData(sql);
            cbbphongban.DisplayMember = "TenPB";
            cbbphongban.ValueMember = "MaPB";
        }
        public void loadData()
        {
            string sql = "select * from NhanVien";
            dtgvshow.DataSource = KetNoi.getData(sql);
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            KetNoi.moKetNoi();
            loadPB();
            loadData();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            string sql = "Insert into NhanVien Values(@MaNV, @TenNV, @NgaySinh, @GioiTinh, @SDT, @MaPhong, @Picture)";
            string[] name = { "@MaNV", "@TenNV", "@NgaySinh", "@GioiTinh", "@SDT", "@MaPhong", "@Picture" };
            bool gt = rdNam.Checked == true ? true : false;
            object[] value = { tbmanv.Text, tbten.Text, dtpkdate.Value, gt, tbsdt.Text, cbbphongban.SelectedValue, lbanh.Text};
            KetNoi.moKetNoi();
            KetNoi.updateData(sql, value, name, 7);
            loadData();
            KetNoi.dongKetNoi();
        }

        private void btchon_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openfile.FileName);
                lbanh.Text = Path.GetFileName(openfile.FileName);
            }
        }
    }
}
