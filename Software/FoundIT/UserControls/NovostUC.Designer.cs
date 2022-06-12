
namespace FoundIT.UserControls
{
    partial class NovostUC
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
            this.naslovOutput = new System.Windows.Forms.Label();
            this.datumOutput = new System.Windows.Forms.Label();
            this.kategorijaOutput = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sadrzajOutput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // naslovOutput
            // 
            this.naslovOutput.AutoSize = true;
            this.naslovOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslovOutput.Location = new System.Drawing.Point(13, 10);
            this.naslovOutput.Name = "naslovOutput";
            this.naslovOutput.Size = new System.Drawing.Size(87, 29);
            this.naslovOutput.TabIndex = 2;
            this.naslovOutput.Text = "Naslov";
            // 
            // datumOutput
            // 
            this.datumOutput.AutoSize = true;
            this.datumOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumOutput.Location = new System.Drawing.Point(6, 29);
            this.datumOutput.Name = "datumOutput";
            this.datumOutput.Size = new System.Drawing.Size(59, 20);
            this.datumOutput.TabIndex = 3;
            this.datumOutput.Text = "Datum";
            // 
            // kategorijaOutput
            // 
            this.kategorijaOutput.AutoSize = true;
            this.kategorijaOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategorijaOutput.Location = new System.Drawing.Point(6, 61);
            this.kategorijaOutput.Name = "kategorijaOutput";
            this.kategorijaOutput.Size = new System.Drawing.Size(84, 20);
            this.kategorijaOutput.TabIndex = 4;
            this.kategorijaOutput.Text = "Kategorija";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datumOutput);
            this.groupBox1.Controls.Add(this.kategorijaOutput);
            this.groupBox1.Location = new System.Drawing.Point(679, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 87);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // sadrzajOutput
            // 
            this.sadrzajOutput.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sadrzajOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sadrzajOutput.ForeColor = System.Drawing.Color.White;
            this.sadrzajOutput.Location = new System.Drawing.Point(18, 73);
            this.sadrzajOutput.Multiline = true;
            this.sadrzajOutput.Name = "sadrzajOutput";
            this.sadrzajOutput.Size = new System.Drawing.Size(642, 140);
            this.sadrzajOutput.TabIndex = 6;
            // 
            // NovostUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.sadrzajOutput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.naslovOutput);
            this.Name = "NovostUC";
            this.Size = new System.Drawing.Size(869, 226);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label naslovOutput;
        private System.Windows.Forms.Label datumOutput;
        private System.Windows.Forms.Label kategorijaOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox sadrzajOutput;
    }
}
