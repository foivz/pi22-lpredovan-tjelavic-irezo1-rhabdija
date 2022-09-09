
namespace FoundIT.UserControls
{
    partial class ArtiklUC
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
            this.labelNaslov = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.labelCijena = new System.Windows.Forms.Label();
            this.labelDostupnost = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelProsjecnaOcjena = new System.Windows.Forms.Label();
            this.labelBrojFavorita = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRecenzije = new System.Windows.Forms.Button();
            this.buttonDodajFavorit = new System.Windows.Forms.Button();
            this.textBoxGreskaOutput = new System.Windows.Forms.TextBox();
            this.buttonUkloniFavorit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaslov.Location = new System.Drawing.Point(13, 13);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(99, 29);
            this.labelNaslov.TabIndex = 4;
            this.labelNaslov.Text = "naslovX";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutor.Location = new System.Drawing.Point(13, 63);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(66, 24);
            this.labelAutor.TabIndex = 5;
            this.labelAutor.Text = "autorX";
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpis.Location = new System.Drawing.Point(15, 156);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(46, 18);
            this.labelOpis.TabIndex = 6;
            this.labelOpis.Text = "opisX";
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCijena.Location = new System.Drawing.Point(13, 103);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(81, 24);
            this.labelCijena.TabIndex = 7;
            this.labelCijena.Text = "cijenaX";
            // 
            // labelDostupnost
            // 
            this.labelDostupnost.AutoSize = true;
            this.labelDostupnost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDostupnost.Location = new System.Drawing.Point(166, 103);
            this.labelDostupnost.Name = "labelDostupnost";
            this.labelDostupnost.Size = new System.Drawing.Size(102, 20);
            this.labelDostupnost.TabIndex = 8;
            this.labelDostupnost.Text = "dostupnostX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Prosječna ocjena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Broj favorita:";
            // 
            // labelProsjecnaOcjena
            // 
            this.labelProsjecnaOcjena.AutoSize = true;
            this.labelProsjecnaOcjena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProsjecnaOcjena.Location = new System.Drawing.Point(157, 12);
            this.labelProsjecnaOcjena.Name = "labelProsjecnaOcjena";
            this.labelProsjecnaOcjena.Size = new System.Drawing.Size(22, 25);
            this.labelProsjecnaOcjena.TabIndex = 11;
            this.labelProsjecnaOcjena.Text = "x";
            // 
            // labelBrojFavorita
            // 
            this.labelBrojFavorita.AutoSize = true;
            this.labelBrojFavorita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrojFavorita.Location = new System.Drawing.Point(157, 48);
            this.labelBrojFavorita.Name = "labelBrojFavorita";
            this.labelBrojFavorita.Size = new System.Drawing.Size(22, 25);
            this.labelBrojFavorita.TabIndex = 12;
            this.labelBrojFavorita.Text = "x";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelBrojFavorita);
            this.groupBox1.Controls.Add(this.labelProsjecnaOcjena);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(624, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 88);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // buttonRecenzije
            // 
            this.buttonRecenzije.BackColor = System.Drawing.SystemColors.WindowText;
            this.buttonRecenzije.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRecenzije.Location = new System.Drawing.Point(711, 185);
            this.buttonRecenzije.Name = "buttonRecenzije";
            this.buttonRecenzije.Size = new System.Drawing.Size(145, 39);
            this.buttonRecenzije.TabIndex = 14;
            this.buttonRecenzije.Text = "Idi na recenzije";
            this.buttonRecenzije.UseVisualStyleBackColor = false;
            this.buttonRecenzije.Click += new System.EventHandler(this.buttonRecenzije_Click);
            // 
            // buttonDodajFavorit
            // 
            this.buttonDodajFavorit.BackColor = System.Drawing.SystemColors.WindowText;
            this.buttonDodajFavorit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDodajFavorit.Location = new System.Drawing.Point(560, 185);
            this.buttonDodajFavorit.Name = "buttonDodajFavorit";
            this.buttonDodajFavorit.Size = new System.Drawing.Size(145, 39);
            this.buttonDodajFavorit.TabIndex = 15;
            this.buttonDodajFavorit.Text = "Dodaj u favorite";
            this.buttonDodajFavorit.UseVisualStyleBackColor = false;
            this.buttonDodajFavorit.Click += new System.EventHandler(this.buttonDodajFavorit_Click);
            // 
            // textBoxGreskaOutput
            // 
            this.textBoxGreskaOutput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxGreskaOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxGreskaOutput.Location = new System.Drawing.Point(346, 185);
            this.textBoxGreskaOutput.Multiline = true;
            this.textBoxGreskaOutput.Name = "textBoxGreskaOutput";
            this.textBoxGreskaOutput.Size = new System.Drawing.Size(208, 39);
            this.textBoxGreskaOutput.TabIndex = 33;
            this.textBoxGreskaOutput.Visible = false;
            // 
            // buttonUkloniFavorit
            // 
            this.buttonUkloniFavorit.BackColor = System.Drawing.SystemColors.WindowText;
            this.buttonUkloniFavorit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUkloniFavorit.Location = new System.Drawing.Point(711, 185);
            this.buttonUkloniFavorit.Name = "buttonUkloniFavorit";
            this.buttonUkloniFavorit.Size = new System.Drawing.Size(145, 39);
            this.buttonUkloniFavorit.TabIndex = 34;
            this.buttonUkloniFavorit.Text = "Ukloni iz favorita";
            this.buttonUkloniFavorit.UseVisualStyleBackColor = false;
            this.buttonUkloniFavorit.Click += new System.EventHandler(this.buttonUkloniFavorit_Click);
            // 
            // ArtiklUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.buttonUkloniFavorit);
            this.Controls.Add(this.textBoxGreskaOutput);
            this.Controls.Add(this.buttonDodajFavorit);
            this.Controls.Add(this.buttonRecenzije);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelDostupnost);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelNaslov);
            this.Name = "ArtiklUC";
            this.Size = new System.Drawing.Size(869, 227);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.Label labelCijena;
        private System.Windows.Forms.Label labelDostupnost;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelProsjecnaOcjena;
        private System.Windows.Forms.Label labelBrojFavorita;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRecenzije;
        private System.Windows.Forms.Button buttonDodajFavorit;
        private System.Windows.Forms.TextBox textBoxGreskaOutput;
        private System.Windows.Forms.Button buttonUkloniFavorit;
    }
}
