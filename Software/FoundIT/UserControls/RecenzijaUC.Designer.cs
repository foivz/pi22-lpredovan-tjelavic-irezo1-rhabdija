
namespace FoundIT.UserControls
{
    partial class RecenzijaUC
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
            this.datumOutput = new System.Windows.Forms.Label();
            this.korisnikOutput = new System.Windows.Forms.Label();
            this.ocjenaOutput = new System.Windows.Forms.Label();
            this.sadrzajOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Korisnik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ocjena:";
            // 
            // datumOutput
            // 
            this.datumOutput.AutoSize = true;
            this.datumOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumOutput.ForeColor = System.Drawing.SystemColors.GrayText;
            this.datumOutput.Location = new System.Drawing.Point(15, 11);
            this.datumOutput.Name = "datumOutput";
            this.datumOutput.Size = new System.Drawing.Size(24, 29);
            this.datumOutput.TabIndex = 8;
            this.datumOutput.Text = "x";
            // 
            // korisnikOutput
            // 
            this.korisnikOutput.AutoSize = true;
            this.korisnikOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korisnikOutput.Location = new System.Drawing.Point(127, 48);
            this.korisnikOutput.Name = "korisnikOutput";
            this.korisnikOutput.Size = new System.Drawing.Size(24, 29);
            this.korisnikOutput.TabIndex = 9;
            this.korisnikOutput.Text = "x";
            // 
            // ocjenaOutput
            // 
            this.ocjenaOutput.AutoSize = true;
            this.ocjenaOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocjenaOutput.Location = new System.Drawing.Point(504, 48);
            this.ocjenaOutput.Name = "ocjenaOutput";
            this.ocjenaOutput.Size = new System.Drawing.Size(24, 29);
            this.ocjenaOutput.TabIndex = 10;
            this.ocjenaOutput.Text = "x";
            // 
            // sadrzajOutput
            // 
            this.sadrzajOutput.AutoSize = true;
            this.sadrzajOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sadrzajOutput.Location = new System.Drawing.Point(127, 154);
            this.sadrzajOutput.Name = "sadrzajOutput";
            this.sadrzajOutput.Size = new System.Drawing.Size(24, 29);
            this.sadrzajOutput.TabIndex = 11;
            this.sadrzajOutput.Text = "x";
            this.sadrzajOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecenzijaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.sadrzajOutput);
            this.Controls.Add(this.ocjenaOutput);
            this.Controls.Add(this.korisnikOutput);
            this.Controls.Add(this.datumOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RecenzijaUC";
            this.Size = new System.Drawing.Size(559, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label datumOutput;
        private System.Windows.Forms.Label korisnikOutput;
        private System.Windows.Forms.Label ocjenaOutput;
        private System.Windows.Forms.Label sadrzajOutput;
    }
}
