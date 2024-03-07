namespace ördek
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btn_ilerisekme = new System.Windows.Forms.Button();
            this.btn_gerisekme = new System.Windows.Forms.Button();
            this.txt_motor = new System.Windows.Forms.TextBox();
            this.btn_googleara = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "KULLANIM";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(178, 81);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(929, 471);
            this.webBrowser1.TabIndex = 1;
            // 
            // btn_ilerisekme
            // 
            this.btn_ilerisekme.Location = new System.Drawing.Point(178, 32);
            this.btn_ilerisekme.Name = "btn_ilerisekme";
            this.btn_ilerisekme.Size = new System.Drawing.Size(75, 43);
            this.btn_ilerisekme.TabIndex = 6;
            this.btn_ilerisekme.Text = "------->";
            this.btn_ilerisekme.UseVisualStyleBackColor = true;
            this.btn_ilerisekme.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_gerisekme
            // 
            this.btn_gerisekme.Location = new System.Drawing.Point(1032, 32);
            this.btn_gerisekme.Name = "btn_gerisekme";
            this.btn_gerisekme.Size = new System.Drawing.Size(75, 43);
            this.btn_gerisekme.TabIndex = 7;
            this.btn_gerisekme.Text = "<-------";
            this.btn_gerisekme.UseVisualStyleBackColor = true;
            this.btn_gerisekme.Click += new System.EventHandler(this.button6_Click);
            // 
            // txt_motor
            // 
            this.txt_motor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_motor.Location = new System.Drawing.Point(384, 43);
            this.txt_motor.Multiline = true;
            this.txt_motor.Name = "txt_motor";
            this.txt_motor.Size = new System.Drawing.Size(446, 32);
            this.txt_motor.TabIndex = 8;
            // 
            // btn_googleara
            // 
            this.btn_googleara.Location = new System.Drawing.Point(836, 43);
            this.btn_googleara.Name = "btn_googleara";
            this.btn_googleara.Size = new System.Drawing.Size(93, 32);
            this.btn_googleara.TabIndex = 9;
            this.btn_googleara.Text = "ARA";
            this.btn_googleara.UseVisualStyleBackColor = true;
            this.btn_googleara.Click += new System.EventHandler(this.btn_googleara_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(523, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Google\'da ARA";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 14);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(143, 257);
            this.treeView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 564);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_googleara);
            this.Controls.Add(this.txt_motor);
            this.Controls.Add(this.btn_gerisekme);
            this.Controls.Add(this.btn_ilerisekme);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btn_ilerisekme;
        private System.Windows.Forms.Button btn_gerisekme;
        private System.Windows.Forms.TextBox txt_motor;
        private System.Windows.Forms.Button btn_googleara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
    }
}

