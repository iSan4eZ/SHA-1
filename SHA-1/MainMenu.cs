using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHA_1
{
    public partial class MainMenu : Form
    {
        LabForm frmLabForm = new LabForm();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnStartLab_Click(object sender, EventArgs e)
        {
            frmLabForm.ShowDialog();
        }

        private void btnHashIt_Click(object sender, EventArgs e)
        {
            FrmHashIt frmHashIt = new FrmHashIt();
            frmHashIt.ShowDialog();
        }
    }
}
