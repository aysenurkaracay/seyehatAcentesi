namespace seyehatAcentesi
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
            this.grbKb = new System.Windows.Forms.GroupBox();
            this.btnSayı = new System.Windows.Forms.Button();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.rdbKadın = new System.Windows.Forms.RadioButton();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.lblsayi = new System.Windows.Forms.Label();
            this.lblKNo = new System.Windows.Forms.Label();
            this.lblCınsıyet = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lboxSatilanKoltuklar = new System.Windows.Forms.ListBox();
            this.flwPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.grbKb.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbKb
            // 
            this.grbKb.Controls.Add(this.btnSayı);
            this.grbKb.Controls.Add(this.btnKayıt);
            this.grbKb.Controls.Add(this.rdbKadın);
            this.grbKb.Controls.Add(this.rdbErkek);
            this.grbKb.Controls.Add(this.textSoyad);
            this.grbKb.Controls.Add(this.textAd);
            this.grbKb.Controls.Add(this.lblsayi);
            this.grbKb.Controls.Add(this.lblKNo);
            this.grbKb.Controls.Add(this.lblCınsıyet);
            this.grbKb.Controls.Add(this.lblTelefon);
            this.grbKb.Controls.Add(this.mskTel);
            this.grbKb.Controls.Add(this.lblSoyad);
            this.grbKb.Controls.Add(this.lblAd);
            this.grbKb.Location = new System.Drawing.Point(319, 12);
            this.grbKb.Name = "grbKb";
            this.grbKb.Size = new System.Drawing.Size(256, 191);
            this.grbKb.TabIndex = 0;
            this.grbKb.TabStop = false;
            this.grbKb.Text = "Kişisel Bilgiler";
            // 
            // btnSayı
            // 
            this.btnSayı.Location = new System.Drawing.Point(82, 156);
            this.btnSayı.Name = "btnSayı";
            this.btnSayı.Size = new System.Drawing.Size(70, 23);
            this.btnSayı.TabIndex = 13;
            this.btnSayı.UseVisualStyleBackColor = true;
            // 
            // btnKayıt
            // 
            this.btnKayıt.Location = new System.Drawing.Point(158, 156);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(70, 23);
            this.btnKayıt.TabIndex = 12;
            this.btnKayıt.Text = "Kaydet";
            this.btnKayıt.UseVisualStyleBackColor = true;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // rdbKadın
            // 
            this.rdbKadın.AutoSize = true;
            this.rdbKadın.Location = new System.Drawing.Point(143, 125);
            this.rdbKadın.Name = "rdbKadın";
            this.rdbKadın.Size = new System.Drawing.Size(52, 17);
            this.rdbKadın.TabIndex = 11;
            this.rdbKadın.TabStop = true;
            this.rdbKadın.Text = "Kadın";
            this.rdbKadın.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Location = new System.Drawing.Point(75, 125);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(53, 17);
            this.rdbErkek.TabIndex = 10;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "Erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(75, 62);
            this.textSoyad.Multiline = true;
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(153, 18);
            this.textSoyad.TabIndex = 9;
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(75, 28);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(153, 20);
            this.textAd.TabIndex = 8;
            // 
            // lblsayi
            // 
            this.lblsayi.AutoSize = true;
            this.lblsayi.Location = new System.Drawing.Point(72, 156);
            this.lblsayi.Name = "lblsayi";
            this.lblsayi.Size = new System.Drawing.Size(0, 13);
            this.lblsayi.TabIndex = 6;
            // 
            // lblKNo
            // 
            this.lblKNo.AutoSize = true;
            this.lblKNo.Location = new System.Drawing.Point(9, 156);
            this.lblKNo.Name = "lblKNo";
            this.lblKNo.Size = new System.Drawing.Size(57, 13);
            this.lblKNo.TabIndex = 5;
            this.lblKNo.Text = "Koltuk No:";
            // 
            // lblCınsıyet
            // 
            this.lblCınsıyet.AutoSize = true;
            this.lblCınsıyet.Location = new System.Drawing.Point(9, 125);
            this.lblCınsıyet.Name = "lblCınsıyet";
            this.lblCınsıyet.Size = new System.Drawing.Size(46, 13);
            this.lblCınsıyet.TabIndex = 4;
            this.lblCınsıyet.Text = "Cinsiyet:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(9, 91);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(46, 13);
            this.lblTelefon.TabIndex = 3;
            this.lblTelefon.Text = "Telefon:";
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(75, 88);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(153, 20);
            this.mskTel.TabIndex = 2;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(6, 62);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(40, 13);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            this.lblAd.Location = new System.Drawing.Point(9, 28);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(66, 23);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad:";
            // 
            // lboxSatilanKoltuklar
            // 
            this.lboxSatilanKoltuklar.FormattingEnabled = true;
            this.lboxSatilanKoltuklar.Location = new System.Drawing.Point(319, 209);
            this.lboxSatilanKoltuklar.Name = "lboxSatilanKoltuklar";
            this.lboxSatilanKoltuklar.Size = new System.Drawing.Size(256, 225);
            this.lboxSatilanKoltuklar.TabIndex = 0;
            // 
            // flwPanel
            // 
            this.flwPanel.Location = new System.Drawing.Point(40, 20);
            this.flwPanel.Name = "flwPanel";
            this.flwPanel.Size = new System.Drawing.Size(229, 764);
            this.flwPanel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.flwPanel);
            this.Controls.Add(this.lboxSatilanKoltuklar);
            this.Controls.Add(this.grbKb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbKb.ResumeLayout(false);
            this.grbKb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKb;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.Label lblsayi;
        private System.Windows.Forms.Label lblKNo;
        private System.Windows.Forms.Label lblCınsıyet;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.ListBox lboxSatilanKoltuklar;
        private System.Windows.Forms.RadioButton rdbKadın;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.Button btnSayı;
        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.FlowLayoutPanel flwPanel;
    }
}

