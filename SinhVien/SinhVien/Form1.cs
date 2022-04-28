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
using System.Configuration;


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
            if (KetNoi.ktraMaNV(tbmanv.Text) == 0)
            {
                string sql = "Insert into NhanVien Values(@MaNV, @TenNV, @NgaySinh, @GioiTinh, @SDT, @MaPhong, @Picture)";
                string[] name = { "@MaNV", "@TenNV", "@NgaySinh", "@GioiTinh", "@SDT", "@MaPhong", "@Picture" };
                bool gt = rdNam.Checked == true ? true : false;
                object[] value = { tbmanv.Text, tbten.Text, dtpkdate.Value, gt, tbsdt.Text, cbbphongban.SelectedValue, lbanh.Text };
                KetNoi.moKetNoi();
                KetNoi.updateData(sql, value, name, 7);
                loadData();
                KetNoi.dongKetNoi();
                MessageBox.Show("Đã thêm thành công vào CSDL");
            }
            else
            {
                MessageBox.Show("Mã Nhân viên đã tồn tại. Vui lòng nhập mã khác!");
            }
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
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Bạn có đồng ý sửa lại thông tin không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                string sql = string.Format(@"Update NhanVien set MaNV = @MaNV, TenNV = @TenNV, NgaySinh = @NgaySinh,
                        GioiTinh = @GioiTinh, SoDT = @SoDT, MaPB = @MaPB, Picture = @Picture where MaNV ='{0}'", tbmanv.Text);
                string[] name = { "@MaNV", "@TenNV", "@NgaySinh", "@GioiTinh", "@SoDT", "@MaPB", "@Picture" };
                bool gt = rdNam.Checked == true ? true : false;
                object[] value = { tbmanv.Text, tbten.Text, dtpkdate.Value, gt, tbsdt.Text, cbbphongban.SelectedValue, lbanh.Text };
                KetNoi.moKetNoi();
                KetNoi.updateData(sql, value, name, 7);
                loadData();
                KetNoi.dongKetNoi();
                MessageBox.Show("Đã Sửa thành công vào CSDL");
            }
            else
            {
                MessageBox.Show("Bạn đã hủy sửa thông tin này!");
            }
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
                MessageBox.Show("Bạn đã xóa thành công");
            }
            else
            {
                MessageBox.Show("Bạn đã hủy xóa đối tượng này!");
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
            string PathAnh = ConfigurationManager.AppSettings.Get("DuongDanAnh") + "\\"+lbanh.Text;
            if (File.Exists(PathAnh))
            {
                pictureBox1.Image = Image.FromFile(PathAnh);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void dtgvshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btlammoi_Click(object sender, EventArgs e)
        {
            tbmanv.Text = "";
            tbten.Text = "";
            tbsdt.Text = "";
            rdNam.Checked = false;
            rdNu.Checked = false;
            cbbphongban.SelectedValue = "";
            dtpkdate.Value = DateTime.Today;
            pictureBox1.Image = null;
        }
    }
}
