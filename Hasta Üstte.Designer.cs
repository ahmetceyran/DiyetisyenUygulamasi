
namespace Yazılım_Mimarisi
{
    partial class Hasta_Üstte
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
            this.btnhtml = new System.Windows.Forms.Button();
            this.btnjson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnhtml
            // 
            this.btnhtml.Location = new System.Drawing.Point(64, 60);
            this.btnhtml.Margin = new System.Windows.Forms.Padding(4);
            this.btnhtml.Name = "btnhtml";
            this.btnhtml.Size = new System.Drawing.Size(108, 65);
            this.btnhtml.TabIndex = 0;
            this.btnhtml.Text = "HTML";
            this.btnhtml.UseVisualStyleBackColor = true;
            this.btnhtml.Click += new System.EventHandler(this.btnhtml_Click);
            // 
            // btnjson
            // 
            this.btnjson.Location = new System.Drawing.Point(227, 60);
            this.btnjson.Margin = new System.Windows.Forms.Padding(4);
            this.btnjson.Name = "btnjson";
            this.btnjson.Size = new System.Drawing.Size(108, 65);
            this.btnjson.TabIndex = 1;
            this.btnjson.Text = "JSON";
            this.btnjson.UseVisualStyleBackColor = true;
            this.btnjson.Click += new System.EventHandler(this.btnjson_Click);
            // 
            // Hasta_Üstte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 206);
            this.Controls.Add(this.btnjson);
            this.Controls.Add(this.btnhtml);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Hasta_Üstte";
            this.Text = "Hasta_Üstte";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnhtml;
        private System.Windows.Forms.Button btnjson;
    }
}