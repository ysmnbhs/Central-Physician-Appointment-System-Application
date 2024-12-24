namespace VT_DonemSonuProje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSekreterGirisi = new System.Windows.Forms.Button();
            this.btnDoktorGirisi = new System.Windows.Forms.Button();
            this.btnEczacıGirisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(190, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Muayene Bilgi Yönetim Sistemine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(312, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hoş Geldiniz";
            // 
            // btnSekreterGirisi
            // 
            this.btnSekreterGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSekreterGirisi.Location = new System.Drawing.Point(115, 285);
            this.btnSekreterGirisi.Name = "btnSekreterGirisi";
            this.btnSekreterGirisi.Size = new System.Drawing.Size(106, 59);
            this.btnSekreterGirisi.TabIndex = 2;
            this.btnSekreterGirisi.Text = "Sekreter Girişi";
            this.btnSekreterGirisi.UseVisualStyleBackColor = true;
            this.btnSekreterGirisi.Click += new System.EventHandler(this.btnSekreterGirisi_Click);
            // 
            // btnDoktorGirisi
            // 
            this.btnDoktorGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDoktorGirisi.Location = new System.Drawing.Point(335, 285);
            this.btnDoktorGirisi.Name = "btnDoktorGirisi";
            this.btnDoktorGirisi.Size = new System.Drawing.Size(106, 59);
            this.btnDoktorGirisi.TabIndex = 3;
            this.btnDoktorGirisi.Text = "Doktor Girişi";
            this.btnDoktorGirisi.UseVisualStyleBackColor = true;
            this.btnDoktorGirisi.Click += new System.EventHandler(this.btnDoktorGirisi_Click);
            // 
            // btnEczacıGirisi
            // 
            this.btnEczacıGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEczacıGirisi.Location = new System.Drawing.Point(554, 285);
            this.btnEczacıGirisi.Name = "btnEczacıGirisi";
            this.btnEczacıGirisi.Size = new System.Drawing.Size(106, 59);
            this.btnEczacıGirisi.TabIndex = 4;
            this.btnEczacıGirisi.Text = "Eczacı Girişi";
            this.btnEczacıGirisi.UseVisualStyleBackColor = true;
            this.btnEczacıGirisi.Click += new System.EventHandler(this.btnEczacıGirisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEczacıGirisi);
            this.Controls.Add(this.btnDoktorGirisi);
            this.Controls.Add(this.btnSekreterGirisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnSekreterGirisi;
        private Button btnDoktorGirisi;
        private Button btnEczacıGirisi;
    }
}