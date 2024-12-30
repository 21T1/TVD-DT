namespace QuanLySinhVien_Thi.GUI
{
	partial class FormNganhDaoTao_ChinhSua
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
			txtMaNganh = new TextBox();
			txtTenNganhDaoTao = new TextBox();
			label2 = new Label();
			btn_ChinhSua = new Button();
			btn_Huy = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(23, 29);
			label1.Name = "label1";
			label1.Size = new Size(101, 25);
			label1.TabIndex = 0;
			label1.Text = "Mã ngành: ";
			// 
			// txtMaNganh
			// 
			txtMaNganh.Location = new Point(143, 23);
			txtMaNganh.Name = "txtMaNganh";
			txtMaNganh.Size = new Size(197, 31);
			txtMaNganh.TabIndex = 1;
			// 
			// txtTenNganhDaoTao
			// 
			txtTenNganhDaoTao.Location = new Point(143, 71);
			txtTenNganhDaoTao.Name = "txtTenNganhDaoTao";
			txtTenNganhDaoTao.Size = new Size(361, 31);
			txtTenNganhDaoTao.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(23, 77);
			label2.Name = "label2";
			label2.Size = new Size(102, 25);
			label2.TabIndex = 2;
			label2.Text = "Tên ngành: ";
			// 
			// btn_ChinhSua
			// 
			btn_ChinhSua.Location = new Point(274, 134);
			btn_ChinhSua.Name = "btn_ChinhSua";
			btn_ChinhSua.Size = new Size(112, 34);
			btn_ChinhSua.TabIndex = 4;
			btn_ChinhSua.Text = "Sửa";
			btn_ChinhSua.UseVisualStyleBackColor = true;
			// 
			// btn_Huy
			// 
			btn_Huy.Location = new Point(392, 134);
			btn_Huy.Name = "btn_Huy";
			btn_Huy.Size = new Size(112, 34);
			btn_Huy.TabIndex = 5;
			btn_Huy.Text = "Hủy";
			btn_Huy.UseVisualStyleBackColor = true;
			btn_Huy.Click += btn_Huy_Click;
			// 
			// FormNganhDaoTao_ChinhSua
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(575, 255);
			Controls.Add(btn_Huy);
			Controls.Add(btn_ChinhSua);
			Controls.Add(txtTenNganhDaoTao);
			Controls.Add(label2);
			Controls.Add(txtMaNganh);
			Controls.Add(label1);
			Name = "FormNganhDaoTao_ChinhSua";
			Text = "FormNganhDaoTao_BoSung";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtMaNganh;
		private TextBox txtTenNganhDaoTao;
		private Label label2;
		private Button btn_ChinhSua;
		private Button btn_Huy;
	}
}