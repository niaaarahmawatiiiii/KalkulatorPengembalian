using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace PraktekDesktop
{
    public partial class KalkulatorPengembalian : Form
    {
        // Menyimpan TextBox yang sedang dipilih.
        private TextBox inputAktif;

        // [TAMBAHAN] Daftar pecahan rupiah yang berlaku (besar ke kecil).
        private static readonly long[] DaftarPecahan =
        {
            100000, 50000, 20000, 10000, 5000, 2000,
            1000, 500, 200, 100, 50
        };

        // Konstruktor Form.
        public KalkulatorPengembalian()
        {
            InitializeComponent();

            // Menentukan input awal ke Total Belanja.
            inputAktif = textBox1;

            // TextBox hanya dapat diisi melalui tombol angka.
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;

            // Mengatur warna TextBox hasil kembalian.
            textBox3.BackColor = Color.Honeydew;

            // Mengatur informasi transaksi awal.
            ResetInformasi();

            // [TAMBAHAN] Lebar kolom tabel otomatis, ikut berubah jika tabel diubah ukurannya.
            AturLebarKolom();
            lvRincian.Resize += (s, e) => AturLebarKolom();
        }

        // Mengubah angka menjadi format Rupiah.
        private string FormatRupiah(long angka)
        {
            return "Rp " + angka.ToString(
                "N0",
                CultureInfo.GetCultureInfo("id-ID")
            );
        }

        // Mengembalikan informasi transaksi ke kondisi awal.
        private void ResetInformasi()
        {
            lblStatusHasil.Text = "Belum Ada Transaksi";
            lblTotalHasil.Text = "Rp0";
            lblDibayarHasil.Text = "Rp0";
            lblKembalianHasil.Text = "Rp0";

            // Warna status awal.
            lblStatusHasil.ForeColor = Color.Gray;

            // [TAMBAHAN] Kosongkan tabel rincian pecahan dan label total.
            lvRincian.Items.Clear();
            lblTotalLembar.Text = "";
        }

        // Memasukkan angka ke TextBox yang sedang dipilih.
        private void TambahAngka(string angka)
        {
            if (inputAktif == null)
                return;

            inputAktif.Text += angka;

            // Menghapus hasil dan informasi sebelumnya.
            textBox3.Clear();
            ResetInformasi();
        }

        // Tombol angka 1.
        private void button1_Click(object sender, EventArgs e)
        {
            TambahAngka("1");
        }

        // Tombol angka 2.
        private void button2_Click(object sender, EventArgs e)
        {
            TambahAngka("2");
        }

        // Tombol angka 3.
        private void button3_Click(object sender, EventArgs e)
        {
            TambahAngka("3");
        }

        // Tombol angka 4.
        private void button4_Click(object sender, EventArgs e)
        {
            TambahAngka("4");
        }

        // Tombol angka 5.
        private void button5_Click(object sender, EventArgs e)
        {
            TambahAngka("5");
        }

        // Tombol angka 6.
        private void button6_Click(object sender, EventArgs e)
        {
            TambahAngka("6");
        }

        // Tombol angka 7.
        private void button7_Click(object sender, EventArgs e)
        {
            TambahAngka("7");
        }

        // Tombol angka 8.
        private void button8_Click(object sender, EventArgs e)
        {
            TambahAngka("8");
        }

        // Tombol angka 9.
        private void button9_Click(object sender, EventArgs e)
        {
            TambahAngka("9");
        }

        // Tombol 00.
        private void button10_Click(object sender, EventArgs e)
        {
            TambahAngka("00");
        }

        // Tombol angka 0.
        private void button11_Click(object sender, EventArgs e)
        {
            TambahAngka("0");
        }

        // Tombol 000.
        private void button12_Click(object sender, EventArgs e)
        {
            TambahAngka("000");
        }

        // Tombol C untuk menghapus seluruh input aktif.
        private void button13_Click_1(object sender, EventArgs e)
        {
            if (inputAktif != null)
            {
                inputAktif.Clear();
            }

            textBox3.Clear();
            ResetInformasi();
        }

        // Tombol X untuk menghapus satu angka terakhir.
        private void button14_Click_1(object sender, EventArgs e)
        {
            if (inputAktif != null &&
                inputAktif.Text.Length > 0)
            {
                inputAktif.Text = inputAktif.Text.Substring(
                    0, inputAktif.Text.Length - 1
                );
            }

            textBox3.Clear();
            ResetInformasi();
        }

        // Tombol Belanja untuk memilih Total Belanja.
        private void button15_Click(object sender, EventArgs e)
        {
            inputAktif = textBox1;
            textBox3.Clear();
            ResetInformasi();
        }

        // Tombol Bayar untuk memilih Uang Dibayarkan.
        private void button16_Click(object sender, EventArgs e)
        {
            inputAktif = textBox2;
            textBox3.Clear();
            ResetInformasi();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            HitungKembalian();
        }

        // Fungsi utama menghitung uang kembalian.
        private void HitungKembalian()
        {
            long totalBelanja;
            long uangDibayar;

            // Memeriksa input Total Belanja.
            if (!long.TryParse(textBox1.Text, out totalBelanja)
                || totalBelanja <= 0)
            {
                MessageBox.Show(
                    "Masukkan total belanja yang benar!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Memeriksa input Uang Dibayarkan.
            if (!long.TryParse(textBox2.Text, out uangDibayar)
                || uangDibayar <= 0)
            {
                MessageBox.Show(
                    "Masukkan uang yang dibayarkan dengan benar!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Menghitung selisih pembayaran.
            long kembalian = uangDibayar - totalBelanja;

            // Memperbarui informasi total transaksi.
            lblTotalHasil.Text = FormatRupiah(totalBelanja);
            lblDibayarHasil.Text = FormatRupiah(uangDibayar);

            // Jika uang pembayaran kurang.
            if (kembalian < 0)
            {
                long kekurangan = Math.Abs(kembalian);

                // Menampilkan hasil kekurangan.
                textBox3.Text = "Kurang " + FormatRupiah(kekurangan);

                // Memperbarui informasi transaksi.
                lblStatusHasil.Text = "Pembayaran Kurang";
                lblKembalianHasil.Text =
                    "Kurang " + FormatRupiah(kekurangan);

                // Mengubah warna status menjadi merah.
                lblStatusHasil.ForeColor = Color.Red;

                MessageBox.Show(
                    "Uang pembayaran belum mencukupi!\n\n" +
                    "Kekurangan: " + FormatRupiah(kekurangan),
                    "Pembayaran Kurang",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                // Menampilkan hasil uang kembalian.
                textBox3.Text = FormatRupiah(kembalian);

                // Memperbarui informasi transaksi.
                lblStatusHasil.Text = "Lunas";
                lblKembalianHasil.Text = FormatRupiah(kembalian);

                // Mengubah warna status menjadi hijau.
                lblStatusHasil.ForeColor = Color.Green;

                // [TAMBAHAN] Tampilkan rincian lembar/keping di tabel.
                TampilkanRincian(kembalian);

                MessageBox.Show(
                    "Pembayaran Berhasil!\n\n" +
                    "Total Belanja: " +
                    FormatRupiah(totalBelanja) +
                    "\nUang Dibayar: " +
                    FormatRupiah(uangDibayar) +
                    "\nUang Kembalian: " +
                    FormatRupiah(kembalian),
                    "Hasil Perhitungan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        // [TAMBAHAN] Menghitung dan menampilkan jumlah lembar/keping tiap pecahan.
        private void TampilkanRincian(long kembalian)
        {
            lvRincian.Items.Clear();
            lblTotalLembar.Text = "";

            if (kembalian == 0)
            {
                lblTotalLembar.Text = "Uang pas, tidak ada kembalian.";
                return;
            }

            // Jika ListView punya kolom kosong di urutan 0 (4 kolom),
            // teks dimulai dari kolom 1. Jika hanya 3 kolom, mulai dari kolom 0.
            bool adaKolomKosong = lvRincian.Columns.Count >= 4;

            long sisa = kembalian;
            long totalLembar = 0;

            foreach (long pecahan in DaftarPecahan)
            {
                long jumlah = sisa / pecahan;
                if (jumlah == 0)
                    continue;

                string satuan = pecahan >= 1000 ? "lembar" : "keping";

                ListViewItem item;
                if (adaKolomKosong)
                {
                    item = new ListViewItem("");
                    item.SubItems.Add(FormatRupiah(pecahan));
                }
                else
                {
                    item = new ListViewItem(FormatRupiah(pecahan));
                }

                item.SubItems.Add(jumlah + " " + satuan);
                item.SubItems.Add(FormatRupiah(jumlah * pecahan));
                lvRincian.Items.Add(item);

                totalLembar += jumlah;
                sisa -= jumlah * pecahan;
            }

            lblTotalLembar.Text = "Total: " + totalLembar + " lembar/keping";

            // Sesuaikan lebar kolom setelah tabel terisi.
            AturLebarKolom();

            // Sisa di bawah pecahan terkecil (Rp50) tidak bisa dikembalikan.
            if (sisa > 0)
            {
                lblTotalLembar.Text += "\nSisa " + FormatRupiah(sisa) +
                                       " (tidak ada pecahan)";
            }
        }

        // [TAMBAHAN] Membagi lebar tabel sama rata ke semua kolom yang terlihat.
        private void AturLebarKolom()
        {
            bool adaKolomKosong = lvRincian.Columns.Count >= 4;
            int awal = adaKolomKosong ? 1 : 0;
            int jumlahKolom = lvRincian.Columns.Count - awal;

            if (jumlahKolom <= 0)
                return;

            // Kolom kosong di urutan 0 tetap tersembunyi.
            if (adaKolomKosong)
                lvRincian.Columns[0].Width = 0;

            // Sisakan ruang untuk scrollbar supaya tidak muncul scroll mendatar.
            int lebarTersedia = lvRincian.ClientSize.Width
                                - SystemInformation.VerticalScrollBarWidth;
            int lebar = lebarTersedia / jumlahKolom;

            for (int i = awal; i < lvRincian.Columns.Count; i++)
            {
                lvRincian.Columns[i].Width = lebar;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // Menghapus seluruh input.
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            // Mengembalikan input aktif ke Total Belanja.
            inputAktif = textBox1;

            // Mengembalikan informasi transaksi.
            ResetInformasi();
        }

        // Event Label jika masih terhubung di Design.
        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void KalkulatorPengembalian_Load(object sender, EventArgs e)
        {

        }

        private void lvRincian_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}