namespace QuanLySinhVien_Thi.GUI
{
	partial class FormSinhVien_BoSung
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
			label1 = new Label();
			txtMaSinhVien = new TextBox();
			txtHoDem = new TextBox();
			label2 = new Label();
			txtTen = new TextBox();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			txtGhiChu = new TextBox();
			label6 = new Label();
			txtGioiTinh = new ComboBox();
			txtNgaySinh = new DateTimePicker();
			txtNganh = new ComboBox();
			label7 = new Label();
			btn_Them = new Button();
			btn_Huy = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(53, 52);
			label1.Margin = new Padding(5, 0, 5, 0);
			label1.Name = "label1";
			label1.Size = new Size(124, 25);
			label1.TabIndex = 0;
			label1.Text = "Mã Sinh Viên: ";
			// 
			// txtMaSinhVien
			// 
			txtMaSinhVien.Location = new Point(190, 46);
			txtMaSinhVien.Margin = new Padding(5, 6, 5, 6);
			txtMaSinhVien.Name = "txtMaSinhVien";
			txtMaSinhVien.Size = new Size(409, 31);
			txtMaSinhVien.TabIndex = 1;
			// 
			// txtHoDem
			// 
			txtHoDem.Location = new Point(190, 117);
			txtHoDem.Margin = new Padding(5, 6, 5, 6);
			txtHoDem.Name = "txtHoDem";
			txtHoDem.Size = new Size(409, 31);
			txtHoDem.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(53, 123);
			label2.Margin = new Padding(5, 0, 5, 0);
			label2.Name = "label2";
			label2.Size = new Size(88, 25);
			label2.TabIndex = 2;
			label2.Text = "Họ Đệm: ";
			// 
			// txtTen
			// 
			txtTen.Location = new Point(190, 187);
			txtTen.Margin = new Padding(5, 6, 5, 6);
			txtTen.Name = "txtTen";
			txtTen.Size = new Size(409, 31);
			txtTen.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(53, 192);
			label3.Margin = new Padding(5, 0, 5, 0);
			label3.Name = "label3";
			label3.Size = new Size(47, 25);
			label3.TabIndex = 4;
			label3.Text = "Tên: ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(53, 263);
			label4.Margin = new Padding(5, 0, 5, 0);
			label4.Name = "label4";
			label4.Size = new Size(90, 25);
			label4.TabIndex = 6;
			label4.Text = "Giới Tính: ";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(53, 335);
			label5.Margin = new Padding(5, 0, 5, 0);
			label5.Name = "label5";
			label5.Size = new Size(102, 25);
			label5.TabIndex = 8;
			label5.Text = "Ngày Sinh: ";
			// 
			// txtGhiChu
			// 
			txtGhiChu.Location = new Point(188, 477);
			txtGhiChu.Margin = new Padding(5, 6, 5, 6);
			txtGhiChu.Name = "txtGhiChu";
			txtGhiChu.Size = new Size(409, 31);
			txtGhiChu.TabIndex = 11;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(53, 483);
			label6.Margin = new Padding(5, 0, 5, 0);
			label6.Name = "label6";
			label6.Size = new Size(83, 25);
			label6.TabIndex = 10;
			label6.Text = "Ghi Chú: ";
			// 
			// txtGioiTinh
			// 
			txtGioiTinh.FormattingEnabled = true;
			txtGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
			txtGioiTinh.Location = new Point(190, 258);
			txtGioiTinh.Margin = new Padding(5, 6, 5, 6);
			txtGioiTinh.Name = "txtGioiTinh";
			txtGioiTinh.Size = new Size(409, 33);
			txtGioiTinh.TabIndex = 12;
			// 
			// txtNgaySinh
			// 
			txtNgaySinh.CustomFormat = "dd/MM/yyyy";
			txtNgaySinh.Format = DateTimePickerFormat.Custom;
			txtNgaySinh.Location = new Point(188, 323);
			txtNgaySinh.Margin = new Padding(5, 6, 5, 6);
			txtNgaySinh.Name = "txtNgaySinh";
			txtNgaySinh.Size = new Size(411, 31);
			txtNgaySinh.TabIndex = 13;
			txtNgaySinh.Value = new DateTime(2024, 12, 12, 9, 52, 7, 0);
			// 
			// txtNganh
			// 
			txtNganh.FormattingEnabled = true;
			txtNganh.Location = new Point(188, 398);
			txtNganh.Margin = new Padding(5, 6, 5, 6);
			txtNganh.Name = "txtNganh";
			txtNganh.Size = new Size(409, 33);
			txtNganh.TabIndex = 15;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(53, 404);
			label7.Margin = new Padding(5, 0, 5, 0);
			label7.Name = "label7";
			label7.Size = new Size(69, 25);
			label7.TabIndex = 14;
			label7.Text = "Ngành:";
			// 
			// btn_Them
			// 
			btn_Them.Location = new Point(380, 552);
			btn_Them.Margin = new Padding(5, 6, 5, 6);
			btn_Them.Name = "btn_Them";
			btn_Them.Size = new Size(105, 42);
			btn_Them.TabIndex = 16;
			btn_Them.Text = "Thêm";
			btn_Them.UseVisualStyleBackColor = true;
			btn_Them.Click += btn_Them_Click;
			// 
			// btn_Huy
			// 
			btn_Huy.Location = new Point(497, 552);
			btn_Huy.Margin = new Padding(5, 6, 5, 6);
			btn_Huy.Name = "btn_Huy";
			btn_Huy.Size = new Size(105, 42);
			btn_Huy.TabIndex = 17;
			btn_Huy.Text = "Hủy";
			btn_Huy.UseVisualStyleBackColor = true;
			btn_Huy.Click += btn_Huy_Click;
			// 
			// FormSinhVien_BoSung
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(664, 644);
			Controls.Add(btn_Huy);
			Controls.Add(btn_Them);
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
			Name = "FormSinhVien_BoSung";
			Text = "ThemSinhVien";
			Load += FormSinhVien_BoSung_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMaSinhVien;
		private System.Windows.Forms.TextBox txtHoDem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtGhiChu;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox txtGioiTinh;
		private System.Windows.Forms.DateTimePicker txtNgaySinh;
		private System.Windows.Forms.ComboBox txtNganh;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btn_Them;
		private System.Windows.Forms.Button btn_Huy;
	}
}