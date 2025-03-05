using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevkontrolu
{
    public partial class sifre : Form
    {
        public sifre()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "abuziddin" &&
                   txtParola.Text == "kıllıbacak")
            {
                DialogResult = DialogResult.OK;//formu kapatır
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı yada parola!");
            }
        }
    }
}
