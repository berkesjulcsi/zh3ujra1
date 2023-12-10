using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh3ujra1.Models;

namespace zh3ujra1
{
    public partial class CsomagokUC : UserControl
    {
        TelefonContext telefonContext = new TelefonContext();
        public CsomagokUC()
        {
            InitializeComponent();
            csomaglistb.DisplayMember = "CsomagNév";
            SzűrésCsomag();
        }

        private void SzűrésCsomag()
        {
            var megjelen = from x in telefonContext.Csomagoks
                           where x.CsomagNév.Contains(csomagtxtb.Text)
                           select x;
            csomaglistb.DataSource = megjelen.ToList();
        }

        private void csomaglistb_SelectedIndexChanged(object sender, EventArgs e)
        {
            időttxtb.Text = ((Csomagok)csomaglistb.SelectedItem).Időtartam.ToString();
            fizütxtb.Text = ((Csomagok)csomaglistb.SelectedItem).FizÜtemezés.ToString();
            ártxtb.Text = ((Csomagok)csomaglistb.SelectedItem).Ár.ToString();
        }

        private void csomagtxtb_TextChanged(object sender, EventArgs e)
        {
            SzűrésCsomag();
        }
    }
}
