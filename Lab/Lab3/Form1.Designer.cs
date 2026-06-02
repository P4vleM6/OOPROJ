namespace OOPJlab3
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AdresaStanovanja = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.TextBox();
            this.prezime = new System.Windows.Forms.TextBox();
            this.ime = new System.Windows.Forms.TextBox();
            this.ListaOsoba = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sort = new System.Windows.Forms.ComboBox();
            this.sortirajListu = new System.Windows.Forms.Button();
            this.obrisiListu = new System.Windows.Forms.Button();
            this.obrisiOsobu = new System.Windows.Forms.Button();
            this.ponisti = new System.Windows.Forms.Button();
            this.zapamti = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.ponisti);
            this.groupBox1.Controls.Add(this.zapamti);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AdresaStanovanja);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.datumRodjenja);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.telefon);
            this.groupBox1.Controls.Add(this.prezime);
            this.groupBox1.Controls.Add(this.ime);
            this.groupBox1.Location = new System.Drawing.Point(15, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o osobi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 61);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adresa stanovanja:";
            // 
            // AdresaStanovanja
            // 
            this.AdresaStanovanja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdresaStanovanja.FormattingEnabled = true;
            this.AdresaStanovanja.Location = new System.Drawing.Point(229, 77);
            this.AdresaStanovanja.Name = "AdresaStanovanja";
            this.AdresaStanovanja.ScrollAlwaysVisible = true;
            this.AdresaStanovanja.Size = new System.Drawing.Size(197, 41);
            this.AdresaStanovanja.TabIndex = 10;
            this.AdresaStanovanja.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datum rodjenja:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // datumRodjenja
            // 
            this.datumRodjenja.CustomFormat = "dd.MM.yyyy";
            this.datumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datumRodjenja.Location = new System.Drawing.Point(313, 29);
            this.datumRodjenja.Name = "datumRodjenja";
            this.datumRodjenja.Size = new System.Drawing.Size(113, 20);
            this.datumRodjenja.TabIndex = 6;
            this.datumRodjenja.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime:";
            // 
            // telefon
            // 
            this.telefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telefon.Location = new System.Drawing.Point(60, 98);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(148, 20);
            this.telefon.TabIndex = 2;
            this.telefon.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // prezime
            // 
            this.prezime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prezime.Location = new System.Drawing.Point(60, 63);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(148, 20);
            this.prezime.TabIndex = 1;
            this.prezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // ime
            // 
            this.ime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ime.Location = new System.Drawing.Point(60, 27);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(148, 20);
            this.ime.TabIndex = 0;
            this.ime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.ime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // ListaOsoba
            // 
            this.ListaOsoba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListaOsoba.FormattingEnabled = true;
            this.ListaOsoba.HorizontalScrollbar = true;
            this.ListaOsoba.Location = new System.Drawing.Point(15, 235);
            this.ListaOsoba.Name = "ListaOsoba";
            this.ListaOsoba.ScrollAlwaysVisible = true;
            this.ListaOsoba.Size = new System.Drawing.Size(443, 223);
            this.ListaOsoba.TabIndex = 1;
            this.ListaOsoba.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.ListaOsoba.DoubleClick += new System.EventHandler(this.ListaOsoba_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(170, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Lista osoba";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // sort
            // 
            this.sort.FormattingEnabled = true;
            this.sort.Location = new System.Drawing.Point(328, 476);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(130, 21);
            this.sort.TabIndex = 16;
            // 
            // sortirajListu
            // 
            this.sortirajListu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sortirajListu.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.sortirajListu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortirajListu.Image = global::OOPJlab3.Properties.Resources.sort_by;
            this.sortirajListu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sortirajListu.Location = new System.Drawing.Point(244, 467);
            this.sortirajListu.Name = "sortirajListu";
            this.sortirajListu.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.sortirajListu.Size = new System.Drawing.Size(78, 37);
            this.sortirajListu.TabIndex = 15;
            this.sortirajListu.Text = "Sortiraj listu";
            this.sortirajListu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sortirajListu.UseVisualStyleBackColor = false;
            this.sortirajListu.Click += new System.EventHandler(this.sortirajListu_Click);
            // 
            // obrisiListu
            // 
            this.obrisiListu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.obrisiListu.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.obrisiListu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obrisiListu.Image = global::OOPJlab3.Properties.Resources.delete;
            this.obrisiListu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.obrisiListu.Location = new System.Drawing.Point(127, 467);
            this.obrisiListu.Name = "obrisiListu";
            this.obrisiListu.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.obrisiListu.Size = new System.Drawing.Size(106, 37);
            this.obrisiListu.TabIndex = 14;
            this.obrisiListu.Text = "Obrisi listu osoba";
            this.obrisiListu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.obrisiListu.UseVisualStyleBackColor = false;
            this.obrisiListu.Click += new System.EventHandler(this.button4_Click);
            // 
            // obrisiOsobu
            // 
            this.obrisiOsobu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.obrisiOsobu.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.obrisiOsobu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obrisiOsobu.Image = global::OOPJlab3.Properties.Resources.remove;
            this.obrisiOsobu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.obrisiOsobu.Location = new System.Drawing.Point(15, 467);
            this.obrisiOsobu.Name = "obrisiOsobu";
            this.obrisiOsobu.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.obrisiOsobu.Size = new System.Drawing.Size(106, 37);
            this.obrisiOsobu.TabIndex = 13;
            this.obrisiOsobu.Text = "Obrisi izabranu osobu";
            this.obrisiOsobu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.obrisiOsobu.UseVisualStyleBackColor = false;
            this.obrisiOsobu.Click += new System.EventHandler(this.button3_Click);
            // 
            // ponisti
            // 
            this.ponisti.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ponisti.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ponisti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ponisti.Image = global::OOPJlab3.Properties.Resources.rubber;
            this.ponisti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ponisti.Location = new System.Drawing.Point(229, 127);
            this.ponisti.Name = "ponisti";
            this.ponisti.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.ponisti.Size = new System.Drawing.Size(106, 37);
            this.ponisti.TabIndex = 13;
            this.ponisti.Text = "Ponisti";
            this.ponisti.UseVisualStyleBackColor = false;
            this.ponisti.Click += new System.EventHandler(this.button2_Click);
            // 
            // zapamti
            // 
            this.zapamti.BackColor = System.Drawing.SystemColors.ControlLight;
            this.zapamti.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.zapamti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zapamti.Image = global::OOPJlab3.Properties.Resources.add__1_;
            this.zapamti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zapamti.Location = new System.Drawing.Point(102, 127);
            this.zapamti.Name = "zapamti";
            this.zapamti.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.zapamti.Size = new System.Drawing.Size(106, 37);
            this.zapamti.TabIndex = 12;
            this.zapamti.Text = "Zapamti";
            this.zapamti.UseVisualStyleBackColor = false;
            this.zapamti.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 519);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.sortirajListu);
            this.Controls.Add(this.obrisiListu);
            this.Controls.Add(this.obrisiOsobu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ListaOsoba);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "OOProjektovanje lab vezba 3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox prezime;
        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.DateTimePicker datumRodjenja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox AdresaStanovanja;
        private System.Windows.Forms.Button zapamti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ponisti;
        private System.Windows.Forms.ListBox ListaOsoba;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button obrisiOsobu;
        private System.Windows.Forms.Button obrisiListu;
        private System.Windows.Forms.Button sortirajListu;
        private System.Windows.Forms.ComboBox sort;
    }
}

