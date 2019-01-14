using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHA_1
{
    public partial class FrmHashIt : Form
    {
        public FrmHashIt()
        {
            InitializeComponent();
        }

        private string hashIt(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        private void btnHashIt_Click(object sender, EventArgs e)
        {
            txbOutput.Text = hashIt(rtbInput.Text);
        }
    }
}
