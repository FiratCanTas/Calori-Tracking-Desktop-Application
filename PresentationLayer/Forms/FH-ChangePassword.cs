using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class FH_ChangePassword : Form
    {
        public FH_ChangePassword()
        {
            InitializeComponent();
        }

        FH_SignIn fH_SignIn;

        private void btnSifreGüncelle_Click(object sender, EventArgs e)
        {
            fH_SignIn = new FH_SignIn();
            fH_SignIn.Show();
            this.Hide();
        }

        private void FH_ChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            FH_SignIn.userMainPage.Show();
        }
    }
}
