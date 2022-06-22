
namespace LINQ_Project
{
    partial class Siparis_hepsi
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
            this.sayilar_hepsi = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Negatif = new System.Windows.Forms.Button();
            this.Pozitif = new System.Windows.Forms.Button();
            this.cift = new System.Windows.Forms.Button();
            this.Tek = new System.Windows.Forms.Button();
            this.En_buyuk = new System.Windows.Forms.Button();
            this.En_kucuk = new System.Windows.Forms.Button();
            this.eleman_sys = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ekle = new System.Windows.Forms.Button();
            this.alfabetik = new System.Windows.Forms.Button();
            this.Tersten = new System.Windows.Forms.Button();
            this.isimler_Hepsi = new System.Windows.Forms.Button();
            this.elmnsys_isimler = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.harf_iceren = new System.Windows.Forms.Button();
            this.SiparisHepsi = new System.Windows.Forms.Button();
            this.TarihGetir = new System.Windows.Forms.Button();
            this.Top5 = new System.Windows.Forms.Button();
            this.Son5 = new System.Windows.Forms.Button();
            this.Musteriye_göre = new System.Windows.Forms.Button();
            this.Siparis_sayisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sayilar_hepsi
            // 
            this.sayilar_hepsi.Location = new System.Drawing.Point(12, 12);
            this.sayilar_hepsi.Name = "sayilar_hepsi";
            this.sayilar_hepsi.Size = new System.Drawing.Size(95, 54);
            this.sayilar_hepsi.TabIndex = 0;
            this.sayilar_hepsi.Text = "Tüm Sayılar";
            this.sayilar_hepsi.UseVisualStyleBackColor = true;
            this.sayilar_hepsi.Click += new System.EventHandler(this.sayilar_hepsi_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 265);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(285, 164);
            this.listBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(315, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 164);
            this.dataGridView1.TabIndex = 2;
            // 
            // Negatif
            // 
            this.Negatif.Location = new System.Drawing.Point(113, 12);
            this.Negatif.Name = "Negatif";
            this.Negatif.Size = new System.Drawing.Size(95, 54);
            this.Negatif.TabIndex = 3;
            this.Negatif.Text = "Negatif Olanlar";
            this.Negatif.UseVisualStyleBackColor = true;
            this.Negatif.Click += new System.EventHandler(this.Negatif_Click);
            // 
            // Pozitif
            // 
            this.Pozitif.Location = new System.Drawing.Point(214, 12);
            this.Pozitif.Name = "Pozitif";
            this.Pozitif.Size = new System.Drawing.Size(95, 54);
            this.Pozitif.TabIndex = 4;
            this.Pozitif.Text = "Pozitif Olanlar";
            this.Pozitif.UseVisualStyleBackColor = true;
            this.Pozitif.Click += new System.EventHandler(this.Pozitif_Click);
            // 
            // cift
            // 
            this.cift.Location = new System.Drawing.Point(315, 12);
            this.cift.Name = "cift";
            this.cift.Size = new System.Drawing.Size(95, 54);
            this.cift.TabIndex = 5;
            this.cift.Text = "Çift Olanlar";
            this.cift.UseVisualStyleBackColor = true;
            this.cift.Click += new System.EventHandler(this.cift_Click);
            // 
            // Tek
            // 
            this.Tek.Location = new System.Drawing.Point(416, 12);
            this.Tek.Name = "Tek";
            this.Tek.Size = new System.Drawing.Size(95, 54);
            this.Tek.TabIndex = 6;
            this.Tek.Text = "Tek Olanlar";
            this.Tek.UseVisualStyleBackColor = true;
            this.Tek.Click += new System.EventHandler(this.Tek_Click);
            // 
            // En_buyuk
            // 
            this.En_buyuk.Location = new System.Drawing.Point(517, 12);
            this.En_buyuk.Name = "En_buyuk";
            this.En_buyuk.Size = new System.Drawing.Size(95, 54);
            this.En_buyuk.TabIndex = 7;
            this.En_buyuk.Text = "En Büyük Olan";
            this.En_buyuk.UseVisualStyleBackColor = true;
            this.En_buyuk.Click += new System.EventHandler(this.En_buyuk_Click);
            // 
            // En_kucuk
            // 
            this.En_kucuk.Location = new System.Drawing.Point(618, 12);
            this.En_kucuk.Name = "En_kucuk";
            this.En_kucuk.Size = new System.Drawing.Size(95, 54);
            this.En_kucuk.TabIndex = 8;
            this.En_kucuk.Text = "En Küçük Olan";
            this.En_kucuk.UseVisualStyleBackColor = true;
            this.En_kucuk.Click += new System.EventHandler(this.En_kucuk_Click);
            // 
            // eleman_sys
            // 
            this.eleman_sys.Location = new System.Drawing.Point(719, 12);
            this.eleman_sys.Name = "eleman_sys";
            this.eleman_sys.Size = new System.Drawing.Size(95, 54);
            this.eleman_sys.TabIndex = 9;
            this.eleman_sys.Text = "Eleman Sayısı Sayılar";
            this.eleman_sys.UseVisualStyleBackColor = true;
            this.eleman_sys.Click += new System.EventHandler(this.eleman_sys_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(12, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 29);
            this.textBox1.TabIndex = 10;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(113, 205);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(89, 54);
            this.ekle.TabIndex = 11;
            this.ekle.Text = "Sayı Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // alfabetik
            // 
            this.alfabetik.Location = new System.Drawing.Point(113, 72);
            this.alfabetik.Name = "alfabetik";
            this.alfabetik.Size = new System.Drawing.Size(95, 54);
            this.alfabetik.TabIndex = 12;
            this.alfabetik.Text = "Alfabetik";
            this.alfabetik.UseVisualStyleBackColor = true;
            this.alfabetik.Click += new System.EventHandler(this.alfabetik_Click);
            // 
            // Tersten
            // 
            this.Tersten.Location = new System.Drawing.Point(214, 72);
            this.Tersten.Name = "Tersten";
            this.Tersten.Size = new System.Drawing.Size(95, 54);
            this.Tersten.TabIndex = 13;
            this.Tersten.Text = "Tersten Alfabetik";
            this.Tersten.UseVisualStyleBackColor = true;
            this.Tersten.Click += new System.EventHandler(this.Tersten_Click);
            // 
            // isimler_Hepsi
            // 
            this.isimler_Hepsi.Location = new System.Drawing.Point(12, 72);
            this.isimler_Hepsi.Name = "isimler_Hepsi";
            this.isimler_Hepsi.Size = new System.Drawing.Size(95, 54);
            this.isimler_Hepsi.TabIndex = 14;
            this.isimler_Hepsi.Text = "Tüm İsimler";
            this.isimler_Hepsi.UseVisualStyleBackColor = true;
            this.isimler_Hepsi.Click += new System.EventHandler(this.isimler_Hepsi_Click);
            // 
            // elmnsys_isimler
            // 
            this.elmnsys_isimler.Location = new System.Drawing.Point(315, 72);
            this.elmnsys_isimler.Name = "elmnsys_isimler";
            this.elmnsys_isimler.Size = new System.Drawing.Size(95, 54);
            this.elmnsys_isimler.TabIndex = 15;
            this.elmnsys_isimler.Text = "Harf Sayısı";
            this.elmnsys_isimler.UseVisualStyleBackColor = true;
            this.elmnsys_isimler.Click += new System.EventHandler(this.elmnsys_isimler_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 54);
            this.button1.TabIndex = 16;
            this.button1.Text = "İsim Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // harf_iceren
            // 
            this.harf_iceren.Location = new System.Drawing.Point(416, 72);
            this.harf_iceren.Name = "harf_iceren";
            this.harf_iceren.Size = new System.Drawing.Size(95, 54);
            this.harf_iceren.TabIndex = 17;
            this.harf_iceren.Text = "Harf İçeren";
            this.harf_iceren.UseVisualStyleBackColor = true;
            this.harf_iceren.Click += new System.EventHandler(this.harf_iceren_Click);
            // 
            // SiparisHepsi
            // 
            this.SiparisHepsi.Location = new System.Drawing.Point(315, 170);
            this.SiparisHepsi.Name = "SiparisHepsi";
            this.SiparisHepsi.Size = new System.Drawing.Size(95, 89);
            this.SiparisHepsi.TabIndex = 18;
            this.SiparisHepsi.Text = "Tüm Siparişleri Getir";
            this.SiparisHepsi.UseVisualStyleBackColor = true;
            this.SiparisHepsi.Click += new System.EventHandler(this.SiparislerHepsi);
            // 
            // TarihGetir
            // 
            this.TarihGetir.Location = new System.Drawing.Point(416, 170);
            this.TarihGetir.Name = "TarihGetir";
            this.TarihGetir.Size = new System.Drawing.Size(95, 89);
            this.TarihGetir.TabIndex = 19;
            this.TarihGetir.Text = "Tarih Getir";
            this.TarihGetir.UseVisualStyleBackColor = true;
            this.TarihGetir.Click += new System.EventHandler(this.TarihGetir_Click);
            // 
            // Top5
            // 
            this.Top5.Location = new System.Drawing.Point(517, 170);
            this.Top5.Name = "Top5";
            this.Top5.Size = new System.Drawing.Size(95, 89);
            this.Top5.TabIndex = 20;
            this.Top5.Text = "Top 5";
            this.Top5.UseVisualStyleBackColor = true;
            this.Top5.Click += new System.EventHandler(this.Top5_Click);
            // 
            // Son5
            // 
            this.Son5.Location = new System.Drawing.Point(618, 170);
            this.Son5.Name = "Son5";
            this.Son5.Size = new System.Drawing.Size(95, 89);
            this.Son5.TabIndex = 21;
            this.Son5.Text = "Son 5";
            this.Son5.UseVisualStyleBackColor = true;
            this.Son5.Click += new System.EventHandler(this.Son5_Click);
            // 
            // Musteriye_göre
            // 
            this.Musteriye_göre.Location = new System.Drawing.Point(208, 205);
            this.Musteriye_göre.Name = "Musteriye_göre";
            this.Musteriye_göre.Size = new System.Drawing.Size(89, 54);
            this.Musteriye_göre.TabIndex = 22;
            this.Musteriye_göre.Text = "Müşteriye Göre Getir";
            this.Musteriye_göre.UseVisualStyleBackColor = true;
            this.Musteriye_göre.Click += new System.EventHandler(this.Musteriye_göre_Click);
            // 
            // Siparis_sayisi
            // 
            this.Siparis_sayisi.Location = new System.Drawing.Point(719, 170);
            this.Siparis_sayisi.Name = "Siparis_sayisi";
            this.Siparis_sayisi.Size = new System.Drawing.Size(95, 89);
            this.Siparis_sayisi.TabIndex = 23;
            this.Siparis_sayisi.Text = "Toplam Sipariş Sayısı";
            this.Siparis_sayisi.UseVisualStyleBackColor = true;
            this.Siparis_sayisi.Click += new System.EventHandler(this.Siparis_sayisi_Click);
            // 
            // Siparis_hepsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.Siparis_sayisi);
            this.Controls.Add(this.Musteriye_göre);
            this.Controls.Add(this.Son5);
            this.Controls.Add(this.Top5);
            this.Controls.Add(this.TarihGetir);
            this.Controls.Add(this.SiparisHepsi);
            this.Controls.Add(this.harf_iceren);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.elmnsys_isimler);
            this.Controls.Add(this.isimler_Hepsi);
            this.Controls.Add(this.Tersten);
            this.Controls.Add(this.alfabetik);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.eleman_sys);
            this.Controls.Add(this.En_kucuk);
            this.Controls.Add(this.En_buyuk);
            this.Controls.Add(this.Tek);
            this.Controls.Add(this.cift);
            this.Controls.Add(this.Pozitif);
            this.Controls.Add(this.Negatif);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.sayilar_hepsi);
            this.Name = "Siparis_hepsi";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sayilar_hepsi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Negatif;
        private System.Windows.Forms.Button Pozitif;
        private System.Windows.Forms.Button cift;
        private System.Windows.Forms.Button Tek;
        private System.Windows.Forms.Button En_buyuk;
        private System.Windows.Forms.Button En_kucuk;
        private System.Windows.Forms.Button eleman_sys;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button alfabetik;
        private System.Windows.Forms.Button Tersten;
        private System.Windows.Forms.Button isimler_Hepsi;
        private System.Windows.Forms.Button elmnsys_isimler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button harf_iceren;
        private System.Windows.Forms.Button SiparisHepsi;
        private System.Windows.Forms.Button TarihGetir;
        private System.Windows.Forms.Button Top5;
        private System.Windows.Forms.Button Son5;
        private System.Windows.Forms.Button Musteriye_göre;
        private System.Windows.Forms.Button Siparis_sayisi;
    }
}

