
namespace FoundIT.Forms
{
    partial class OstaviRecenziju
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
            this.buttonPosalji = new System.Windows.Forms.Button();
            this.textBoxSadrzaj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOcjene = new System.Windows.Forms.ComboBox();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.textBoxGreskaOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPosalji
            // 
            this.buttonPosalji.Location = new System.Drawing.Point(604, 329);
            this.buttonPosalji.Name = "buttonPosalji";
            this.buttonPosalji.Size = new System.Drawing.Size(75, 27);
            this.buttonPosalji.TabIndex = 22;
            this.buttonPosalji.Text = "Pošalji";
            this.buttonPosalji.UseVisualStyleBackColor = true;
            this.buttonPosalji.Click += new System.EventHandler(this.buttonPosalji_Click);
            // 
            // textBoxSadrzaj
            // 
            this.textBoxSadrzaj.Location = new System.Drawing.Point(281, 139);
            this.textBoxSadrzaj.Multiline = true;
            this.textBoxSadrzaj.Name = "textBoxSadrzaj";
            this.textBoxSadrzaj.Size = new System.Drawing.Size(299, 217);
            this.textBoxSadrzaj.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Sadržaj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ocjena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ostavi recenziju za";
            // 
            // comboBoxOcjene
            // 
            this.comboBoxOcjene.FormattingEnabled = true;
            this.comboBoxOcjene.Location = new System.Drawing.Point(76, 139);
            this.comboBoxOcjene.Name = "comboBoxOcjene";
            this.comboBoxOcjene.Size = new System.Drawing.Size(100, 24);
            this.comboBoxOcjene.TabIndex = 23;
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaziv.Location = new System.Drawing.Point(18, 45);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(17, 20);
            this.labelNaziv.TabIndex = 33;
            this.labelNaziv.Text = "x";
            // 
            // textBoxGreskaOutput
            // 
            this.textBoxGreskaOutput.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxGreskaOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxGreskaOutput.Location = new System.Drawing.Point(604, 262);
            this.textBoxGreskaOutput.Multiline = true;
            this.textBoxGreskaOutput.Name = "textBoxGreskaOutput";
            this.textBoxGreskaOutput.Size = new System.Drawing.Size(170, 61);
            this.textBoxGreskaOutput.TabIndex = 36;
            this.textBoxGreskaOutput.Visible = false;
            // 
            // OstaviRecenziju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxGreskaOutput);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.comboBoxOcjene);
            this.Controls.Add(this.buttonPosalji);
            this.Controls.Add(this.textBoxSadrzaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OstaviRecenziju";
            this.Text = "OstaviRecenziju";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPosalji;
        private System.Windows.Forms.TextBox textBoxSadrzaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOcjene;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.TextBox textBoxGreskaOutput;
    }
}