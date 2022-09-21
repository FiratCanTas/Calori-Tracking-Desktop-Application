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
    public partial class FH_ComparingPage : Form
    {
        public FH_ComparingPage()
        {
            InitializeComponent();
        }

        private void FH_ComparingPage_Load(object sender, EventArgs e)
        {
            dtpRaporBaslangic.Value = dtpRaporBitis.Value.AddDays(-7);

            chrRapor.Series["Günlük Kalori"].Points.AddXY(dtpRaporBaslangic.Value.ToShortDateString(), 2250);
            chrRapor.Series["Günlük Kalori"].Points.AddXY(dtpRaporBaslangic.Value.AddDays(1).ToShortDateString(), 2130);
            chrRapor.Series["Günlük Kalori"].Points.AddXY(dtpRaporBaslangic.Value.AddDays(2).ToShortDateString(), 2430);
            chrRapor.Series["Günlük Kalori"].Points.AddXY(dtpRaporBaslangic.Value.AddDays(3).ToShortDateString(), 3410);
            chrRapor.Series["Günlük Kalori"].Points.AddXY(dtpRaporBaslangic.Value.AddDays(4).ToShortDateString(), 1234);
            chrRapor.Series["Günlük Kalori"].Points.AddXY(dtpRaporBaslangic.Value.AddDays(5).ToShortDateString(), 3214);
            chrRapor.Series["Günlük Kalori"].Points.AddXY(dtpRaporBaslangic.Value.AddDays(6).ToShortDateString(), 4213);
        }

        private void FH_ComparingPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            FH_SignIn.userMainPage.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
