namespace VT_DonemSonuProje
{
    partial class İlacListesi
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
            this.btnGöster = new System.Windows.Forms.Button();
            this.btnİlacEklemeEkrani = new System.Windows.Forms.Button();
            this.dgİlacListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgİlacListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGöster
            // 
            this.btnGöster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGöster.Location = new System.Drawing.Point(646, 391);
            this.btnGöster.Name = "btnGöster";
            this.btnGöster.Size = new System.Drawing.Size(125, 49);
            this.btnGöster.TabIndex = 5;
            this.btnGöster.Text = "GÖSTER";
            this.btnGöster.UseVisualStyleBackColor = true;
            this.btnGöster.Click += new System.EventHandler(this.btnGöster_Click);
            // 
            // btnİlacEklemeEkrani
            // 
            this.btnİlacEklemeEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnİlacEklemeEkrani.Location = new System.Drawing.Point(503, 391);
            this.btnİlacEklemeEkrani.Name = "btnİlacEklemeEkrani";
            this.btnİlacEklemeEkrani.Size = new System.Drawing.Size(125, 49);
            this.btnİlacEklemeEkrani.TabIndex = 4;
            this.btnİlacEklemeEkrani.Text = "İlaç Ekleme Ekranı";
            this.btnİlacEklemeEkrani.UseVisualStyleBackColor = true;
            // 
            // dgİlacListesi
            // 
            this.dgİlacListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgİlacListesi.Location = new System.Drawing.Point(12, 11);
            this.dgİlacListesi.Name = "dgİlacListesi";
            this.dgİlacListesi.RowTemplate.Height = 25;
            this.dgİlacListesi.Size = new System.Drawing.Size(776, 374);
            this.dgİlacListesi.TabIndex = 3;
            this.dgİlacListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgİlacListesi_CellContentClick);
            // 
            // İlacListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGöster);
            this.Controls.Add(this.btnİlacEklemeEkrani);
            this.Controls.Add(this.dgİlacListesi);
            this.Name = "İlacListesi";
            this.Text = "İlaç Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dgİlacListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGöster;
        private Button btnİlacEklemeEkrani;
        private DataGridView dgİlacListesi;
    }
}