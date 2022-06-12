
namespace FoundIT.Forms
{
    partial class DodajNovost
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
            this.label1 = new System.Windows.Forms.Label();
            this.uxNaslovInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxKategorijaInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uxSadrzajInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uxDatumInput = new System.Windows.Forms.DateTimePicker();
            this.uxDodajClick = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dodaj novost";
            // 
            // uxNaslovInput
            // 
            this.uxNaslovInput.Location = new System.Drawing.Point(17, 113);
            this.uxNaslovInput.Name = "uxNaslovInput";
            this.uxNaslovInput.Size = new System.Drawing.Size(186, 22);
            this.uxNaslovInput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naslov";
            // 
            // uxKategorijaInput
            // 
            this.uxKategorijaInput.Location = new System.Drawing.Point(17, 197);
            this.uxKategorijaInput.Name = "uxKategorijaInput";
            this.uxKategorijaInput.Size = new System.Drawing.Size(186, 22);
            this.uxKategorijaInput.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategorija";
            // 
            // uxSadrzajInput
            // 
            this.uxSadrzajInput.Location = new System.Drawing.Point(296, 113);
            this.uxSadrzajInput.Multiline = true;
            this.uxSadrzajInput.Name = "uxSadrzajInput";
            this.uxSadrzajInput.Size = new System.Drawing.Size(299, 217);
            this.uxSadrzajInput.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sadržaj";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Datum";
            // 
            // uxDatumInput
            // 
            this.uxDatumInput.Location = new System.Drawing.Point(17, 295);
            this.uxDatumInput.Name = "uxDatumInput";
            this.uxDatumInput.Size = new System.Drawing.Size(200, 22);
            this.uxDatumInput.TabIndex = 11;
            // 
            // uxDodajClick
            // 
            this.uxDodajClick.Location = new System.Drawing.Point(520, 363);
            this.uxDodajClick.Name = "uxDodajClick";
            this.uxDodajClick.Size = new System.Drawing.Size(75, 27);
            this.uxDodajClick.TabIndex = 12;
            this.uxDodajClick.Text = "Dodaj";
            this.uxDodajClick.UseVisualStyleBackColor = true;
            this.uxDodajClick.Click += new System.EventHandler(this.uxDodajClick_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "FoundIT.chm";
            // 
            // DodajNovost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 402);
            this.Controls.Add(this.uxDodajClick);
            this.Controls.Add(this.uxDatumInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uxSadrzajInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxKategorijaInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxNaslovInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.helpProvider1.SetHelpKeyword(this, "dodaj_novost");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Name = "DodajNovost";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "DodajNovost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxNaslovInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxKategorijaInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uxSadrzajInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker uxDatumInput;
        private System.Windows.Forms.Button uxDodajClick;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}