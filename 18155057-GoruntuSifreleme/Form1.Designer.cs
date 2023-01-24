namespace _18155057_GoruntuSifreleme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.DesifreEt = new System.Windows.Forms.Button();
            this.KarmasikSifrele = new System.Windows.Forms.Button();
            this.orijinal = new System.Windows.Forms.PictureBox();
            this.hedef = new System.Windows.Forms.PictureBox();
            this.EstetikSifreleme = new System.Windows.Forms.Button();
            this.estetikDesifre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orijinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hedef)).BeginInit();
            this.SuspendLayout();
            // 
            // DesifreEt
            // 
            this.DesifreEt.Location = new System.Drawing.Point(343, 114);
            this.DesifreEt.Name = "DesifreEt";
            this.DesifreEt.Size = new System.Drawing.Size(128, 30);
            this.DesifreEt.TabIndex = 0;
            this.DesifreEt.Text = "Deşifre Et";
            this.DesifreEt.UseVisualStyleBackColor = true;
            this.DesifreEt.Click += new System.EventHandler(this.DesifreEt_Click);
            // 
            // KarmasikSifrele
            // 
            this.KarmasikSifrele.Location = new System.Drawing.Point(343, 78);
            this.KarmasikSifrele.Name = "KarmasikSifrele";
            this.KarmasikSifrele.Size = new System.Drawing.Size(128, 30);
            this.KarmasikSifrele.TabIndex = 1;
            this.KarmasikSifrele.Text = "Karmaşık Şifreleme";
            this.KarmasikSifrele.UseVisualStyleBackColor = true;
            this.KarmasikSifrele.Click += new System.EventHandler(this.KarmasikSifrele_Click);
            // 
            // orijinal
            // 
            this.orijinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orijinal.Location = new System.Drawing.Point(23, 12);
            this.orijinal.Name = "orijinal";
            this.orijinal.Size = new System.Drawing.Size(280, 426);
            this.orijinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orijinal.TabIndex = 2;
            this.orijinal.TabStop = false;
            this.orijinal.Click += new System.EventHandler(this.orijinal_Click);
            // 
            // hedef
            // 
            this.hedef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hedef.Location = new System.Drawing.Point(509, 12);
            this.hedef.Name = "hedef";
            this.hedef.Size = new System.Drawing.Size(280, 426);
            this.hedef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hedef.TabIndex = 3;
            this.hedef.TabStop = false;
            // 
            // EstetikSifreleme
            // 
            this.EstetikSifreleme.Location = new System.Drawing.Point(343, 199);
            this.EstetikSifreleme.Name = "EstetikSifreleme";
            this.EstetikSifreleme.Size = new System.Drawing.Size(128, 30);
            this.EstetikSifreleme.TabIndex = 4;
            this.EstetikSifreleme.Text = "Estetik Şifreleme";
            this.EstetikSifreleme.UseVisualStyleBackColor = true;
            this.EstetikSifreleme.Click += new System.EventHandler(this.EstetikSifreleme_Click);
            // 
            // estetikDesifre
            // 
            this.estetikDesifre.Location = new System.Drawing.Point(343, 235);
            this.estetikDesifre.Name = "estetikDesifre";
            this.estetikDesifre.Size = new System.Drawing.Size(128, 30);
            this.estetikDesifre.TabIndex = 5;
            this.estetikDesifre.Text = "Estetik Desifre";
            this.estetikDesifre.UseVisualStyleBackColor = true;
            this.estetikDesifre.Click += new System.EventHandler(this.estetikDesifre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.estetikDesifre);
            this.Controls.Add(this.EstetikSifreleme);
            this.Controls.Add(this.hedef);
            this.Controls.Add(this.orijinal);
            this.Controls.Add(this.KarmasikSifrele);
            this.Controls.Add(this.DesifreEt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orijinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hedef)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DesifreEt;
        private System.Windows.Forms.Button KarmasikSifrele;
        private System.Windows.Forms.PictureBox orijinal;
        private System.Windows.Forms.PictureBox hedef;
        private System.Windows.Forms.Button EstetikSifreleme;
        private System.Windows.Forms.Button estetikDesifre;
    }
}

