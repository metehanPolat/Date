
namespace AppointmentForm
{
    partial class InformationsScreen
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuncellekaydet = new System.Windows.Forms.Button();
            this.btnGuncelleIptal = new System.Windows.Forms.Button();
            this.txtGuncelleName = new System.Windows.Forms.TextBox();
            this.txtGuncelleSurname = new System.Windows.Forms.TextBox();
            this.txtGuncelleTC = new System.Windows.Forms.TextBox();
            this.txtGuncelleMail = new System.Windows.Forms.TextBox();
            this.txtGuncelleSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(51, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(50, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre";
            // 
            // btnGuncellekaydet
            // 
            this.btnGuncellekaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncellekaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncellekaydet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuncellekaydet.Location = new System.Drawing.Point(50, 389);
            this.btnGuncellekaydet.Name = "btnGuncellekaydet";
            this.btnGuncellekaydet.Size = new System.Drawing.Size(125, 40);
            this.btnGuncellekaydet.TabIndex = 5;
            this.btnGuncellekaydet.Text = "Kaydet";
            this.btnGuncellekaydet.UseVisualStyleBackColor = false;
            this.btnGuncellekaydet.Click += new System.EventHandler(this.btnGuncellekaydet_Click);
            // 
            // btnGuncelleIptal
            // 
            this.btnGuncelleIptal.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelleIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelleIptal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelleIptal.Location = new System.Drawing.Point(210, 389);
            this.btnGuncelleIptal.Name = "btnGuncelleIptal";
            this.btnGuncelleIptal.Size = new System.Drawing.Size(125, 40);
            this.btnGuncelleIptal.TabIndex = 6;
            this.btnGuncelleIptal.Text = "İptal";
            this.btnGuncelleIptal.UseVisualStyleBackColor = false;
            this.btnGuncelleIptal.Click += new System.EventHandler(this.btnGuncelleIptal_Click);
            // 
            // txtGuncelleName
            // 
            this.txtGuncelleName.Location = new System.Drawing.Point(150, 100);
            this.txtGuncelleName.Name = "txtGuncelleName";
            this.txtGuncelleName.Size = new System.Drawing.Size(185, 27);
            this.txtGuncelleName.TabIndex = 7;
            this.txtGuncelleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuncelleName_KeyPress);
            // 
            // txtGuncelleSurname
            // 
            this.txtGuncelleSurname.Location = new System.Drawing.Point(150, 150);
            this.txtGuncelleSurname.Name = "txtGuncelleSurname";
            this.txtGuncelleSurname.Size = new System.Drawing.Size(185, 27);
            this.txtGuncelleSurname.TabIndex = 8;
            this.txtGuncelleSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuncelleSurname_KeyPress);
            // 
            // txtGuncelleTC
            // 
            this.txtGuncelleTC.Location = new System.Drawing.Point(150, 200);
            this.txtGuncelleTC.Name = "txtGuncelleTC";
            this.txtGuncelleTC.Size = new System.Drawing.Size(185, 27);
            this.txtGuncelleTC.TabIndex = 9;
            this.txtGuncelleTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuncelleTC_KeyPress);
            // 
            // txtGuncelleMail
            // 
            this.txtGuncelleMail.Location = new System.Drawing.Point(150, 250);
            this.txtGuncelleMail.Name = "txtGuncelleMail";
            this.txtGuncelleMail.Size = new System.Drawing.Size(185, 27);
            this.txtGuncelleMail.TabIndex = 10;
            // 
            // txtGuncelleSifre
            // 
            this.txtGuncelleSifre.Location = new System.Drawing.Point(150, 300);
            this.txtGuncelleSifre.Name = "txtGuncelleSifre";
            this.txtGuncelleSifre.Size = new System.Drawing.Size(185, 27);
            this.txtGuncelleSifre.TabIndex = 11;
            // 
            // InformationsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(375, 500);
            this.Controls.Add(this.txtGuncelleSifre);
            this.Controls.Add(this.txtGuncelleMail);
            this.Controls.Add(this.txtGuncelleTC);
            this.Controls.Add(this.txtGuncelleSurname);
            this.Controls.Add(this.txtGuncelleName);
            this.Controls.Add(this.btnGuncelleIptal);
            this.Controls.Add(this.btnGuncellekaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformationsScreen";
            this.Text = "InformationsScreen";
            this.Load += new System.EventHandler(this.InformationsScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuncellekaydet;
        private System.Windows.Forms.Button btnGuncelleIptal;
        private System.Windows.Forms.TextBox txtGuncelleName;
        private System.Windows.Forms.TextBox txtGuncelleSurname;
        private System.Windows.Forms.TextBox txtGuncelleTC;
        private System.Windows.Forms.TextBox txtGuncelleMail;
        private System.Windows.Forms.TextBox txtGuncelleSifre;
    }
}