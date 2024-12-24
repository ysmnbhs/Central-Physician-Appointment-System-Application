namespace VT_DonemSonuProje
{
    partial class MuayeneListele
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
            this.btnAnaMenü = new System.Windows.Forms.Button();
            this.btnMuayeneEkle = new System.Windows.Forms.Button();
            this.dgMuayeneListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgMuayeneListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnaMenü
            // 
            this.btnAnaMenü.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnaMenü.Location = new System.Drawing.Point(646, 391);
            this.btnAnaMenü.Name = "btnAnaMenü";
            this.btnAnaMenü.Size = new System.Drawing.Size(125, 49);
            this.btnAnaMenü.TabIndex = 8;
            this.btnAnaMenü.Text = "Ana Menü";
            this.btnAnaMenü.UseVisualStyleBackColor = true;
            // 
            // btnMuayeneEkle
            // 
            this.btnMuayeneEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMuayeneEkle.Location = new System.Drawing.Point(503, 391);
            this.btnMuayeneEkle.Name = "btnMuayeneEkle";
            this.btnMuayeneEkle.Size = new System.Drawing.Size(125, 49);
            this.btnMuayeneEkle.TabIndex = 7;
            this.btnMuayeneEkle.Text = "Muayene Ekleme Ekranı";
            this.btnMuayeneEkle.UseVisualStyleBackColor = true;
            // 
            // dgMuayeneListesi
            // 
            this.dgMuayeneListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMuayeneListesi.Location = new System.Drawing.Point(12, 11);
            this.dgMuayeneListesi.Name = "dgMuayeneListesi";
            this.dgMuayeneListesi.RowTemplate.Height = 25;
            this.dgMuayeneListesi.Size = new System.Drawing.Size(776, 374);
            this.dgMuayeneListesi.TabIndex = 6;
            // 
            // MuayeneListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnaMenü);
            this.Controls.Add(this.btnMuayeneEkle);
            this.Controls.Add(this.dgMuayeneListesi);
            this.Name = "MuayeneListele";
            this.Text = "Muayene Listele";
            ((System.ComponentModel.ISupportInitialize)(this.dgMuayeneListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAnaMenü;
        private Button btnMuayeneEkle;
        private DataGridView dgMuayeneListesi;
    }
}