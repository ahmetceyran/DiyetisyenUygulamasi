
namespace Yazılım_Mimarisi
{
    partial class Diyetisyen_Ekranı
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
            this.btnhasta = new System.Windows.Forms.Button();
            this.btnhastaekle = new System.Windows.Forms.Button();
            this.btndiyet = new System.Windows.Forms.Button();
            this.btnhastalık = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.txthastadı = new System.Windows.Forms.TextBox();
            this.txtdiyetadı = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnüst = new System.Windows.Forms.Button();
            this.btnalt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnhasta
            // 
            this.btnhasta.Location = new System.Drawing.Point(12, 12);
            this.btnhasta.Name = "btnhasta";
            this.btnhasta.Size = new System.Drawing.Size(94, 42);
            this.btnhasta.TabIndex = 0;
            this.btnhasta.Text = "Hasta Listele";
            this.btnhasta.UseVisualStyleBackColor = true;
            this.btnhasta.Click += new System.EventHandler(this.btnhasta_Click);
            // 
            // btnhastaekle
            // 
            this.btnhastaekle.Location = new System.Drawing.Point(12, 60);
            this.btnhastaekle.Name = "btnhastaekle";
            this.btnhastaekle.Size = new System.Drawing.Size(94, 42);
            this.btnhastaekle.TabIndex = 1;
            this.btnhastaekle.Text = "Yeni Hasta Ekle";
            this.btnhastaekle.UseVisualStyleBackColor = true;
            this.btnhastaekle.Click += new System.EventHandler(this.btnhastaekle_Click);
            // 
            // btndiyet
            // 
            this.btndiyet.Location = new System.Drawing.Point(12, 108);
            this.btndiyet.Name = "btndiyet";
            this.btndiyet.Size = new System.Drawing.Size(94, 42);
            this.btndiyet.TabIndex = 2;
            this.btndiyet.Text = "Diyet Listele";
            this.btndiyet.UseVisualStyleBackColor = true;
            this.btndiyet.Click += new System.EventHandler(this.btndiyet_Click);
            // 
            // btnhastalık
            // 
            this.btnhastalık.Location = new System.Drawing.Point(12, 156);
            this.btnhastalık.Name = "btnhastalık";
            this.btnhastalık.Size = new System.Drawing.Size(94, 42);
            this.btnhastalık.TabIndex = 4;
            this.btnhastalık.Text = "Hastalık Listele";
            this.btnhastalık.UseVisualStyleBackColor = true;
            this.btnhastalık.Click += new System.EventHandler(this.btnhastalık_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hasta Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Yeni Diyet Programı:";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(220, 143);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(94, 42);
            this.btnguncelle.TabIndex = 8;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // txthastadı
            // 
            this.txthastadı.Location = new System.Drawing.Point(220, 72);
            this.txthastadı.Name = "txthastadı";
            this.txthastadı.Size = new System.Drawing.Size(123, 20);
            this.txthastadı.TabIndex = 9;
            // 
            // txtdiyetadı
            // 
            this.txtdiyetadı.Location = new System.Drawing.Point(220, 108);
            this.txtdiyetadı.Name = "txtdiyetadı";
            this.txtdiyetadı.Size = new System.Drawing.Size(123, 20);
            this.txtdiyetadı.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(210, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Diyet Değiştirme";
            // 
            // btnüst
            // 
            this.btnüst.Location = new System.Drawing.Point(57, 234);
            this.btnüst.Name = "btnüst";
            this.btnüst.Size = new System.Drawing.Size(106, 55);
            this.btnüst.TabIndex = 30;
            this.btnüst.Text = "Hasta Bilgisi Üstte Rapor";
            this.btnüst.UseVisualStyleBackColor = true;
            this.btnüst.Click += new System.EventHandler(this.btnüst_Click);
            // 
            // btnalt
            // 
            this.btnalt.Location = new System.Drawing.Point(208, 234);
            this.btnalt.Name = "btnalt";
            this.btnalt.Size = new System.Drawing.Size(106, 55);
            this.btnalt.TabIndex = 31;
            this.btnalt.Text = "Hasta Bilgisi Altta Rapor";
            this.btnalt.UseVisualStyleBackColor = true;
            this.btnalt.Click += new System.EventHandler(this.btnalt_Click);
            // 
            // Diyetisyen_Ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 328);
            this.Controls.Add(this.btnalt);
            this.Controls.Add(this.btnüst);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtdiyetadı);
            this.Controls.Add(this.txthastadı);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhastalık);
            this.Controls.Add(this.btndiyet);
            this.Controls.Add(this.btnhastaekle);
            this.Controls.Add(this.btnhasta);
            this.Name = "Diyetisyen_Ekranı";
            this.Text = "Diyetisyen_Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhasta;
        private System.Windows.Forms.Button btnhastaekle;
        private System.Windows.Forms.Button btndiyet;
        private System.Windows.Forms.Button btnhastalık;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.TextBox txthastadı;
        private System.Windows.Forms.TextBox txtdiyetadı;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnüst;
        private System.Windows.Forms.Button btnalt;
    }
}