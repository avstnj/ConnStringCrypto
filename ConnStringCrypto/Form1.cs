using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnStringCrypto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrypto_Click(object sender, EventArgs e)
        {
            txtDest.Text = ACWSED.AESEncryption.EncryptString(txtSource.Text.Trim());
        }

        private void btnDeCrypt_Click(object sender, EventArgs e)
        {
            txtSource.Text = ACWSED.AESEncryption.DecryptString(txtDest.Text.Trim());
        }
    }
}
