namespace QuanLySinhVien_Thi.GUI
{
	partial class FormSinhVien_ChinhSua
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
			btn_Huy = new Button();
			btn_Sua = new Button();
			txtNganh = new ComboBox();
			label7 = new Label();
			txtNgaySinh = new DateTimePicker();
			txtGioiTinh = new ComboBox();
			txtGhiChu = new TextBox();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			txtTen = new TextBox();
			label3 = new Label();
			txtHoDem = new TextBox();
			label2 = new Label();
			txtMaSinhVien = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// btn_Huy
			// 
			btn_Huy.Location = new Point(510, 569);
			btn_Huy.Margin = new Padding(5, 6, 5, 6);
			btn_Huy.Name = "btn_Huy";
			btn_Huy.Size = new Size(105, 42);
			btn_Huy.TabIndex = 33;
			btn_Huy.Text = "Hủy";
			btn_Huy.UseVisualStyleBackColor = true;
			btn_Huy.Click += btn_Huy_Click;
			// 
			// btn_Sua
			// 
			btn_Sua.Location = new Point(393, 569);
			btn_Sua.Margin = new Padding(5, 6, 5, 6);
			btn_Sua.Name = "btn_Sua";
			btn_Sua.Size = new Size(105, 42);
			btn_Sua.TabIndex = 32;
			btn_Sua.Text = "Sửa";
			btn_Sua.UseVisualStyleBackColor = true;
			btn_Sua.Click += btn_Sua_Click;
			// 
			// txtNganh
			// 
			txtNganh.FormattingEnabled = true;
			txtNganh.Location = new Point(202, 415);
			txtNganh.Margin = new Padding(5, 6, 5, 6);
			txtNganh.Name = "txtNganh";
			txtNganh.Size = new Size(409, 33);
			txtNganh.TabIndex = 31;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(67, 421);
			label7.Margin = new Padding(5, 0, 5, 0);
			label7.Name = "label7";
			label7.Size = new Size(69, 25);
			label7.TabIndex = 30;
			label7.Text = "Ngành:";
			// 
			// txtNgaySinh
			// 
			txtNgaySinh.CustomFormat = "dd/MM/yyyy";
			txtNgaySinh.Format = DateTimePickerFormat.Custom;
			txtNgaySinh.Location = new Point(202, 340);
			txtNgaySinh.Margin = new Padding(5, 6, 5, 6);
			txtNgaySinh.Name = "txtNgaySinh";
			txtNgaySinh.Size = new Size(411, 31);
			txtNgaySinh.TabIndex = 29;
			txtNgaySinh.Value = new DateTime(2024, 12, 12, 9, 52, 7, 0);
			// 
			// txtGioiTinh
			// 
			txtGioiTinh.FormattingEnabled = true;
			txtGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
			txtGioiTinh.Location = new Point(203, 275);
			txtGioiTinh.Margin = new Padding(5, 6, 5, 6);
			txtGioiTinh.Name = "txtGioiTinh";
			txtGioiTinh.Size = new Size(409, 33);
			txtGioiTinh.TabIndex = 28;
			// 
			// txtGhiChu
			// 
			txtGhiChu.Location = new Point(202, 494);
			txtGhiChu.Margin = new Padding(5, 6, 5, 6);
			txtGhiChu.Name = "txtGhiChu";
			txtGhiChu.Size = new Size(409, 31);
			txtGhiChu.TabIndex = 27;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(67, 500);
			label6.Margin = new Padding(5, 0, 5, 0);
			label6.Name = "label6";
			label6.Size = new Size(83, 25);
			label6.TabIndex = 26;
			label6.Text = "Ghi Chú: ";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(67, 352);
			label5.Margin = new Padding(5, 0, 5, 0);
			label5.Name = "label5";
			label5.Size = new Size(102, 25);
			label5.TabIndex = 25;
			label5.Text = "Ngày Sinh: ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(67, 281);
			label4.Margin = new Padding(5, 0, 5, 0);
			label4.Name = "label4";
			label4.Size = new Size(90, 25);
			label4.TabIndex = 24;
			label4.Text = "Giới Tính: ";
			// 
			// txtTen
			// 
			txtTen.Location = new Point(203, 204);
			txtTen.Margin = new Padding(5, 6, 5, 6);
			txtTen.Name = "txtTen";
			txtTen.Size = new Size(409, 31);
			txtTen.TabIndex = 23;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(67, 210);
			label3.Margin = new Padding(5, 0, 5, 0);
			label3.Name = "label3";
			label3.Size = new Size(47, 25);
			label3.TabIndex = 22;
			label3.Text = "Tên: ";
			// 
			// txtHoDem
			// 
			txtHoDem.Location = new Point(203, 135);
			txtHoDem.Margin = new Padding(5, 6, 5, 6);
			txtHoDem.Name = "txtHoDem";
			txtHoDem.Size = new Size(409, 31);
			txtHoDem.TabIndex = 21;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(67, 140);
			label2.Margin = new Padding(5, 0, 5, 0);
			label2.Name = "label2";
			label2.Size = new Size(88, 25);
			label2.TabIndex = 20;
			label2.Text = "Họ Đệm: ";
			// 
			// txtMaSinhVien
			// 
			txtMaSinhVien.Location = new Point(203, 63);
			txtMaSinhVien.Margin = new Padding(5, 6, 5, 6);
			txtMaSinhVien.Name = "txtMaSinhVien";
			txtMaSinhVien.Size = new Size(409, 31);
			txtMaSinhVien.TabIndex = 19;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(67, 69);
			label1.Margin = new Padding(5, 0, 5, 0);
			label1.Name = "label1";
			label1.Size = new Size(124, 25);
			label1.TabIndex = 18;
			label1.Text = "Mã Sinh Viên: ";
			// 
			// FormSinhVien_ChinhSua
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(725, 658);
			Controls.Add(btn_Huy);
			Controls.Add(btn_Sua);
			Controls.Add(txtNganh);
			Controls.Add(label7);
			Controls.Add(txtNgaySinh);
			Controls.Add(txtGioiTinh);
			Controls.Add(txtGhiChu);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(txtTen);
			Controls.Add(label3);
			Controls.Add(txtHoDem);
			Controls.Add(label2);
			Controls.Add(txtMaSinhVien);
			Controls.Add(label1);
			Margin = new Padding(5, 6, 5, 6);
			Name = "FormSinhVien_ChinhSua";
			Text = "FormSuaSinhVien";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.ComboBox txtNganh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtNgaySinh;
        private System.Windows.Forms.ComboBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoDem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Label label1;
	}
}