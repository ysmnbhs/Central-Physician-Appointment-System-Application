namespace VT_DonemSonuProje
{
    partial class ReceteGoruntuleme
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
            this.dgRecete = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecete)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnaMenü
            // 
            this.btnAnaMenü.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnaMenü.Location = new System.Drawing.Point(646, 391);
            this.btnAnaMenü.Name = "btnAnaMenü";
            this.btnAnaMenü.Size = new System.Drawing.Size(125, 49);
            this.btnAnaMenü.TabIndex = 11;
            this.btnAnaMenü.Text = "Ana Menü";
            this.btnAnaMenü.UseVisualStyleBackColor = true;
            // 
            // dgRecete
            // 
            this.dgRecete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecete.Location = new System.Drawing.Point(12, 11);
            this.dgRecete.Name = "dgRecete";
            this.dgRecete.RowTemplate.Height = 25;
            this.dgRecete.Size = new System.Drawing.Size(776, 374);
            this.dgRecete.TabIndex = 9;
            // 
            // ReceteGoruntuleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnaMenü);
            this.Controls.Add(this.dgRecete);
            this.Name = "ReceteGoruntuleme";
            this.Text = "Recete Goruntuleme Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.dgRecete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAnaMenü;
        private DataGridView dgRecete;
    }
}