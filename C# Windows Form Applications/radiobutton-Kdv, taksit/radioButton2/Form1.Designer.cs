namespace radioButton2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rb_bonus = new System.Windows.Forms.RadioButton();
            this.rb_access = new System.Windows.Forms.RadioButton();
            this.rb_maxsimum = new System.Windows.Forms.RadioButton();
            this.rb_tekCekim = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜN FİYATI :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 23);
            this.textBox1.TabIndex = 1;
            // 
            // rb_bonus
            // 
            this.rb_bonus.AutoSize = true;
            this.rb_bonus.Location = new System.Drawing.Point(15, 122);
            this.rb_bonus.Name = "rb_bonus";
            this.rb_bonus.Size = new System.Drawing.Size(204, 21);
            this.rb_bonus.TabIndex = 2;
            this.rb_bonus.TabStop = true;
            this.rb_bonus.Text = "Bonus %5 KDV 15 Ay Taksit";
            this.rb_bonus.UseVisualStyleBackColor = true;
            // 
            // rb_access
            // 
            this.rb_access.AutoSize = true;
            this.rb_access.Location = new System.Drawing.Point(15, 163);
            this.rb_access.Name = "rb_access";
            this.rb_access.Size = new System.Drawing.Size(217, 21);
            this.rb_access.TabIndex = 2;
            this.rb_access.TabStop = true;
            this.rb_access.Text = "Access %10 KDV 20 Ay Taksit";
            this.rb_access.UseVisualStyleBackColor = true;
            // 
            // rb_maxsimum
            // 
            this.rb_maxsimum.AutoSize = true;
            this.rb_maxsimum.Location = new System.Drawing.Point(15, 206);
            this.rb_maxsimum.Name = "rb_maxsimum";
            this.rb_maxsimum.Size = new System.Drawing.Size(221, 21);
            this.rb_maxsimum.TabIndex = 2;
            this.rb_maxsimum.TabStop = true;
            this.rb_maxsimum.Text = "Maxsimum %3 KDV 9 Ay Taksit";
            this.rb_maxsimum.UseVisualStyleBackColor = true;
            // 
            // rb_tekCekim
            // 
            this.rb_tekCekim.AutoSize = true;
            this.rb_tekCekim.Location = new System.Drawing.Point(15, 244);
            this.rb_tekCekim.Name = "rb_tekCekim";
            this.rb_tekCekim.Size = new System.Drawing.Size(161, 21);
            this.rb_tekCekim.TabIndex = 2;
            this.rb_tekCekim.TabStop = true;
            this.rb_tekCekim.Text = "Tek Çekim %5 İndirim";
            this.rb_tekCekim.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "TOPLAM ÖDENECEK TUTAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "AYLIK TAKSİT TUTARI";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(15, 322);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 23);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(264, 322);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 23);
            this.textBox3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(687, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(734, 357);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rb_tekCekim);
            this.Controls.Add(this.rb_maxsimum);
            this.Controls.Add(this.rb_access);
            this.Controls.Add(this.rb_bonus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radio Buton 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rb_bonus;
        private System.Windows.Forms.RadioButton rb_access;
        private System.Windows.Forms.RadioButton rb_maxsimum;
        private System.Windows.Forms.RadioButton rb_tekCekim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

