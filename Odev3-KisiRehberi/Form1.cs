using Odev3_KisiRehberi.Model;
using static System.Net.Mime.MediaTypeNames;

namespace Odev3_KisiRehberi
{
	public partial class Form1 : Form
	{
		KisiRehberiDBContext rh;
		public Form1()
		{
			InitializeComponent();
			rh = new KisiRehberiDBContext();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			txtKisiID.Enabled = false;

			var rehberList = rh.Contacts.ToList();
			foreach (var kisi in rehberList)
			{
				ListViewItem lvi = ListViewEkle(kisi);
				listView1.Items.Add(lvi);

			}
		}
		private void btnEkle_Click(object sender, EventArgs e)
		{
			Contact kisi = new Contact();
			kisi = KisiEkle(kisi);

			ListViewItem listView = new ListViewItem();
			listView = ListViewEkle(kisi);

			listView1.Items.Add(listView);

			string ad = txtAd.Text.Trim(), soyad = txtSoyad.Text.Trim(), telNo = mskTxtTelNo.Text.Trim();

			try
			{
				if (!string.IsNullOrWhiteSpace(ad) && !string.IsNullOrWhiteSpace(soyad) && !string.IsNullOrWhiteSpace(telNo))
				{
					Contact kisiEkle = new Contact()
					{

						FirstName = ad,
						LastName = soyad,
						PhoneNumber = telNo
					};
					rh.Contacts.Add(kisiEkle);
					rh.SaveChanges();
				}
				else
					MessageBox.Show("Ad,Soyad ve Telefon Numarasý boþ geçilemez");
			}
			catch (Exception)
			{

				MessageBox.Show("Kayýt Baþarýsýz");
			}
			Temizle(this.Controls);

		}
		private Contact KisiEkle(Contact kisi)
		{
			kisi.FirstName = txtAd.Text.Trim();
			kisi.LastName = txtSoyad.Text.Trim();
			kisi.PhoneNumber = mskTxtTelNo.Text.Trim();

			return kisi;
		}
		private ListViewItem ListViewEkle(Contact kisi)
		{
			ListViewItem str = new ListViewItem();


			str.SubItems.Add(kisi.FirstName);
			str.SubItems.Add(kisi.LastName);
			str.SubItems.Add(kisi.PhoneNumber);
			//str.SubItems.Add(kisi.Id.ToString());
			str.Tag = kisi;

			return str;
		}
		/// <summary>
		/// Method gives Form Control Clean Process.
		/// </summary>
		/// <param name="controls"></param>
		private void Temizle(Control.ControlCollection controls)
		{
			foreach (Control item in controls)
			{
				if (item is TextBox)
					((TextBox)item).Clear();

				else if (item is MaskedTextBox)
					((MaskedTextBox)(item)).Clear();


			}
		}
		Contact Contact;
		int secilenSatir;
		private void listView1_DoubleClick(object sender, EventArgs e)
		{
			secilenSatir = listView1.SelectedItems[0].Index;
			Contact = (Contact)listView1.SelectedItems[0].Tag;
			int id = Contact.Id;
			string idContact = Convert.ToString(id);
			txtKisiID.Text = idContact;
			txtAd.Text = Contact.FirstName;
			txtSoyad.Text = Contact.LastName;

			mskTxtTelNo.Text = Contact.PhoneNumber;

		}

		private void btnEkranTemize_Click(object sender, EventArgs e)
		{
			Temizle(this.Controls);
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			Contact = KisiEkle(Contact);
			listView1.Items.RemoveAt(secilenSatir);
			listView1.Items.Insert(secilenSatir, ListViewEkle(Contact));
			Temizle(this.Controls);
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				int secilenSatir = listView1.SelectedItems[0].Index;
				Contact silinecekKisi = (Contact)listView1.SelectedItems[0].Tag;
				int id = silinecekKisi.Id;

				var result = rh.Contacts.FirstOrDefault(c => c.Id == id);
				if (result != null)
				{
					rh.Contacts.Remove(result);
					rh.SaveChanges();
					listView1.Items.RemoveAt(secilenSatir);
					Temizle(this.Controls);
					System.GC.Collect();
					System.GC.WaitForPendingFinalizers();
				}
			}
			else
			{
				MessageBox.Show("Listeden seçim yapmalýsýnýz");
			}
		}



		private void btnAra_Click(object sender, EventArgs e)
		{
			string ad = txtAd.Text.Trim();
			string soyad = txtSoyad.Text.Trim();

			if (!string.IsNullOrWhiteSpace(ad))
			{
				var arananKisiler = rh.Contacts.Where(c => c.FirstName == ad).ToList();


				listView1.Items.Clear();

				foreach (var kisi in arananKisiler)
				{
					ListViewItem lvi = ListViewEkle(kisi);
					listView1.Items.Add(lvi);
				}
				Temizle(this.Controls);
			}
			else
			{
				MessageBox.Show("Ad boþ geçilemez");
			}
		}
		private void btnListele_Click(object sender, EventArgs e)
		{

			listView1.Items.Clear();

			var rehberList = rh.Contacts.ToList();
			foreach (var kisi in rehberList)
			{
				ListViewItem lvi = ListViewEkle(kisi);
				listView1.Items.Add(lvi);
			}
			Temizle(this.Controls);
		}
	}

}