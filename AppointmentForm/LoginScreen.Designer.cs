
namespace AppointmentForm
{
    partial class LoginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.pnlGiris = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlKayitOl = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtKayitSifre = new System.Windows.Forms.TextBox();
            this.txtKayitMail = new System.Windows.Forms.TextBox();
            this.txtKayitTC = new System.Windows.Forms.TextBox();
            this.txtKayitSurname = new System.Windows.Forms.TextBox();
            this.txtKayitName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlKayitOl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(127, 230);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(185, 27);
            this.txtTC.TabIndex = 0;
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_KeyPress);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(127, 275);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(185, 27);
            this.txtSifre.TabIndex = 1;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(210, 380);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(108, 37);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AppointmentForm.Properties.Resources.walpaper1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 500);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(68, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre :";
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.CadetBlue;
            this.btnKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayitOl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKayitOl.ForeColor = System.Drawing.Color.White;
            this.btnKayitOl.Location = new System.Drawing.Point(80, 380);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(108, 37);
            this.btnKayitOl.TabIndex = 6;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // pnlGiris
            // 
            this.pnlGiris.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlGiris.Controls.Add(this.pictureBox6);
            this.pnlGiris.Controls.Add(this.pictureBox5);
            this.pnlGiris.Controls.Add(this.pictureBox3);
            this.pnlGiris.Controls.Add(this.pictureBox2);
            this.pnlGiris.Controls.Add(this.txtTC);
            this.pnlGiris.Controls.Add(this.btnKayitOl);
            this.pnlGiris.Controls.Add(this.txtSifre);
            this.pnlGiris.Controls.Add(this.label2);
            this.pnlGiris.Controls.Add(this.btnGiris);
            this.pnlGiris.Controls.Add(this.label1);
            this.pnlGiris.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGiris.Location = new System.Drawing.Point(616, 0);
            this.pnlGiris.Name = "pnlGiris";
            this.pnlGiris.Size = new System.Drawing.Size(384, 500);
            this.pnlGiris.TabIndex = 7;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AppointmentForm.Properties.Resources.cikis;
            this.pictureBox5.Location = new System.Drawing.Point(325, 20);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AppointmentForm.Properties.Resources.invisible;
            this.pictureBox3.Location = new System.Drawing.Point(318, 275);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppointmentForm.Properties.Resources.view;
            this.pictureBox2.Location = new System.Drawing.Point(318, 275);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pnlKayitOl
            // 
            this.pnlKayitOl.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlKayitOl.Controls.Add(this.pictureBox4);
            this.pnlKayitOl.Controls.Add(this.button1);
            this.pnlKayitOl.Controls.Add(this.btnKaydet);
            this.pnlKayitOl.Controls.Add(this.txtKayitSifre);
            this.pnlKayitOl.Controls.Add(this.txtKayitMail);
            this.pnlKayitOl.Controls.Add(this.txtKayitTC);
            this.pnlKayitOl.Controls.Add(this.txtKayitSurname);
            this.pnlKayitOl.Controls.Add(this.txtKayitName);
            this.pnlKayitOl.Controls.Add(this.label7);
            this.pnlKayitOl.Controls.Add(this.label6);
            this.pnlKayitOl.Controls.Add(this.label5);
            this.pnlKayitOl.Controls.Add(this.label4);
            this.pnlKayitOl.Controls.Add(this.label3);
            this.pnlKayitOl.ForeColor = System.Drawing.Color.Black;
            this.pnlKayitOl.Location = new System.Drawing.Point(616, 0);
            this.pnlKayitOl.Name = "pnlKayitOl";
            this.pnlKayitOl.Size = new System.Drawing.Size(384, 500);
            this.pnlKayitOl.TabIndex = 8;
            this.pnlKayitOl.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AppointmentForm.Properties.Resources.cikis;
            this.pictureBox4.Location = new System.Drawing.Point(325, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(80, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "İptal Et";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.CadetBlue;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(210, 380);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(98, 37);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtKayitSifre
            // 
            this.txtKayitSifre.Location = new System.Drawing.Point(127, 275);
            this.txtKayitSifre.Name = "txtKayitSifre";
            this.txtKayitSifre.Size = new System.Drawing.Size(185, 27);
            this.txtKayitSifre.TabIndex = 9;
            // 
            // txtKayitMail
            // 
            this.txtKayitMail.Location = new System.Drawing.Point(127, 230);
            this.txtKayitMail.Name = "txtKayitMail";
            this.txtKayitMail.Size = new System.Drawing.Size(185, 27);
            this.txtKayitMail.TabIndex = 8;
            this.txtKayitMail.Enter += new System.EventHandler(this.txtKayitMail_Enter);
            // 
            // txtKayitTC
            // 
            this.txtKayitTC.Location = new System.Drawing.Point(127, 185);
            this.txtKayitTC.Name = "txtKayitTC";
            this.txtKayitTC.Size = new System.Drawing.Size(185, 27);
            this.txtKayitTC.TabIndex = 7;
            this.txtKayitTC.TextChanged += new System.EventHandler(this.txtKayitTC_TextChanged);
            this.txtKayitTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKayitTC_KeyPress);
            this.txtKayitTC.Leave += new System.EventHandler(this.txtKayitTC_Leave);
            // 
            // txtKayitSurname
            // 
            this.txtKayitSurname.Location = new System.Drawing.Point(127, 140);
            this.txtKayitSurname.Name = "txtKayitSurname";
            this.txtKayitSurname.Size = new System.Drawing.Size(185, 27);
            this.txtKayitSurname.TabIndex = 6;
            this.txtKayitSurname.TextChanged += new System.EventHandler(this.txtKayitSurname_TextChanged);
            this.txtKayitSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKayitSurname_KeyPress);
            // 
            // txtKayitName
            // 
            this.txtKayitName.Location = new System.Drawing.Point(127, 95);
            this.txtKayitName.Name = "txtKayitName";
            this.txtKayitName.Size = new System.Drawing.Size(185, 27);
            this.txtKayitName.TabIndex = 5;
            this.txtKayitName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKayitName_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(68, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Şifre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(69, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(58, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "TC No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(47, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Soyisim :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(71, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "İsim :";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::AppointmentForm.Properties.Resources.hospital;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(97, 66);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(230, 143);
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.pnlKayitOl);
            this.Controls.Add(this.pnlGiris);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Takip";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlGiris.ResumeLayout(false);
            this.pnlGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlKayitOl.ResumeLayout(false);
            this.pnlKayitOl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Panel pnlGiris;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtKayitSifre;
        private System.Windows.Forms.TextBox txtKayitMail;
        private System.Windows.Forms.TextBox txtKayitTC;
        private System.Windows.Forms.TextBox txtKayitSurname;
        private System.Windows.Forms.TextBox txtKayitName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlKayitOl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

