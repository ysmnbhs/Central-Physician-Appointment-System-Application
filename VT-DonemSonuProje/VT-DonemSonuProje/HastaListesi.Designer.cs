namespace VT_DonemSonuProje
{
    partial class HastaListesi
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
            this.dgHastaListesi = new System.Windows.Forms.DataGridView();
            this.btnHastaEklemeEkrani = new System.Windows.Forms.Button();
            this.btnAnaMenü = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgHastaListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHastaListesi
            // 
            this.dgHastaListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHastaListesi.Location = new System.Drawing.Point(12, 12);
            this.dgHastaListesi.Name = "dgHastaListesi";
            this.dgHastaListesi.RowTemplate.Height = 25;
            this.dgHastaListesi.Size = new System.Drawing.Size(776, 374);
            this.dgHastaListesi.TabIndex = 0;
            // 
            // btnHastaEklemeEkrani
            // 
            this.btnHastaEklemeEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHastaEklemeEkrani.Location = new System.Drawing.Point(503, 392);
            this.btnHastaEklemeEkrani.Name = "btnHastaEklemeEkrani";
            this.btnHastaEklemeEkrani.Size = new System.Drawing.Size(125, 49);
            this.btnHastaEklemeEkrani.TabIndex = 1;
            this.btnHastaEklemeEkrani.Text = "Hasta Ekleme Ekranı";
            this.btnHastaEklemeEkrani.UseVisualStyleBackColor = true;
            // 
            // btnAnaMenü
            // 
            this.btnAnaMenü.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnaMenü.Location = new System.Drawing.Point(646, 392);
            this.btnAnaMenü.Name = "btnAnaMenü";
            this.btnAnaMenü.Size = new System.Drawing.Size(125, 49);
            this.btnAnaMenü.TabIndex = 2;
            this.btnAnaMenü.Text = "Ana Menü";
            this.btnAnaMenü.UseVisualStyleBackColor = true;
            // 
            // HastaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnaMenü);
            this.Controls.Add(this.btnHastaEklemeEkrani);
            this.Controls.Add(this.dgHastaListesi);
            this.Name = "HastaListesi";
            this.Text = "Hasta Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dgHastaListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgHastaListesi;
        private Button btnHastaEklemeEkrani;
        private Button btnAnaMenü;
    }
}