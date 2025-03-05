namespace odevkontrolu
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
            panel1 = new Panel();
            btnKaydet = new Button();
            btnEkle = new Button();
            btnSil = new Button();
            btnYeni = new Button();
            cbSınıf = new ComboBox();
            rbHayır = new RadioButton();
            rbEvet = new RadioButton();
            txtPuan = new TextBox();
            txtOdevKonusu = new TextBox();
            txtNumara = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Ogrenciler = new ListBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(btnKaydet);
            panel1.Controls.Add(btnEkle);
            panel1.Controls.Add(btnSil);
            panel1.Controls.Add(btnYeni);
            panel1.Controls.Add(cbSınıf);
            panel1.Controls.Add(rbHayır);
            panel1.Controls.Add(rbEvet);
            panel1.Controls.Add(txtPuan);
            panel1.Controls.Add(txtOdevKonusu);
            panel1.Controls.Add(txtNumara);
            panel1.Controls.Add(txtSoyad);
            panel1.Controls.Add(txtAd);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Ogrenciler);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(12, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 571);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Cyan;
            btnKaydet.Location = new Point(458, 11);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 40);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Lime;
            btnEkle.Location = new Point(401, 510);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(112, 35);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle/Guncelle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += button1_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Red;
            btnSil.Location = new Point(308, 510);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 35);
            btnSil.TabIndex = 8;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnYeni
            // 
            btnYeni.BackColor = Color.FromArgb(192, 192, 0);
            btnYeni.Location = new Point(184, 510);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(75, 35);
            btnYeni.TabIndex = 8;
            btnYeni.Text = "Yeni";
            btnYeni.UseVisualStyleBackColor = false;
            btnYeni.Click += btnYeni_Click;
            // 
            // cbSınıf
            // 
            cbSınıf.FormattingEnabled = true;
            cbSınıf.Location = new Point(237, 191);
            cbSınıf.Name = "cbSınıf";
            cbSınıf.Size = new Size(100, 23);
            cbSınıf.TabIndex = 7;
            // 
            // rbHayır
            // 
            rbHayır.AutoSize = true;
            rbHayır.Location = new Point(345, 339);
            rbHayır.Name = "rbHayır";
            rbHayır.Size = new Size(53, 19);
            rbHayır.TabIndex = 6;
            rbHayır.TabStop = true;
            rbHayır.Text = "Hayır";
            rbHayır.UseVisualStyleBackColor = true;
            // 
            // rbEvet
            // 
            rbEvet.AutoSize = true;
            rbEvet.Location = new Point(292, 340);
            rbEvet.Name = "rbEvet";
            rbEvet.Size = new Size(47, 19);
            rbEvet.TabIndex = 6;
            rbEvet.TabStop = true;
            rbEvet.Text = "Evet";
            rbEvet.UseVisualStyleBackColor = true;
            // 
            // txtPuan
            // 
            txtPuan.Location = new Point(250, 429);
            txtPuan.Name = "txtPuan";
            txtPuan.Size = new Size(107, 23);
            txtPuan.TabIndex = 5;
            // 
            // txtOdevKonusu
            // 
            txtOdevKonusu.Location = new Point(270, 248);
            txtOdevKonusu.Multiline = true;
            txtOdevKonusu.Name = "txtOdevKonusu";
            txtOdevKonusu.Size = new Size(113, 54);
            txtOdevKonusu.TabIndex = 5;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(237, 156);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(100, 23);
            txtNumara.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(237, 127);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(239, 93);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 5;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(161, 339);
            label8.Name = "label8";
            label8.Size = new Size(86, 23);
            label8.TabIndex = 4;
            label8.Text = "Ödev Yaptı Mı ?";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label9_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(157, 429);
            label9.Name = "label9";
            label9.Size = new Size(84, 23);
            label9.TabIndex = 4;
            label9.Text = "Ödev Puanı";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += label9_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Location = new Point(157, 247);
            label7.Name = "label7";
            label7.Size = new Size(98, 23);
            label7.TabIndex = 4;
            label7.Text = "Ödev Konucu";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(161, 189);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 4;
            label6.Text = "Sınıf";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(157, 155);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 4;
            label5.Text = "Numara";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(167, 124);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 4;
            label4.Text = "Soyad";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(159, 92);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
            label3.Text = "Ad";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(3, 52);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 3;
            label2.Text = "Ogrenciler";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Ogrenciler
            // 
            Ogrenciler.FormattingEnabled = true;
            Ogrenciler.ItemHeight = 15;
            Ogrenciler.Location = new Point(3, 81);
            Ogrenciler.Name = "Ogrenciler";
            Ogrenciler.Size = new Size(150, 439);
            Ogrenciler.TabIndex = 2;
            Ogrenciler.SelectedIndexChanged += Ogrenciler_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SpringGreen;
            pictureBox1.Image = Properties.Resources.homework;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.MediumSeaGreen;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(546, 49);
            label1.TabIndex = 0;
            label1.Text = "Ödev Planı";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 603);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListBox Ogrenciler;
        private TextBox txtPuan;
        private TextBox txtOdevKonusu;
        private TextBox txtNumara;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label9;
        private Label label7;
        private RadioButton rbHayır;
        private RadioButton rbEvet;
        private Label label8;
        private Button btnYeni;
        private ComboBox cbSınıf;
        private Button btnKaydet;
        private Button btnEkle;
        private Button btnSil;
    }
}
