namespace KütüphaneSist
{
    partial class GirişEkranı
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.giris_adtext = new System.Windows.Forms.TextBox();
            this.giris_sifretext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.girisBtn1 = new System.Windows.Forms.Button();
            this.kayıtBtn1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 15);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(293, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(50, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "HOŞGELDİNİZ!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 11.25F);
            this.label3.Location = new System.Drawing.Point(42, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kullanıcı Adı: ";
            // 
            // giris_adtext
            // 
            this.giris_adtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.giris_adtext.Font = new System.Drawing.Font("Book Antiqua", 12.25F);
            this.giris_adtext.Location = new System.Drawing.Point(46, 231);
            this.giris_adtext.Multiline = true;
            this.giris_adtext.Name = "giris_adtext";
            this.giris_adtext.Size = new System.Drawing.Size(227, 26);
            this.giris_adtext.TabIndex = 4;
            this.giris_adtext.TextChanged += new System.EventHandler(this.giris_adtext_TextChanged);
            // 
            // giris_sifretext
            // 
            this.giris_sifretext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.giris_sifretext.Font = new System.Drawing.Font("Book Antiqua", 12.25F);
            this.giris_sifretext.Location = new System.Drawing.Point(46, 286);
            this.giris_sifretext.Multiline = true;
            this.giris_sifretext.Name = "giris_sifretext";
            this.giris_sifretext.PasswordChar = '*';
            this.giris_sifretext.Size = new System.Drawing.Size(227, 26);
            this.giris_sifretext.TabIndex = 6;
            this.giris_sifretext.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 11.25F);
            this.label4.Location = new System.Drawing.Point(42, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Şifre:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // girisBtn1
            // 
            this.girisBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.girisBtn1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.girisBtn1.FlatAppearance.BorderSize = 5;
            this.girisBtn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.girisBtn1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisBtn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.girisBtn1.Location = new System.Drawing.Point(46, 339);
            this.girisBtn1.Name = "girisBtn1";
            this.girisBtn1.Size = new System.Drawing.Size(227, 30);
            this.girisBtn1.TabIndex = 7;
            this.girisBtn1.Text = "Giriş";
            this.girisBtn1.UseVisualStyleBackColor = false;
            this.girisBtn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kayıtBtn1
            // 
            this.kayıtBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kayıtBtn1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.kayıtBtn1.FlatAppearance.BorderSize = 5;
            this.kayıtBtn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.kayıtBtn1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtBtn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kayıtBtn1.Location = new System.Drawing.Point(46, 407);
            this.kayıtBtn1.Name = "kayıtBtn1";
            this.kayıtBtn1.Size = new System.Drawing.Size(227, 30);
            this.kayıtBtn1.TabIndex = 9;
            this.kayıtBtn1.Text = "Kayıt Ol";
            this.kayıtBtn1.UseVisualStyleBackColor = false;
            this.kayıtBtn1.Click += new System.EventHandler(this.kayıtBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 493);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 7);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 478);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(303, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(7, 478);
            this.panel4.TabIndex = 12;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KütüphaneSist.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(109, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(43, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hesabınız Yok  Mu ? Hemen Oluşturun ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // GirişEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(310, 500);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kayıtBtn1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.girisBtn1);
            this.Controls.Add(this.giris_sifretext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.giris_adtext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirişEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirişEkranı";
            this.Load += new System.EventHandler(this.GirişEkranı_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox giris_adtext;
        private System.Windows.Forms.TextBox giris_sifretext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button girisBtn1;
        private System.Windows.Forms.Button kayıtBtn1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
    }
}