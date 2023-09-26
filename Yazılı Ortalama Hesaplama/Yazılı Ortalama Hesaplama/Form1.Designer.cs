namespace Yazılı_Ortalama_Hesaplama
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
            this.lblYazili1 = new System.Windows.Forms.Label();
            this.lblYazili2 = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.txtYazili1 = new System.Windows.Forms.TextBox();
            this.txtYazili2 = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblYazili1
            // 
            this.lblYazili1.AutoSize = true;
            this.lblYazili1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazili1.Location = new System.Drawing.Point(32, 54);
            this.lblYazili1.Name = "lblYazili1";
            this.lblYazili1.Size = new System.Drawing.Size(46, 16);
            this.lblYazili1.TabIndex = 0;
            this.lblYazili1.Text = "Yazılı1";
            // 
            // lblYazili2
            // 
            this.lblYazili2.AutoSize = true;
            this.lblYazili2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazili2.Location = new System.Drawing.Point(32, 98);
            this.lblYazili2.Name = "lblYazili2";
            this.lblYazili2.Size = new System.Drawing.Size(46, 16);
            this.lblYazili2.TabIndex = 1;
            this.lblYazili2.Text = "Yazılı2";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Enabled = false;
            this.lblOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrtalama.Location = new System.Drawing.Point(32, 235);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(65, 16);
            this.lblOrtalama.TabIndex = 2;
            this.lblOrtalama.Text = "Ortalama:";
            // 
            // txtYazili1
            // 
            this.txtYazili1.Location = new System.Drawing.Point(112, 53);
            this.txtYazili1.Name = "txtYazili1";
            this.txtYazili1.Size = new System.Drawing.Size(100, 20);
            this.txtYazili1.TabIndex = 3;
            this.txtYazili1.TextChanged += new System.EventHandler(this.txtYazili1_TextChanged);
            // 
            // txtYazili2
            // 
            this.txtYazili2.Location = new System.Drawing.Point(112, 98);
            this.txtYazili2.Name = "txtYazili2";
            this.txtYazili2.Size = new System.Drawing.Size(100, 20);
            this.txtYazili2.TabIndex = 4;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.White;
            this.btnHesapla.Location = new System.Drawing.Point(112, 153);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 51);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(112, 235);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(100, 20);
            this.txtOrtalama.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 297);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtYazili2);
            this.Controls.Add(this.txtYazili1);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.lblYazili2);
            this.Controls.Add(this.lblYazili1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYazili1;
        private System.Windows.Forms.Label lblYazili2;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.TextBox txtYazili1;
        private System.Windows.Forms.TextBox txtYazili2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtOrtalama;
    }
}

