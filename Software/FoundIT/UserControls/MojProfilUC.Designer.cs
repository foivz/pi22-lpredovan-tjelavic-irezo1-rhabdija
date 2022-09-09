
namespace FoundIT.UserControls
{
    partial class MojProfilUC
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.naslovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nakladaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaUvezaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jezikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izdanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brStranicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.naslovOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.emailSpremiClick = new System.Windows.Forms.Button();
            this.emailTextInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lozinkaSpremiClick = new System.Windows.Forms.Button();
            this.lozinkatextInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.obavijestSpremiClick = new System.Windows.Forms.Button();
            this.obavijestInput = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.slikaClick = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.buttonOstaviRecenziju = new System.Windows.Forms.Button();
            this.textBoxGreskaOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naslovDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.nakladaDataGridViewTextBoxColumn,
            this.vrstaUvezaDataGridViewTextBoxColumn,
            this.jezikDataGridViewTextBoxColumn,
            this.izdanjeDataGridViewTextBoxColumn,
            this.brStranicaDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.zanrDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.artiklBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 345);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(954, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // naslovDataGridViewTextBoxColumn
            // 
            this.naslovDataGridViewTextBoxColumn.DataPropertyName = "Naslov";
            this.naslovDataGridViewTextBoxColumn.HeaderText = "Naslov";
            this.naslovDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.naslovDataGridViewTextBoxColumn.Name = "naslovDataGridViewTextBoxColumn";
            this.naslovDataGridViewTextBoxColumn.ReadOnly = true;
            this.naslovDataGridViewTextBoxColumn.Width = 125;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            this.autorDataGridViewTextBoxColumn.Width = 125;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cijenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            this.opisDataGridViewTextBoxColumn.Width = 125;
            // 
            // nakladaDataGridViewTextBoxColumn
            // 
            this.nakladaDataGridViewTextBoxColumn.DataPropertyName = "Naklada";
            this.nakladaDataGridViewTextBoxColumn.HeaderText = "Naklada";
            this.nakladaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nakladaDataGridViewTextBoxColumn.Name = "nakladaDataGridViewTextBoxColumn";
            this.nakladaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nakladaDataGridViewTextBoxColumn.Width = 125;
            // 
            // vrstaUvezaDataGridViewTextBoxColumn
            // 
            this.vrstaUvezaDataGridViewTextBoxColumn.DataPropertyName = "VrstaUveza";
            this.vrstaUvezaDataGridViewTextBoxColumn.HeaderText = "VrstaUveza";
            this.vrstaUvezaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vrstaUvezaDataGridViewTextBoxColumn.Name = "vrstaUvezaDataGridViewTextBoxColumn";
            this.vrstaUvezaDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrstaUvezaDataGridViewTextBoxColumn.Width = 125;
            // 
            // jezikDataGridViewTextBoxColumn
            // 
            this.jezikDataGridViewTextBoxColumn.DataPropertyName = "Jezik";
            this.jezikDataGridViewTextBoxColumn.HeaderText = "Jezik";
            this.jezikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jezikDataGridViewTextBoxColumn.Name = "jezikDataGridViewTextBoxColumn";
            this.jezikDataGridViewTextBoxColumn.ReadOnly = true;
            this.jezikDataGridViewTextBoxColumn.Width = 125;
            // 
            // izdanjeDataGridViewTextBoxColumn
            // 
            this.izdanjeDataGridViewTextBoxColumn.DataPropertyName = "Izdanje";
            this.izdanjeDataGridViewTextBoxColumn.HeaderText = "Izdanje";
            this.izdanjeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.izdanjeDataGridViewTextBoxColumn.Name = "izdanjeDataGridViewTextBoxColumn";
            this.izdanjeDataGridViewTextBoxColumn.ReadOnly = true;
            this.izdanjeDataGridViewTextBoxColumn.Width = 125;
            // 
            // brStranicaDataGridViewTextBoxColumn
            // 
            this.brStranicaDataGridViewTextBoxColumn.DataPropertyName = "BrStranica";
            this.brStranicaDataGridViewTextBoxColumn.HeaderText = "BrStranica";
            this.brStranicaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brStranicaDataGridViewTextBoxColumn.Name = "brStranicaDataGridViewTextBoxColumn";
            this.brStranicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.brStranicaDataGridViewTextBoxColumn.Width = 125;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            this.iSBNDataGridViewTextBoxColumn.Width = 125;
            // 
            // zanrDataGridViewTextBoxColumn
            // 
            this.zanrDataGridViewTextBoxColumn.DataPropertyName = "Zanr";
            this.zanrDataGridViewTextBoxColumn.HeaderText = "Zanr";
            this.zanrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zanrDataGridViewTextBoxColumn.Name = "zanrDataGridViewTextBoxColumn";
            this.zanrDataGridViewTextBoxColumn.ReadOnly = true;
            this.zanrDataGridViewTextBoxColumn.Width = 125;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(FoundIT.Models.Artikl);
            // 
            // naslovOutput
            // 
            this.naslovOutput.AutoSize = true;
            this.naslovOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslovOutput.Location = new System.Drawing.Point(6, 303);
            this.naslovOutput.Name = "naslovOutput";
            this.naslovOutput.Size = new System.Drawing.Size(138, 29);
            this.naslovOutput.TabIndex = 3;
            this.naslovOutput.Text = "Moje knjige";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 44);
            this.label1.TabIndex = 29;
            this.label1.Text = "Moj profil";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.emailSpremiClick);
            this.groupBox1.Controls.Add(this.emailTextInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(719, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 124);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moji podaci";
            // 
            // emailSpremiClick
            // 
            this.emailSpremiClick.Location = new System.Drawing.Point(316, 85);
            this.emailSpremiClick.Name = "emailSpremiClick";
            this.emailSpremiClick.Size = new System.Drawing.Size(75, 33);
            this.emailSpremiClick.TabIndex = 33;
            this.emailSpremiClick.Text = "Spremi";
            this.emailSpremiClick.UseVisualStyleBackColor = true;
            this.emailSpremiClick.Click += new System.EventHandler(this.emailSpremiClick_Click);
            // 
            // emailTextInput
            // 
            this.emailTextInput.Location = new System.Drawing.Point(11, 75);
            this.emailTextInput.Name = "emailTextInput";
            this.emailTextInput.Size = new System.Drawing.Size(186, 22);
            this.emailTextInput.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Promijeni email";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lozinkaSpremiClick);
            this.groupBox2.Controls.Add(this.lozinkatextInput);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(719, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 124);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Moji podaci";
            // 
            // lozinkaSpremiClick
            // 
            this.lozinkaSpremiClick.Location = new System.Drawing.Point(316, 86);
            this.lozinkaSpremiClick.Name = "lozinkaSpremiClick";
            this.lozinkaSpremiClick.Size = new System.Drawing.Size(75, 32);
            this.lozinkaSpremiClick.TabIndex = 32;
            this.lozinkaSpremiClick.Text = "Spremi";
            this.lozinkaSpremiClick.UseVisualStyleBackColor = true;
            this.lozinkaSpremiClick.Click += new System.EventHandler(this.lozinkaSpremiClick_Click);
            // 
            // lozinkatextInput
            // 
            this.lozinkatextInput.Location = new System.Drawing.Point(11, 75);
            this.lozinkatextInput.Name = "lozinkatextInput";
            this.lozinkatextInput.PasswordChar = '*';
            this.lozinkatextInput.Size = new System.Drawing.Size(186, 22);
            this.lozinkatextInput.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Promijeni lozinku";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.obavijestSpremiClick);
            this.groupBox3.Controls.Add(this.obavijestInput);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(302, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 124);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Moji podaci";
            // 
            // obavijestSpremiClick
            // 
            this.obavijestSpremiClick.Location = new System.Drawing.Point(316, 85);
            this.obavijestSpremiClick.Name = "obavijestSpremiClick";
            this.obavijestSpremiClick.Size = new System.Drawing.Size(75, 33);
            this.obavijestSpremiClick.TabIndex = 6;
            this.obavijestSpremiClick.Text = "Spremi";
            this.obavijestSpremiClick.UseVisualStyleBackColor = true;
            this.obavijestSpremiClick.Click += new System.EventHandler(this.obavijestSpremiClick_Click);
            // 
            // obavijestInput
            // 
            this.obavijestInput.AutoSize = true;
            this.obavijestInput.Location = new System.Drawing.Point(11, 75);
            this.obavijestInput.Name = "obavijestInput";
            this.obavijestInput.Size = new System.Drawing.Size(124, 21);
            this.obavijestInput.TabIndex = 5;
            this.obavijestInput.Text = "Primaj obvijesti";
            this.obavijestInput.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Primaj obavijesti";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(11, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // slikaClick
            // 
            this.slikaClick.Location = new System.Drawing.Point(235, 249);
            this.slikaClick.Name = "slikaClick";
            this.slikaClick.Size = new System.Drawing.Size(98, 33);
            this.slikaClick.TabIndex = 7;
            this.slikaClick.Text = "Učitaj sliku";
            this.slikaClick.UseVisualStyleBackColor = true;
            this.slikaClick.Click += new System.EventHandler(this.slikaClick_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "FoundIT.chm";
            // 
            // buttonOstaviRecenziju
            // 
            this.buttonOstaviRecenziju.Location = new System.Drawing.Point(963, 345);
            this.buttonOstaviRecenziju.Name = "buttonOstaviRecenziju";
            this.buttonOstaviRecenziju.Size = new System.Drawing.Size(170, 46);
            this.buttonOstaviRecenziju.TabIndex = 34;
            this.buttonOstaviRecenziju.Text = "Ostavi recenziju";
            this.buttonOstaviRecenziju.UseVisualStyleBackColor = true;
            this.buttonOstaviRecenziju.Click += new System.EventHandler(this.buttonOstaviRecenziju_Click);
            // 
            // textBoxGreskaOutput
            // 
            this.textBoxGreskaOutput.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxGreskaOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxGreskaOutput.Location = new System.Drawing.Point(963, 397);
            this.textBoxGreskaOutput.Multiline = true;
            this.textBoxGreskaOutput.Name = "textBoxGreskaOutput";
            this.textBoxGreskaOutput.Size = new System.Drawing.Size(170, 61);
            this.textBoxGreskaOutput.TabIndex = 35;
            this.textBoxGreskaOutput.Visible = false;
            // 
            // MojProfilUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxGreskaOutput);
            this.Controls.Add(this.buttonOstaviRecenziju);
            this.Controls.Add(this.slikaClick);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.naslovOutput);
            this.Controls.Add(this.dataGridView1);
            this.helpProvider1.SetHelpKeyword(this, "moj_profil");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Name = "MojProfilUC";
            this.helpProvider1.SetShowHelp(this, true);
            this.Size = new System.Drawing.Size(1136, 635);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label naslovOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nakladaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaUvezaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jezikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izdanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brStranicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanrDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private System.Windows.Forms.TextBox emailTextInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox lozinkatextInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox obavijestInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button emailSpremiClick;
        private System.Windows.Forms.Button lozinkaSpremiClick;
        private System.Windows.Forms.Button obavijestSpremiClick;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button slikaClick;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button buttonOstaviRecenziju;
        private System.Windows.Forms.TextBox textBoxGreskaOutput;
    }
}
