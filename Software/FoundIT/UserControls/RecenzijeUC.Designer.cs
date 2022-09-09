
namespace FoundIT.UserControls
{
    partial class RecenzijeUC
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
            this.buttonPovratakKatalog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.controlFlowRecenzije = new System.Windows.Forms.FlowLayoutPanel();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPovratakKatalog
            // 
            this.buttonPovratakKatalog.Location = new System.Drawing.Point(691, 506);
            this.buttonPovratakKatalog.Name = "buttonPovratakKatalog";
            this.buttonPovratakKatalog.Size = new System.Drawing.Size(108, 46);
            this.buttonPovratakKatalog.TabIndex = 0;
            this.buttonPovratakKatalog.Text = "Vrati se na katalog";
            this.buttonPovratakKatalog.UseVisualStyleBackColor = true;
            this.buttonPovratakKatalog.Click += new System.EventHandler(this.buttonPovratakKatalog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 44);
            this.label1.TabIndex = 29;
            this.label1.Text = "Čitate recenzije za ";
            // 
            // controlFlowRecenzije
            // 
            this.controlFlowRecenzije.AutoScroll = true;
            this.controlFlowRecenzije.Location = new System.Drawing.Point(26, 163);
            this.controlFlowRecenzije.Name = "controlFlowRecenzije";
            this.controlFlowRecenzije.Size = new System.Drawing.Size(648, 389);
            this.controlFlowRecenzije.TabIndex = 31;
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaziv.Location = new System.Drawing.Point(27, 95);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(29, 32);
            this.labelNaziv.TabIndex = 32;
            this.labelNaziv.Text = "x";
            // 
            // RecenzijeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.controlFlowRecenzije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPovratakKatalog);
            this.Name = "RecenzijeUC";
            this.Size = new System.Drawing.Size(1282, 579);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPovratakKatalog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel controlFlowRecenzije;
        private System.Windows.Forms.Label labelNaziv;
    }
}
