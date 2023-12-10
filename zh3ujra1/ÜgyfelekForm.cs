using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh3ujra1.Models;

namespace zh3ujra1
{
    public partial class ÜgyfelekForm : Form
    {
        TelefonContext telefonContext = new TelefonContext();
        public ÜgyfelekForm()
        {
            InitializeComponent();
            csomaglistb.DisplayMember = "CsomagNév";
            ügyféllistb.DisplayMember = "Név";
            SzűrésCsomag();
        }

        private void SzűrésCsomag()
        {
            var megjelen = from x in telefonContext.Csomagoks
                           where x.CsomagNév.Contains(csomagtxtb.Text)
                           select x;
            csomaglistb.DataSource = megjelen.ToList();
        }

        private void MegjelenNév()
        {
            var csomagok = ((Csomagok)csomaglistb.SelectedItem).CsomagId;
            var megjelen = from x in telefonContext.Ügyfeleks
                           where x.CsomagId == csomagok
                           select x;
            ügyféllistb.DataSource = megjelen.ToList();
        }

        private void MegjelenDataJelen()
        {
            var ügyfél = ((Ügyfelek)ügyféllistb.SelectedItem).Név;
            var megjelen = from x in telefonContext.Ügyfeleks
                           where x.Név == ügyfél
                           select new DataJelen
                           {
                               ÜgyfélId = x.ÜgyfélId,
                               Név = x.Név,
                               SzülIdő = x.SzülIdő,
                               TelSzám = x.TelSzám,
                               Email = x.Email,
                               Bővíthetőe = x.BővíthetőE,
                               Ár = x.Csomag.Ár,
                               Perc = x.Csomag.Percek
                           };
            dataJelenBindingSource.DataSource = megjelen.ToList();
        }

        private void csomagtxtb_TextChanged(object sender, EventArgs e)
        {
            SzűrésCsomag();
        }

        private void csomaglistb_SelectedIndexChanged(object sender, EventArgs e)
        {
            MegjelenNév();
        }

        private void ügyféllistb_SelectedIndexChanged(object sender, EventArgs e)
        {
            MegjelenDataJelen();
        }

        private bool Megfelele(string n)
        {
            Regex regex = new Regex("[0-9]{9}$");
            return regex.IsMatch(n);
        }

        private void hozzáadtxtb_Validating(object sender, CancelEventArgs e)
        {
            if (!Megfelele(hozzáadtxtb.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(hozzáadtxtb, "9db számból kell állnia!");
            }
        }

        private void hozzáadtxtb_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(hozzáadtxtb, "");
        }

        private void hozzáadbttn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan hozzáadad az adatot?", "Adat hozzáadása", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Ügyfelek üf = new Ügyfelek();
                üf.TelSzám = hozzáadtxtb.Text.ToString();
                üf.Név = ((Ügyfelek)ügyféllistb.SelectedItem).Név;
                üf.Email = ((Ügyfelek)ügyféllistb.SelectedItem).Email;
                üf.ÜgyfélId = telefonContext.Ügyfeleks.Count() +1;
                telefonContext.Ügyfeleks.Add(üf);
                try
                {
                    telefonContext.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                MegjelenDataJelen();
            }
        }

        private void törléstxtb_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan ki szeretnéd törölni ad adatot?", "Adat törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                var adat = ((DataJelen)dataJelenBindingSource.Current).ÜgyfélId;
                var törlendő = (from x in telefonContext.Ügyfeleks
                               where x.ÜgyfélId == adat
                               select x).FirstOrDefault();
                telefonContext.Ügyfeleks.Remove(törlendő);
                try
                {
                    telefonContext.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                MegjelenDataJelen();
            }
        }
    }
}
