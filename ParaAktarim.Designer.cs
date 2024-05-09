namespace ATMUygulamasi
{
    partial class ParaAktarim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaAktarim));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_alinacakmiktar = new System.Windows.Forms.TextBox();
            this.txt_iban = new System.Windows.Forms.TextBox();
            this.btn_geriDon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_paraYatir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.txt_alinacakmiktar);
            this.panel1.Controls.Add(this.txt_iban);
            this.panel1.Controls.Add(this.btn_geriDon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_paraYatir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 155);
            this.panel1.TabIndex = 6;
            // 
            // txt_alinacakmiktar
            // 
            this.txt_alinacakmiktar.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold);
            this.txt_alinacakmiktar.Location = new System.Drawing.Point(125, 85);
            this.txt_alinacakmiktar.Multiline = true;
            this.txt_alinacakmiktar.Name = "txt_alinacakmiktar";
            this.txt_alinacakmiktar.Size = new System.Drawing.Size(218, 46);
            this.txt_alinacakmiktar.TabIndex = 1;
            this.txt_alinacakmiktar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_alinacakmiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_alinacakmiktar_KeyPress);
            // 
            // txt_iban
            // 
            this.txt_iban.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_iban.Location = new System.Drawing.Point(125, 33);
            this.txt_iban.Multiline = true;
            this.txt_iban.Name = "txt_iban";
            this.txt_iban.Size = new System.Drawing.Size(218, 46);
            this.txt_iban.TabIndex = 0;
            this.txt_iban.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_geriDon
            // 
            this.btn_geriDon.BackColor = System.Drawing.Color.IndianRed;
            this.btn_geriDon.FlatAppearance.BorderSize = 0;
            this.btn_geriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_geriDon.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_geriDon.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_geriDon.Location = new System.Drawing.Point(349, 85);
            this.btn_geriDon.Name = "btn_geriDon";
            this.btn_geriDon.Size = new System.Drawing.Size(154, 46);
            this.btn_geriDon.TabIndex = 3;
            this.btn_geriDon.Text = "Geri dön";
            this.btn_geriDon.UseVisualStyleBackColor = false;
            this.btn_geriDon.Click += new System.EventHandler(this.btn_geriDon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(2, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Miktar: ";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_paraYatir
            // 
            this.btn_paraYatir.BackColor = System.Drawing.Color.IndianRed;
            this.btn_paraYatir.FlatAppearance.BorderSize = 0;
            this.btn_paraYatir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_paraYatir.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paraYatir.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_paraYatir.Location = new System.Drawing.Point(349, 33);
            this.btn_paraYatir.Name = "btn_paraYatir";
            this.btn_paraYatir.Size = new System.Drawing.Size(210, 46);
            this.btn_paraYatir.TabIndex = 2;
            this.btn_paraYatir.Text = "Para Yatır";
            this.btn_paraYatir.UseVisualStyleBackColor = false;
            this.btn_paraYatir.Click += new System.EventHandler(this.btn_paraYatir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(2, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "İban No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ParaAktarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 155);
            this.Controls.Add(this.panel1);
            this.Name = "ParaAktarim";
            this.Text = "ParaAktarim";
            this.Load += new System.EventHandler(this.ParaAktarim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_geriDon;
        private System.Windows.Forms.Button btn_paraYatir;
        private System.Windows.Forms.TextBox txt_iban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_alinacakmiktar;
        private System.Windows.Forms.Label label2;
    }
}