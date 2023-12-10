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
    public partial class ÜzletekUC : UserControl
    {
        TelefonContext telefonContext = new TelefonContext();
        public ÜzletekUC()
        {
            InitializeComponent();
            uzletlistb.DisplayMember = "ÜzletNév";
            SzűrésÜzletek();
        }

        private void SzűrésÜzletek()
        {
            var megjelen = from x in telefonContext.Üzleteks
                           where x.ÜzletNév.Contains(uzlettxtb.Text)
                           select x;
            uzletlistb.DataSource = megjelen.ToList();
        }

        private void uzletlistb_SelectedIndexChanged(object sender, EventArgs e)
        {
            helytxtb.Text = ((Üzletek)uzletlistb.SelectedItem).Helyszín.ToString();
            mérettxtb.Text = ((Üzletek)uzletlistb.SelectedItem).Méret.ToString();
            tavalyivtxtb.Text = ((Üzletek)uzletlistb.SelectedItem).TavalyiVásárlóSzám.ToString();
        }

        private void uzlettxtb_TextChanged(object sender, EventArgs e)
        {
            SzűrésÜzletek();
        }
    }
}
