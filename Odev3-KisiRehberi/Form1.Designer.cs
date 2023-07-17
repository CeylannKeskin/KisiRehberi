namespace Odev3_KisiRehberi
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			txtKisiID = new TextBox();
			label1 = new Label();
			label2 = new Label();
			txtAd = new TextBox();
			label3 = new Label();
			txtSoyad = new TextBox();
			label4 = new Label();
			mskTxtTelNo = new MaskedTextBox();
			listView1 = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			btnEkle = new Button();
			btnGuncelle = new Button();
			btnSil = new Button();
			btnListele = new Button();
			btnAra = new Button();
			btnEkranTemize = new Button();
			SuspendLayout();
			// 
			// txtKisiID
			// 
			txtKisiID.Location = new Point(222, 16);
			txtKisiID.Margin = new Padding(3, 4, 3, 4);
			txtKisiID.Name = "txtKisiID";
			txtKisiID.Size = new Size(156, 27);
			txtKisiID.TabIndex = 0;
			// 
			// label1
			// 
			label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(14, 27);
			label1.Name = "label1";
			label1.Size = new Size(114, 31);
			label1.TabIndex = 1;
			label1.Text = "Kişi ID:";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(14, 92);
			label2.Name = "label2";
			label2.Size = new Size(114, 20);
			label2.TabIndex = 3;
			label2.Text = "Ad:";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txtAd
			// 
			txtAd.Location = new Point(222, 81);
			txtAd.Margin = new Padding(3, 4, 3, 4);
			txtAd.Name = "txtAd";
			txtAd.Size = new Size(156, 27);
			txtAd.TabIndex = 2;
			// 
			// label3
			// 
			label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(14, 147);
			label3.Name = "label3";
			label3.Size = new Size(114, 39);
			label3.TabIndex = 5;
			label3.Text = "Soyad:";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txtSoyad
			// 
			txtSoyad.Location = new Point(222, 147);
			txtSoyad.Margin = new Padding(3, 4, 3, 4);
			txtSoyad.Name = "txtSoyad";
			txtSoyad.Size = new Size(156, 27);
			txtSoyad.TabIndex = 4;
			// 
			// label4
			// 
			label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(14, 208);
			label4.Name = "label4";
			label4.Size = new Size(157, 20);
			label4.TabIndex = 7;
			label4.Text = "Telefon Numarası:";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// mskTxtTelNo
			// 
			mskTxtTelNo.Location = new Point(222, 197);
			mskTxtTelNo.Margin = new Padding(3, 4, 3, 4);
			mskTxtTelNo.Mask = "(999) 000-0000";
			mskTxtTelNo.Name = "mskTxtTelNo";
			mskTxtTelNo.Size = new Size(156, 27);
			mskTxtTelNo.TabIndex = 8;
			// 
			// listView1
			// 
			listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
			listView1.FullRowSelect = true;
			listView1.GridLines = true;
			listView1.Location = new Point(417, 16);
			listView1.Margin = new Padding(3, 4, 3, 4);
			listView1.Name = "listView1";
			listView1.Size = new Size(483, 567);
			listView1.TabIndex = 9;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.Details;
			listView1.DoubleClick += listView1_DoubleClick;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Kişi ID";
			columnHeader1.Width = 80;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Ad";
			columnHeader2.Width = 80;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Soyad";
			columnHeader3.Width = 80;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Telefon Numarası";
			columnHeader4.Width = 120;
			// 
			// btnEkle
			// 
			btnEkle.BackColor = SystemColors.GrayText;
			btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnEkle.Location = new Point(14, 293);
			btnEkle.Margin = new Padding(3, 4, 3, 4);
			btnEkle.Name = "btnEkle";
			btnEkle.Size = new Size(101, 31);
			btnEkle.TabIndex = 10;
			btnEkle.Text = "EKLE";
			btnEkle.UseVisualStyleBackColor = false;
			btnEkle.Click += btnEkle_Click;
			// 
			// btnGuncelle
			// 
			btnGuncelle.BackColor = SystemColors.GrayText;
			btnGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnGuncelle.Location = new Point(152, 293);
			btnGuncelle.Margin = new Padding(3, 4, 3, 4);
			btnGuncelle.Name = "btnGuncelle";
			btnGuncelle.Size = new Size(109, 31);
			btnGuncelle.TabIndex = 11;
			btnGuncelle.Text = "GÜNCELLE";
			btnGuncelle.UseVisualStyleBackColor = false;
			btnGuncelle.Click += btnGuncelle_Click;
			// 
			// btnSil
			// 
			btnSil.BackColor = SystemColors.GrayText;
			btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnSil.Location = new Point(301, 293);
			btnSil.Margin = new Padding(3, 4, 3, 4);
			btnSil.Name = "btnSil";
			btnSil.Size = new Size(110, 31);
			btnSil.TabIndex = 12;
			btnSil.Text = "SİL";
			btnSil.UseVisualStyleBackColor = false;
			btnSil.Click += btnSil_Click;
			// 
			// btnListele
			// 
			btnListele.BackColor = SystemColors.GrayText;
			btnListele.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnListele.Location = new Point(70, 389);
			btnListele.Margin = new Padding(3, 4, 3, 4);
			btnListele.Name = "btnListele";
			btnListele.Size = new Size(101, 31);
			btnListele.TabIndex = 13;
			btnListele.Text = "LİSTELE";
			btnListele.UseVisualStyleBackColor = false;
			btnListele.Click += btnListele_Click;
			// 
			// btnAra
			// 
			btnAra.BackColor = SystemColors.GrayText;
			btnAra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnAra.Location = new Point(237, 389);
			btnAra.Margin = new Padding(3, 4, 3, 4);
			btnAra.Name = "btnAra";
			btnAra.Size = new Size(105, 31);
			btnAra.TabIndex = 14;
			btnAra.Text = "KİŞİ ARA";
			btnAra.UseVisualStyleBackColor = false;
			btnAra.Click += btnAra_Click;
			// 
			// btnEkranTemize
			// 
			btnEkranTemize.BackColor = SystemColors.GradientActiveCaption;
			btnEkranTemize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnEkranTemize.Location = new Point(14, 553);
			btnEkranTemize.Margin = new Padding(3, 4, 3, 4);
			btnEkranTemize.Name = "btnEkranTemize";
			btnEkranTemize.Size = new Size(157, 44);
			btnEkranTemize.TabIndex = 15;
			btnEkranTemize.Text = "Ekranı Temizle";
			btnEkranTemize.UseVisualStyleBackColor = false;
			btnEkranTemize.Click += btnEkranTemize_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.MintCream;
			ClientSize = new Size(914, 600);
			Controls.Add(btnEkranTemize);
			Controls.Add(btnAra);
			Controls.Add(btnListele);
			Controls.Add(btnSil);
			Controls.Add(btnGuncelle);
			Controls.Add(btnEkle);
			Controls.Add(listView1);
			Controls.Add(mskTxtTelNo);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(txtSoyad);
			Controls.Add(label2);
			Controls.Add(txtAd);
			Controls.Add(label1);
			Controls.Add(txtKisiID);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(3, 4, 3, 4);
			Name = "Form1";
			Text = "Kişi Rehberi";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtKisiID;
		private Label label1;
		private Label label2;
		private TextBox txtAd;
		private Label label3;
		private TextBox txtSoyad;
		private Label label4;
		private MaskedTextBox mskTxtTelNo;
		private ListView listView1;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private Button btnEkle;
		private Button btnGuncelle;
		private Button btnSil;
		private Button btnListele;
		private Button btnAra;
		private Button btnEkranTemize;
	}
}