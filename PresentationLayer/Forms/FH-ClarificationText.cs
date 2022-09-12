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
    public partial class FH_ClarificationText : Form
    {
        public FH_ClarificationText()
        {
            InitializeComponent();
        }

        FH_MainPage mainPage;

        private void btnRedEdiyorum_Click(object sender, EventArgs e)
        {
            mainPage = new FH_MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void FH_ClarificationText_FormClosed(object sender, FormClosedEventArgs e)
        {
            FH_SignIn.userMainPage.Show();
        }

        private void btnKabul_Click(object sender, EventArgs e)
        {
            UserMainPage userMainPage = new UserMainPage();
            userMainPage.Show();
            this.Hide();
        }
    }
}
