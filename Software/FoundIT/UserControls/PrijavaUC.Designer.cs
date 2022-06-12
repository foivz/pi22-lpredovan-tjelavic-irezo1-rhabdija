
namespace FoundIT.UserControls
{
    partial class PrijavaUC
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
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextInput = new System.Windows.Forms.TextBox();
            this.lozinkaTextInput = new System.Windows.Forms.TextBox();
            this.prijavaClick = new System.Windows.Forms.Button();
            this.registracijaClick = new System.Windows.Forms.Button();
            this.uxGreskaOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prijava";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lozinka";
            // 
            // emailTextInput
            // 
            this.emailTextInput.Location = new System.Drawing.Point(330, 104);
            this.emailTextInput.Name = "emailTextInput";
            this.emailTextInput.Size = new System.Drawing.Size(186, 22);
            this.emailTextInput.TabIndex = 3;
            // 
            // lozinkaTextInput
            // 
            this.lozinkaTextInput.Location = new System.Drawing.Point(330, 208);
            this.lozinkaTextInput.Name = "lozinkaTextInput";
            this.lozinkaTextInput.PasswordChar = '*';
            this.lozinkaTextInput.Size = new System.Drawing.Size(186, 22);
            this.lozinkaTextInput.TabIndex = 4;
            // 
            // prijavaClick
            // 
            this.prijavaClick.Location = new System.Drawing.Point(330, 262);
            this.prijavaClick.Name = "prijavaClick";
            this.prijavaClick.Size = new System.Drawing.Size(81, 34);
            this.prijavaClick.TabIndex = 5;
            this.prijavaClick.Text = "Prijavi me";
            this.prijavaClick.UseVisualStyleBackColor = true;
            this.prijavaClick.Click += new System.EventHandler(this.prijavaClick_Click);
            // 
            // registracijaClick
            // 
            this.registracijaClick.Location = new System.Drawing.Point(681, 14);
            this.registracijaClick.Name = "registracijaClick";
            this.registracijaClick.Size = new System.Drawing.Size(97, 32);
            this.registracijaClick.TabIndex = 6;
            this.registracijaClick.Text = "Registracija";
            this.registracijaClick.UseVisualStyleBackColor = true;
            this.registracijaClick.Click += new System.EventHandler(this.registracijaClick_Click);
            // 
            // uxGreskaOutput
            // 
            this.uxGreskaOutput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.uxGreskaOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uxGreskaOutput.Location = new System.Drawing.Point(27, 235);
            this.uxGreskaOutput.Multiline = true;
            this.uxGreskaOutput.Name = "uxGreskaOutput";
            this.uxGreskaOutput.Size = new System.Drawing.Size(210, 192);
            this.uxGreskaOutput.TabIndex = 7;
            this.uxGreskaOutput.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(681, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 56);
            this.button1.TabIndex = 8;
            this.button1.Text = "Brza prijava admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "FoundIT.chm";
            // 
            // PrijavaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uxGreskaOutput);
            this.Controls.Add(this.registracijaClick);
            this.Controls.Add(this.prijavaClick);
            this.Controls.Add(this.lozinkaTextInput);
            this.Controls.Add(this.emailTextInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.helpProvider1.SetHelpKeyword(this, "prijava");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Name = "PrijavaUC";
            this.helpProvider1.SetShowHelp(this, true);
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTextInput;
        private System.Windows.Forms.TextBox lozinkaTextInput;
        private System.Windows.Forms.Button prijavaClick;
        private System.Windows.Forms.Button registracijaClick;
        private System.Windows.Forms.TextBox uxGreskaOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
