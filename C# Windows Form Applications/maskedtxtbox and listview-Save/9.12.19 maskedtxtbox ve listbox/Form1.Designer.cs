namespace _9._12._19_maskedtxtbox_ve_listbox
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.mskd_kayıt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskd_kimlik = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_anne = new System.Windows.Forms.TextBox();
            this.mskd_tel = new System.Windows.Forms.MaskedTextBox();
            this.txt_anneKizlik = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txt_baba = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kayıt Tarihi";
            // 
            // mskd_kayıt
            // 
            this.mskd_kayıt.Location = new System.Drawing.Point(141, 11);
            this.mskd_kayıt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskd_kayıt.Mask = "00/00/0000";
            this.mskd_kayıt.Name = "mskd_kayıt";
            this.mskd_kayıt.Size = new System.Drawing.Size(132, 22);
            this.mskd_kayıt.TabIndex = 1;
            this.mskd_kayıt.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC Kimlik No";
            // 
            // mskd_kimlik
            // 
            this.mskd_kimlik.Location = new System.Drawing.Point(141, 55);
            this.mskd_kimlik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskd_kimlik.Mask = "00000000000";
            this.mskd_kimlik.Name = "mskd_kimlik";
            this.mskd_kimlik.Size = new System.Drawing.Size(132, 22);
            this.mskd_kimlik.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(16, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Anne Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(16, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Baba Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(16, 266);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Telefon No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(16, 309);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Anne Kızlık Adı";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(141, 92);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(132, 22);
            this.txt_ad.TabIndex = 10;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(141, 133);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(132, 22);
            this.txt_soyad.TabIndex = 11;
            // 
            // txt_anne
            // 
            this.txt_anne.Location = new System.Drawing.Point(141, 176);
            this.txt_anne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_anne.Name = "txt_anne";
            this.txt_anne.Size = new System.Drawing.Size(132, 22);
            this.txt_anne.TabIndex = 12;
            // 
            // mskd_tel
            // 
            this.mskd_tel.Location = new System.Drawing.Point(141, 266);
            this.mskd_tel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskd_tel.Mask = "(999) 000-0000";
            this.mskd_tel.Name = "mskd_tel";
            this.mskd_tel.Size = new System.Drawing.Size(132, 22);
            this.mskd_tel.TabIndex = 14;
            // 
            // txt_anneKizlik
            // 
            this.txt_anneKizlik.Location = new System.Drawing.Point(141, 309);
            this.txt_anneKizlik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_anneKizlik.Name = "txt_anneKizlik";
            this.txt_anneKizlik.Size = new System.Drawing.Size(132, 22);
            this.txt_anneKizlik.TabIndex = 15;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(20, 372);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(100, 34);
            this.btn_kaydet.TabIndex = 16;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(175, 372);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(100, 34);
            this.btn_sil.TabIndex = 17;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(283, 11);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(692, 394);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txt_baba
            // 
            this.txt_baba.Location = new System.Drawing.Point(141, 219);
            this.txt_baba.Margin = new System.Windows.Forms.Padding(4);
            this.txt_baba.Name = "txt_baba";
            this.txt_baba.Size = new System.Drawing.Size(132, 22);
            this.txt_baba.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 430);
            this.Controls.Add(this.txt_baba);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_anneKizlik);
            this.Controls.Add(this.mskd_tel);
            this.Controls.Add(this.txt_anne);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskd_kimlik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskd_kayıt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskd_kayıt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskd_kimlik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_anne;
        private System.Windows.Forms.MaskedTextBox mskd_tel;
        private System.Windows.Forms.TextBox txt_anneKizlik;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txt_baba;
    }
}

