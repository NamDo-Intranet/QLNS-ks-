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
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                lbanh.Text = Path.GetFileName(openfile.FileName);
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {

        }

        private void lbanh_Click(object sender, EventArgs e)
        {

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Bạn có muốn xoá không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                int i = dtgvshow.CurrentCell.RowIndex;
                string ma = dtgvshow.Rows[i].Cells[0].Value.ToString();
                string sql = string.Format("Delete from NhanVien where MaNV='{0}'", ma);
                string[] name = { };
                object[] value = { };
                KetNoi.moKetNoi();
                KetNoi.updateData(sql, value, name, 0);
                loadData();
                KetNoi.dongKetNoi();
            }
        }

        private void dtgvshow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgvshow.CurrentCell.RowIndex;
            tbmanv.Text = dtgvshow.Rows[i].Cells[0].Value.ToString();
            tbten.Text = dtgvshow.Rows[i].Cells[1].Value.ToString();
            dtpkdate.Text = dtgvshow.Rows[i].Cells[2].Value.ToString();
            string gt = dtgvshow.Rows[i].Cells[3].Value.ToString();
            if (gt == "True")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            tbsdt.Text = dtgvshow.Rows[i].Cells[4].Value.ToString();
            cbbphongban.SelectedValue = dtgvshow.Rows[i].Cells[5].Value.ToString();           
            lbanh.Text = dtgvshow.Rows[i].Cells[6].Value.ToString();
        }
    }
}
