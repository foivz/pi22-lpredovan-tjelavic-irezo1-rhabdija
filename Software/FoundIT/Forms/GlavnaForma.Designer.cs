
namespace FoundIT.Forms
{
    partial class GlavnaForma
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
            this.uxNavigacija = new System.Windows.Forms.FlowLayoutPanel();
            this.imeOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxNavigacija
            // 
            this.uxNavigacija.Location = new System.Drawing.Point(12, 51);
            this.uxNavigacija.Name = "uxNavigacija";
            this.uxNavigacija.Size = new System.Drawing.Size(1374, 63);
            this.uxNavigacija.TabIndex = 0;
            // 
            // imeOutput
            // 
            this.imeOutput.AutoSize = true;
            this.imeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imeOutput.Location = new System.Drawing.Point(13, 13);
            this.imeOutput.Name = "imeOutput";
            this.imeOutput.Size = new System.Drawing.Size(53, 20);
            this.imeOutput.TabIndex = 1;
            this.imeOutput.Text = "label1";
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 753);
            this.Controls.Add(this.imeOutput);
            this.Controls.Add(this.uxNavigacija);
            this.Name = "GlavnaForma";
            this.Text = "FoundIT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GlavnaForma_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel uxNavigacija;
        private System.Windows.Forms.Label imeOutput;
    }
}