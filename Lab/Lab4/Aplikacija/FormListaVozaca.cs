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
    public partial class FormListaVozaca : Form
    {
        public FormListaVozaca()
        {
            InitializeComponent();
        }

        private void FormListaVozaca_Load(object sender, EventArgs e)
        {
            lblTacnoVreme.Text = string.Empty;
            tmrTacnoVreme.Start();

            //cbSort.SelectedIndex = 0;

            UcitajPodatke();
        }

        private void tmrTacnoVreme_Tick(object sender, EventArgs e)
        {
            String str = DateTime.Now.ToString("HH.mm.ss dd.MM.yyyy.");
            lblTacnoVreme.Text = str;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var form = new FormVozac();
            DialogResult dr = form.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                UcitajPodatke();
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvListaVozaca.SelectedRows.Count == 0)
                return;

            int selectedRow = dgvListaVozaca.SelectedRows[0].Index;
            string brDozvole = (string)dgvListaVozaca.Rows[selectedRow].Cells[2].Value;

            Vozac v = ListaVozaca.Instance.GetVozac(brDozvole);

            var form = new FormVozac(v);
            DialogResult dr = form.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                UcitajPodatke();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvListaVozaca.SelectedRows.Count == 0)
                return;

            DialogResult dr = MessageBox.Show("Da li ste sigurni da želite da obrišete ovog vozača?", "Brisanje vozača", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == System.Windows.Forms.DialogResult.No)
                return;

            int selectedRow = dgvListaVozaca.SelectedRows[0].Index;
            string brDozvole = (string)dgvListaVozaca.Rows[selectedRow].Cells[2].Value;

            Vozac v = ListaVozaca.Instance.GetVozac(brDozvole);

            if (ListaVozaca.Instance.ObrisiVozaca(v))
            {
                MessageBox.Show("Vozač je uspešno obrisan.", "Brisanje vozača", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UcitajPodatke();
            }
            else
            {
                MessageBox.Show("Došlo je do greške prilikom brisanja vozača.", "Brisanje vozača", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSort.SelectedIndex == 0)
                ListaVozaca.Instance.SortListDelegate = new ListaVozaca.SortDelegate(SortBrVozackeDozvole);
            else if (cbSort.SelectedIndex == 1)
                ListaVozaca.Instance.SortListDelegate = new ListaVozaca.SortDelegate(SortIme);
            else if (cbSort.SelectedIndex == 2)
                ListaVozaca.Instance.SortListDelegate = new ListaVozaca.SortDelegate(SortPrezime);
            
            UcitajPodatke();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            ListaVozaca.Instance.SortirajListu();
            UcitajPodatke();
        }

        private void FormListaVozaca_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = ZatvoriFormu();
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void UcitajPodatke()
        {
            dgvListaVozaca.DataSource = ListaVozaca.Instance.ListaVozacaVrednosti.ToList();

            if (dgvListaVozaca.RowCount > 0)
            {
                btnObrisi.Enabled = true;
                btnIzmeni.Enabled = true;
            }
            else
            {
                btnObrisi.Enabled = false;
                btnIzmeni.Enabled = false;
            }
        }

        private void SortBrVozackeDozvole(List<Vozac> v)
        {
            ListaVozaca.Instance.ListaVozacaVrednosti.Sort((v1, v2) => v1.BrojDozvole.CompareTo(v2.BrojDozvole));
        }

        private void SortIme(List<Vozac> v)
        {
            ListaVozaca.Instance.ListaVozacaVrednosti.Sort((v1, v2) => v1.Ime.CompareTo(v2.Ime));
        }

        private void SortPrezime(List<Vozac> v)
        {
            ListaVozaca.Instance.ListaVozacaVrednosti.Sort((v1, v2) => v1.Prezime.CompareTo(v2.Prezime));
        }

        private DialogResult ZatvoriFormu()
        {
            return MessageBox.Show("Da li ste sigurni da želite da zatvorite formu?", "Zatvaranje forme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
