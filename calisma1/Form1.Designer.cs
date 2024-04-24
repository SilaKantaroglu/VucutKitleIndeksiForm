
namespace VucutKitleIndeksiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblboy = new System.Windows.Forms.Label();
            this.lblKilo = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.arsiv = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblboy
            // 
            resources.ApplyResources(this.lblboy, "lblboy");
            this.lblboy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblboy.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblboy.Name = "lblboy";
            // 
            // lblKilo
            // 
            this.lblKilo.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            resources.ApplyResources(this.lblKilo, "lblKilo");
            this.lblKilo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKilo.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblKilo.Name = "lblKilo";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.LemonChiffon;
            resources.ApplyResources(this.btnHesapla, "btnHesapla");
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtBoy
            // 
            resources.ApplyResources(this.txtBoy, "txtBoy");
            this.txtBoy.Name = "txtBoy";
            // 
            // txtKilo
            // 
            resources.ApplyResources(this.txtKilo, "txtKilo");
            this.txtKilo.Name = "txtKilo";
            // 
            // txtSonuc
            // 
            resources.ApplyResources(this.txtSonuc, "txtSonuc");
            this.txtSonuc.Name = "txtSonuc";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // arsiv
            // 
            resources.ApplyResources(this.arsiv, "arsiv");
            this.arsiv.Name = "arsiv";
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Name = "listBox1";
            // 
            // btnTemizle
            // 
            resources.ApplyResources(this.btnTemizle, "btnTemizle");
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.arsiv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.txtKilo);
            this.Controls.Add(this.txtBoy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblKilo);
            this.Controls.Add(this.lblboy);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblboy;
        private System.Windows.Forms.Label lblKilo;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label arsiv;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnTemizle;
    }
}

