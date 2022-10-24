namespace P5_4_1214085
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelJudul = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelJenisKelamin = new System.Windows.Forms.Label();
            this.labelTanggalLahir = new System.Windows.Forms.Label();
            this.gbPilihanKelas = new System.Windows.Forms.GroupBox();
            this.cbKomposer = new System.Windows.Forms.CheckBox();
            this.cbVokal = new System.Windows.Forms.CheckBox();
            this.cbDrum = new System.Windows.Forms.CheckBox();
            this.cbPiano = new System.Windows.Forms.CheckBox();
            this.cbKonduktor = new System.Windows.Forms.CheckBox();
            this.cbSaxophone = new System.Windows.Forms.CheckBox();
            this.cbGitar = new System.Windows.Forms.CheckBox();
            this.cbBiola = new System.Windows.Forms.CheckBox();
            this.gbPilihanJadwal = new System.Windows.Forms.GroupBox();
            this.rbMinggu = new System.Windows.Forms.RadioButton();
            this.rbSabtuMinggu = new System.Windows.Forms.RadioButton();
            this.rbSelasaKamis = new System.Windows.Forms.RadioButton();
            this.rbSeninRabu = new System.Windows.Forms.RadioButton();
            this.buttonTampilkan = new System.Windows.Forms.Button();
            this.buttonSelesai = new System.Windows.Forms.Button();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.cmbJenisKelamin = new System.Windows.Forms.ComboBox();
            this.gbPilihanKelas.SuspendLayout();
            this.gbPilihanJadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(262, 28);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(271, 37);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "Form Pendaftaran";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(360, 95);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(300, 26);
            this.tbNama.TabIndex = 1;
            this.tbNama.TextChanged += new System.EventHandler(this.tbNama_TextChanged_1);
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(156, 101);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(51, 20);
            this.labelNama.TabIndex = 4;
            this.labelNama.Text = "Nama";
            // 
            // labelJenisKelamin
            // 
            this.labelJenisKelamin.AutoSize = true;
            this.labelJenisKelamin.Location = new System.Drawing.Point(156, 148);
            this.labelJenisKelamin.Name = "labelJenisKelamin";
            this.labelJenisKelamin.Size = new System.Drawing.Size(106, 20);
            this.labelJenisKelamin.TabIndex = 5;
            this.labelJenisKelamin.Text = "Jenis Kelamin";
            // 
            // labelTanggalLahir
            // 
            this.labelTanggalLahir.AutoSize = true;
            this.labelTanggalLahir.Location = new System.Drawing.Point(156, 199);
            this.labelTanggalLahir.Name = "labelTanggalLahir";
            this.labelTanggalLahir.Size = new System.Drawing.Size(105, 20);
            this.labelTanggalLahir.TabIndex = 6;
            this.labelTanggalLahir.Text = "Tanggal Lahir";
            // 
            // gbPilihanKelas
            // 
            this.gbPilihanKelas.Controls.Add(this.cbKomposer);
            this.gbPilihanKelas.Controls.Add(this.cbVokal);
            this.gbPilihanKelas.Controls.Add(this.cbDrum);
            this.gbPilihanKelas.Controls.Add(this.cbPiano);
            this.gbPilihanKelas.Controls.Add(this.cbKonduktor);
            this.gbPilihanKelas.Controls.Add(this.cbSaxophone);
            this.gbPilihanKelas.Controls.Add(this.cbGitar);
            this.gbPilihanKelas.Controls.Add(this.cbBiola);
            this.gbPilihanKelas.Location = new System.Drawing.Point(50, 309);
            this.gbPilihanKelas.Name = "gbPilihanKelas";
            this.gbPilihanKelas.Size = new System.Drawing.Size(310, 202);
            this.gbPilihanKelas.TabIndex = 7;
            this.gbPilihanKelas.TabStop = false;
            this.gbPilihanKelas.Text = "Pilihan Kelas";
            this.gbPilihanKelas.Enter += new System.EventHandler(this.gbPilihanKelas_Enter);
            // 
            // cbKomposer
            // 
            this.cbKomposer.AutoSize = true;
            this.cbKomposer.Location = new System.Drawing.Point(160, 162);
            this.cbKomposer.Name = "cbKomposer";
            this.cbKomposer.Size = new System.Drawing.Size(107, 24);
            this.cbKomposer.TabIndex = 6;
            this.cbKomposer.Text = "Komposer";
            this.cbKomposer.UseVisualStyleBackColor = true;
            // 
            // cbVokal
            // 
            this.cbVokal.AutoSize = true;
            this.cbVokal.Location = new System.Drawing.Point(160, 120);
            this.cbVokal.Name = "cbVokal";
            this.cbVokal.Size = new System.Drawing.Size(75, 24);
            this.cbVokal.TabIndex = 5;
            this.cbVokal.Text = "Vokal";
            this.cbVokal.UseVisualStyleBackColor = true;
            // 
            // cbDrum
            // 
            this.cbDrum.AutoSize = true;
            this.cbDrum.Location = new System.Drawing.Point(160, 81);
            this.cbDrum.Name = "cbDrum";
            this.cbDrum.Size = new System.Drawing.Size(74, 24);
            this.cbDrum.TabIndex = 4;
            this.cbDrum.Text = "Drum";
            this.cbDrum.UseVisualStyleBackColor = true;
            // 
            // cbPiano
            // 
            this.cbPiano.AutoSize = true;
            this.cbPiano.Location = new System.Drawing.Point(160, 40);
            this.cbPiano.Name = "cbPiano";
            this.cbPiano.Size = new System.Drawing.Size(75, 24);
            this.cbPiano.TabIndex = 1;
            this.cbPiano.Text = "Piano";
            this.cbPiano.UseVisualStyleBackColor = true;
            // 
            // cbKonduktor
            // 
            this.cbKonduktor.AutoSize = true;
            this.cbKonduktor.Location = new System.Drawing.Point(19, 162);
            this.cbKonduktor.Name = "cbKonduktor";
            this.cbKonduktor.Size = new System.Drawing.Size(108, 24);
            this.cbKonduktor.TabIndex = 3;
            this.cbKonduktor.Text = "Konduktor";
            this.cbKonduktor.UseVisualStyleBackColor = true;
            // 
            // cbSaxophone
            // 
            this.cbSaxophone.AutoSize = true;
            this.cbSaxophone.Location = new System.Drawing.Point(19, 120);
            this.cbSaxophone.Name = "cbSaxophone";
            this.cbSaxophone.Size = new System.Drawing.Size(116, 24);
            this.cbSaxophone.TabIndex = 2;
            this.cbSaxophone.Text = "Saxophone";
            this.cbSaxophone.UseVisualStyleBackColor = true;
            // 
            // cbGitar
            // 
            this.cbGitar.AutoSize = true;
            this.cbGitar.Location = new System.Drawing.Point(19, 81);
            this.cbGitar.Name = "cbGitar";
            this.cbGitar.Size = new System.Drawing.Size(70, 24);
            this.cbGitar.TabIndex = 1;
            this.cbGitar.Text = "Gitar";
            this.cbGitar.UseVisualStyleBackColor = true;
            this.cbGitar.CheckedChanged += new System.EventHandler(this.cbGitar_CheckedChanged);
            // 
            // cbBiola
            // 
            this.cbBiola.AutoSize = true;
            this.cbBiola.Location = new System.Drawing.Point(19, 40);
            this.cbBiola.Name = "cbBiola";
            this.cbBiola.Size = new System.Drawing.Size(70, 24);
            this.cbBiola.TabIndex = 0;
            this.cbBiola.Text = "Biola";
            this.cbBiola.UseVisualStyleBackColor = true;
            this.cbBiola.CheckedChanged += new System.EventHandler(this.cbBiola_CheckedChanged);
            // 
            // gbPilihanJadwal
            // 
            this.gbPilihanJadwal.Controls.Add(this.rbMinggu);
            this.gbPilihanJadwal.Controls.Add(this.rbSabtuMinggu);
            this.gbPilihanJadwal.Controls.Add(this.rbSelasaKamis);
            this.gbPilihanJadwal.Controls.Add(this.rbSeninRabu);
            this.gbPilihanJadwal.Location = new System.Drawing.Point(460, 309);
            this.gbPilihanJadwal.Name = "gbPilihanJadwal";
            this.gbPilihanJadwal.Size = new System.Drawing.Size(289, 202);
            this.gbPilihanJadwal.TabIndex = 8;
            this.gbPilihanJadwal.TabStop = false;
            this.gbPilihanJadwal.Text = "Pilihan Jadwal";
            this.gbPilihanJadwal.CursorChanged += new System.EventHandler(this.gbPilihanJadwal_CursorChanged_1);
            this.gbPilihanJadwal.Enter += new System.EventHandler(this.gbPilihanJadwal_Enter);
            // 
            // rbMinggu
            // 
            this.rbMinggu.AutoSize = true;
            this.rbMinggu.Location = new System.Drawing.Point(33, 162);
            this.rbMinggu.Name = "rbMinggu";
            this.rbMinggu.Size = new System.Drawing.Size(187, 24);
            this.rbMinggu.TabIndex = 3;
            this.rbMinggu.TabStop = true;
            this.rbMinggu.Text = "Minggu, 13.00 - 17.00";
            this.rbMinggu.UseVisualStyleBackColor = true;
            // 
            // rbSabtuMinggu
            // 
            this.rbSabtuMinggu.AutoSize = true;
            this.rbSabtuMinggu.Location = new System.Drawing.Point(33, 120);
            this.rbSabtuMinggu.Name = "rbSabtuMinggu";
            this.rbSabtuMinggu.Size = new System.Drawing.Size(249, 24);
            this.rbSabtuMinggu.TabIndex = 2;
            this.rbSabtuMinggu.TabStop = true;
            this.rbSabtuMinggu.Text = "Sabtu && Minggu, 09.00 - 11.00";
            this.rbSabtuMinggu.UseVisualStyleBackColor = true;
            // 
            // rbSelasaKamis
            // 
            this.rbSelasaKamis.AutoSize = true;
            this.rbSelasaKamis.Location = new System.Drawing.Point(33, 81);
            this.rbSelasaKamis.Name = "rbSelasaKamis";
            this.rbSelasaKamis.Size = new System.Drawing.Size(246, 24);
            this.rbSelasaKamis.TabIndex = 1;
            this.rbSelasaKamis.TabStop = true;
            this.rbSelasaKamis.Text = "Selasa && Kamis, 14.00 - 16.00";
            this.rbSelasaKamis.UseVisualStyleBackColor = true;
            // 
            // rbSeninRabu
            // 
            this.rbSeninRabu.AutoSize = true;
            this.rbSeninRabu.Location = new System.Drawing.Point(33, 39);
            this.rbSeninRabu.Name = "rbSeninRabu";
            this.rbSeninRabu.Size = new System.Drawing.Size(234, 24);
            this.rbSeninRabu.TabIndex = 0;
            this.rbSeninRabu.TabStop = true;
            this.rbSeninRabu.Text = "Senin && Rabu, 14.00 - 16.00";
            this.rbSeninRabu.UseVisualStyleBackColor = true;
            this.rbSeninRabu.CheckedChanged += new System.EventHandler(this.rbSeninRabu_CheckedChanged_1);
            // 
            // buttonTampilkan
            // 
            this.buttonTampilkan.AutoSize = true;
            this.buttonTampilkan.Location = new System.Drawing.Point(269, 556);
            this.buttonTampilkan.Name = "buttonTampilkan";
            this.buttonTampilkan.Size = new System.Drawing.Size(91, 30);
            this.buttonTampilkan.TabIndex = 9;
            this.buttonTampilkan.Text = "Tampilkan";
            this.buttonTampilkan.UseVisualStyleBackColor = true;
            this.buttonTampilkan.Click += new System.EventHandler(this.buttonTampilkan_Click);
            // 
            // buttonSelesai
            // 
            this.buttonSelesai.Location = new System.Drawing.Point(460, 556);
            this.buttonSelesai.Name = "buttonSelesai";
            this.buttonSelesai.Size = new System.Drawing.Size(91, 30);
            this.buttonSelesai.TabIndex = 10;
            this.buttonSelesai.Text = "Selesai";
            this.buttonSelesai.UseVisualStyleBackColor = true;
            this.buttonSelesai.Click += new System.EventHandler(this.buttonSelesai_Click);
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.Location = new System.Drawing.Point(360, 199);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(300, 26);
            this.dtpTanggalLahir.TabIndex = 11;
            this.dtpTanggalLahir.ValueChanged += new System.EventHandler(this.dtpTanggalLahir_ValueChanged);
            // 
            // cmbJenisKelamin
            // 
            this.cmbJenisKelamin.FormattingEnabled = true;
            this.cmbJenisKelamin.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.cmbJenisKelamin.Location = new System.Drawing.Point(360, 148);
            this.cmbJenisKelamin.Name = "cmbJenisKelamin";
            this.cmbJenisKelamin.Size = new System.Drawing.Size(300, 28);
            this.cmbJenisKelamin.TabIndex = 12;
            this.cmbJenisKelamin.Text = "--- Pilih Jenis Kelamin ---";
            this.cmbJenisKelamin.Click += new System.EventHandler(this.cmbJenisKelamin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.cmbJenisKelamin);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.buttonSelesai);
            this.Controls.Add(this.buttonTampilkan);
            this.Controls.Add(this.gbPilihanJadwal);
            this.Controls.Add(this.gbPilihanKelas);
            this.Controls.Add(this.labelTanggalLahir);
            this.Controls.Add(this.labelJenisKelamin);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.labelJudul);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ASTRA MUSIC SCHOOL";
            this.gbPilihanKelas.ResumeLayout(false);
            this.gbPilihanKelas.PerformLayout();
            this.gbPilihanJadwal.ResumeLayout(false);
            this.gbPilihanJadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelJenisKelamin;
        private System.Windows.Forms.Label labelTanggalLahir;
        private System.Windows.Forms.GroupBox gbPilihanKelas;
        private System.Windows.Forms.CheckBox cbKomposer;
        private System.Windows.Forms.CheckBox cbVokal;
        private System.Windows.Forms.CheckBox cbDrum;
        private System.Windows.Forms.CheckBox cbPiano;
        private System.Windows.Forms.CheckBox cbKonduktor;
        private System.Windows.Forms.CheckBox cbSaxophone;
        private System.Windows.Forms.CheckBox cbGitar;
        private System.Windows.Forms.CheckBox cbBiola;
        private System.Windows.Forms.GroupBox gbPilihanJadwal;
        private System.Windows.Forms.RadioButton rbMinggu;
        private System.Windows.Forms.RadioButton rbSabtuMinggu;
        private System.Windows.Forms.RadioButton rbSelasaKamis;
        private System.Windows.Forms.RadioButton rbSeninRabu;
        private System.Windows.Forms.Button buttonTampilkan;
        private System.Windows.Forms.Button buttonSelesai;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.ComboBox cmbJenisKelamin;
    }
}

