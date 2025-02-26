namespace KütüphaneSist
{
    partial class Anasayfa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.çıkış_btn = new System.Windows.Forms.Button();
            this.hosgeldiniz_etiketi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ekleme1 = new KütüphaneSist.Ekleme();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 32);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kütüphane Yönetim Sistemi | AnaSayfa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1072, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.çıkış_btn);
            this.panel2.Controls.Add(this.hosgeldiniz_etiketi);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 568);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // çıkış_btn
            // 
            this.çıkış_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.çıkış_btn.FlatAppearance.BorderSize = 2;
            this.çıkış_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.çıkış_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.çıkış_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.çıkış_btn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkış_btn.ForeColor = System.Drawing.Color.White;
            this.çıkış_btn.Image = global::KütüphaneSist.Properties.Resources.icons8_log_out_32;
            this.çıkış_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.çıkış_btn.Location = new System.Drawing.Point(12, 387);
            this.çıkış_btn.Name = "çıkış_btn";
            this.çıkış_btn.Size = new System.Drawing.Size(190, 45);
            this.çıkış_btn.TabIndex = 6;
            this.çıkış_btn.Text = "ÇIKIŞ";
            this.çıkış_btn.UseVisualStyleBackColor = true;
            this.çıkış_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // hosgeldiniz_etiketi
            // 
            this.hosgeldiniz_etiketi.AutoSize = true;
            this.hosgeldiniz_etiketi.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hosgeldiniz_etiketi.ForeColor = System.Drawing.SystemColors.Window;
            this.hosgeldiniz_etiketi.Location = new System.Drawing.Point(25, 249);
            this.hosgeldiniz_etiketi.Name = "hosgeldiniz_etiketi";
            this.hosgeldiniz_etiketi.Size = new System.Drawing.Size(177, 104);
            this.hosgeldiniz_etiketi.TabIndex = 1;
            this.hosgeldiniz_etiketi.Text = " KÜTÜPHANE \r\n    YÖNETİM\r\n   SİSTEMİNE\r\nHOŞGELDİNİZ!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KütüphaneSist.Properties.Resources.icons8_library_100;
            this.pictureBox1.Location = new System.Drawing.Point(52, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ekleme1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(214, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(886, 568);
            this.panel3.TabIndex = 2;
            // 
            // ekleme1
            // 
            this.ekleme1.Location = new System.Drawing.Point(0, -1);
            this.ekleme1.Name = "ekleme1";
            this.ekleme1.Size = new System.Drawing.Size(886, 568);
            this.ekleme1.TabIndex = 0;
            this.ekleme1.Load += new System.EventHandler(this.ekleme1_Load_1);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label hosgeldiniz_etiketi;
        private System.Windows.Forms.Button çıkış_btn;
        private System.Windows.Forms.Panel panel3;
        private Ekleme ekleme1;
    }
}