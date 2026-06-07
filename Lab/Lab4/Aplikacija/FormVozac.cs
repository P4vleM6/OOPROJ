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
    public partial class FormVozac : Form
    {
        private bool uRedu = false;
        private List<Kategorija> prListaKategorija = new List<Kategorija>();
        private List<Zabrana> prListaZabrana = new List<Zabrana>();

        public Vozac Vozac { get; set; }

        public FormVozac()
        {
            InitializeComponent();
        }

        public FormVozac(Vozac v)
            : this()
        {
            Vozac = v;
            prListaKategorija = v.ListaKategorija.ToList();
            prListaZabrana = v.ListaZabrana.ToList();
            btnProsledi.Text = "Izmeni";
            btnSlika.Text = "Izmeni sliku";
            tbDozvola.Enabled = false;
        }

        private void tbIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbMesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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

        private void FormVozac_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!uRedu)
            {
                if (ZatvoriFormu() == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbSlika.ImageLocation = ofd.FileName;
            }
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (!Validacija())
                return;

            if (Vozac == null)
            {
                if (!Dodaj())
                {
                    MessageBox.Show("Došlo je do greške prilikom dodavanja vozača!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (!Izmeni())
                {
                    MessageBox.Show("Došlo je do greške prilikom izmene vozača!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Podaci su uspešno sačuvani!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            uRedu = true;
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void FormVozac_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void tbDozvola_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDodajKat_Click(object sender, EventArgs e)
        {
            var form = new FormKategorija(ref prListaKategorija);
            DialogResult dlg = form.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
            {
                UcitajDGV();
            }
        }

        private void btnDodajZab_Click(object sender, EventArgs e)
        {
            var form = new FormZabrana(ref prListaZabrana, prListaKategorija);
            DialogResult dlg = form.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
            {
                UcitajDGV();
            }
        }

        private void btnObrisiKat_Click(object sender, EventArgs e)
        {
            if (dgvKategorija.SelectedRows.Count == 0)
                return;

            DialogResult dlg = MessageBox.Show("Da li ste sigurni da zelite da obrisete kategoriju?", "Brisanje kategorije", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.No)
                return;

            int selectedRow = dgvKategorija.SelectedRows[0].Index;
            string oznakaKategorije = (string)dgvKategorija.Rows[selectedRow].Cells[0].Value;

            if (ObrisiKategoriju(oznakaKategorije))
            {
                ObrisiZabranu(oznakaKategorije);

                MessageBox.Show("Kategorija je uspešno obrisana!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UcitajDGV();
            }
            else
            {
                MessageBox.Show("Došlo je do greške prilikom brisanja kategorije!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObrisiZab_Click(object sender, EventArgs e)
        {
            if (dgvZabrana.SelectedRows.Count == 0)
                return;

            DialogResult dlg = MessageBox.Show("Da li ste sigurni da zelite da obrisete zabranu?", "Brisanje zabrane", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.No)
                return;

            int selectedRow = dgvZabrana.SelectedRows[0].Index;
            string kategorija = (string)dgvKategorija.Rows[selectedRow].Cells[0].Value;

            if (ObrisiZabranu(kategorija))
            {
                MessageBox.Show("Zabrana je uspešno obrisana!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UcitajDGV();
            }
            else
            {
                MessageBox.Show("Došlo je do greške prilikom brisanja zabrane!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ObrisiZabranu(string kategorija)
        {
            Zabrana z = prListaZabrana.Find(x => x.Kategorija == kategorija);

            if (z == null)
                return false;

            prListaZabrana.Remove(z);
            return true;
        }

        private bool ObrisiKategoriju(string oznakaKategorije)
        {
            Kategorija k = prListaKategorija.Find(x => x.OznakaKategorije == oznakaKategorije);

            if (k == null)
                return false;

            prListaKategorija.Remove(k);
            return true;
        }

        private bool Izmeni()
        {
            Vozac v = new Vozac(tbIme.Text, tbPrezime.Text, dtpDatumRod.Value, dtpOd.Value, dtpDo.Value, tbDozvola.Text, tbMesto.Text, cbPol.SelectedItem.ToString(), pbSlika.ImageLocation, prListaKategorija, prListaZabrana);
            return ListaVozaca.Instance.IzmeniVozaca(v);
        }

        private bool Dodaj()
        {
            Vozac v = new Vozac(tbIme.Text, tbPrezime.Text, dtpDatumRod.Value, dtpOd.Value, dtpDo.Value, tbDozvola.Text, tbMesto.Text, cbPol.SelectedItem.ToString(), pbSlika.ImageLocation, prListaKategorija, prListaZabrana);
            return ListaVozaca.Instance.DodajVozaca(v);
        }

        private bool Validacija()
        {
            if (String.IsNullOrEmpty(tbIme.Text))
            {
                MessageBox.Show("Polje ime ne sme biti prazno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbIme.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(tbPrezime.Text))
            {
                MessageBox.Show("Polje prezime ne sme biti prazno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPrezime.Focus();
                return false;
            }

            if (tbDozvola.Text.Length < tbDozvola.MaxLength)
            {
                MessageBox.Show("Polje broj vozacke dozvole mora imati 9 cifara!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDozvola.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(tbMesto.Text))
            {
                MessageBox.Show("Polje mesto izdavanja ne sme biti prazno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMesto.Focus();
                return false;
            }

            if (cbPol.SelectedIndex == -1)
            {
                MessageBox.Show("Morate odabrati pol!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbPol.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(pbSlika.ImageLocation))
            {
                MessageBox.Show("Morate odabrati sliku!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSlika.Focus();
                return false;
            }

            return true;
        }

        private void UcitajPodatke()
        {
            if (Vozac != null)
                UcitajPodatkeUKontrole();
            UcitajDGV();
        }

        private void UcitajPodatkeUKontrole()
        {
            tbIme.Text = Vozac.Ime;
            tbPrezime.Text = Vozac.Prezime;
            dtpDatumRod.Value = DateTime.Parse(Vozac.DatumRodjenja);
            dtpOd.Value = DateTime.Parse(Vozac.VazenjeDozvoleOd);
            dtpDo.Value = DateTime.Parse(Vozac.VazenjeDozvoleDo);
            tbDozvola.Text = Vozac.BrojDozvole;
            tbMesto.Text = Vozac.MestoIzdavanjaDozvole;
            cbPol.SelectedItem = Vozac.Pol;
            pbSlika.ImageLocation = Vozac.PathDoSlike;
        }

        private void UcitajDGV()
        {
            dgvKategorija.DataSource = prListaKategorija.ToList();
            dgvZabrana.DataSource = prListaZabrana.ToList();

            if (dgvKategorija.RowCount > 0 )
                btnObrisiKat.Enabled = true;
            else
                btnObrisiKat.Enabled = false;

            if (dgvZabrana.RowCount > 0)
                btnObrisiZab.Enabled = true;
            else
                btnObrisiZab.Enabled = false;
        }

        private DialogResult ZatvoriFormu()
        {
            return MessageBox.Show("Da li ste sigurni da zelite da zatvorite formu?", "Zatvaranje forme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
