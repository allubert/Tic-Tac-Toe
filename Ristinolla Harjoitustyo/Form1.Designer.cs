namespace Ristinolla_Harjoitustyo
{
    partial class frmAloitus
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAloita = new System.Windows.Forms.Button();
            this.btnHae2 = new System.Windows.Forms.Button();
            this.btnHae1 = new System.Windows.Forms.Button();
            this.btnTallenna2 = new System.Windows.Forms.Button();
            this.btnTallenna1 = new System.Windows.Forms.Button();
            this.tbSyntvuosi2 = new System.Windows.Forms.TextBox();
            this.tbSuku2 = new System.Windows.Forms.TextBox();
            this.tbEtu2 = new System.Windows.Forms.TextBox();
            this.lblPelaaja2 = new System.Windows.Forms.Label();
            this.tbSyntvuosi = new System.Windows.Forms.TextBox();
            this.tbSuku1 = new System.Windows.Forms.TextBox();
            this.tbEtu1 = new System.Windows.Forms.TextBox();
            this.lblPelaaja1tiedot = new System.Windows.Forms.Label();
            this.btnPelaaja2 = new System.Windows.Forms.Button();
            this.btnTietokone = new System.Windows.Forms.Button();
            this.lblValinta = new System.Windows.Forms.Label();
            this.lblRistinolla = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saannotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAloita);
            this.panel1.Controls.Add(this.btnHae2);
            this.panel1.Controls.Add(this.btnHae1);
            this.panel1.Controls.Add(this.btnTallenna2);
            this.panel1.Controls.Add(this.btnTallenna1);
            this.panel1.Controls.Add(this.tbSyntvuosi2);
            this.panel1.Controls.Add(this.tbSuku2);
            this.panel1.Controls.Add(this.tbEtu2);
            this.panel1.Controls.Add(this.lblPelaaja2);
            this.panel1.Controls.Add(this.tbSyntvuosi);
            this.panel1.Controls.Add(this.tbSuku1);
            this.panel1.Controls.Add(this.tbEtu1);
            this.panel1.Controls.Add(this.lblPelaaja1tiedot);
            this.panel1.Controls.Add(this.btnPelaaja2);
            this.panel1.Controls.Add(this.btnTietokone);
            this.panel1.Controls.Add(this.lblValinta);
            this.panel1.Controls.Add(this.lblRistinolla);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // btnAloita
            // 
            this.btnAloita.Location = new System.Drawing.Point(686, 388);
            this.btnAloita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAloita.Name = "btnAloita";
            this.btnAloita.Size = new System.Drawing.Size(87, 35);
            this.btnAloita.TabIndex = 17;
            this.btnAloita.Text = "Aloita peli";
            this.btnAloita.UseVisualStyleBackColor = true;
            this.btnAloita.Click += new System.EventHandler(this.btnAloita_Click);
            // 
            // btnHae2
            // 
            this.btnHae2.Location = new System.Drawing.Point(145, 372);
            this.btnHae2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHae2.Name = "btnHae2";
            this.btnHae2.Size = new System.Drawing.Size(76, 28);
            this.btnHae2.TabIndex = 16;
            this.btnHae2.Text = "Hae";
            this.btnHae2.UseVisualStyleBackColor = true;
            this.btnHae2.Visible = false;
            // 
            // btnHae1
            // 
            this.btnHae1.Enabled = false;
            this.btnHae1.Location = new System.Drawing.Point(146, 292);
            this.btnHae1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHae1.Name = "btnHae1";
            this.btnHae1.Size = new System.Drawing.Size(75, 30);
            this.btnHae1.TabIndex = 15;
            this.btnHae1.Text = "Hae";
            this.btnHae1.UseVisualStyleBackColor = true;
            this.btnHae1.Click += new System.EventHandler(this.btnHae1_Click);
            // 
            // btnTallenna2
            // 
            this.btnTallenna2.Location = new System.Drawing.Point(36, 372);
            this.btnTallenna2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTallenna2.Name = "btnTallenna2";
            this.btnTallenna2.Size = new System.Drawing.Size(90, 28);
            this.btnTallenna2.TabIndex = 14;
            this.btnTallenna2.Text = "Tallenna";
            this.btnTallenna2.UseVisualStyleBackColor = true;
            this.btnTallenna2.Visible = false;
            this.btnTallenna2.Click += new System.EventHandler(this.btnTallenna1_Click);
            // 
            // btnTallenna1
            // 
            this.btnTallenna1.Location = new System.Drawing.Point(36, 292);
            this.btnTallenna1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTallenna1.Name = "btnTallenna1";
            this.btnTallenna1.Size = new System.Drawing.Size(90, 30);
            this.btnTallenna1.TabIndex = 13;
            this.btnTallenna1.Text = "Tallenna";
            this.btnTallenna1.UseVisualStyleBackColor = true;
            this.btnTallenna1.Click += new System.EventHandler(this.btnTallenna1_Click);
            // 
            // tbSyntvuosi2
            // 
            this.tbSyntvuosi2.Location = new System.Drawing.Point(602, 330);
            this.tbSyntvuosi2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSyntvuosi2.Name = "tbSyntvuosi2";
            this.tbSyntvuosi2.Size = new System.Drawing.Size(100, 26);
            this.tbSyntvuosi2.TabIndex = 12;
            this.tbSyntvuosi2.Visible = false;
            this.tbSyntvuosi2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSyntvuosi_KeyPress);
            this.tbSyntvuosi2.Leave += new System.EventHandler(this.tbSyntvuosi_Leave);
            // 
            // tbSuku2
            // 
            this.tbSuku2.Location = new System.Drawing.Point(443, 330);
            this.tbSuku2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSuku2.Name = "tbSuku2";
            this.tbSuku2.Size = new System.Drawing.Size(100, 26);
            this.tbSuku2.TabIndex = 11;
            this.tbSuku2.Visible = false;
            this.tbSuku2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEtu1_KeyPress);
            // 
            // tbEtu2
            // 
            this.tbEtu2.Location = new System.Drawing.Point(285, 330);
            this.tbEtu2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEtu2.Name = "tbEtu2";
            this.tbEtu2.Size = new System.Drawing.Size(100, 26);
            this.tbEtu2.TabIndex = 10;
            this.tbEtu2.Visible = false;
            this.tbEtu2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEtu1_KeyPress);
            // 
            // lblPelaaja2
            // 
            this.lblPelaaja2.AutoSize = true;
            this.lblPelaaja2.Location = new System.Drawing.Point(50, 336);
            this.lblPelaaja2.Name = "lblPelaaja2";
            this.lblPelaaja2.Size = new System.Drawing.Size(171, 20);
            this.lblPelaaja2.TabIndex = 9;
            this.lblPelaaja2.Text = "Syötä pelaajan 2 tiedot";
            this.lblPelaaja2.Visible = false;
            // 
            // tbSyntvuosi
            // 
            this.tbSyntvuosi.Location = new System.Drawing.Point(602, 258);
            this.tbSyntvuosi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSyntvuosi.Name = "tbSyntvuosi";
            this.tbSyntvuosi.Size = new System.Drawing.Size(100, 26);
            this.tbSyntvuosi.TabIndex = 8;
            this.tbSyntvuosi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSyntvuosi_KeyPress);
            this.tbSyntvuosi.Leave += new System.EventHandler(this.tbSyntvuosi_Leave);
            // 
            // tbSuku1
            // 
            this.tbSuku1.Location = new System.Drawing.Point(443, 258);
            this.tbSuku1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSuku1.Name = "tbSuku1";
            this.tbSuku1.Size = new System.Drawing.Size(100, 26);
            this.tbSuku1.TabIndex = 7;
            this.tbSuku1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEtu1_KeyPress);
            // 
            // tbEtu1
            // 
            this.tbEtu1.Location = new System.Drawing.Point(285, 258);
            this.tbEtu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEtu1.Name = "tbEtu1";
            this.tbEtu1.Size = new System.Drawing.Size(100, 26);
            this.tbEtu1.TabIndex = 6;
            this.tbEtu1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEtu1_KeyPress);
            // 
            // lblPelaaja1tiedot
            // 
            this.lblPelaaja1tiedot.AutoSize = true;
            this.lblPelaaja1tiedot.Location = new System.Drawing.Point(50, 260);
            this.lblPelaaja1tiedot.Name = "lblPelaaja1tiedot";
            this.lblPelaaja1tiedot.Size = new System.Drawing.Size(171, 20);
            this.lblPelaaja1tiedot.TabIndex = 5;
            this.lblPelaaja1tiedot.Text = "Syötä pelaajan 1 tiedot";
            // 
            // btnPelaaja2
            // 
            this.btnPelaaja2.Location = new System.Drawing.Point(583, 162);
            this.btnPelaaja2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPelaaja2.Name = "btnPelaaja2";
            this.btnPelaaja2.Size = new System.Drawing.Size(93, 46);
            this.btnPelaaja2.TabIndex = 4;
            this.btnPelaaja2.Text = "Pelaaja 2";
            this.btnPelaaja2.UseVisualStyleBackColor = true;
            this.btnPelaaja2.Click += new System.EventHandler(this.btnPelaaja2_Click);
            // 
            // btnTietokone
            // 
            this.btnTietokone.Location = new System.Drawing.Point(443, 162);
            this.btnTietokone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTietokone.Name = "btnTietokone";
            this.btnTietokone.Size = new System.Drawing.Size(100, 46);
            this.btnTietokone.TabIndex = 3;
            this.btnTietokone.Text = "Tietokone (AI)";
            this.btnTietokone.UseVisualStyleBackColor = true;
            this.btnTietokone.Click += new System.EventHandler(this.btnTietokone_Click);
            // 
            // lblValinta
            // 
            this.lblValinta.AutoSize = true;
            this.lblValinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValinta.Location = new System.Drawing.Point(46, 162);
            this.lblValinta.Name = "lblValinta";
            this.lblValinta.Size = new System.Drawing.Size(370, 46);
            this.lblValinta.TabIndex = 2;
            this.lblValinta.Text = "Valitse vastustajasi!";
            // 
            // lblRistinolla
            // 
            this.lblRistinolla.AutoSize = true;
            this.lblRistinolla.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRistinolla.Location = new System.Drawing.Point(263, 36);
            this.lblRistinolla.Name = "lblRistinolla";
            this.lblRistinolla.Size = new System.Drawing.Size(217, 55);
            this.lblRistinolla.TabIndex = 1;
            this.lblRistinolla.Text = "Ristinolla";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saannotToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 36);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saannotToolStripMenuItem
            // 
            this.saannotToolStripMenuItem.Name = "saannotToolStripMenuItem";
            this.saannotToolStripMenuItem.Size = new System.Drawing.Size(93, 32);
            this.saannotToolStripMenuItem.Text = "Säännöt";
            this.saannotToolStripMenuItem.Click += new System.EventHandler(this.saannotToolStripMenuItem_Click);
            // 
            // frmAloitus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAloitus";
            this.Text = "Ristinollan aloitusruutu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblValinta;
        private System.Windows.Forms.Label lblRistinolla;
        private System.Windows.Forms.Label lblPelaaja1tiedot;
        private System.Windows.Forms.Button btnPelaaja2;
        private System.Windows.Forms.Button btnTietokone;
        private System.Windows.Forms.Button btnTallenna2;
        private System.Windows.Forms.Button btnTallenna1;
        private System.Windows.Forms.TextBox tbSyntvuosi2;
        private System.Windows.Forms.TextBox tbSuku2;
        private System.Windows.Forms.TextBox tbEtu2;
        private System.Windows.Forms.Label lblPelaaja2;
        private System.Windows.Forms.TextBox tbSyntvuosi;
        private System.Windows.Forms.TextBox tbSuku1;
        private System.Windows.Forms.TextBox tbEtu1;
        private System.Windows.Forms.Button btnHae2;
        private System.Windows.Forms.Button btnHae1;
        private System.Windows.Forms.Button btnAloita;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saannotToolStripMenuItem;
    }
}

