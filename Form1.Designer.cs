
namespace Lab02_Demo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_MaHV = new System.Windows.Forms.ComboBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpk_NgayDK = new System.Windows.Forms.DateTimePicker();
            this.ckb_TinHocA = new System.Windows.Forms.CheckBox();
            this.ckbTinHocB = new System.Windows.Forms.CheckBox();
            this.ckbTiengAnhA = new System.Windows.Forms.CheckBox();
            this.ckbTiengAnhB = new System.Windows.Forms.CheckBox();
            this.lblTHA = new System.Windows.Forms.Label();
            this.lblTHB = new System.Windows.Forms.Label();
            this.lblTAA = new System.Windows.Forms.Label();
            this.lblTAB = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TinhTien = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÍNH TIỀN HỌC TRUNG TÂM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Học Viên";
            // 
            // cbb_MaHV
            // 
            this.cbb_MaHV.FormattingEnabled = true;
            this.cbb_MaHV.Items.AddRange(new object[] {
            "0001",
            "0002",
            "0003",
            "0004",
            "0005"});
            this.cbb_MaHV.Location = new System.Drawing.Point(131, 84);
            this.cbb_MaHV.Name = "cbb_MaHV";
            this.cbb_MaHV.Size = new System.Drawing.Size(121, 24);
            this.cbb_MaHV.TabIndex = 0;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(366, 82);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(58, 21);
            this.rdNam.TabIndex = 1;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(449, 82);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(47, 21);
            this.rdNu.TabIndex = 2;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            this.rdNu.CheckedChanged += new System.EventHandler(this.rdNu_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Họ Tên";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(131, 126);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(365, 22);
            this.txt_HoTen.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Đăng Kí";
            // 
            // dtpk_NgayDK
            // 
            this.dtpk_NgayDK.Location = new System.Drawing.Point(131, 168);
            this.dtpk_NgayDK.Name = "dtpk_NgayDK";
            this.dtpk_NgayDK.Size = new System.Drawing.Size(365, 22);
            this.dtpk_NgayDK.TabIndex = 4;
            // 
            // ckb_TinHocA
            // 
            this.ckb_TinHocA.AutoSize = true;
            this.ckb_TinHocA.Location = new System.Drawing.Point(131, 214);
            this.ckb_TinHocA.Name = "ckb_TinHocA";
            this.ckb_TinHocA.Size = new System.Drawing.Size(92, 21);
            this.ckb_TinHocA.TabIndex = 5;
            this.ckb_TinHocA.Text = "Tín Học A";
            this.ckb_TinHocA.UseVisualStyleBackColor = true;
            // 
            // ckbTinHocB
            // 
            this.ckbTinHocB.AutoSize = true;
            this.ckbTinHocB.Location = new System.Drawing.Point(131, 241);
            this.ckbTinHocB.Name = "ckbTinHocB";
            this.ckbTinHocB.Size = new System.Drawing.Size(92, 21);
            this.ckbTinHocB.TabIndex = 6;
            this.ckbTinHocB.Text = "Tin Học B";
            this.ckbTinHocB.UseVisualStyleBackColor = true;
            // 
            // ckbTiengAnhA
            // 
            this.ckbTiengAnhA.AutoSize = true;
            this.ckbTiengAnhA.Location = new System.Drawing.Point(131, 268);
            this.ckbTiengAnhA.Name = "ckbTiengAnhA";
            this.ckbTiengAnhA.Size = new System.Drawing.Size(108, 21);
            this.ckbTiengAnhA.TabIndex = 7;
            this.ckbTiengAnhA.Text = "Tiếng Anh A";
            this.ckbTiengAnhA.UseVisualStyleBackColor = true;
            // 
            // ckbTiengAnhB
            // 
            this.ckbTiengAnhB.AutoSize = true;
            this.ckbTiengAnhB.Location = new System.Drawing.Point(131, 295);
            this.ckbTiengAnhB.Name = "ckbTiengAnhB";
            this.ckbTiengAnhB.Size = new System.Drawing.Size(108, 21);
            this.ckbTiengAnhB.TabIndex = 8;
            this.ckbTiengAnhB.Text = "Tiếng Anh B";
            this.ckbTiengAnhB.UseVisualStyleBackColor = true;
            // 
            // lblTHA
            // 
            this.lblTHA.AutoSize = true;
            this.lblTHA.Location = new System.Drawing.Point(401, 215);
            this.lblTHA.Name = "lblTHA";
            this.lblTHA.Size = new System.Drawing.Size(96, 17);
            this.lblTHA.TabIndex = 1;
            this.lblTHA.Text = "300.000 đồng";
            // 
            // lblTHB
            // 
            this.lblTHB.AutoSize = true;
            this.lblTHB.Location = new System.Drawing.Point(400, 245);
            this.lblTHB.Name = "lblTHB";
            this.lblTHB.Size = new System.Drawing.Size(96, 17);
            this.lblTHB.TabIndex = 1;
            this.lblTHB.Text = "500.000 đồng";
            // 
            // lblTAA
            // 
            this.lblTAA.AutoSize = true;
            this.lblTAA.Location = new System.Drawing.Point(401, 272);
            this.lblTAA.Name = "lblTAA";
            this.lblTAA.Size = new System.Drawing.Size(96, 17);
            this.lblTAA.TabIndex = 1;
            this.lblTAA.Text = "400.000 đồng";
            // 
            // lblTAB
            // 
            this.lblTAB.AutoSize = true;
            this.lblTAB.Location = new System.Drawing.Point(401, 299);
            this.lblTAB.Name = "lblTAB";
            this.lblTAB.Size = new System.Drawing.Size(96, 17);
            this.lblTAB.TabIndex = 1;
            this.lblTAB.Text = "600.000 đồng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(131, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tổng Tiền";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Enabled = false;
            this.txt_TongTien.Location = new System.Drawing.Point(241, 344);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(255, 22);
            this.txt_TongTien.TabIndex = 9;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(396, 393);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(100, 50);
            this.btn_Thoat.TabIndex = 12;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_TinhTien
            // 
            this.btn_TinhTien.Location = new System.Drawing.Point(36, 393);
            this.btn_TinhTien.Name = "btn_TinhTien";
            this.btn_TinhTien.Size = new System.Drawing.Size(100, 50);
            this.btn_TinhTien.TabIndex = 11;
            this.btn_TinhTien.Text = "Tính Tiền";
            this.btn_TinhTien.UseVisualStyleBackColor = true;
            this.btn_TinhTien.Click += new System.EventHandler(this.btn_TinhTien_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Image = global::Lab02_Demo.Properties.Resources.icons8_cancel_30;
            this.btn_Cancel.Location = new System.Drawing.Point(222, 393);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 50);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 477);
            this.Controls.Add(this.btn_TinhTien);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ckbTiengAnhB);
            this.Controls.Add(this.ckbTiengAnhA);
            this.Controls.Add(this.ckbTinHocB);
            this.Controls.Add(this.ckb_TinHocA);
            this.Controls.Add(this.dtpk_NgayDK);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.cbb_MaHV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTAB);
            this.Controls.Add(this.lblTAA);
            this.Controls.Add(this.lblTHB);
            this.Controls.Add(this.lblTHA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lab02 Exercise 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_MaHV;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpk_NgayDK;
        private System.Windows.Forms.CheckBox ckb_TinHocA;
        private System.Windows.Forms.CheckBox ckbTinHocB;
        private System.Windows.Forms.CheckBox ckbTiengAnhA;
        private System.Windows.Forms.CheckBox ckbTiengAnhB;
        private System.Windows.Forms.Label lblTHA;
        private System.Windows.Forms.Label lblTHB;
        private System.Windows.Forms.Label lblTAA;
        private System.Windows.Forms.Label lblTAB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_TinhTien;
    }
}

