namespace Aplikacija
{
    partial class FormZabrana
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
            this.cbKat = new System.Windows.Forms.ComboBox();
            this.lblKat = new System.Windows.Forms.Label();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.lblOd = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbKat
            // 
            this.cbKat.FormattingEnabled = true;
            this.cbKat.Location = new System.Drawing.Point(109, 20);
            this.cbKat.Name = "cbKat";
            this.cbKat.Size = new System.Drawing.Size(133, 21);
            this.cbKat.TabIndex = 0;
            // 
            // lblKat
            // 
            this.lblKat.AutoSize = true;
            this.lblKat.Location = new System.Drawing.Point(46, 23);
            this.lblKat.Name = "lblKat";
            this.lblKat.Size = new System.Drawing.Size(57, 13);
            this.lblKat.TabIndex = 1;
            this.lblKat.Text = "Kategorija:";
            // 
            // dtpOd
            // 
            this.dtpOd.CustomFormat = "dd.MM.yyyy.";
            this.dtpOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOd.Location = new System.Drawing.Point(109, 47);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(103, 20);
            this.dtpOd.TabIndex = 2;
            // 
            // dtpDo
            // 
            this.dtpDo.CustomFormat = "dd.MM.yyyy.";
            this.dtpDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDo.Location = new System.Drawing.Point(109, 73);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(103, 20);
            this.dtpDo.TabIndex = 3;
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Location = new System.Drawing.Point(46, 51);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(56, 13);
            this.lblOd.TabIndex = 4;
            this.lblOd.Text = "Datum od:";
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Location = new System.Drawing.Point(46, 77);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(56, 13);
            this.lblDo.TabIndex = 5;
            this.lblDo.Text = "Datum do:";
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(60, 103);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(77, 30);
            this.btnProsledi.TabIndex = 6;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(161, 103);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(77, 30);
            this.btnZatvori.TabIndex = 7;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // FormZabrana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 147);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.lblDo);
            this.Controls.Add(this.lblOd);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.lblKat);
            this.Controls.Add(this.cbKat);
            this.MaximizeBox = false;
            this.Name = "FormZabrana";
            this.Text = "Zabrana";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormZabrana_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKat;
        private System.Windows.Forms.Label lblKat;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Button btnZatvori;
    }
}