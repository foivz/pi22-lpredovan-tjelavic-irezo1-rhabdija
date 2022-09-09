
namespace FoundIT.UserControls
{
    partial class StatistikaUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewStatistika = new System.Windows.Forms.DataGridView();
            this.buttonKupci = new System.Windows.Forms.Button();
            this.buttonZanrovi = new System.Windows.Forms.Button();
            this.buttonArtikli = new System.Windows.Forms.Button();
            this.buttonVratiSe = new System.Windows.Forms.Button();
            this.labelKojaStatistika = new System.Windows.Forms.Label();
            this.buttonNedostupni = new System.Windows.Forms.Button();
            this.buttonArtikliKupnja = new System.Windows.Forms.Button();
            this.buttonVrijemeKupnje = new System.Windows.Forms.Button();
            this.buttonProsliMjesec = new System.Windows.Forms.Button();
            this.buttonPredprosliMjesec = new System.Windows.Forms.Button();
            this.buttonOvajMjesec = new System.Windows.Forms.Button();
            this.buttonSveMjeseci = new System.Windows.Forms.Button();
            this.buttonSortirajUzlazno = new System.Windows.Forms.Button();
            this.buttonSortirajSilazno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistika)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 44);
            this.label1.TabIndex = 30;
            this.label1.Text = "Interna statistika";
            // 
            // dataGridViewStatistika
            // 
            this.dataGridViewStatistika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistika.Location = new System.Drawing.Point(11, 126);
            this.dataGridViewStatistika.Name = "dataGridViewStatistika";
            this.dataGridViewStatistika.RowHeadersWidth = 51;
            this.dataGridViewStatistika.RowTemplate.Height = 24;
            this.dataGridViewStatistika.Size = new System.Drawing.Size(1188, 379);
            this.dataGridViewStatistika.TabIndex = 31;
            // 
            // buttonKupci
            // 
            this.buttonKupci.Location = new System.Drawing.Point(650, 73);
            this.buttonKupci.Name = "buttonKupci";
            this.buttonKupci.Size = new System.Drawing.Size(154, 44);
            this.buttonKupci.TabIndex = 32;
            this.buttonKupci.Text = "Najčešći kupci";
            this.buttonKupci.UseVisualStyleBackColor = true;
            this.buttonKupci.Click += new System.EventHandler(this.buttonKupci_Click);
            // 
            // buttonZanrovi
            // 
            this.buttonZanrovi.Location = new System.Drawing.Point(491, 73);
            this.buttonZanrovi.Name = "buttonZanrovi";
            this.buttonZanrovi.Size = new System.Drawing.Size(153, 44);
            this.buttonZanrovi.TabIndex = 33;
            this.buttonZanrovi.Text = "Najpopularniji žanrovi";
            this.buttonZanrovi.UseVisualStyleBackColor = true;
            this.buttonZanrovi.Click += new System.EventHandler(this.buttonZanrovi_Click);
            // 
            // buttonArtikli
            // 
            this.buttonArtikli.Location = new System.Drawing.Point(171, 73);
            this.buttonArtikli.Name = "buttonArtikli";
            this.buttonArtikli.Size = new System.Drawing.Size(154, 44);
            this.buttonArtikli.TabIndex = 35;
            this.buttonArtikli.Text = "Najomiljeniji artikli";
            this.buttonArtikli.UseVisualStyleBackColor = true;
            this.buttonArtikli.Click += new System.EventHandler(this.buttonArtikli_Click);
            // 
            // buttonVratiSe
            // 
            this.buttonVratiSe.Location = new System.Drawing.Point(1205, 465);
            this.buttonVratiSe.Name = "buttonVratiSe";
            this.buttonVratiSe.Size = new System.Drawing.Size(86, 40);
            this.buttonVratiSe.TabIndex = 36;
            this.buttonVratiSe.Text = "Vrati se";
            this.buttonVratiSe.UseVisualStyleBackColor = true;
            this.buttonVratiSe.Click += new System.EventHandler(this.buttonVratiSe_Click);
            // 
            // labelKojaStatistika
            // 
            this.labelKojaStatistika.AutoSize = true;
            this.labelKojaStatistika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKojaStatistika.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelKojaStatistika.Location = new System.Drawing.Point(15, 82);
            this.labelKojaStatistika.Name = "labelKojaStatistika";
            this.labelKojaStatistika.Size = new System.Drawing.Size(20, 24);
            this.labelKojaStatistika.TabIndex = 37;
            this.labelKojaStatistika.Text = "x";
            // 
            // buttonNedostupni
            // 
            this.buttonNedostupni.Location = new System.Drawing.Point(331, 73);
            this.buttonNedostupni.Name = "buttonNedostupni";
            this.buttonNedostupni.Size = new System.Drawing.Size(154, 44);
            this.buttonNedostupni.TabIndex = 39;
            this.buttonNedostupni.Text = "Nedostupni artikli";
            this.buttonNedostupni.UseVisualStyleBackColor = true;
            this.buttonNedostupni.Click += new System.EventHandler(this.buttonNedostupni_Click);
            // 
            // buttonArtikliKupnja
            // 
            this.buttonArtikliKupnja.Location = new System.Drawing.Point(11, 73);
            this.buttonArtikliKupnja.Name = "buttonArtikliKupnja";
            this.buttonArtikliKupnja.Size = new System.Drawing.Size(154, 44);
            this.buttonArtikliKupnja.TabIndex = 40;
            this.buttonArtikliKupnja.Text = "Najpopularniji artikli";
            this.buttonArtikliKupnja.UseVisualStyleBackColor = true;
            this.buttonArtikliKupnja.Click += new System.EventHandler(this.buttonArtikliKupnja_Click);
            // 
            // buttonVrijemeKupnje
            // 
            this.buttonVrijemeKupnje.Location = new System.Drawing.Point(810, 73);
            this.buttonVrijemeKupnje.Name = "buttonVrijemeKupnje";
            this.buttonVrijemeKupnje.Size = new System.Drawing.Size(154, 44);
            this.buttonVrijemeKupnje.TabIndex = 42;
            this.buttonVrijemeKupnje.Text = "Vrijeme recenzija";
            this.buttonVrijemeKupnje.UseVisualStyleBackColor = true;
            this.buttonVrijemeKupnje.Click += new System.EventHandler(this.buttonVrijemeKupnje_Click);
            // 
            // buttonProsliMjesec
            // 
            this.buttonProsliMjesec.Location = new System.Drawing.Point(1205, 229);
            this.buttonProsliMjesec.Name = "buttonProsliMjesec";
            this.buttonProsliMjesec.Size = new System.Drawing.Size(154, 44);
            this.buttonProsliMjesec.TabIndex = 43;
            this.buttonProsliMjesec.Text = "Prošli mjesec";
            this.buttonProsliMjesec.UseVisualStyleBackColor = true;
            this.buttonProsliMjesec.Click += new System.EventHandler(this.buttonProsliMjesec_Click);
            // 
            // buttonPredprosliMjesec
            // 
            this.buttonPredprosliMjesec.Location = new System.Drawing.Point(1205, 179);
            this.buttonPredprosliMjesec.Name = "buttonPredprosliMjesec";
            this.buttonPredprosliMjesec.Size = new System.Drawing.Size(154, 44);
            this.buttonPredprosliMjesec.TabIndex = 44;
            this.buttonPredprosliMjesec.Text = "Predprošli mjesec";
            this.buttonPredprosliMjesec.UseVisualStyleBackColor = true;
            this.buttonPredprosliMjesec.Click += new System.EventHandler(this.buttonPredprosliMjesec_Click);
            // 
            // buttonOvajMjesec
            // 
            this.buttonOvajMjesec.Location = new System.Drawing.Point(1205, 279);
            this.buttonOvajMjesec.Name = "buttonOvajMjesec";
            this.buttonOvajMjesec.Size = new System.Drawing.Size(154, 44);
            this.buttonOvajMjesec.TabIndex = 45;
            this.buttonOvajMjesec.Text = "Ovaj mjesec";
            this.buttonOvajMjesec.UseVisualStyleBackColor = true;
            this.buttonOvajMjesec.Click += new System.EventHandler(this.buttonOvajMjesec_Click);
            // 
            // buttonSveMjeseci
            // 
            this.buttonSveMjeseci.Location = new System.Drawing.Point(1205, 126);
            this.buttonSveMjeseci.Name = "buttonSveMjeseci";
            this.buttonSveMjeseci.Size = new System.Drawing.Size(154, 44);
            this.buttonSveMjeseci.TabIndex = 46;
            this.buttonSveMjeseci.Text = "Sve";
            this.buttonSveMjeseci.UseVisualStyleBackColor = true;
            this.buttonSveMjeseci.Click += new System.EventHandler(this.buttonSveMjeseci_Click);
            // 
            // buttonSortirajUzlazno
            // 
            this.buttonSortirajUzlazno.Location = new System.Drawing.Point(1205, 179);
            this.buttonSortirajUzlazno.Name = "buttonSortirajUzlazno";
            this.buttonSortirajUzlazno.Size = new System.Drawing.Size(154, 44);
            this.buttonSortirajUzlazno.TabIndex = 47;
            this.buttonSortirajUzlazno.Text = "Sortiraj uzlazno";
            this.buttonSortirajUzlazno.UseVisualStyleBackColor = true;
            this.buttonSortirajUzlazno.Click += new System.EventHandler(this.buttonSortirajUzlazno_Click);
            // 
            // buttonSortirajSilazno
            // 
            this.buttonSortirajSilazno.Location = new System.Drawing.Point(1205, 126);
            this.buttonSortirajSilazno.Name = "buttonSortirajSilazno";
            this.buttonSortirajSilazno.Size = new System.Drawing.Size(154, 44);
            this.buttonSortirajSilazno.TabIndex = 48;
            this.buttonSortirajSilazno.Text = "Sortiraj silazno";
            this.buttonSortirajSilazno.UseVisualStyleBackColor = true;
            this.buttonSortirajSilazno.Click += new System.EventHandler(this.buttonSortirajSilazno_Click);
            // 
            // StatistikaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSortirajSilazno);
            this.Controls.Add(this.buttonSortirajUzlazno);
            this.Controls.Add(this.buttonSveMjeseci);
            this.Controls.Add(this.buttonOvajMjesec);
            this.Controls.Add(this.buttonPredprosliMjesec);
            this.Controls.Add(this.buttonProsliMjesec);
            this.Controls.Add(this.buttonVrijemeKupnje);
            this.Controls.Add(this.buttonArtikliKupnja);
            this.Controls.Add(this.buttonNedostupni);
            this.Controls.Add(this.labelKojaStatistika);
            this.Controls.Add(this.buttonVratiSe);
            this.Controls.Add(this.buttonArtikli);
            this.Controls.Add(this.buttonZanrovi);
            this.Controls.Add(this.buttonKupci);
            this.Controls.Add(this.dataGridViewStatistika);
            this.Controls.Add(this.label1);
            this.Name = "StatistikaUC";
            this.Size = new System.Drawing.Size(1429, 523);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewStatistika;
        private System.Windows.Forms.Button buttonKupci;
        private System.Windows.Forms.Button buttonZanrovi;
        private System.Windows.Forms.Button buttonArtikli;
        private System.Windows.Forms.Button buttonVratiSe;
        private System.Windows.Forms.Label labelKojaStatistika;
        private System.Windows.Forms.Button buttonNedostupni;
        private System.Windows.Forms.Button buttonArtikliKupnja;
        private System.Windows.Forms.Button buttonVrijemeKupnje;
        private System.Windows.Forms.Button buttonProsliMjesec;
        private System.Windows.Forms.Button buttonPredprosliMjesec;
        private System.Windows.Forms.Button buttonOvajMjesec;
        private System.Windows.Forms.Button buttonSveMjeseci;
        private System.Windows.Forms.Button buttonSortirajUzlazno;
        private System.Windows.Forms.Button buttonSortirajSilazno;
    }
}
