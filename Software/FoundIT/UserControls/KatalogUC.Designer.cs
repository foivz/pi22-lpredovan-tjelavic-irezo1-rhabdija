
namespace FoundIT.UserControls
{
    partial class KatalogUC
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
            this.controlFlowKatalog = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 44);
            this.label1.TabIndex = 29;
            this.label1.Text = "Katalog knjiga i stripova";
            // 
            // controlFlowKatalog
            // 
            this.controlFlowKatalog.AutoScroll = true;
            this.controlFlowKatalog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlFlowKatalog.Location = new System.Drawing.Point(11, 104);
            this.controlFlowKatalog.Name = "controlFlowKatalog";
            this.controlFlowKatalog.Size = new System.Drawing.Size(914, 484);
            this.controlFlowKatalog.TabIndex = 39;
            // 
            // KatalogUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlFlowKatalog);
            this.Controls.Add(this.label1);
            this.Name = "KatalogUC";
            this.Size = new System.Drawing.Size(1065, 591);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel controlFlowKatalog;
    }
}
