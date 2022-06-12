
namespace FoundIT.UserControls
{
    partial class NaslovnicaKnjigeUC
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
            this.uxPrikazClick = new System.Windows.Forms.Button();
            this.uxControlFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // uxPrikazClick
            // 
            this.uxPrikazClick.Location = new System.Drawing.Point(934, 574);
            this.uxPrikazClick.Name = "uxPrikazClick";
            this.uxPrikazClick.Size = new System.Drawing.Size(75, 43);
            this.uxPrikazClick.TabIndex = 1;
            this.uxPrikazClick.Text = "Promjeni prikaz";
            this.uxPrikazClick.UseVisualStyleBackColor = true;
            this.uxPrikazClick.Click += new System.EventHandler(this.uxPrikazClick_Click);
            // 
            // uxControlFlow
            // 
            this.uxControlFlow.AutoScroll = true;
            this.uxControlFlow.Location = new System.Drawing.Point(14, 111);
            this.uxControlFlow.Name = "uxControlFlow";
            this.uxControlFlow.Size = new System.Drawing.Size(914, 506);
            this.uxControlFlow.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 44);
            this.label1.TabIndex = 28;
            this.label1.Text = "Top knjige";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "FoundIT.chm";
            // 
            // NaslovnicaKnjigeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxControlFlow);
            this.Controls.Add(this.uxPrikazClick);
            this.helpProvider1.SetHelpKeyword(this, "top_knjige");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Name = "NaslovnicaKnjigeUC";
            this.helpProvider1.SetShowHelp(this, true);
            this.Size = new System.Drawing.Size(1136, 635);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxPrikazClick;
        private System.Windows.Forms.FlowLayoutPanel uxControlFlow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
