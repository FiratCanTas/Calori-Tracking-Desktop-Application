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
    public partial class FH_SignUp : Form
    {
        public FH_SignUp()
        {
            InitializeComponent();
        }

        FH_ClarificationText fH_ClarificationText;
        FatHunterDbContext db = new FatHunterDbContext();

        private void btnIptal_Click(object sender, EventArgs e)
        {
            //Clear(); KATMANLIDA BASE İÇERSİNDE OLUŞACAK
            this.Hide();
            FH_MainPage.page.Show();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            fH_ClarificationText = new FH_ClarificationText();
            fH_ClarificationText.Show();
            this.Hide();
        }

        private void FH_SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
