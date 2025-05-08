namespace Prelab7
{
    partial class Ayarlar
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
            this.cmbResimTema = new System.Windows.Forms.ComboBox();
            this.cmbZorluk = new System.Windows.Forms.ComboBox();
            this.btnAyarKaydet = new System.Windows.Forms.Button();
            this.cmbSure = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbResimTema
            // 
            this.cmbResimTema.FormattingEnabled = true;
            this.cmbResimTema.Location = new System.Drawing.Point(54, 174);
            this.cmbResimTema.Name = "cmbResimTema";
            this.cmbResimTema.Size = new System.Drawing.Size(178, 24);
            this.cmbResimTema.TabIndex = 1;
            // 
            // cmbZorluk
            // 
            this.cmbZorluk.FormattingEnabled = true;
            this.cmbZorluk.Location = new System.Drawing.Point(54, 233);
            this.cmbZorluk.Name = "cmbZorluk";
            this.cmbZorluk.Size = new System.Drawing.Size(178, 24);
            this.cmbZorluk.TabIndex = 2;
            // 
            // btnAyarKaydet
            // 
            this.btnAyarKaydet.Location = new System.Drawing.Point(605, 618);
            this.btnAyarKaydet.Name = "btnAyarKaydet";
            this.btnAyarKaydet.Size = new System.Drawing.Size(143, 50);
            this.btnAyarKaydet.TabIndex = 4;
            this.btnAyarKaydet.Text = "Kaydet";
            this.btnAyarKaydet.UseVisualStyleBackColor = true;
            this.btnAyarKaydet.Click += new System.EventHandler(this.btnAyarKaydet_Click);
            // 
            // cmbSure
            // 
            this.cmbSure.FormattingEnabled = true;
            this.cmbSure.Location = new System.Drawing.Point(54, 127);
            this.cmbSure.Name = "cmbSure";
            this.cmbSure.Size = new System.Drawing.Size(178, 24);
            this.cmbSure.TabIndex = 5;
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 721);
            this.Controls.Add(this.cmbSure);
            this.Controls.Add(this.btnAyarKaydet);
            this.Controls.Add(this.cmbZorluk);
            this.Controls.Add(this.cmbResimTema);
            this.Name = "Ayarlar";
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbResimTema;
        private System.Windows.Forms.ComboBox cmbZorluk;
        private System.Windows.Forms.Button btnAyarKaydet;
        private System.Windows.Forms.ComboBox cmbSure;
    }
}