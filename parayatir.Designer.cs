namespace ATMUygulamasi
{
    partial class parayatir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(parayatir));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_geriDon = new System.Windows.Forms.Button();
            this.btn_paraYatir = new System.Windows.Forms.Button();
            this.txt_BakiyeParaYatir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.btn_geriDon);
            this.panel1.Controls.Add(this.btn_paraYatir);
            this.panel1.Controls.Add(this.txt_BakiyeParaYatir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 224);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_geriDon
            // 
            this.btn_geriDon.BackColor = System.Drawing.Color.IndianRed;
            this.btn_geriDon.FlatAppearance.BorderSize = 0;
            this.btn_geriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_geriDon.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_geriDon.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_geriDon.Location = new System.Drawing.Point(291, 149);
            this.btn_geriDon.Name = "btn_geriDon";
            this.btn_geriDon.Size = new System.Drawing.Size(154, 46);
            this.btn_geriDon.TabIndex = 2;
            this.btn_geriDon.Text = "Geri dön";
            this.btn_geriDon.UseVisualStyleBackColor = false;
            this.btn_geriDon.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_paraYatir
            // 
            this.btn_paraYatir.BackColor = System.Drawing.Color.IndianRed;
            this.btn_paraYatir.FlatAppearance.BorderSize = 0;
            this.btn_paraYatir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_paraYatir.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paraYatir.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_paraYatir.Location = new System.Drawing.Point(75, 149);
            this.btn_paraYatir.Name = "btn_paraYatir";
            this.btn_paraYatir.Size = new System.Drawing.Size(210, 46);
            this.btn_paraYatir.TabIndex = 1;
            this.btn_paraYatir.Text = "Para Yatır";
            this.btn_paraYatir.UseVisualStyleBackColor = false;
            this.btn_paraYatir.Click += new System.EventHandler(this.btn_paraYatir_Click);
            // 
            // txt_BakiyeParaYatir
            // 
            this.txt_BakiyeParaYatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_BakiyeParaYatir.Location = new System.Drawing.Point(75, 62);
            this.txt_BakiyeParaYatir.Multiline = true;
            this.txt_BakiyeParaYatir.Name = "txt_BakiyeParaYatir";
            this.txt_BakiyeParaYatir.Size = new System.Drawing.Size(370, 81);
            this.txt_BakiyeParaYatir.TabIndex = 0;
            this.txt_BakiyeParaYatir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_BakiyeParaYatir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_BakiyeParaYatir_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ne kadar Yatırmak istiyorsunuz?";
            // 
            // parayatir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 224);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "parayatir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "parayatir";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_geriDon;
        private System.Windows.Forms.Button btn_paraYatir;
        private System.Windows.Forms.TextBox txt_BakiyeParaYatir;
        private System.Windows.Forms.Label label1;
    }
}