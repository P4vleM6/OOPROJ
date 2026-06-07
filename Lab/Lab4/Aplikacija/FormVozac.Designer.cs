namespace Aplikacija
{
    partial class FormVozac
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPodaci = new System.Windows.Forms.GroupBox();
            this.btnSlika = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.lblPol = new System.Windows.Forms.Label();
            this.lblMesto = new System.Windows.Forms.Label();
            this.lblBrDozvole = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.lblOd = new System.Windows.Forms.Label();
            this.lblDatumRod = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.cbPol = new System.Windows.Forms.ComboBox();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumRod = new System.Windows.Forms.DateTimePicker();
            this.tbMesto = new System.Windows.Forms.TextBox();
            this.tbDozvola = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.gbKategorija = new System.Windows.Forms.GroupBox();
            this.btnDodajKat = new System.Windows.Forms.Button();
            this.btnObrisiKat = new System.Windows.Forms.Button();
            this.dgvKategorija = new System.Windows.Forms.DataGridView();
            this.gbZabrana = new System.Windows.Forms.GroupBox();
            this.btnDodajZab = new System.Windows.Forms.Button();
            this.btnObrisiZab = new System.Windows.Forms.Button();
            this.dgvZabrana = new System.Windows.Forms.DataGridView();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.gbPodaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.gbKategorija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorija)).BeginInit();
            this.gbZabrana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZabrana)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPodaci
            // 
            this.gbPodaci.Controls.Add(this.btnSlika);
            this.gbPodaci.Controls.Add(this.pbSlika);
            this.gbPodaci.Controls.Add(this.lblPol);
            this.gbPodaci.Controls.Add(this.lblMesto);
            this.gbPodaci.Controls.Add(this.lblBrDozvole);
            this.gbPodaci.Controls.Add(this.lblDo);
            this.gbPodaci.Controls.Add(this.lblOd);
            this.gbPodaci.Controls.Add(this.lblDatumRod);
            this.gbPodaci.Controls.Add(this.lblPrezime);
            this.gbPodaci.Controls.Add(this.lblIme);
            this.gbPodaci.Controls.Add(this.cbPol);
            this.gbPodaci.Controls.Add(this.dtpDo);
            this.gbPodaci.Controls.Add(this.dtpOd);
            this.gbPodaci.Controls.Add(this.dtpDatumRod);
            this.gbPodaci.Controls.Add(this.tbMesto);
            this.gbPodaci.Controls.Add(this.tbDozvola);
            this.gbPodaci.Controls.Add(this.tbPrezime);
            this.gbPodaci.Controls.Add(this.tbIme);
            this.gbPodaci.Location = new System.Drawing.Point(12, 12);
            this.gbPodaci.Name = "gbPodaci";
            this.gbPodaci.Size = new System.Drawing.Size(464, 267);
            this.gbPodaci.TabIndex = 0;
            this.gbPodaci.TabStop = false;
            this.gbPodaci.Text = "Osnovni podaci";
            // 
            // btnSlika
            // 
            this.btnSlika.Location = new System.Drawing.Point(317, 185);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(76, 32);
            this.btnSlika.TabIndex = 17;
            this.btnSlika.Text = "Dodaj sliku";
            this.btnSlika.UseVisualStyleBackColor = true;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(280, 24);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(155, 155);
            this.pbSlika.TabIndex = 16;
            this.pbSlika.TabStop = false;
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.Location = new System.Drawing.Point(96, 235);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(25, 13);
            this.lblPol.TabIndex = 15;
            this.lblPol.Text = "Pol:";
            // 
            // lblMesto
            // 
            this.lblMesto.AutoSize = true;
            this.lblMesto.Location = new System.Drawing.Point(34, 204);
            this.lblMesto.Name = "lblMesto";
            this.lblMesto.Size = new System.Drawing.Size(87, 13);
            this.lblMesto.TabIndex = 14;
            this.lblMesto.Text = "Mesto izdavanja:";
            // 
            // lblBrDozvole
            // 
            this.lblBrDozvole.AutoSize = true;
            this.lblBrDozvole.Location = new System.Drawing.Point(14, 178);
            this.lblBrDozvole.Name = "lblBrDozvole";
            this.lblBrDozvole.Size = new System.Drawing.Size(107, 13);
            this.lblBrDozvole.TabIndex = 13;
            this.lblBrDozvole.Text = "Br. vozacke dozvole:";
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Location = new System.Drawing.Point(102, 152);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(19, 13);
            this.lblDo.TabIndex = 12;
            this.lblDo.Text = "do";
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Location = new System.Drawing.Point(21, 126);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(100, 13);
            this.lblOd.TabIndex = 11;
            this.lblOd.Text = "Vazenje dozvole od";
            // 
            // lblDatumRod
            // 
            this.lblDatumRod.AutoSize = true;
            this.lblDatumRod.Location = new System.Drawing.Point(40, 87);
            this.lblDatumRod.Name = "lblDatumRod";
            this.lblDatumRod.Size = new System.Drawing.Size(81, 13);
            this.lblDatumRod.TabIndex = 10;
            this.lblDatumRod.Text = "Datum rodjenja:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(74, 52);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 9;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(94, 26);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 8;
            this.lblIme.Text = "Ime:";
            // 
            // cbPol
            // 
            this.cbPol.FormattingEnabled = true;
            this.cbPol.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.cbPol.Location = new System.Drawing.Point(135, 232);
            this.cbPol.Name = "cbPol";
            this.cbPol.Size = new System.Drawing.Size(113, 21);
            this.cbPol.TabIndex = 7;
            // 
            // dtpDo
            // 
            this.dtpDo.CustomFormat = "dd.MM.yyyy.";
            this.dtpDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDo.Location = new System.Drawing.Point(135, 148);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(113, 20);
            this.dtpDo.TabIndex = 6;
            // 
            // dtpOd
            // 
            this.dtpOd.CustomFormat = "dd.MM.yyyy.";
            this.dtpOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOd.Location = new System.Drawing.Point(135, 122);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(113, 20);
            this.dtpOd.TabIndex = 5;
            // 
            // dtpDatumRod
            // 
            this.dtpDatumRod.CustomFormat = "dd.MM.yyy.";
            this.dtpDatumRod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumRod.Location = new System.Drawing.Point(135, 83);
            this.dtpDatumRod.Name = "dtpDatumRod";
            this.dtpDatumRod.Size = new System.Drawing.Size(113, 20);
            this.dtpDatumRod.TabIndex = 4;
            // 
            // tbMesto
            // 
            this.tbMesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMesto.Location = new System.Drawing.Point(135, 202);
            this.tbMesto.Name = "tbMesto";
            this.tbMesto.Size = new System.Drawing.Size(113, 20);
            this.tbMesto.TabIndex = 3;
            this.tbMesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMesto_KeyPress);
            // 
            // tbDozvola
            // 
            this.tbDozvola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDozvola.Location = new System.Drawing.Point(135, 176);
            this.tbDozvola.MaxLength = 9;
            this.tbDozvola.Name = "tbDozvola";
            this.tbDozvola.Size = new System.Drawing.Size(113, 20);
            this.tbDozvola.TabIndex = 2;
            this.tbDozvola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDozvola_KeyPress);
            // 
            // tbPrezime
            // 
            this.tbPrezime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrezime.Location = new System.Drawing.Point(135, 50);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(113, 20);
            this.tbPrezime.TabIndex = 1;
            this.tbPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrezime_KeyPress);
            // 
            // tbIme
            // 
            this.tbIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIme.Location = new System.Drawing.Point(135, 24);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(113, 20);
            this.tbIme.TabIndex = 0;
            this.tbIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIme_KeyPress);
            // 
            // gbKategorija
            // 
            this.gbKategorija.Controls.Add(this.btnDodajKat);
            this.gbKategorija.Controls.Add(this.btnObrisiKat);
            this.gbKategorija.Controls.Add(this.dgvKategorija);
            this.gbKategorija.Location = new System.Drawing.Point(12, 292);
            this.gbKategorija.Name = "gbKategorija";
            this.gbKategorija.Size = new System.Drawing.Size(464, 179);
            this.gbKategorija.TabIndex = 1;
            this.gbKategorija.TabStop = false;
            this.gbKategorija.Text = "Kategorija";
            // 
            // btnDodajKat
            // 
            this.btnDodajKat.Image = global::Aplikacija.Properties.Resources.add;
            this.btnDodajKat.Location = new System.Drawing.Point(6, 131);
            this.btnDodajKat.Name = "btnDodajKat";
            this.btnDodajKat.Size = new System.Drawing.Size(137, 41);
            this.btnDodajKat.TabIndex = 2;
            this.btnDodajKat.Text = "Dodaj novu kategoriju";
            this.btnDodajKat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajKat.UseVisualStyleBackColor = true;
            this.btnDodajKat.Click += new System.EventHandler(this.btnDodajKat_Click);
            // 
            // btnObrisiKat
            // 
            this.btnObrisiKat.Image = global::Aplikacija.Properties.Resources.delete;
            this.btnObrisiKat.Location = new System.Drawing.Point(376, 131);
            this.btnObrisiKat.Name = "btnObrisiKat";
            this.btnObrisiKat.Size = new System.Drawing.Size(82, 41);
            this.btnObrisiKat.TabIndex = 1;
            this.btnObrisiKat.Text = "Obrisi kategoriju";
            this.btnObrisiKat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisiKat.UseVisualStyleBackColor = true;
            this.btnObrisiKat.Click += new System.EventHandler(this.btnObrisiKat_Click);
            // 
            // dgvKategorija
            // 
            this.dgvKategorija.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKategorija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategorija.Location = new System.Drawing.Point(6, 19);
            this.dgvKategorija.Name = "dgvKategorija";
            this.dgvKategorija.Size = new System.Drawing.Size(452, 106);
            this.dgvKategorija.TabIndex = 0;
            // 
            // gbZabrana
            // 
            this.gbZabrana.Controls.Add(this.btnDodajZab);
            this.gbZabrana.Controls.Add(this.btnObrisiZab);
            this.gbZabrana.Controls.Add(this.dgvZabrana);
            this.gbZabrana.Location = new System.Drawing.Point(12, 485);
            this.gbZabrana.Name = "gbZabrana";
            this.gbZabrana.Size = new System.Drawing.Size(464, 180);
            this.gbZabrana.TabIndex = 2;
            this.gbZabrana.TabStop = false;
            this.gbZabrana.Text = "Zabrana upravljanja";
            // 
            // btnDodajZab
            // 
            this.btnDodajZab.Image = global::Aplikacija.Properties.Resources.add;
            this.btnDodajZab.Location = new System.Drawing.Point(6, 133);
            this.btnDodajZab.Name = "btnDodajZab";
            this.btnDodajZab.Size = new System.Drawing.Size(137, 41);
            this.btnDodajZab.TabIndex = 3;
            this.btnDodajZab.Text = "Dodaj novu zabranu";
            this.btnDodajZab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajZab.UseVisualStyleBackColor = true;
            this.btnDodajZab.Click += new System.EventHandler(this.btnDodajZab_Click);
            // 
            // btnObrisiZab
            // 
            this.btnObrisiZab.Image = global::Aplikacija.Properties.Resources.delete;
            this.btnObrisiZab.Location = new System.Drawing.Point(376, 133);
            this.btnObrisiZab.Name = "btnObrisiZab";
            this.btnObrisiZab.Size = new System.Drawing.Size(82, 41);
            this.btnObrisiZab.TabIndex = 1;
            this.btnObrisiZab.Text = "Obrisi zabranu";
            this.btnObrisiZab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisiZab.UseVisualStyleBackColor = true;
            this.btnObrisiZab.Click += new System.EventHandler(this.btnObrisiZab_Click);
            // 
            // dgvZabrana
            // 
            this.dgvZabrana.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvZabrana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZabrana.Location = new System.Drawing.Point(6, 21);
            this.dgvZabrana.Name = "dgvZabrana";
            this.dgvZabrana.Size = new System.Drawing.Size(452, 106);
            this.dgvZabrana.TabIndex = 0;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(252, 671);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(92, 30);
            this.btnZatvori.TabIndex = 3;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(142, 671);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(92, 30);
            this.btnProsledi.TabIndex = 4;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // FormVozac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 708);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.gbZabrana);
            this.Controls.Add(this.gbKategorija);
            this.Controls.Add(this.gbPodaci);
            this.MaximizeBox = false;
            this.Name = "FormVozac";
            this.Text = "Vozac";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVozac_FormClosing);
            this.Load += new System.EventHandler(this.FormVozac_Load);
            this.gbPodaci.ResumeLayout(false);
            this.gbPodaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.gbKategorija.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorija)).EndInit();
            this.gbZabrana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZabrana)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPodaci;
        private System.Windows.Forms.GroupBox gbKategorija;
        private System.Windows.Forms.GroupBox gbZabrana;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDatumRod;
        private System.Windows.Forms.TextBox tbMesto;
        private System.Windows.Forms.TextBox tbDozvola;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.ComboBox cbPol;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.Label lblDatumRod;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPol;
        private System.Windows.Forms.Label lblMesto;
        private System.Windows.Forms.Label lblBrDozvole;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.DataGridView dgvKategorija;
        private System.Windows.Forms.Button btnDodajKat;
        private System.Windows.Forms.Button btnObrisiKat;
        private System.Windows.Forms.Button btnDodajZab;
        private System.Windows.Forms.Button btnObrisiZab;
        private System.Windows.Forms.DataGridView dgvZabrana;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnProsledi;
    }
}