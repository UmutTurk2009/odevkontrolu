namespace odevkontrolu
{
    partial class sifre
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
            txtParola = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            txtKullanici = new TextBox();
            SuspendLayout();
            // 
            // txtParola
            // 
            txtParola.Location = new Point(293, 183);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(100, 23);
            txtParola.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(12, 247);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(776, 191);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "giriş";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 156);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 191);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Parola";
            // 
            // txtKullanici
            // 
            txtKullanici.Location = new Point(293, 148);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(100, 23);
            txtKullanici.TabIndex = 1;
            // 
            // sifre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtKullanici);
            Controls.Add(txtParola);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "sifre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtParola;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private TextBox txtKullanici;
    }
}