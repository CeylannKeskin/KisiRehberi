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
            txtKisiID.Location = new Point(194, 12);
            txtKisiID.Name = "txtKisiID";
            txtKisiID.Size = new Size(137, 23);
            txtKisiID.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 1;
            label1.Text = "Kişi ID:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 3;
            label2.Text = "Ad:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(194, 61);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(137, 23);
            txtAd.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(100, 29);
            label3.TabIndex = 5;
            label3.Text = "Soyad:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(194, 110);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(137, 23);
            txtSoyad.TabIndex = 4;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 156);
            label4.Name = "label4";
            label4.Size = new Size(137, 15);
            label4.TabIndex = 7;
            label4.Text = "Telefon Numarası:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mskTxtTelNo
            // 
            mskTxtTelNo.Location = new Point(194, 148);
            mskTxtTelNo.Mask = "(999) 000-0000";
            mskTxtTelNo.Name = "mskTxtTelNo";
            mskTxtTelNo.Size = new Size(137, 23);
            mskTxtTelNo.TabIndex = 8;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(365, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(423, 426);
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
            btnEkle.Location = new Point(12, 220);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(88, 23);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.GrayText;
            btnGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(133, 220);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(95, 23);
            btnGuncelle.TabIndex = 11;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.GrayText;
            btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(263, 220);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(96, 23);
            btnSil.TabIndex = 12;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnListele
            // 
            btnListele.BackColor = SystemColors.GrayText;
            btnListele.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnListele.Location = new Point(61, 292);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(88, 23);
            btnListele.TabIndex = 13;
            btnListele.Text = "LİSTELE";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // btnAra
            // 
            btnAra.BackColor = SystemColors.GrayText;
            btnAra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAra.Location = new Point(207, 292);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(92, 23);
            btnAra.TabIndex = 14;
            btnAra.Text = "KİŞİ ARA";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // btnEkranTemize
            // 
            btnEkranTemize.BackColor = SystemColors.GradientActiveCaption;
            btnEkranTemize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkranTemize.Location = new Point(12, 415);
            btnEkranTemize.Name = "btnEkranTemize";
            btnEkranTemize.Size = new Size(137, 33);
            btnEkranTemize.TabIndex = 15;
            btnEkranTemize.Text = "Ekranı Temizle";
            btnEkranTemize.UseVisualStyleBackColor = false;
            btnEkranTemize.Click += btnEkranTemize_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(800, 450);
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
            Name = "Form1";
            Text = "Form1";
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