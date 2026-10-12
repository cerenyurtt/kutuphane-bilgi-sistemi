namespace KutuphaneBS.UI
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
            txtAdi = new TextBox();
            btnEkle = new Button();
            dataGridView1 = new DataGridView();
            bntSil = new Button();
            btnGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(58, 20);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(100, 23);
            txtAdi.TabIndex = 0;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(58, 55);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Kaydet";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(447, 184);
            dataGridView1.TabIndex = 2;
            // 
            // bntSil
            // 
            bntSil.Location = new Point(57, 318);
            bntSil.Name = "bntSil";
            bntSil.Size = new Size(75, 23);
            bntSil.TabIndex = 3;
            bntSil.Text = "Sil";
            bntSil.UseVisualStyleBackColor = true;
            bntSil.Click += bntSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(170, 321);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuncelle);
            Controls.Add(bntSil);
            Controls.Add(dataGridView1);
            Controls.Add(btnEkle);
            Controls.Add(txtAdi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdi;
        private Button btnEkle;
        private DataGridView dataGridView1;
        private Button bntSil;
        private Button btnGuncelle;
    }
}
