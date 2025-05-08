namespace Prelab7
{
    partial class OyunForm
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
            this.components = new System.ComponentModel.Container();
            this.lblKelime = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblYanlislar = new System.Windows.Forms.Label();
            this.lblKelimeUzunlugu = new System.Windows.Forms.Label();
            this.txtHarf = new System.Windows.Forms.TextBox();
            this.picAdam = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTahminEt = new System.Windows.Forms.Button();
            this.btnOyunuBitir = new System.Windows.Forms.Button();
            this.btnIpucu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSure = new System.Windows.Forms.Label();
            this.lblZorluk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAdam)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelime.Location = new System.Drawing.Point(36, 407);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(103, 38);
            this.lblKelime.TabIndex = 0;
            this.lblKelime.Text = "label1";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.Location = new System.Drawing.Point(198, 127);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(103, 38);
            this.lblPuan.TabIndex = 1;
            this.lblPuan.Text = "label2";
            // 
            // lblYanlislar
            // 
            this.lblYanlislar.AutoSize = true;
            this.lblYanlislar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYanlislar.Location = new System.Drawing.Point(654, 86);
            this.lblYanlislar.Name = "lblYanlislar";
            this.lblYanlislar.Size = new System.Drawing.Size(103, 38);
            this.lblYanlislar.TabIndex = 2;
            this.lblYanlislar.Text = "label3";
            // 
            // lblKelimeUzunlugu
            // 
            this.lblKelimeUzunlugu.AutoSize = true;
            this.lblKelimeUzunlugu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelimeUzunlugu.Location = new System.Drawing.Point(36, 342);
            this.lblKelimeUzunlugu.Name = "lblKelimeUzunlugu";
            this.lblKelimeUzunlugu.Size = new System.Drawing.Size(103, 38);
            this.lblKelimeUzunlugu.TabIndex = 3;
            this.lblKelimeUzunlugu.Text = "label4";
            // 
            // txtHarf
            // 
            this.txtHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHarf.Location = new System.Drawing.Point(43, 483);
            this.txtHarf.Name = "txtHarf";
            this.txtHarf.Size = new System.Drawing.Size(162, 34);
            this.txtHarf.TabIndex = 4;
            // 
            // picAdam
            // 
            this.picAdam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picAdam.Location = new System.Drawing.Point(661, 127);
            this.picAdam.Name = "picAdam";
            this.picAdam.Size = new System.Drawing.Size(776, 545);
            this.picAdam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdam.TabIndex = 8;
            this.picAdam.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(572, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 51);
            this.label1.TabIndex = 9;
            this.label1.Text = "HANGMAN";
            // 
            // btnTahminEt
            // 
            this.btnTahminEt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTahminEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTahminEt.Location = new System.Drawing.Point(32, 621);
            this.btnTahminEt.Name = "btnTahminEt";
            this.btnTahminEt.Size = new System.Drawing.Size(146, 90);
            this.btnTahminEt.TabIndex = 5;
            this.btnTahminEt.Text = "TAHMİN ET";
            this.btnTahminEt.UseVisualStyleBackColor = false;
            this.btnTahminEt.Click += new System.EventHandler(this.btnTahminEt_Click);
            // 
            // btnOyunuBitir
            // 
            this.btnOyunuBitir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOyunuBitir.Location = new System.Drawing.Point(205, 621);
            this.btnOyunuBitir.Name = "btnOyunuBitir";
            this.btnOyunuBitir.Size = new System.Drawing.Size(145, 90);
            this.btnOyunuBitir.TabIndex = 6;
            this.btnOyunuBitir.Text = "OYUNU BİTİR";
            this.btnOyunuBitir.UseVisualStyleBackColor = false;
            this.btnOyunuBitir.Click += new System.EventHandler(this.btnOyunuBitir_Click);
            // 
            // btnIpucu
            // 
            this.btnIpucu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIpucu.Location = new System.Drawing.Point(384, 621);
            this.btnIpucu.Name = "btnIpucu";
            this.btnIpucu.Size = new System.Drawing.Size(179, 90);
            this.btnIpucu.TabIndex = 7;
            this.btnIpucu.Text = "İPUCU VER";
            this.btnIpucu.UseVisualStyleBackColor = false;
            this.btnIpucu.Click += new System.EventHandler(this.btnIpucu_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(36, 270);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(178, 38);
            this.lblSure.TabIndex = 11;
            this.lblSure.Text = "Kalan Süre";
            // 
            // lblZorluk
            // 
            this.lblZorluk.AutoSize = true;
            this.lblZorluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZorluk.Location = new System.Drawing.Point(52, 210);
            this.lblZorluk.Name = "lblZorluk";
            this.lblZorluk.Size = new System.Drawing.Size(92, 32);
            this.lblZorluk.TabIndex = 12;
            this.lblZorluk.Text = "label3";
            // 
            // OyunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prelab7.Properties.Resources.cover21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1471, 744);
            this.Controls.Add(this.lblZorluk);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picAdam);
            this.Controls.Add(this.btnIpucu);
            this.Controls.Add(this.btnOyunuBitir);
            this.Controls.Add(this.btnTahminEt);
            this.Controls.Add(this.txtHarf);
            this.Controls.Add(this.lblKelimeUzunlugu);
            this.Controls.Add(this.lblYanlislar);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.lblKelime);
            this.Name = "OyunForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picAdam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblYanlislar;
        private System.Windows.Forms.Label lblKelimeUzunlugu;
        private System.Windows.Forms.TextBox txtHarf;
        private System.Windows.Forms.PictureBox picAdam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTahminEt;
        private System.Windows.Forms.Button btnOyunuBitir;
        private System.Windows.Forms.Button btnIpucu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblZorluk;
    }
}