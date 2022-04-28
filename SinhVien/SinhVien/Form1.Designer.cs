
namespace SinhVien
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbma = new System.Windows.Forms.Label();
            this.lbten = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgvshow = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btlammoi = new System.Windows.Forms.Button();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.gt = new System.Windows.Forms.Label();
            this.dtpkdate = new System.Windows.Forms.DateTimePicker();
            this.cbbphongban = new System.Windows.Forms.ComboBox();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.tbten = new System.Windows.Forms.TextBox();
            this.tbmanv = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbanh = new System.Windows.Forms.Label();
            this.btchon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvshow)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbma
            // 
            this.lbma.AutoSize = true;
            this.lbma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbma.Location = new System.Drawing.Point(30, 18);
            this.lbma.Name = "lbma";
            this.lbma.Size = new System.Drawing.Size(100, 18);
            this.lbma.TabIndex = 0;
            this.lbma.Text = "Mã Nhân Viên";
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbten.Location = new System.Drawing.Point(26, 54);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(104, 18);
            this.lbten.TabIndex = 1;
            this.lbten.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "SĐT";
            // 
            // dtgvshow
            // 
            this.dtgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvshow.Location = new System.Drawing.Point(51, 315);
            this.dtgvshow.Name = "dtgvshow";
            this.dtgvshow.Size = new System.Drawing.Size(722, 230);
            this.dtgvshow.TabIndex = 6;
            this.dtgvshow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvshow_CellClick);
            this.dtgvshow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvshow_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btlammoi);
            this.panel1.Controls.Add(this.rdNu);
            this.panel1.Controls.Add(this.rdNam);
            this.panel1.Controls.Add(this.gt);
            this.panel1.Controls.Add(this.dtpkdate);
            this.panel1.Controls.Add(this.cbbphongban);
            this.panel1.Controls.Add(this.btxoa);
            this.panel1.Controls.Add(this.btsua);
            this.panel1.Controls.Add(this.btthem);
            this.panel1.Controls.Add(this.tbsdt);
            this.panel1.Controls.Add(this.tbten);
            this.panel1.Controls.Add(this.tbmanv);
            this.panel1.Controls.Add(this.lbma);
            this.panel1.Controls.Add(this.lbten);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(51, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 272);
            this.panel1.TabIndex = 7;
            // 
            // btlammoi
            // 
            this.btlammoi.Location = new System.Drawing.Point(321, 158);
            this.btlammoi.Name = "btlammoi";
            this.btlammoi.Size = new System.Drawing.Size(75, 23);
            this.btlammoi.TabIndex = 21;
            this.btlammoi.Text = "Làm Mới";
            this.btlammoi.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(238, 145);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 20;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(136, 145);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 19;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // gt
            // 
            this.gt.AutoSize = true;
            this.gt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gt.Location = new System.Drawing.Point(26, 145);
            this.gt.Name = "gt";
            this.gt.Size = new System.Drawing.Size(67, 18);
            this.gt.TabIndex = 18;
            this.gt.Text = "Giới Tính";
            // 
            // dtpkdate
            // 
            this.dtpkdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkdate.Location = new System.Drawing.Point(136, 99);
            this.dtpkdate.Name = "dtpkdate";
            this.dtpkdate.Size = new System.Drawing.Size(154, 20);
            this.dtpkdate.TabIndex = 17;
            // 
            // cbbphongban
            // 
            this.cbbphongban.FormattingEnabled = true;
            this.cbbphongban.Location = new System.Drawing.Point(136, 193);
            this.cbbphongban.Name = "cbbphongban";
            this.cbbphongban.Size = new System.Drawing.Size(154, 21);
            this.cbbphongban.TabIndex = 16;
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(321, 109);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 14;
            this.btxoa.Text = "Xoá";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(321, 61);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 13;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(321, 10);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 12;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // tbsdt
            // 
            this.tbsdt.Location = new System.Drawing.Point(136, 235);
            this.tbsdt.Multiline = true;
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(154, 20);
            this.tbsdt.TabIndex = 11;
            // 
            // tbten
            // 
            this.tbten.Location = new System.Drawing.Point(136, 54);
            this.tbten.Multiline = true;
            this.tbten.Name = "tbten";
            this.tbten.Size = new System.Drawing.Size(154, 20);
            this.tbten.TabIndex = 7;
            // 
            // tbmanv
            // 
            this.tbmanv.Location = new System.Drawing.Point(136, 16);
            this.tbmanv.Multiline = true;
            this.tbmanv.Name = "tbmanv";
            this.tbmanv.Size = new System.Drawing.Size(154, 20);
            this.tbmanv.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbanh);
            this.panel2.Controls.Add(this.btchon);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(529, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 272);
            this.panel2.TabIndex = 8;
            // 
            // lbanh
            // 
            this.lbanh.Location = new System.Drawing.Point(124, 234);
            this.lbanh.Name = "lbanh";
            this.lbanh.Size = new System.Drawing.Size(94, 18);
            this.lbanh.TabIndex = 2;
            this.lbanh.Text = "DuongDanAnh";
            this.lbanh.Click += new System.EventHandler(this.lbanh_Click);
            // 
            // btchon
            // 
            this.btchon.Location = new System.Drawing.Point(43, 234);
            this.btchon.Name = "btchon";
            this.btchon.Size = new System.Drawing.Size(75, 23);
            this.btchon.TabIndex = 1;
            this.btchon.Text = "Chọn ảnh";
            this.btchon.UseVisualStyleBackColor = true;
            this.btchon.Click += new System.EventHandler(this.btchon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(43, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 213);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvshow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvshow)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbma;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgvshow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.TextBox tbten;
        private System.Windows.Forms.TextBox tbmanv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbanh;
        private System.Windows.Forms.Button btchon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbbphongban;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label gt;
        private System.Windows.Forms.DateTimePicker dtpkdate;
        private System.Windows.Forms.Button btlammoi;
    }
}

