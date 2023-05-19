namespace değikenlerin_kapsamı
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
            this.lblSayac = new System.Windows.Forms.Label();
            this.btnArttır = new System.Windows.Forms.Button();
            this.btnazalt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Location = new System.Drawing.Point(367, 106);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(18, 20);
            this.lblSayac.TabIndex = 0;
            this.lblSayac.Text = "0";
            // 
            // btnArttır
            // 
            this.btnArttır.Location = new System.Drawing.Point(188, 168);
            this.btnArttır.Name = "btnArttır";
            this.btnArttır.Size = new System.Drawing.Size(138, 61);
            this.btnArttır.TabIndex = 1;
            this.btnArttır.Text = "+";
            this.btnArttır.UseVisualStyleBackColor = true;
            this.btnArttır.Click += new System.EventHandler(this.btnArttır_Click);
            // 
            // btnazalt
            // 
            this.btnazalt.Location = new System.Drawing.Point(457, 168);
            this.btnazalt.Name = "btnazalt";
            this.btnazalt.Size = new System.Drawing.Size(127, 61);
            this.btnazalt.TabIndex = 2;
            this.btnazalt.Text = "-";
            this.btnazalt.UseVisualStyleBackColor = true;
            this.btnazalt.Click += new System.EventHandler(this.btnazalt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnazalt);
            this.Controls.Add(this.btnArttır);
            this.Controls.Add(this.lblSayac);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.Button btnArttır;
        private System.Windows.Forms.Button btnazalt;
    }
}

