using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_1214085
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTampilkan_Click(object sender, EventArgs e)
        {
            string kelas = "";
            string jadwal = "";

            if (cbBiola.Checked)
            {
                kelas = kelas + "Biola, ";
            }
            if (cbGitar.Checked)
            {
                kelas = kelas + "Gitar, ";
            }
            if (cbSaxophone.Checked)
            {
                kelas = kelas + "Saxophone, ";
            }
            if (cbKonduktor.Checked)
            {
                kelas = kelas + "Konduktor, ";
            }
            if (cbPiano.Checked)
            {
                kelas = kelas + "Piano, ";
            }
            if (cbDrum.Checked)
            {
                kelas = kelas + "Drum, ";
            }
            if (cbVokal.Checked)
            {
                kelas = kelas + "Vokal, ";
            }
            if (cbKomposer.Checked)
            {
                kelas = kelas + "Komposer, ";
            }

            var again = true;

            if (rbSeninRabu.Checked)
            {
                jadwal = "Senin & Rabu, 14.00 - 16.00";
            }
            else if (rbSelasaKamis.Checked)
            {
                jadwal = "Senin & Kamis, 14.00 - 16.00";
            }
            else if (rbSabtuMinggu.Checked)
            {
                jadwal = "Sabtu & Minggu, 09.00 - 11.00";
            }
            else if (rbMinggu.Checked)
            {
                jadwal = "Minggu, 13.00 - 17.00";
            }
            else
            {
                again = false;
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            while (again)
            {
                if (cbBiola.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nJenis Kelamin : " + cmbJenisKelamin.Text +
                    "\nTanggal Lahir : " + dtpTanggalLahir.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (cbGitar.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nJenis Kelamin : " + cmbJenisKelamin.Text +
                    "\nTanggal Lahir : " + dtpTanggalLahir.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (cbSaxophone.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nJenis Kelamin : " + cmbJenisKelamin.Text +
                    "\nTanggal Lahir : " + dtpTanggalLahir.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (cbKonduktor.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nJenis Kelamin : " + cmbJenisKelamin.Text +
                    "\nTanggal Lahir : " + dtpTanggalLahir.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (cbPiano.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nJenis Kelamin : " + cmbJenisKelamin.Text +
                    "\nTanggal Lahir : " + dtpTanggalLahir.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (cbDrum.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nJenis Kelamin : " + cmbJenisKelamin.Text +
                    "\nTanggal Lahir : " + dtpTanggalLahir.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (cbVokal.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nJenis Kelamin : " + cmbJenisKelamin.Text +
                    "\nTanggal Lahir : " + dtpTanggalLahir.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (cbKomposer.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nJenis Kelamin : " + cmbJenisKelamin.Text +
                    "\nTanggal Lahir : " + dtpTanggalLahir.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else
                {
                    MessageBox.Show("Harus memilih salah satu dari pilihan kelas", "Warning!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    again = false;
                }
            }

        }

        private void buttonSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbPilihanJadwal_CursorChanged_1(object sender, EventArgs e)
        {

        }

        private void tbNama_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void rbSeninRabu_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbJenisKelamin_Click(object sender, EventArgs e)
        {

        }

        private void dtpTanggalLahir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbBiola_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbGitar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbPilihanKelas_Enter(object sender, EventArgs e)
        {

        }

        private void gbPilihanJadwal_Enter(object sender, EventArgs e)
        {

        }
    }
}

