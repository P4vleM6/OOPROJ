namespace Aplikacija
{
    partial class FormListaVozaca
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
            this.components = new System.ComponentModel.Container();
            this.gbListaVozaca = new System.Windows.Forms.GroupBox();
            this.dgvListaVozaca = new System.Windows.Forms.DataGridView();
            this.btnSort = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.lblTacnoVreme = new System.Windows.Forms.Label();
            this.tmrTacnoVreme = new System.Windows.Forms.Timer(this.components);
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.gbListaVozaca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVozaca)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListaVozaca
            // 
            this.gbListaVozaca.Controls.Add(this.dgvListaVozaca);
            this.gbListaVozaca.Controls.Add(this.btnIzmeni);
            this.gbListaVozaca.Controls.Add(this.btnDodaj);
            this.gbListaVozaca.Controls.Add(this.btnObrisi);
            this.gbListaVozaca.Location = new System.Drawing.Point(12, 45);
            this.gbListaVozaca.Name = "gbListaVozaca";
            this.gbListaVozaca.Size = new System.Drawing.Size(654, 315);
            this.gbListaVozaca.TabIndex = 0;
            this.gbListaVozaca.TabStop = false;
            this.gbListaVozaca.Text = "Lista vozaca";
            // 
            // dgvListaVozaca
            // 
            this.dgvListaVozaca.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListaVozaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVozaca.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListaVozaca.Location = new System.Drawing.Point(6, 19);
            this.dgvListaVozaca.Name = "dgvListaVozaca";
            this.dgvListaVozaca.Size = new System.Drawing.Size(642, 241);
            this.dgvListaVozaca.TabIndex = 3;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(432, 16);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(87, 21);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sortiraj";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Broj vozacke dozvole",
            "Ime",
            "Prezime"});
            this.cbSort.Location = new System.Drawing.Point(525, 16);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(141, 21);
            this.cbSort.TabIndex = 2;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // lblTacnoVreme
            // 
            this.lblTacnoVreme.AutoSize = true;
            this.lblTacnoVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacnoVreme.Location = new System.Drawing.Point(15, 18);
            this.lblTacnoVreme.Name = "lblTacnoVreme";
            this.lblTacnoVreme.Size = new System.Drawing.Size(47, 15);
            this.lblTacnoVreme.TabIndex = 3;
            this.lblTacnoVreme.Text = "label1";
            // 
            // tmrTacnoVreme
            // 
            this.tmrTacnoVreme.Tick += new System.EventHandler(this.tmrTacnoVreme_Tick);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Image = global::Aplikacija.Properties.Resources.edit;
            this.btnIzmeni.Location = new System.Drawing.Point(99, 266);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(87, 42);
            this.btnIzmeni.TabIndex = 2;
            this.btnIzmeni.Text = "Izmeni vozaca";
            this.btnIzmeni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Image = global::Aplikacija.Properties.Resources.add;
            this.btnDodaj.Location = new System.Drawing.Point(6, 266);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(87, 42);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj vozaca";
            this.btnDodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Image = global::Aplikacija.Properties.Resources.delete;
            this.btnObrisi.Location = new System.Drawing.Point(561, 266);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(87, 43);
            this.btnObrisi.TabIndex = 0;
            this.btnObrisi.Text = "Obrisi vozaca";
            this.btnObrisi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // FormListaVozaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 369);
            this.Controls.Add(this.lblTacnoVreme);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.gbListaVozaca);
            this.MaximizeBox = false;
            this.Name = "FormListaVozaca";
            this.Text = "Lista vozaca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormListaVozaca_FormClosing);
            this.Load += new System.EventHandler(this.FormListaVozaca_Load);
            this.gbListaVozaca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVozaca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListaVozaca;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvListaVozaca;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label lblTacnoVreme;
        private System.Windows.Forms.Timer tmrTacnoVreme;
    }
}

