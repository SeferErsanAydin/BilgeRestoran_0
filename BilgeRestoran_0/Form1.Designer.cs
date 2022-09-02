namespace BilgeRestoran_0
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
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtMasaNo = new System.Windows.Forms.TextBox();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.btnToplam = new System.Windows.Forms.Button();
            this.lblCiro = new System.Windows.Forms.Label();
            this.grbIcecekler = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grbAraSicaklar = new System.Windows.Forms.GroupBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.grbAnaYemekler = new System.Windows.Forms.GroupBox();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.grbTatlilar = new System.Windows.Forms.GroupBox();
            this.checkBox31 = new System.Windows.Forms.CheckBox();
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.checkBox29 = new System.Windows.Forms.CheckBox();
            this.checkBox27 = new System.Windows.Forms.CheckBox();
            this.checkBox28 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOnIzleme = new System.Windows.Forms.Button();
            this.grbIcecekler.SuspendLayout();
            this.grbAraSicaklar.SuspendLayout();
            this.grbAnaYemekler.SuspendLayout();
            this.grbTatlilar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.Location = new System.Drawing.Point(664, 12);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(881, 420);
            this.lstSiparisler.TabIndex = 0;
            // 
            // lblAciklama
            // 
            this.lblAciklama.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAciklama.Location = new System.Drawing.Point(9, 473);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(536, 146);
            this.lblAciklama.TabIndex = 1;
            // 
            // txtMasaNo
            // 
            this.txtMasaNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtMasaNo.Location = new System.Drawing.Point(12, 45);
            this.txtMasaNo.MaxLength = 2;
            this.txtMasaNo.Name = "txtMasaNo";
            this.txtMasaNo.Size = new System.Drawing.Size(100, 20);
            this.txtMasaNo.TabIndex = 2;
            this.txtMasaNo.TextChanged += new System.EventHandler(this.txtMasaNo_TextChanged);
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(664, 454);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(83, 50);
            this.btnSiparisEkle.TabIndex = 3;
            this.btnSiparisEkle.Text = "Siparisi Onayla";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // btnToplam
            // 
            this.btnToplam.Location = new System.Drawing.Point(1471, 473);
            this.btnToplam.Name = "btnToplam";
            this.btnToplam.Size = new System.Drawing.Size(51, 44);
            this.btnToplam.TabIndex = 3;
            this.btnToplam.Text = "Toplam Ciro";
            this.btnToplam.UseVisualStyleBackColor = true;
            this.btnToplam.Click += new System.EventHandler(this.btnToplam_Click);
            // 
            // lblCiro
            // 
            this.lblCiro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCiro.Location = new System.Drawing.Point(1455, 548);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(81, 23);
            this.lblCiro.TabIndex = 4;
            this.lblCiro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbIcecekler
            // 
            this.grbIcecekler.Controls.Add(this.checkBox4);
            this.grbIcecekler.Controls.Add(this.checkBox3);
            this.grbIcecekler.Controls.Add(this.checkBox2);
            this.grbIcecekler.Controls.Add(this.checkBox1);
            this.grbIcecekler.Location = new System.Drawing.Point(12, 86);
            this.grbIcecekler.Name = "grbIcecekler";
            this.grbIcecekler.Size = new System.Drawing.Size(97, 248);
            this.grbIcecekler.TabIndex = 5;
            this.grbIcecekler.TabStop = false;
            this.grbIcecekler.Text = "İçecekler";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 88);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(48, 17);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Tag = "5";
            this.checkBox4.Text = "Rakı";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 65);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(47, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Tag = "2";
            this.checkBox3.Text = "Kola";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(39, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Tag = "1";
            this.checkBox2.Text = "Su";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(44, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Tag = "1.5";
            this.checkBox1.Text = "Çay";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // grbAraSicaklar
            // 
            this.grbAraSicaklar.Controls.Add(this.checkBox9);
            this.grbAraSicaklar.Controls.Add(this.checkBox15);
            this.grbAraSicaklar.Controls.Add(this.checkBox10);
            this.grbAraSicaklar.Controls.Add(this.checkBox11);
            this.grbAraSicaklar.Controls.Add(this.checkBox13);
            this.grbAraSicaklar.Location = new System.Drawing.Point(134, 86);
            this.grbAraSicaklar.Name = "grbAraSicaklar";
            this.grbAraSicaklar.Size = new System.Drawing.Size(133, 248);
            this.grbAraSicaklar.TabIndex = 5;
            this.grbAraSicaklar.TabStop = false;
            this.grbAraSicaklar.Text = "Ara Sıcaklar";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(6, 19);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(111, 17);
            this.checkBox9.TabIndex = 6;
            this.checkBox9.Tag = "10";
            this.checkBox9.Text = "Mantar Kavurması";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(6, 88);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(106, 17);
            this.checkBox15.TabIndex = 6;
            this.checkBox15.Tag = "13";
            this.checkBox15.Text = "Pastırmalı Humus";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(6, 111);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(106, 17);
            this.checkBox10.TabIndex = 6;
            this.checkBox10.Tag = "14";
            this.checkBox10.Text = "Kabak Karnıyarık";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(6, 42);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(97, 17);
            this.checkBox11.TabIndex = 6;
            this.checkBox11.Tag = "11";
            this.checkBox11.Text = "Patates Graten";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(6, 65);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(121, 17);
            this.checkBox13.TabIndex = 6;
            this.checkBox13.Tag = "12";
            this.checkBox13.Text = "Milföylü Biber Sarma";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // grbAnaYemekler
            // 
            this.grbAnaYemekler.Controls.Add(this.checkBox23);
            this.grbAnaYemekler.Controls.Add(this.checkBox22);
            this.grbAnaYemekler.Controls.Add(this.checkBox18);
            this.grbAnaYemekler.Controls.Add(this.checkBox21);
            this.grbAnaYemekler.Controls.Add(this.checkBox19);
            this.grbAnaYemekler.Location = new System.Drawing.Point(305, 86);
            this.grbAnaYemekler.Name = "grbAnaYemekler";
            this.grbAnaYemekler.Size = new System.Drawing.Size(133, 248);
            this.grbAnaYemekler.TabIndex = 5;
            this.grbAnaYemekler.TabStop = false;
            this.grbAnaYemekler.Text = "Ana Yemekler";
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.Location = new System.Drawing.Point(6, 19);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(49, 17);
            this.checkBox23.TabIndex = 6;
            this.checkBox23.Tag = "20";
            this.checkBox23.Text = "Balık";
            this.checkBox23.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.Location = new System.Drawing.Point(6, 88);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(57, 17);
            this.checkBox22.TabIndex = 6;
            this.checkBox22.Tag = "35";
            this.checkBox22.Text = "Kebap";
            this.checkBox22.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(6, 65);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(76, 17);
            this.checkBox18.TabIndex = 6;
            this.checkBox18.Tag = "15";
            this.checkBox18.Text = "Lahmacun";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Location = new System.Drawing.Point(6, 111);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(50, 17);
            this.checkBox21.TabIndex = 6;
            this.checkBox21.Tag = "33";
            this.checkBox21.Text = "Ciğer";
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(6, 42);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(36, 17);
            this.checkBox19.TabIndex = 6;
            this.checkBox19.Tag = "30";
            this.checkBox19.Text = "Et";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // grbTatlilar
            // 
            this.grbTatlilar.Controls.Add(this.checkBox31);
            this.grbTatlilar.Controls.Add(this.checkBox26);
            this.grbTatlilar.Controls.Add(this.checkBox29);
            this.grbTatlilar.Controls.Add(this.checkBox27);
            this.grbTatlilar.Controls.Add(this.checkBox28);
            this.grbTatlilar.Location = new System.Drawing.Point(470, 86);
            this.grbTatlilar.Name = "grbTatlilar";
            this.grbTatlilar.Size = new System.Drawing.Size(133, 248);
            this.grbTatlilar.TabIndex = 5;
            this.grbTatlilar.TabStop = false;
            this.grbTatlilar.Text = "Tatlılar";
            // 
            // checkBox31
            // 
            this.checkBox31.AutoSize = true;
            this.checkBox31.Location = new System.Drawing.Point(6, 19);
            this.checkBox31.Name = "checkBox31";
            this.checkBox31.Size = new System.Drawing.Size(50, 17);
            this.checkBox31.TabIndex = 6;
            this.checkBox31.Tag = "10";
            this.checkBox31.Text = "Sufle";
            this.checkBox31.UseVisualStyleBackColor = true;
            // 
            // checkBox26
            // 
            this.checkBox26.AutoSize = true;
            this.checkBox26.Location = new System.Drawing.Point(6, 42);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(98, 17);
            this.checkBox26.TabIndex = 6;
            this.checkBox26.Tag = "12";
            this.checkBox26.Text = "Çikolatalı Pasta";
            this.checkBox26.UseVisualStyleBackColor = true;
            // 
            // checkBox29
            // 
            this.checkBox29.AutoSize = true;
            this.checkBox29.Location = new System.Drawing.Point(6, 88);
            this.checkBox29.Name = "checkBox29";
            this.checkBox29.Size = new System.Drawing.Size(87, 17);
            this.checkBox29.TabIndex = 6;
            this.checkBox29.Tag = "14";
            this.checkBox29.Text = "Piramit Pasta";
            this.checkBox29.UseVisualStyleBackColor = true;
            // 
            // checkBox27
            // 
            this.checkBox27.AutoSize = true;
            this.checkBox27.Location = new System.Drawing.Point(6, 111);
            this.checkBox27.Name = "checkBox27";
            this.checkBox27.Size = new System.Drawing.Size(71, 17);
            this.checkBox27.TabIndex = 6;
            this.checkBox27.Tag = "15";
            this.checkBox27.Text = "Supangle";
            this.checkBox27.UseVisualStyleBackColor = true;
            // 
            // checkBox28
            // 
            this.checkBox28.AutoSize = true;
            this.checkBox28.Location = new System.Drawing.Point(6, 65);
            this.checkBox28.Name = "checkBox28";
            this.checkBox28.Size = new System.Drawing.Size(70, 17);
            this.checkBox28.TabIndex = 6;
            this.checkBox28.Tag = "13";
            this.checkBox28.Text = "Islak Kek";
            this.checkBox28.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Masa No";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(9, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Detaylı Fiyat Bilgisi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOnIzleme
            // 
            this.btnOnIzleme.Location = new System.Drawing.Point(12, 363);
            this.btnOnIzleme.Name = "btnOnIzleme";
            this.btnOnIzleme.Size = new System.Drawing.Size(108, 43);
            this.btnOnIzleme.TabIndex = 8;
            this.btnOnIzleme.Text = "Siparis Ön İzleme";
            this.btnOnIzleme.UseVisualStyleBackColor = true;
            this.btnOnIzleme.Click += new System.EventHandler(this.btnOnIzleme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1672, 673);
            this.Controls.Add(this.btnOnIzleme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbTatlilar);
            this.Controls.Add(this.grbAnaYemekler);
            this.Controls.Add(this.grbAraSicaklar);
            this.Controls.Add(this.grbIcecekler);
            this.Controls.Add(this.lblCiro);
            this.Controls.Add(this.btnToplam);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.txtMasaNo);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lstSiparisler);
            this.Name = "Form1";
            this.Text = "Bilge Restoran";
            this.grbIcecekler.ResumeLayout(false);
            this.grbIcecekler.PerformLayout();
            this.grbAraSicaklar.ResumeLayout(false);
            this.grbAraSicaklar.PerformLayout();
            this.grbAnaYemekler.ResumeLayout(false);
            this.grbAnaYemekler.PerformLayout();
            this.grbTatlilar.ResumeLayout(false);
            this.grbTatlilar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtMasaNo;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.Button btnToplam;
        private System.Windows.Forms.Label lblCiro;
        private System.Windows.Forms.GroupBox grbIcecekler;
        private System.Windows.Forms.GroupBox grbAraSicaklar;
        private System.Windows.Forms.GroupBox grbAnaYemekler;
        private System.Windows.Forms.GroupBox grbTatlilar;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox23;
        private System.Windows.Forms.CheckBox checkBox22;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox31;
        private System.Windows.Forms.CheckBox checkBox26;
        private System.Windows.Forms.CheckBox checkBox29;
        private System.Windows.Forms.CheckBox checkBox27;
        private System.Windows.Forms.CheckBox checkBox28;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOnIzleme;
    }
}

