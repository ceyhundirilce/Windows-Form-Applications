namespace richtextbox
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_vrsfnt = new System.Windows.Forms.Button();
            this.btn_rnk = new System.Windows.Forms.Button();
            this.btn_arnk = new System.Windows.Forms.Button();
            this.btn_kyd = new System.Windows.Forms.Button();
            this.btn_ac = new System.Windows.Forms.Button();
            this.fntdiyalog = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_fnt = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(471, 181);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btn_vrsfnt
            // 
            this.btn_vrsfnt.Location = new System.Drawing.Point(17, 235);
            this.btn_vrsfnt.Name = "btn_vrsfnt";
            this.btn_vrsfnt.Size = new System.Drawing.Size(88, 30);
            this.btn_vrsfnt.TabIndex = 1;
            this.btn_vrsfnt.Text = "varsayılan font";
            this.btn_vrsfnt.UseVisualStyleBackColor = true;
            this.btn_vrsfnt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_rnk
            // 
            this.btn_rnk.Location = new System.Drawing.Point(111, 200);
            this.btn_rnk.Name = "btn_rnk";
            this.btn_rnk.Size = new System.Drawing.Size(88, 30);
            this.btn_rnk.TabIndex = 2;
            this.btn_rnk.Text = "renk";
            this.btn_rnk.UseVisualStyleBackColor = true;
            this.btn_rnk.Click += new System.EventHandler(this.btn_rnk_Click);
            // 
            // btn_arnk
            // 
            this.btn_arnk.Location = new System.Drawing.Point(205, 199);
            this.btn_arnk.Name = "btn_arnk";
            this.btn_arnk.Size = new System.Drawing.Size(87, 30);
            this.btn_arnk.TabIndex = 3;
            this.btn_arnk.Text = "arka renk";
            this.btn_arnk.UseVisualStyleBackColor = true;
            this.btn_arnk.Click += new System.EventHandler(this.btn_arnk_Click);
            // 
            // btn_kyd
            // 
            this.btn_kyd.Location = new System.Drawing.Point(298, 199);
            this.btn_kyd.Name = "btn_kyd";
            this.btn_kyd.Size = new System.Drawing.Size(87, 30);
            this.btn_kyd.TabIndex = 4;
            this.btn_kyd.Text = "kaydet";
            this.btn_kyd.UseVisualStyleBackColor = true;
            this.btn_kyd.Click += new System.EventHandler(this.btn_kyd_Click);
            // 
            // btn_ac
            // 
            this.btn_ac.Location = new System.Drawing.Point(391, 199);
            this.btn_ac.Name = "btn_ac";
            this.btn_ac.Size = new System.Drawing.Size(87, 30);
            this.btn_ac.TabIndex = 5;
            this.btn_ac.Text = "aç";
            this.btn_ac.UseVisualStyleBackColor = true;
            this.btn_ac.Click += new System.EventHandler(this.btn_ac_Click);
            // 
            // btn_fnt
            // 
            this.btn_fnt.Location = new System.Drawing.Point(17, 200);
            this.btn_fnt.Name = "btn_fnt";
            this.btn_fnt.Size = new System.Drawing.Size(88, 29);
            this.btn_fnt.TabIndex = 6;
            this.btn_fnt.Text = "Font";
            this.btn_fnt.UseVisualStyleBackColor = true;
            this.btn_fnt.Click += new System.EventHandler(this.button6_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 276);
            this.Controls.Add(this.btn_fnt);
            this.Controls.Add(this.btn_ac);
            this.Controls.Add(this.btn_kyd);
            this.Controls.Add(this.btn_arnk);
            this.Controls.Add(this.btn_rnk);
            this.Controls.Add(this.btn_vrsfnt);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_vrsfnt;
        private System.Windows.Forms.Button btn_rnk;
        private System.Windows.Forms.Button btn_arnk;
        private System.Windows.Forms.Button btn_kyd;
        private System.Windows.Forms.Button btn_ac;
        private System.Windows.Forms.FontDialog fntdiyalog;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_fnt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

