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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace OOPJlab3
{
    public partial class Form1 : Form
    {
        private List<Osoba> osobe = OsobeSingleton.Instance.Osobe;
        private Osoba izabranaOsoba = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            string pattern = @"^\+381 \d{2} \d{7}$";
            if (!Regex.IsMatch(telefon.Text, pattern))
            {
                MessageBox.Show("Telefon mora biti u formatu +381 XX XXXXXXX");
                telefon.Focus();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            datumRodjenja.Text = datumRodjenja.Value.ToString("dd.MM.yyyy.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ime.Text) || string.IsNullOrWhiteSpace(prezime.Text) || string.IsNullOrWhiteSpace(telefon.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            if (izabranaOsoba != null)
            {
                izabranaOsoba.Ime = ime.Text;
                izabranaOsoba.Prezime = prezime.Text;
                izabranaOsoba.Telefon = telefon.Text;
                izabranaOsoba.DatumRodjenja = datumRodjenja.Value;

                izabranaOsoba = null;
            }
            else
            {
                Osoba nova = new Osoba(ime.Text, prezime.Text, telefon.Text, datumRodjenja.Value);
                osobe.Insert(0, nova);
            }

            ListaOsoba.DataSource = null;
            ListaOsoba.DataSource = osobe;

            ime.Focus();
            MessageBox.Show("Osoba je zapamcena!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ime.Clear();
            prezime.Clear();
            telefon.Clear();
            datumRodjenja.Value = DateTime.Now;
            MessageBox.Show("Sva polja su ponistena!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ListaOsoba.SelectedItem is Osoba o)
            {
                osobe.Remove(o);
                ListaOsoba.DataSource = null;
                ListaOsoba.DataSource = osobe;
            }
            MessageBox.Show("Osoba je obrisana!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            osobe.Clear();

            ListaOsoba.DataSource = null;
            ListaOsoba.DataSource = osobe;

            MessageBox.Show("Lista osoba je obrisana!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Da li ste sigurni da želite zatvoriti aplikaciju?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sort.Items.Add("PO IMENU");
            sort.Items.Add("PO PREZIMENU");
            sort.Items.Add("PO DATUMU ROĐENJA");
            sort.SelectedIndex = 0;
        }

        private void sortirajListu_Click(object sender, EventArgs e)
        {
            Osoba.SortDelegate kriterijum;
            switch (sort.SelectedItem.ToString())
            {
                case "PO IMENU":
                    kriterijum = Osoba.PorediPoImenu;
                    break;
                case "PO PREZIMENU":
                    kriterijum = Osoba.PorediPoPrezimenu;
                    break;
                case "PO DATUMU ROĐENJA":
                    kriterijum = Osoba.PorediPoDatumu;
                    break;
                default:
                    return;
            }

            osobe.Sort(new Comparison<Osoba>(kriterijum));

            ListaOsoba.DataSource = null;
            ListaOsoba.DataSource = osobe;

            MessageBox.Show("Lista osoba je sortirana!");
        }

        private void ListaOsoba_DoubleClick(object sender, EventArgs e)
        {
            if (ListaOsoba.SelectedItem is Osoba o)
            {
                izabranaOsoba = o;
                ime.Text = o.Ime;
                prezime.Text = o.Prezime;
                telefon.Text = o.Telefon;
                datumRodjenja.Value = o.DatumRodjenja;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            string vreme = Osoba.FormatirajDatum(DateTime.Now);
            MessageBox.Show(vreme, "Trenutno vreme");
        }
    }
}
