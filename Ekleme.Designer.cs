namespace KütüphaneSist
{
    partial class Ekleme
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ekleme_id = new System.Windows.Forms.TextBox();
            this.ekleme_listelebuton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ekleme_temizlebuton = new System.Windows.Forms.Button();
            this.ekleme_yayıntarihi = new System.Windows.Forms.DateTimePicker();
            this.ekleme_güncellebuton = new System.Windows.Forms.Button();
            this.ekleme_eklebuton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ekleme_resim = new System.Windows.Forms.PictureBox();
            this.ekleme_silbuton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ekleme_yazar = new System.Windows.Forms.TextBox();
            this.ekleme_kitapismi = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ekleme_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(18, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 325);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(32, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tüm Kitaplar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(17, 29);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(816, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ekleme_id);
            this.panel1.Controls.Add(this.ekleme_listelebuton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ekleme_temizlebuton);
            this.panel1.Controls.Add(this.ekleme_yayıntarihi);
            this.panel1.Controls.Add(this.ekleme_güncellebuton);
            this.panel1.Controls.Add(this.ekleme_eklebuton);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ekleme_resim);
            this.panel1.Controls.Add(this.ekleme_silbuton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ekleme_yazar);
            this.panel1.Controls.Add(this.ekleme_kitapismi);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(18, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 180);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(90, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "ID :";
            // 
            // ekleme_id
            // 
            this.ekleme_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ekleme_id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleme_id.Location = new System.Drawing.Point(129, 36);
            this.ekleme_id.Multiline = true;
            this.ekleme_id.Name = "ekleme_id";
            this.ekleme_id.Size = new System.Drawing.Size(167, 26);
            this.ekleme_id.TabIndex = 36;
            // 
            // ekleme_listelebuton
            // 
            this.ekleme_listelebuton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ekleme_listelebuton.FlatAppearance.BorderSize = 0;
            this.ekleme_listelebuton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.ekleme_listelebuton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.ekleme_listelebuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekleme_listelebuton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.ekleme_listelebuton.ForeColor = System.Drawing.SystemColors.Window;
            this.ekleme_listelebuton.Location = new System.Drawing.Point(720, 59);
            this.ekleme_listelebuton.Name = "ekleme_listelebuton";
            this.ekleme_listelebuton.Size = new System.Drawing.Size(96, 57);
            this.ekleme_listelebuton.TabIndex = 35;
            this.ekleme_listelebuton.Text = "LİSTELE";
            this.ekleme_listelebuton.UseVisualStyleBackColor = false;
            this.ekleme_listelebuton.Click += new System.EventHandler(this.ekleme_listelebuton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(32, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "Kitap Bilgileri";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(358, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Yükle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ekleme_temizlebuton
            // 
            this.ekleme_temizlebuton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ekleme_temizlebuton.FlatAppearance.BorderSize = 0;
            this.ekleme_temizlebuton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.ekleme_temizlebuton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.ekleme_temizlebuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekleme_temizlebuton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.ekleme_temizlebuton.ForeColor = System.Drawing.SystemColors.Window;
            this.ekleme_temizlebuton.Location = new System.Drawing.Point(600, 95);
            this.ekleme_temizlebuton.Name = "ekleme_temizlebuton";
            this.ekleme_temizlebuton.Size = new System.Drawing.Size(96, 57);
            this.ekleme_temizlebuton.TabIndex = 32;
            this.ekleme_temizlebuton.Text = "TEMİZLE";
            this.ekleme_temizlebuton.UseVisualStyleBackColor = false;
            this.ekleme_temizlebuton.Click += new System.EventHandler(this.ekleme_temizlebuton_Click);
            // 
            // ekleme_yayıntarihi
            // 
            this.ekleme_yayıntarihi.Location = new System.Drawing.Point(129, 132);
            this.ekleme_yayıntarihi.Name = "ekleme_yayıntarihi";
            this.ekleme_yayıntarihi.Size = new System.Drawing.Size(167, 20);
            this.ekleme_yayıntarihi.TabIndex = 27;
            this.ekleme_yayıntarihi.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ekleme_güncellebuton
            // 
            this.ekleme_güncellebuton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ekleme_güncellebuton.FlatAppearance.BorderSize = 0;
            this.ekleme_güncellebuton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.ekleme_güncellebuton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.ekleme_güncellebuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekleme_güncellebuton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.ekleme_güncellebuton.ForeColor = System.Drawing.SystemColors.Window;
            this.ekleme_güncellebuton.Location = new System.Drawing.Point(470, 95);
            this.ekleme_güncellebuton.Name = "ekleme_güncellebuton";
            this.ekleme_güncellebuton.Size = new System.Drawing.Size(101, 57);
            this.ekleme_güncellebuton.TabIndex = 31;
            this.ekleme_güncellebuton.Text = "GÜNCELLE";
            this.ekleme_güncellebuton.UseVisualStyleBackColor = false;
            this.ekleme_güncellebuton.Click += new System.EventHandler(this.ekleme_güncellebuton_Click);
            // 
            // ekleme_eklebuton
            // 
            this.ekleme_eklebuton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ekleme_eklebuton.FlatAppearance.BorderSize = 0;
            this.ekleme_eklebuton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.ekleme_eklebuton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.ekleme_eklebuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekleme_eklebuton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleme_eklebuton.ForeColor = System.Drawing.SystemColors.Window;
            this.ekleme_eklebuton.Location = new System.Drawing.Point(470, 21);
            this.ekleme_eklebuton.Name = "ekleme_eklebuton";
            this.ekleme_eklebuton.Size = new System.Drawing.Size(101, 57);
            this.ekleme_eklebuton.TabIndex = 30;
            this.ekleme_eklebuton.Text = "EKLE";
            this.ekleme_eklebuton.UseVisualStyleBackColor = false;
            this.ekleme_eklebuton.Click += new System.EventHandler(this.ekleme_eklebuton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(33, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Yayın Tarihi :";
            // 
            // ekleme_resim
            // 
            this.ekleme_resim.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ekleme_resim.Location = new System.Drawing.Point(358, 21);
            this.ekleme_resim.Name = "ekleme_resim";
            this.ekleme_resim.Size = new System.Drawing.Size(80, 120);
            this.ekleme_resim.TabIndex = 24;
            this.ekleme_resim.TabStop = false;
            // 
            // ekleme_silbuton
            // 
            this.ekleme_silbuton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ekleme_silbuton.FlatAppearance.BorderSize = 0;
            this.ekleme_silbuton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.ekleme_silbuton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.ekleme_silbuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekleme_silbuton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.ekleme_silbuton.ForeColor = System.Drawing.SystemColors.Window;
            this.ekleme_silbuton.Location = new System.Drawing.Point(600, 21);
            this.ekleme_silbuton.Name = "ekleme_silbuton";
            this.ekleme_silbuton.Size = new System.Drawing.Size(96, 57);
            this.ekleme_silbuton.TabIndex = 29;
            this.ekleme_silbuton.Text = "SİL";
            this.ekleme_silbuton.UseVisualStyleBackColor = false;
            this.ekleme_silbuton.Click += new System.EventHandler(this.ekleme_silbuton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(66, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Yazar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(44, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Kitap İsmi :";
            // 
            // ekleme_yazar
            // 
            this.ekleme_yazar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ekleme_yazar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleme_yazar.Location = new System.Drawing.Point(129, 100);
            this.ekleme_yazar.Multiline = true;
            this.ekleme_yazar.Name = "ekleme_yazar";
            this.ekleme_yazar.Size = new System.Drawing.Size(167, 26);
            this.ekleme_yazar.TabIndex = 15;
            // 
            // ekleme_kitapismi
            // 
            this.ekleme_kitapismi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ekleme_kitapismi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleme_kitapismi.Location = new System.Drawing.Point(129, 68);
            this.ekleme_kitapismi.Multiline = true;
            this.ekleme_kitapismi.Name = "ekleme_kitapismi";
            this.ekleme_kitapismi.Size = new System.Drawing.Size(167, 26);
            this.ekleme_kitapismi.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(886, 7);
            this.panel6.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 561);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(879, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(7, 561);
            this.panel4.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(7, 561);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(872, 7);
            this.panel5.TabIndex = 20;
            // 
            // Ekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Ekleme";
            this.Size = new System.Drawing.Size(886, 568);
            this.Load += new System.EventHandler(this.Ekleme_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ekleme_resim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ekleme_temizlebuton;
        private System.Windows.Forms.Button ekleme_güncellebuton;
        private System.Windows.Forms.Button ekleme_eklebuton;
        private System.Windows.Forms.Button ekleme_silbuton;
        private System.Windows.Forms.DateTimePicker ekleme_yayıntarihi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox ekleme_resim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ekleme_yazar;
        private System.Windows.Forms.TextBox ekleme_kitapismi;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ekleme_listelebuton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ekleme_id;
    }
}
