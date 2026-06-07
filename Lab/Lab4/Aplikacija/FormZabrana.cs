using Podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija
{
    public partial class FormZabrana : Form
    {
        private bool uRedu = false;
        private List<Zabrana> listaZabrana;
        private List<Zabrana> listaMogucihKat;

        public FormZabrana()
        {
            InitializeComponent();
        }

        public FormZabrana(ref List<Zabrana> listaZabrana, List<Kategorija> listaMogucihKat)
            : this()
        {
            this.listaZabrana = listaZabrana;

            cbKat.Items.Clear();
            foreach (Kategorija kategorija in listaMogucihKat)
            {
                cbKat.Items.Add(kategorija.OznakaKategorije);
            }
        }

        private void FormZabrana_FormClosing(object sender, FormClosingEventArgs e)
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

            string nazivKat = cbKat.SelectedItem.ToString();
            Zabrana pr = new Zabrana(nazivKat, dtpOd.Value, dtpDo.Value);

            if (!Proveri(pr))
            {
                MessageBox.Show("Zabrana sa istom kategorijom već postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listaZabrana.Add(pr);
            uRedu = true;
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private bool Validiraj()
        {
            if (cbKat.SelectedIndex == -1)
            {
                MessageBox.Show("Niste odabrali kategoriju!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbKat.Focus();
                return false;
            }
            if (dtpOd.Value > dtpDo.Value)
            {
                MessageBox.Show("Datum početka zabrane ne može biti veći od datuma kraja zabrane!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpOd.Focus();
                return false;
            }

            return true;
        }

        private bool Proveri(Zabrana pr)
        {
            foreach (var z in listaZabrana)
            {
                if (z.Kategorija == pr.Kategorija)
                    return false;
            }

            return true;
        }

        private DialogResult ZatvoriFormu()
        {
            return MessageBox.Show("Da li ste sigurni da želite da zatvorite formu?", "Zatvaranje forme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
