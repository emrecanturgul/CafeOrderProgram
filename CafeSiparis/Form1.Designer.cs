namespace CafeSiparis
{
    partial class Form1
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.siparisGroupBox = new System.Windows.Forms.GroupBox();
            this.cayLabel = new System.Windows.Forms.Label();
            this.caySayısıLabel = new System.Windows.Forms.Label();
            this.cayArtıLabel = new System.Windows.Forms.Button();
            this.cayEksiLabel = new System.Windows.Forms.Button();
            this.kahveEksiLabel = new System.Windows.Forms.Button();
            this.kahveArtıLabel = new System.Windows.Forms.Button();
            this.kahveSayisiLabel = new System.Windows.Forms.Label();
            this.kahveLabel = new System.Windows.Forms.Label();
            this.kolaEksiLabel = new System.Windows.Forms.Button();
            this.kolaArtıLabel = new System.Windows.Forms.Button();
            this.kolaSayısıLabel = new System.Windows.Forms.Label();
            this.kolaLabel = new System.Windows.Forms.Label();
            this.sıfırlaButon = new System.Windows.Forms.Button();
            this.tamamlaButon = new System.Windows.Forms.Button();
            this.siparisGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // siparisGroupBox
            // 
            this.siparisGroupBox.Controls.Add(this.kolaEksiLabel);
            this.siparisGroupBox.Controls.Add(this.kolaArtıLabel);
            this.siparisGroupBox.Controls.Add(this.kolaSayısıLabel);
            this.siparisGroupBox.Controls.Add(this.kolaLabel);
            this.siparisGroupBox.Controls.Add(this.kahveEksiLabel);
            this.siparisGroupBox.Controls.Add(this.kahveArtıLabel);
            this.siparisGroupBox.Controls.Add(this.kahveSayisiLabel);
            this.siparisGroupBox.Controls.Add(this.kahveLabel);
            this.siparisGroupBox.Controls.Add(this.cayEksiLabel);
            this.siparisGroupBox.Controls.Add(this.cayArtıLabel);
            this.siparisGroupBox.Controls.Add(this.caySayısıLabel);
            this.siparisGroupBox.Controls.Add(this.cayLabel);
            this.siparisGroupBox.Location = new System.Drawing.Point(0, 0);
            this.siparisGroupBox.Name = "siparisGroupBox";
            this.siparisGroupBox.Size = new System.Drawing.Size(534, 397);
            this.siparisGroupBox.TabIndex = 0;
            this.siparisGroupBox.TabStop = false;
            this.siparisGroupBox.Text = "Sipariş";
            // 
            // cayLabel
            // 
            this.cayLabel.AutoSize = true;
            this.cayLabel.Location = new System.Drawing.Point(57, 78);
            this.cayLabel.Name = "cayLabel";
            this.cayLabel.Size = new System.Drawing.Size(50, 24);
            this.cayLabel.TabIndex = 0;
            this.cayLabel.Text = "ÇAY";
            // 
            // caySayısıLabel
            // 
            this.caySayısıLabel.AutoSize = true;
            this.caySayısıLabel.Location = new System.Drawing.Point(163, 78);
            this.caySayısıLabel.Name = "caySayısıLabel";
            this.caySayısıLabel.Size = new System.Drawing.Size(22, 24);
            this.caySayısıLabel.TabIndex = 1;
            this.caySayısıLabel.Text = "0";
            // 
            // cayArtıLabel
            // 
            this.cayArtıLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cayArtıLabel.Location = new System.Drawing.Point(327, 69);
            this.cayArtıLabel.Name = "cayArtıLabel";
            this.cayArtıLabel.Size = new System.Drawing.Size(92, 39);
            this.cayArtıLabel.TabIndex = 2;
            this.cayArtıLabel.Text = "+";
            this.cayArtıLabel.UseVisualStyleBackColor = true;
            this.cayArtıLabel.Click += new System.EventHandler(this.cayArtıLabel_Click);
            // 
            // cayEksiLabel
            // 
            this.cayEksiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cayEksiLabel.Location = new System.Drawing.Point(210, 69);
            this.cayEksiLabel.Name = "cayEksiLabel";
            this.cayEksiLabel.Size = new System.Drawing.Size(92, 39);
            this.cayEksiLabel.TabIndex = 3;
            this.cayEksiLabel.Text = "-";
            this.cayEksiLabel.UseVisualStyleBackColor = true;
            // 
            // kahveEksiLabel
            // 
            this.kahveEksiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kahveEksiLabel.Location = new System.Drawing.Point(210, 136);
            this.kahveEksiLabel.Name = "kahveEksiLabel";
            this.kahveEksiLabel.Size = new System.Drawing.Size(92, 39);
            this.kahveEksiLabel.TabIndex = 7;
            this.kahveEksiLabel.Text = "-";
            this.kahveEksiLabel.UseVisualStyleBackColor = true;
            // 
            // kahveArtıLabel
            // 
            this.kahveArtıLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kahveArtıLabel.Location = new System.Drawing.Point(327, 136);
            this.kahveArtıLabel.Name = "kahveArtıLabel";
            this.kahveArtıLabel.Size = new System.Drawing.Size(92, 39);
            this.kahveArtıLabel.TabIndex = 6;
            this.kahveArtıLabel.Text = "+";
            this.kahveArtıLabel.UseVisualStyleBackColor = true;
            // 
            // kahveSayisiLabel
            // 
            this.kahveSayisiLabel.AutoSize = true;
            this.kahveSayisiLabel.Location = new System.Drawing.Point(163, 145);
            this.kahveSayisiLabel.Name = "kahveSayisiLabel";
            this.kahveSayisiLabel.Size = new System.Drawing.Size(18, 20);
            this.kahveSayisiLabel.TabIndex = 5;
            this.kahveSayisiLabel.Text = "0";
            // 
            // kahveLabel
            // 
            this.kahveLabel.AutoSize = true;
            this.kahveLabel.Location = new System.Drawing.Point(57, 145);
            this.kahveLabel.Name = "kahveLabel";
            this.kahveLabel.Size = new System.Drawing.Size(77, 24);
            this.kahveLabel.TabIndex = 4;
            this.kahveLabel.Text = "KAHVE";
            // 
            // kolaEksiLabel
            // 
            this.kolaEksiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kolaEksiLabel.Location = new System.Drawing.Point(210, 213);
            this.kolaEksiLabel.Name = "kolaEksiLabel";
            this.kolaEksiLabel.Size = new System.Drawing.Size(92, 39);
            this.kolaEksiLabel.TabIndex = 11;
            this.kolaEksiLabel.Text = "-";
            this.kolaEksiLabel.UseVisualStyleBackColor = true;
            // 
            // kolaArtıLabel
            // 
            this.kolaArtıLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kolaArtıLabel.Location = new System.Drawing.Point(327, 213);
            this.kolaArtıLabel.Name = "kolaArtıLabel";
            this.kolaArtıLabel.Size = new System.Drawing.Size(92, 39);
            this.kolaArtıLabel.TabIndex = 10;
            this.kolaArtıLabel.Text = "+";
            this.kolaArtıLabel.UseVisualStyleBackColor = true;
            // 
            // kolaSayısıLabel
            // 
            this.kolaSayısıLabel.AutoSize = true;
            this.kolaSayısıLabel.Location = new System.Drawing.Point(163, 222);
            this.kolaSayısıLabel.Name = "kolaSayısıLabel";
            this.kolaSayısıLabel.Size = new System.Drawing.Size(18, 20);
            this.kolaSayısıLabel.TabIndex = 9;
            this.kolaSayısıLabel.Text = "0";
            // 
            // kolaLabel
            // 
            this.kolaLabel.AutoSize = true;
            this.kolaLabel.Location = new System.Drawing.Point(57, 222);
            this.kolaLabel.Name = "kolaLabel";
            this.kolaLabel.Size = new System.Drawing.Size(61, 24);
            this.kolaLabel.TabIndex = 8;
            this.kolaLabel.Text = "KOLA";
            // 
            // sıfırlaButon
            // 
            this.sıfırlaButon.Location = new System.Drawing.Point(61, 403);
            this.sıfırlaButon.Name = "sıfırlaButon";
            this.sıfırlaButon.Size = new System.Drawing.Size(185, 46);
            this.sıfırlaButon.TabIndex = 12;
            this.sıfırlaButon.Text = "SIFIRLA";
            this.sıfırlaButon.UseVisualStyleBackColor = true;
            // 
            // tamamlaButon
            // 
            this.tamamlaButon.Location = new System.Drawing.Point(317, 403);
            this.tamamlaButon.Name = "tamamlaButon";
            this.tamamlaButon.Size = new System.Drawing.Size(177, 46);
            this.tamamlaButon.TabIndex = 13;
            this.tamamlaButon.Text = "SİPARİŞİ TAMAMLA";
            this.tamamlaButon.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 480);
            this.Controls.Add(this.tamamlaButon);
            this.Controls.Add(this.sıfırlaButon);
            this.Controls.Add(this.siparisGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.siparisGroupBox.ResumeLayout(false);
            this.siparisGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox siparisGroupBox;
        private System.Windows.Forms.Button cayArtıLabel;
        private System.Windows.Forms.Label caySayısıLabel;
        private System.Windows.Forms.Label cayLabel;
        private System.Windows.Forms.Button kolaEksiLabel;
        private System.Windows.Forms.Button kolaArtıLabel;
        private System.Windows.Forms.Label kolaSayısıLabel;
        private System.Windows.Forms.Label kolaLabel;
        private System.Windows.Forms.Button kahveEksiLabel;
        private System.Windows.Forms.Button kahveArtıLabel;
        private System.Windows.Forms.Label kahveSayisiLabel;
        private System.Windows.Forms.Label kahveLabel;
        private System.Windows.Forms.Button cayEksiLabel;
        private System.Windows.Forms.Button sıfırlaButon;
        private System.Windows.Forms.Button tamamlaButon;
    }
}