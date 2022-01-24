
namespace Yazılım_Mimarisi
{
    partial class Hasta_Ekleme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txthastadı = new System.Windows.Forms.TextBox();
            this.txthastasoyad = new System.Windows.Forms.TextBox();
            this.txthastatc = new System.Windows.Forms.TextBox();
            this.txthastalik = new System.Windows.Forms.TextBox();
            this.txtdiyet = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hastalığı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Uygulanacak Diyet:";
            // 
            // txthastadı
            // 
            this.txthastadı.Location = new System.Drawing.Point(118, 58);
            this.txthastadı.Name = "txthastadı";
            this.txthastadı.Size = new System.Drawing.Size(141, 20);
            this.txthastadı.TabIndex = 5;
            // 
            // txthastasoyad
            // 
            this.txthastasoyad.Location = new System.Drawing.Point(118, 99);
            this.txthastasoyad.Name = "txthastasoyad";
            this.txthastasoyad.Size = new System.Drawing.Size(141, 20);
            this.txthastasoyad.TabIndex = 6;
            // 
            // txthastatc
            // 
            this.txthastatc.Location = new System.Drawing.Point(118, 143);
            this.txthastatc.Name = "txthastatc";
            this.txthastatc.Size = new System.Drawing.Size(141, 20);
            this.txthastatc.TabIndex = 7;
            // 
            // txthastalik
            // 
            this.txthastalik.Location = new System.Drawing.Point(118, 186);
            this.txthastalik.Name = "txthastalik";
            this.txthastalik.Size = new System.Drawing.Size(141, 20);
            this.txthastalik.TabIndex = 8;
            // 
            // txtdiyet
            // 
            this.txtdiyet.Location = new System.Drawing.Point(118, 227);
            this.txtdiyet.Name = "txtdiyet";
            this.txtdiyet.Size = new System.Drawing.Size(141, 20);
            this.txtdiyet.TabIndex = 9;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(121, 265);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(106, 46);
            this.btnekle.TabIndex = 10;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // Hasta_Ekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 348);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtdiyet);
            this.Controls.Add(this.txthastalik);
            this.Controls.Add(this.txthastatc);
            this.Controls.Add(this.txthastasoyad);
            this.Controls.Add(this.txthastadı);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Hasta_Ekleme";
            this.Text = "Hasta_Ekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txthastadı;
        private System.Windows.Forms.TextBox txthastasoyad;
        private System.Windows.Forms.TextBox txthastatc;
        private System.Windows.Forms.TextBox txthastalik;
        private System.Windows.Forms.TextBox txtdiyet;
        private System.Windows.Forms.Button btnekle;
    }
}