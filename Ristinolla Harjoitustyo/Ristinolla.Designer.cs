namespace Ristinolla_Harjoitustyo
{
    partial class Ristinolla
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
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Red;
            this.btnRestart.Location = new System.Drawing.Point(238, 541);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(309, 59);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Pelaa uudelleen";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Ristinolla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 596);
            this.Controls.Add(this.btnRestart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ristinolla";
            this.Text = "Ristinolla";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRestart;
    }
}