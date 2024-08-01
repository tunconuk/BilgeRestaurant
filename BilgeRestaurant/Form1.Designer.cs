namespace BilgeRestaurant
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
            this.TxtMasaNo = new System.Windows.Forms.TextBox();
            this.LstSiparisler = new System.Windows.Forms.ListBox();
            this.CbAnaYemekler = new System.Windows.Forms.ComboBox();
            this.CbAraSicaklar = new System.Windows.Forms.ComboBox();
            this.CbTatlilar = new System.Windows.Forms.ComboBox();
            this.CbIcecekler = new System.Windows.Forms.ComboBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnCiro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtMasaNo
            // 
            this.TxtMasaNo.Location = new System.Drawing.Point(31, 44);
            this.TxtMasaNo.Name = "TxtMasaNo";
            this.TxtMasaNo.Size = new System.Drawing.Size(150, 20);
            this.TxtMasaNo.TabIndex = 0;
            // 
            // LstSiparisler
            // 
            this.LstSiparisler.BackColor = System.Drawing.SystemColors.Control;
            this.LstSiparisler.FormattingEnabled = true;
            this.LstSiparisler.Location = new System.Drawing.Point(303, 33);
            this.LstSiparisler.Name = "LstSiparisler";
            this.LstSiparisler.Size = new System.Drawing.Size(799, 368);
            this.LstSiparisler.TabIndex = 1;
            // 
            // CbAnaYemekler
            // 
            this.CbAnaYemekler.FormattingEnabled = true;
            this.CbAnaYemekler.Location = new System.Drawing.Point(31, 122);
            this.CbAnaYemekler.Name = "CbAnaYemekler";
            this.CbAnaYemekler.Size = new System.Drawing.Size(241, 21);
            this.CbAnaYemekler.TabIndex = 3;
            // 
            // CbAraSicaklar
            // 
            this.CbAraSicaklar.FormattingEnabled = true;
            this.CbAraSicaklar.Location = new System.Drawing.Point(31, 183);
            this.CbAraSicaklar.Name = "CbAraSicaklar";
            this.CbAraSicaklar.Size = new System.Drawing.Size(241, 21);
            this.CbAraSicaklar.TabIndex = 3;
            // 
            // CbTatlilar
            // 
            this.CbTatlilar.FormattingEnabled = true;
            this.CbTatlilar.Location = new System.Drawing.Point(31, 249);
            this.CbTatlilar.Name = "CbTatlilar";
            this.CbTatlilar.Size = new System.Drawing.Size(241, 21);
            this.CbTatlilar.TabIndex = 3;
            // 
            // CbIcecekler
            // 
            this.CbIcecekler.FormattingEnabled = true;
            this.CbIcecekler.Location = new System.Drawing.Point(31, 312);
            this.CbIcecekler.Name = "CbIcecekler";
            this.CbIcecekler.Size = new System.Drawing.Size(241, 21);
            this.CbIcecekler.TabIndex = 3;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(465, 460);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(172, 57);
            this.BtnEkle.TabIndex = 4;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnCiro
            // 
            this.BtnCiro.Location = new System.Drawing.Point(730, 460);
            this.BtnCiro.Name = "BtnCiro";
            this.BtnCiro.Size = new System.Drawing.Size(173, 57);
            this.BtnCiro.TabIndex = 4;
            this.BtnCiro.Text = "Ciro";
            this.BtnCiro.UseVisualStyleBackColor = true;
            this.BtnCiro.Click += new System.EventHandler(this.BtnCiro_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ana Yemekler";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Masa Numarasi";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Icecekler";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tatlilar";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ara Sicaklar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1170, 602);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCiro);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.CbIcecekler);
            this.Controls.Add(this.CbTatlilar);
            this.Controls.Add(this.CbAraSicaklar);
            this.Controls.Add(this.CbAnaYemekler);
            this.Controls.Add(this.LstSiparisler);
            this.Controls.Add(this.TxtMasaNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMasaNo;
        private System.Windows.Forms.ListBox LstSiparisler;
        private System.Windows.Forms.ComboBox CbAnaYemekler;
        private System.Windows.Forms.ComboBox CbAraSicaklar;
        private System.Windows.Forms.ComboBox CbTatlilar;
        private System.Windows.Forms.ComboBox CbIcecekler;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnCiro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

