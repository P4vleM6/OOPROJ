using Podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija
{
    public partial class FormKategorija : Form
    {
        private bool uRedu = false;
        private List<Kategorija> listaKategorija;

        public FormKategorija()
        {
            InitializeComponent();
        }

        public FormKategorija(ref List<Kategorija> listaKategorija)
            : this()
        {
            this.listaKategorija = listaKategorija;
        }

        private void FormKategorija_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!uRedu)
            {
                if (ZatvoriFormu() == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            if (ZatvoriFormu() == DialogResult.Yes)
            {
                uRedu = true;
                this.Close();
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (!Validiraj())
                return;

            string nazivKat = cbKategorija.SelectedItem.ToString();
            Kategorija pr = new Kategorija(nazivKat, dtpOd.Value, dtpDo.Value);

            if (!Proveri(pr))
            {
                MessageBox.Show("Kategorija sa ovom oznakom vec postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listaKategorija.Add(pr);
            uRedu = true;
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private bool Validiraj()
        {
            if (cbKategorija.SelectedIndex == -1)
            {
                MessageBox.Show("Niste odabrali kategoriju!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbKategorija.Focus();
                return false;
            }
            if (dtpOd.Value > dtpDo.Value)
            {
                MessageBox.Show("Datum početka ne može biti veći od datuma završetka!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpOd.Focus();
                return false;
            }

            return true;
        }

        private bool Proveri(Kategorija pr)
        {
            foreach (var k in listaKategorija)
            {
                if (k.OznakaKategorije == pr.OznakaKategorije)
                {
                    return false;
                }
            }
            return true;
        }

        private DialogResult ZatvoriFormu()
        {
            return MessageBox.Show("Da li ste sigurni da želite da zatvorite formu?", "Zatvaranje forme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
