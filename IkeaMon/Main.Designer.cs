namespace IkeaMon
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.gonderilecekdosyayolu = new System.Windows.Forms.OpenFileDialog();
            this.telefonnumaralari = new System.Windows.Forms.OpenFileDialog();
            this.btn_baslat = new System.Windows.Forms.Button();
            this.arkaplaniscisi = new System.ComponentModel.BackgroundWorker();
            this.txt_console = new System.Windows.Forms.TextBox();
            this.statusband = new System.Windows.Forms.StatusStrip();
            this.logdosyasikaydet = new System.Windows.Forms.SaveFileDialog();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusband.SuspendLayout();
            this.SuspendLayout();


            // btn_baslat
            // 
            this.btn_baslat.Location = new System.Drawing.Point(12, 22);
            this.btn_baslat.Name = "btn_baslat";
            this.btn_baslat.Size = new System.Drawing.Size(460, 53);
            this.btn_baslat.TabIndex = 7;
            this.btn_baslat.Text = "Run Ikea site monitor";
            this.btn_baslat.UseVisualStyleBackColor = true;
            this.btn_baslat.Click += new System.EventHandler(this.btn_run_Click);

            // 
            // txt_console
            // 
            this.txt_console.Location = new System.Drawing.Point(12, 81);
            this.txt_console.Multiline = true;
            this.txt_console.Name = "txt_console";
            this.txt_console.ReadOnly = true;
            this.txt_console.Size = new System.Drawing.Size(460, 115);
            this.txt_console.TabIndex = 8;
            // 
            // statusband
            // 
            this.statusband.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusband.Location = new System.Drawing.Point(0, 199);
            this.statusband.Name = "statusband";
            this.statusband.Size = new System.Drawing.Size(484, 22);
            this.statusband.TabIndex = 9;

            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 221);
            this.Controls.Add(this.statusband);
            this.Controls.Add(this.txt_console);
            this.Controls.Add(this.btn_baslat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "IkeaMon";
            this.statusband.ResumeLayout(false);
            this.statusband.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog gonderilecekdosyayolu;
        private System.Windows.Forms.OpenFileDialog telefonnumaralari;
        private System.Windows.Forms.Button btn_baslat;
        private System.ComponentModel.BackgroundWorker arkaplaniscisi;
        private System.Windows.Forms.TextBox txt_console;
        private System.Windows.Forms.StatusStrip statusband;
        private System.Windows.Forms.SaveFileDialog logdosyasikaydet;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

