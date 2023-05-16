
namespace Songul_Kosak_211103058
{
    partial class Seanslar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_geri = new System.Windows.Forms.Button();
            this.button_yeniseans = new System.Windows.Forms.Button();
            this.button_tümseans = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button_geri);
            this.groupBox1.Controls.Add(this.button_yeniseans);
            this.groupBox1.Controls.Add(this.button_tümseans);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 257);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seanslar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // button_geri
            // 
            this.button_geri.ForeColor = System.Drawing.Color.Black;
            this.button_geri.Location = new System.Drawing.Point(18, 193);
            this.button_geri.Name = "button_geri";
            this.button_geri.Size = new System.Drawing.Size(83, 30);
            this.button_geri.TabIndex = 4;
            this.button_geri.Text = "Geri Dön";
            this.button_geri.UseVisualStyleBackColor = true;
            this.button_geri.Click += new System.EventHandler(this.button_geri_Click_1);
            // 
            // button_yeniseans
            // 
            this.button_yeniseans.ForeColor = System.Drawing.Color.Black;
            this.button_yeniseans.Location = new System.Drawing.Point(114, 193);
            this.button_yeniseans.Name = "button_yeniseans";
            this.button_yeniseans.Size = new System.Drawing.Size(132, 31);
            this.button_yeniseans.TabIndex = 3;
            this.button_yeniseans.Text = "Yeni Seans Ekle";
            this.button_yeniseans.UseVisualStyleBackColor = true;
            this.button_yeniseans.Click += new System.EventHandler(this.button_yeniseans_Click_1);
            // 
            // button_tümseans
            // 
            this.button_tümseans.ForeColor = System.Drawing.Color.Black;
            this.button_tümseans.Location = new System.Drawing.Point(259, 193);
            this.button_tümseans.Name = "button_tümseans";
            this.button_tümseans.Size = new System.Drawing.Size(122, 32);
            this.button_tümseans.TabIndex = 2;
            this.button_tümseans.Text = "Tüm Seanslar";
            this.button_tümseans.UseVisualStyleBackColor = true;
            this.button_tümseans.Click += new System.EventHandler(this.button_tümseans_Click_1);
            // 
            // Seanslar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(476, 287);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Seanslar";
            this.Text = "Seanslar";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_geri;
        private System.Windows.Forms.Button button_yeniseans;
        private System.Windows.Forms.Button button_tümseans;
    }
}