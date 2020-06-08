namespace TestiAppMF
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.luokkaSelect = new System.Windows.Forms.ComboBox();
            this.hakuButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kayttamattomatPDtButton = new System.Windows.Forms.Button();
            this.pdLuokkaMapButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pdLista = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.varastoyhteysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uusiYhteysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedVault = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Luokka:";
            // 
            // luokkaSelect
            // 
            this.luokkaSelect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luokkaSelect.FormattingEnabled = true;
            this.luokkaSelect.Location = new System.Drawing.Point(380, 73);
            this.luokkaSelect.Name = "luokkaSelect";
            this.luokkaSelect.Size = new System.Drawing.Size(171, 25);
            this.luokkaSelect.TabIndex = 3;
            // 
            // hakuButton
            // 
            this.hakuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hakuButton.Enabled = false;
            this.hakuButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hakuButton.Location = new System.Drawing.Point(380, 104);
            this.hakuButton.Name = "hakuButton";
            this.hakuButton.Size = new System.Drawing.Size(171, 31);
            this.hakuButton.TabIndex = 2;
            this.hakuButton.Text = "Hae luokan ominaisuudet";
            this.hakuButton.UseVisualStyleBackColor = true;
            this.hakuButton.Click += new System.EventHandler(this.HaeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox1.Location = new System.Drawing.Point(380, 141);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(380, 161);
            this.textBox1.TabIndex = 6;
            // 
            // kayttamattomatPDtButton
            // 
            this.kayttamattomatPDtButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kayttamattomatPDtButton.Enabled = false;
            this.kayttamattomatPDtButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayttamattomatPDtButton.Location = new System.Drawing.Point(380, 316);
            this.kayttamattomatPDtButton.Name = "kayttamattomatPDtButton";
            this.kayttamattomatPDtButton.Size = new System.Drawing.Size(251, 41);
            this.kayttamattomatPDtButton.TabIndex = 7;
            this.kayttamattomatPDtButton.Text = "Hae käyttämättömät ominaisuudet";
            this.kayttamattomatPDtButton.UseVisualStyleBackColor = true;
            this.kayttamattomatPDtButton.Click += new System.EventHandler(this.KayttamattomatPDtButton_Click);
            // 
            // pdLuokkaMapButton
            // 
            this.pdLuokkaMapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pdLuokkaMapButton.Enabled = false;
            this.pdLuokkaMapButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdLuokkaMapButton.Location = new System.Drawing.Point(589, 104);
            this.pdLuokkaMapButton.Name = "pdLuokkaMapButton";
            this.pdLuokkaMapButton.Size = new System.Drawing.Size(171, 31);
            this.pdLuokkaMapButton.TabIndex = 8;
            this.pdLuokkaMapButton.Text = "Hae luokat";
            this.pdLuokkaMapButton.UseVisualStyleBackColor = true;
            this.pdLuokkaMapButton.Click += new System.EventHandler(this.PdLuokkaMapButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(586, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ominaisuus:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 52);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(251, 311);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pdLista
            // 
            this.pdLista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdLista.FormattingEnabled = true;
            this.pdLista.Location = new System.Drawing.Point(589, 73);
            this.pdLista.Name = "pdLista";
            this.pdLista.Size = new System.Drawing.Size(171, 25);
            this.pdLista.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.varastoyhteysToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // varastoyhteysToolStripMenuItem
            // 
            this.varastoyhteysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uusiYhteysToolStripMenuItem,
            this.lopetaToolStripMenuItem});
            this.varastoyhteysToolStripMenuItem.Name = "varastoyhteysToolStripMenuItem";
            this.varastoyhteysToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.varastoyhteysToolStripMenuItem.Text = "Varastoyhteys";
            // 
            // uusiYhteysToolStripMenuItem
            // 
            this.uusiYhteysToolStripMenuItem.Name = "uusiYhteysToolStripMenuItem";
            this.uusiYhteysToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.uusiYhteysToolStripMenuItem.Text = "Uusi yhteys...";
            this.uusiYhteysToolStripMenuItem.Click += new System.EventHandler(this.UusiYhteysToolStripMenuItem_Click);
            // 
            // lopetaToolStripMenuItem
            // 
            this.lopetaToolStripMenuItem.Name = "lopetaToolStripMenuItem";
            this.lopetaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.lopetaToolStripMenuItem.Text = "Lopeta";
            this.lopetaToolStripMenuItem.Click += new System.EventHandler(this.LopetaToolStripMenuItem_Click);
            // 
            // selectedVault
            // 
            this.selectedVault.AutoSize = true;
            this.selectedVault.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedVault.Location = new System.Drawing.Point(377, 26);
            this.selectedVault.Name = "selectedVault";
            this.selectedVault.Size = new System.Drawing.Size(178, 17);
            this.selectedVault.TabIndex = 14;
            this.selectedVault.Text = "Ei varastoyhteyttä valittuna";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(380, 369);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(378, 75);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.selectedVault);
            this.Controls.Add(this.pdLista);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pdLuokkaMapButton);
            this.Controls.Add(this.kayttamattomatPDtButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.luokkaSelect);
            this.Controls.Add(this.hakuButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Rakennesovellus";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox luokkaSelect;
        private System.Windows.Forms.Button hakuButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button kayttamattomatPDtButton;
        private System.Windows.Forms.Button pdLuokkaMapButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox pdLista;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem varastoyhteysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uusiYhteysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lopetaToolStripMenuItem;
        private System.Windows.Forms.Label selectedVault;
        private System.Windows.Forms.TextBox textBox3;
    }
}

